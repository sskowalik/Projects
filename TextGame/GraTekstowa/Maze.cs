using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Maze
    {
        private static int Exit;

        public int[,] MazeMatrix = new int[14, 12]
           {
                {1, 1, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1},
                {1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1},
                {1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 1, 1},
                {1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1},
                {1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1},
                {1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1},
                {1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1},
                {1, 1, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1},
                {1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
                {1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1},
                {1, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1},
                {1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1}
           };
        public void Game()
        {
            Console.WriteLine("ODGŁOSY WALKI BUDZĄ BARLOGA ZE SNU!");
            Console.WriteLine("UCIEKAJ, ABY UJŚĆ Z ŻYCIEM...");
            Console.WriteLine("PORUSZAJ SIĘ PO LABIRYNCIE ZA POMOCĄ STRZAŁEK --- POSTARAJ SIĘ WYDOSTAĆ! ");
            Console.WriteLine("UWAGA TYLKO JEDNO DROGA JEST PRAWIDŁOWA!");
            Console.WriteLine("ZNACZNIKI: x - ściana --- P - twoja aktualna pozycja na mapie");
            Console.WriteLine("W KTÓRĄ STRONĘ IDZIESZ? (w - północ, d - wschód, s - południe, a - zachód) ");
            Console.WriteLine("PRZYTRZYMAJ ODPOWIEDNI PRZYCISK");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY ROZPOCZĄĆ...");
            Console.ReadKey();
            Thread.Sleep(500);
            int end = Run();
            Exit = end;
        }
        public int getExit()
        {
            return Exit;
        }
        private int positionx=13;
        private int positiony=6;


        public void Print()
        {
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (i==positionx && j==positiony)
                    {
                        Console.Write("P ");
                        j++;
                    }
                    if (MazeMatrix[i, j] == 1)
                    {
                        Console.Write("x ");
                    }
                    if (MazeMatrix[i, j] == 2)
                    {
                        Console.Write("- ");
                    }
                    if (MazeMatrix[i, j] == 0)
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();

            }

        }
         public int Run()
        {
            Console.Clear();
            Print();
            while(true)
            {
                bool key = true;
                while(key)
                {
                    if (Console.ReadKey(true).Key != ConsoleKey.A && Console.ReadKey(true).Key != ConsoleKey.D && Console.ReadKey(true).Key != ConsoleKey.W && Console.ReadKey(true).Key != ConsoleKey.S)
                    {
                        Console.WriteLine("WYBIERZ POPRAWNY KIERUNEK!");
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.A)
                    {
                        key = false;
                        if (MazeMatrix[positionx, positiony - 1] == 1)
                        {
                            Console.WriteLine("NIE MOŻESZ TAM IŚĆ!");
                        }
                        else
                        {
                            positiony--;
                            Console.Clear();
                            Print();
                            break;
                        }
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.D)
                    {
                        key = false;
                        if (MazeMatrix[positionx, positiony + 1] == 1)
                        {
                            Console.WriteLine("NIE MOŻESZ TAM IŚĆ!");
                        }
                        else
                        {
                            positiony++;
                            Console.Clear();
                            Print();
                            break;
                        }
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.W)
                    {
                        key = false;
                        if (MazeMatrix[positionx - 1, positiony] == 1)
                        {
                            Console.WriteLine("NIE MOŻESZ TAM IŚĆ!");
                        }
                        else
                        {
                            positionx--;
                            Console.Clear();
                            Print();
                            break;
                        }
                    }
                    if (Console.ReadKey(true).Key == ConsoleKey.S)
                    {
                        key = false;
                        if (MazeMatrix[positionx + 1, positiony] == 1)
                        {
                            Console.WriteLine("NIE MOŻESZ TAM IŚĆ!");
                        }
                        else
                        {
                            positionx++;
                            Console.Clear();
                            Print();
                            break;
                        }
                    }
                }
                if (MazeMatrix[positionx,positiony]==2)
                {
                    break;
                }
            }
            if(positionx==0 && positiony==2)
            {
                Exit = 1;
                return Exit;
            }
            Exit = 2;
            return Exit;
        }
        public static int ex_return()
        {
            return Exit;
        }
    }
}
