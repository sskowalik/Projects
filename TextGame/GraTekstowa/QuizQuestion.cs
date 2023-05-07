using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class QuizQuestion
    {
        public int normal()
        {
            Console.WriteLine("");
            string choice = "";
            while (choice == "")
            {
                try
                {
                    Console.Write("SAM GAMLEE BYŁ: \na) OGRODNIKIEM\nb) KARCZMARZEM\nc) LOKAJEM ");
                    choice = Console.ReadLine();
                    if (choice != "a" && choice != "b" && choice != "c")
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        choice = "";
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

            }
            if (choice == "a")
            {
                Console.WriteLine("HMM... DOBRZE, ALE TO DOPIERO POCZĄTEK TESTU...");
                return 1;
            }
            return 0;
        }
        public int normal1()
        {
            Console.WriteLine("");
            string choice = "";
            while (choice == "")
            {
                try
                {
                    Console.Write("KTO ODEBRAŁ SAURONOWI PIERŚCIEŃ WŁADZY? \na) ISILDUR\nb) FRODO\nc) GOLLUM ");
                    choice = Console.ReadLine();
                    if (choice != "a" && choice != "b" && choice != "c")
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        choice = "";
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

            }
            if (choice == "a")
            {
                Console.WriteLine("KAŻDY TO WIE...");
                return 1;
            }
            return 0;
        }
        public int elf()
        {
            Console.WriteLine("");
            string choice = "";
            while (choice == "")
            {
                try
                {
                    Console.Write("CZYIM SYNEM BYŁ LEGOLAS? \na) OROPHERA \nb) THRANDUILA\nc) AMDIRA ");
                    choice = Console.ReadLine();
                    if (choice != "a" && choice != "b" && choice != "c")
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        choice = "";
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

            }
            if (choice == "b")
            {
                Console.WriteLine("COŚ-NIECOŚ POTRAFISZ...");
                return 1;
            }
            return 0;
        }
        public int czarodziej()
        {
            Console.WriteLine("");
            string choice = "";
            while (choice == "")
            {
                try
                {
                    Console.Write("GANDALF WPADŁ W ODCHŁAŃ W: \na) KOPALNI MORIA\nb) NA MARTWYCH BAGNACH\nc) JASKINI SZELOBY ");
                    choice = Console.ReadLine();
                    if (choice != "a" && choice != "b" && choice != "c")
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        choice = "";
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

            }
            if (choice == "a")
            {
                Console.WriteLine("MASZ ŁEB NA KARKU...");
                return 1;
            }
            return 0;
        }
        public int krasnolud()
        {
            Console.WriteLine("");
            string choice = "";
            while (choice == "")
            {
                try
                {
                    Console.Write("JEDYNY ZNANY Z SIEDMIU OJCÓW KRASNOLUDÓW, KTÓRY PRZEBUDZIŁ SIĘ W PIECZARACH GÓRY GUNDABAD MIAŁ NA IMIĘ: \na) ERED\nb) THORIN\nc) DURIN ");
                    choice = Console.ReadLine();
                    if (choice != "a" && choice != "b" && choice != "c")
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        choice = "";
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

            }
            if (choice == "c")
            {
                Console.WriteLine("JAK TO WYMYŚLIŁEŚ...");
                return 1;
            }
            return 0;
        }
        public int wojownik()
        {
            Console.WriteLine("");
            string choice = "";
            while (choice == "")
            {
                try
                {
                    Console.Write("ARAGON BYŁ DZIEDZICEM ISILDURA I PRAWOWITYM KRÓLEM: \na) GONDORU\nb) ROHANU\nc) MORDORU ");
                    choice = Console.ReadLine();
                    if (choice != "a" && choice != "b" && choice != "c")
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        choice = "";
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

            }
            if (choice == "")
            {
                Console.WriteLine("MĄDRY Z CIEBIE CZŁOWIEK...");
                return 1;
            }
            return 0;
        }
    }
}
