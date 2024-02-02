import React, { useState } from 'react';
import { View, Text, TouchableOpacity, Image, ScrollView, StyleSheet, Alert } from 'react-native';
import { styles_menu } from './style-menu';
import { styles_map } from './style-map';
import { Picker } from '@react-native-picker/picker';
import { useNavigation, useRoute } from '@react-navigation/native';
import DateTimePicker from '@react-native-community/datetimepicker';
import axios from './ConfigAxios.ts';

const Reservation = () => {
  const [selectedDate, setSelectedDate] = useState(new Date());
  const [visit_date, setvisit_date] = useState(new Date());
  const [visit_time, setvisit_time] = useState('08:00');
  const [showDatePicker, setShowDatePicker] = useState(false);
  const [user_id, setuser_id]=useState();
  const [additional_notes]=useState("Rezerwacja przyjęta!");
  const [created_at, setcreated_at]= useState(new Date());
  const navigation = useNavigation();
  const route = useRoute();
  const { name, office_id, dataAcc, email} = route.params;
  const notificationPress = () => {
    navigation.navigate('notifications');
  };

  const generatePickerItems = () => {
    let items = [];
    for (let hour = 8; hour < 15; hour++) {
      for (let minute of ['00', '30']) {
        const time = `${hour < 10 ? '0' : ''}${hour}:${minute}`;
        items.push(<Picker.Item key={time} label={time} value={time} />);
      }
    }
    return items;
  };

  const reserveAppointment =  async() => {
    setuser_id(dataAcc);
    setcreated_at(new Date());
    const userData={
      user_id: parseInt(dataAcc),
      office_id,
      visit_date,
      visit_time,
      additional_notes,
      created_at,
    };
    await axios.post('/visit', userData)
      .then(response => {
        console.log(response.data);
        // Obsłuż odpowiedź serwera, np. wyświetl komunikat o sukcesie
        Alert.alert('Sukces', 'Rezerwacja została przyjęta!');
        navigation.navigate('menu', {email}); // Przejdź do innej ścieżki po zarejestrowaniu
      })
      .catch(error => {
        // Obsłuż błędy związane z rejestracją, np. wyświetl błąd serwera
        console.error('Błąd rejestracji:', error.message);
        Alert.alert('Błąd rejestracji', 'Wystąpił błąd podczas rezerwacji. Spróbuj ponownie później.');
      });
  };
   

  return (
    <ScrollView>

    <View style={styles_map.container}>
      <View style={styles_menu.containerTopBar}>
        <Image source={require('react_files/app/images/herb_Polski.png')} style={styles_menu.herbPolski} />
        <Text style={styles_menu.urzedasPl}>URZĘDAS.PL</Text>
        <TouchableOpacity onPress={notificationPress}>
          <Image source={require('react_files/app/images/notificationBell.png')} style={styles_menu.notificationBell} />
        </TouchableOpacity>
      </View>
      <View style={styles_menu.lineTop}></View>
      <View style={styles_menu.containerBodyTiles}>
      <View style={styles_map.containerText}>
        <Text style={styles_map.visittext}>Wybierz godzinę, która ci odpowiada i umów się na wizytę! </Text>
        <Text style={styles_map.visittext1}>Wybrałeś urząd: {name} </Text>
      </View>
      <View style={styles_map.picker}>
        <Text style={styles_map.visittext1}>Wybierz datę! </Text>
        <TouchableOpacity
          style={styles.datePickerButton}
          onPress={() => setShowDatePicker(true)}
        >
          <Text style={styles.datePickerButtonText}>{visit_date.toLocaleDateString()}</Text>
        </TouchableOpacity>
        {showDatePicker && (
          <DateTimePicker
            value={visit_date}
            mode="date"
            display="calendar"
            onChange={(event, selectedDate) => {
              setShowDatePicker(false);
              if (selectedDate) {
                setvisit_date(selectedDate);
              }
            }}
          />
        )}
        <Text style={styles_map.visittext1}>Wybierz godzinę: </Text>
        <Picker
          style={styles.picker}
          selectedValue={visit_time}
          onValueChange={(itemValue) => setvisit_time(itemValue)}
        >
          {generatePickerItems()}
        </Picker>

        <TouchableOpacity
          style={styles.reserveButton}
          onPress={reserveAppointment}
        >
          <Text style={styles.reserveButtonText}>Zarezerwuj wizytę</Text>
        </TouchableOpacity>
      </View>
      </View>

      <View style={[styles_menu.containerBottomBar]}>
        <Image source={require('react_files/app/images/COI.png')} style={styles_menu.coi} />
        <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_menu.mc} />
        <Text style={styles_menu.versionText}>wersja 1.0</Text>
      </View> 
    </View>
    </ScrollView>

  );
};

const styles = StyleSheet.create({
  datePickerButton: {
    backgroundColor: '#e0e0e0',
    padding: 10,
    borderRadius: 5,
    marginTop: 10,
    marginBottom: 10,
  },
  datePickerButtonText: {
    fontSize: 16,
    textAlign: 'center',
    color: '#000',
  },
  picker: {
    backgroundColor: '#e0e0e0',
    padding: 10,
    textAlign: 'center',
    borderRadius: 5,
  },
  reserveButton: {
    backgroundColor: '#e1e1e1',
    padding: 10,
    borderRadius: 5,
    marginTop: 30,
  },
  reserveButtonText: {
    color: '#fff',
    fontSize: 25,
    textAlign: 'center',
  },
});

export default Reservation;