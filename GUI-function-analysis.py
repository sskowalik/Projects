from PyQt5.QtGui import *
from PyQt5.QtWidgets import *
import pyqtgraph as pg
import numpy as np
from scipy.fft import fft
import pandas as pd
from scipy.io.wavfile import write


class App(QWidget):
    def __init__(self):
        super().__init__()
        self.wyglad()
        self.radio_buttons()
        self.guziki()
        self.tabela()
        self.parametry()
        self.radio0.setChecked(True)
        self.show()

    def wyglad(self):
        self.title = 'Generowanie przebiegów funkcji!'
        self.layout1 = QGridLayout()
        self.top = 100
        self.width = 1750
        self.left = 100
        self.height = 800
        self.setWindowTitle(self.title)
        self.setGeometry(self.left, self.top, self.width, self.height)
        self.setFont(QFont('Calibri', 18))
        self.group1 = QGroupBox()
        self.group1.setLayout(self.layout1)
        self.layout = QHBoxLayout()
        self.layout.addWidget(self.group1)
        self.setLayout(self.layout)

    def radio_buttons(self):
        self.radio0 = QRadioButton('WYKRES: SINE')
        self.radio1 = QRadioButton('WYKRES: RECTANGLE')
        self.radio2 = QRadioButton('WYKRES: TRIANGLE')
        self.radio3 = QRadioButton('WYKRES: SAWTOOTH')
        self.radio4 = QRadioButton('WYKRES: WHITENOISE')
        self.layout1.addWidget(self.radio0, 0, 0)
        self.layout1.addWidget(self.radio1, 1, 0)
        self.layout1.addWidget(self.radio2, 2, 0)
        self.layout1.addWidget(self.radio3, 3, 0)
        self.layout1.addWidget(self.radio4, 4, 0)
        self.radio0.toggled.connect(self.generowanie)
        self.radio1.toggled.connect(self.generowanie)
        self.radio2.toggled.connect(self.generowanie)
        self.radio3.toggled.connect(self.generowanie)
        self.radio4.toggled.connect(self.generowanie)

    def guziki(self):
        self.guzik1 = QPushButton('ZAPIS DO .CSV', self)
        self.guzik2 = QPushButton('ZAPIS DO .WAV', self)
        self.guzik1.clicked.connect(self.zapiscsv)
        self.guzik2.clicked.connect(self.zapiswav)
        self.layout1.addWidget(self.guzik1, 6, 0)
        self.layout1.addWidget(self.guzik2, 7, 0)



    def tabela(self):
        self.table = QTableWidget(self)
        self.table.setColumnCount(2)
        self.layout1.addWidget(self.table, 8, 0, 1, 2)

    def parametry(self):
        self.dlugosc = QSpinBox(self)
        self.dlugosc.setRange(0, 999999)
        self.dlugosc.setValue(5)
        self.napis = QLabel()
        self.napis.setText("                 DŁUGOŚĆ")
        self.layout1.addWidget(self.napis, 0, 3)
        self.layout1.addWidget(self.dlugosc, 0, 4)
        self.napis1 = QLabel()
        self.napis1.setText("CZĘSTOTL. PRÓBKOWANIA")
        self.layout1.addWidget(self.napis1, 0, 6)
        self.czesto = QSpinBox(self)
        self.czesto.setRange(0, 999999)
        self.czesto.setValue(2000)
        self.layout1.addWidget(self.czesto, 0, 7)
        self.napis2 = QLabel()
        self.napis2.setText("               AMPLITUDA")
        self.layout1.addWidget(self.napis2, 0, 9)
        self.amp = QSpinBox(self)
        self.amp.setRange(0, 999999)
        self.amp.setValue(1)
        self.layout1.addWidget(self.amp, 0, 10)
        self.napis3 = QLabel()
        self.napis3.setText("              CZĘTOTLIWOŚĆ")
        self.layout1.addWidget(self.napis3, 0, 12)
        self.f = QSpinBox(self)
        self.f.setRange(0, 999999)
        self.f.setValue(1)
        self.layout1.addWidget(self.f, 0, 13)
        self.trans_podpis = QLabel()
        self.trans_podpis.setText("TRANSFORMATA FOURIERA:")
        self.layout1.addWidget(self.trans_podpis, 7, 9)
        self.wyk_podpis = QLabel()
        self.wyk_podpis.setText("      WYKRES FUKNCJI: ")
        self.layout1.addWidget(self.wyk_podpis, 3, 9)
        self.czesto.valueChanged.connect(self.akt_SS)
        self.f.valueChanged.connect(self.akt_FF)
        self.amp.valueChanged.connect(self.akt_AA)
        self.dlugosc.valueChanged.connect(self.akt_TT)
        self.FF = self.f.value()
        self.AA = self.amp.value()
        self.SS = self.czesto.value()
        self.TT = self.dlugosc.value()
    def akt_SS(self):
        self.SS=self.czesto.value()
        self.generowanie()
    def akt_FF(self):
        self.FF=self.f.value()
        self.generowanie()
    def akt_AA(self):
        self.AA=self.amp.value()
        self.generowanie()

    def akt_TT(self):
        self.TT=self.dlugosc.value()
        self.generowanie()

    def generowanie(self):

        def TranformataFouriera(t, y):
            N = len(t)
            dt = t[1] - t[0]
            yf = 2.0 / N * np.abs(fft(y)[0:N // 2])
            xf = np.fft.fftfreq(N, d=dt)[0:N // 2]
            return xf, yf

        self.graph = pg.PlotWidget()
        self.graph1 = pg.PlotWidget()
        self.layout1.addWidget(self.graph, 4, 5, 2, 9)
        self.layout1.addWidget(self.graph1, 8, 5, 2, 9)
        par_f = self.FF
        par_A = self.AA
        par_S = self.SS
        par_T = self.TT
        self.x = np.linspace(0, par_T, par_T * par_S)
        if self.radio0.isChecked():
            self.y = par_A * np.sin(2 * 2 * np.pi * par_f * self.x)
        if self.radio1.isChecked():
            self.y = np.sign(par_A * np.sin(2 * np.pi * par_f * self.x))
        if self.radio2.isChecked():
            self.y = 2 * par_A / np.pi * np.arcsin(np.sin(2 * np.pi * par_f * self.x))
        if self.radio3.isChecked():
            self.y = 2 * par_A / np.pi * np.arctan(np.tan(2 * np.pi * par_f * self.x))
        if self.radio4.isChecked():
            self.y = par_A * np.sin(2 * np.pi * par_f * self.x) + (np.random.rand(len(self.x)) - 0.5)
        self.graph.clear()
        self.plot = self.graph.plot(self.x, self.y)
        self.xf, self.yf = TranformataFouriera(self.x, self.y)
        self.plot = self.graph1.plot(self.xf, self.yf)

        self.table.setRowCount(par_S * par_T)
        self.table.setItem(0, 0, QTableWidgetItem("        X"))
        self.table.setItem(0, 1, QTableWidgetItem("        Y"))
        i = 1
        while i < par_S * par_T:
            par_x = str(round(self.x[i], 6))
            par_y = str(round(self.y[i], 6))
            self.table.setItem(i, 0, QTableWidgetItem(par_x))
            self.table.setItem(i, 1, QTableWidgetItem(par_y))
            i = i + 1

    def zapiscsv(self):
        data = {"t": self.x, "y": self.y}
        dataframe = pd.DataFrame(data)
        nazwa = QInputDialog.getText(self, 'NAZWA', 'PODAJ NAZWĘ PLIKU:')
        calosc=nazwa[0]+".csv"
        dataframe.to_csv(calosc, index=False, sep="\t")
        odp=QMessageBox.question(self, "TRANSFORMATA", "CZY CHCESZ ZAPISAĆ TAKŻE TRANSFORMATĘ?" , QMessageBox.Yes | QMessageBox.No, QMessageBox.Yes)
        if odp == QMessageBox.Yes:
            data_t= {"t": self.xf, "y": self.yf}
            dataframe_t = pd.DataFrame(data_t)
            dataframe_t.to_csv("t_"+calosc, index=False, sep="\t")
            QMessageBox.information(self, "ZAPIS", "PLIK ZOSTAŁ ZAPISANY POD NAZWĄ: " + "t_" + calosc)
    def zapiswav(self):
        audio_data = np.int16(self.y * 2 ** 15)
        nazwa = QInputDialog.getText(self, 'NAZWA', 'PODAJ NAZWĘ PLIKU:')
        sampling=self.SS
        calosc=nazwa[0]+".wav"
        write(calosc, sampling, audio_data)



if __name__ == '__main__':
    import sys

    app = QApplication(sys.argv)
    okno = App()
    sys.exit(app.exec_())
