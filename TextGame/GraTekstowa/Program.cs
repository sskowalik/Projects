using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;


namespace LOTRGame
{ 
    class Program
    {
        
        public static void initial_text()
        {
            Console.WriteLine("-------------- GRA OPARTA NA WYDARZENIACH ZAWARTYCH WE WŁADCY PIERŚCIENI --------------");
            Console.WriteLine("----------------------------- WYBIERZ KOLOR CZCIONKI I TŁA -----------------------------");
            Console.WriteLine("--- ZALECA SIĘ GRĘ NA USTAWIENIACH FABRYCZNYCH (BIAŁA CZCIONKA - 15, CZARNE TŁO - 1) ---");
            Thread.Sleep(2000);
            List<string> list = new List<string>();
            list.Add("Black");
            list.Add("Blue");
            list.Add("Cyan");
            list.Add("DarkBlue");
            list.Add("DarkCyan");
            list.Add("DarkGray");
            list.Add("DarkGreen");
            list.Add("DarkMagenta");
            list.Add("DarkRed");
            list.Add("DarkYellow");
            list.Add("Gray");
            list.Add("Green");
            list.Add("Magenta");
            list.Add("Red");
            list.Add("White");
            list.Add("Yellow");
            int k = 0;
            foreach (string s in list)
            {
                Console.Write(k+1);
                Console.WriteLine(". "+s);
                k++;
            }
            int cf_i=0;
            int cb_i=0;
            string cb;
            string cf;
            
            while (cf_i == 0)
            {
                try
                {
                    Console.Write("WYBIERZ KOLOR CZCIONKI WPISUJĄC INDEKS: ");
                    cf_i = Convert.ToInt32(Console.ReadLine());
                    if (cf_i < 1 || cf_i > 16)
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        cf_i = 0;
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                finally
                {
                    if (cf_i != 0)
                    Console.Write("TWÓJ KOLOR CZCIONKI TO: ");

                }
            }
            cf = list[cf_i-1];
            Console.WriteLine(cf);
            while (cb_i == 0)
            {
                try
                {
                    Console.Write("WYBIERZ KOLOR TŁA WPISUJĄC INDEKS: ");
                    cb_i = Convert.ToInt32(Console.ReadLine());
                    if(cb_i < 1 || cb_i > 16)
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        cb_i = 0;
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                finally
                {
                    if (cb_i != 0)
                    Console.Write("TWÓJ KOLOR TŁA TO: ");
                    
                }
            }
            cb = list[cb_i-1];
            Console.WriteLine(cb);
            ConsoleParameters par = new ConsoleParameters(cf, cb);
            par.setDetails();
            par.setWindowSize();
        }
        public static void history()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------- W TEJ GRZE WCIELISZ SIĘ W JEDNEGO Z CZTERECH BOHATERÓW -------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("---------------------------------------------------------------------------------- BĘDZIESZ PRZEMIERZAŁ KRAINY ŚRÓDZIEMIA ----------------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("-------------------------------------------------------------------------------------------- WALCZYŁ Z POTWORAMI -------------------------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("------------------------------------------------------------------------------------ ZDOBYWAŁ DOŚWIADCZENIE ORAZ ZŁOTO -------------------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("----------------------------------------------------------------------------------- NIE ZABRAKNIE ZAGADEK, CZY PODSTĘPÓW -----------------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("------------------------------------------------------------------------------------ WZRASTAJ W SIŁĘ, ZDOBĄDŹ PIERŚCIEŃ ------------------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("-------------------------------------------------------------------------------------- I POKONAJ NAJWIĘKSZEGO WROGA ----------------------------------------------------------------------------------------");
            Thread.Sleep(2000);
            Console.WriteLine("--------------------------------------------------------------------------------- PRZYGOTUJ SIĘ, BO ROZPOCZYNAMY PRZYGODĘ ----------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("-------------------------------------------------------------------------------- NACIŚNIJ DOWOLNY PRZYCISK, ABY ROZPOCZĄĆ GRĘ ------------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public static int turngame(int pl_HP, int pl_MAXHP, int pl_Attack, int pl_Armor, int m_Attack, int m_Defence, int m_HP, int w_amin, int w_amax)
        {
            int playerActualHP = pl_HP;
            int playerMaxHP = pl_MAXHP;
            int playerAttack = pl_Attack;
            int playerArmor = pl_Armor;
            int monsterAttack = m_Attack;
            int monsterHP = m_HP;
            int monsterDefence = m_Defence;
            Random rand = new Random();



            while (playerActualHP > 0 && monsterHP > 0)
            {
                // Player turn
                Console.WriteLine("-- TWOJA TURA --");
                Console.WriteLine("PUNKTY ŻYCIA BOHATERA - " + playerActualHP + " &&&&&&&& " + " PUNKTY ŻYCIA POTWORA - " + monsterHP);
                ;

                string choice = "";
                while (choice == "")
                {
                    try
                    {
                        Console.Write("WPISZ 'a' ABY ZAATAKOWAĆ ");
                        choice = Console.ReadLine();
                        if (choice != "a")
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
                    int weaponBonusDamage = rand.Next(w_amin, w_amax);
                    playerAttack=playerAttack + weaponBonusDamage;
                    monsterHP = monsterHP - (int)Math.Round(playerAttack - 0.1 * monsterDefence);
                    Console.WriteLine("ATAKUJESZ I ZADAJESZ " + playerAttack + " OBRAŻEŃ!");
                    Thread.Sleep(300);
                }
                // Enemy turn
                if (monsterHP > 0)
                {
                    Console.WriteLine("-- TURA PRZECIWNIKA --");
                    Console.WriteLine("PUNKTY ŻYCIA BOHATERA - " + playerActualHP + " &&&&&&&& "+ "PUNKTY ŻYCIA POTWORA - " + monsterHP);
                    playerActualHP = playerActualHP - (int)Math.Round(monsterAttack -0.2*playerArmor);
                    Console.WriteLine("POTWÓR ATAKUJE I ZADAJE " + (int)Math.Round(monsterAttack - 0.1 * playerArmor) + " OBRAŻEŃ!");
                    Thread.Sleep(300);
                }
            }

            if (playerActualHP > 0)
            {
                Console.WriteLine("WYGRANA, NAGRODY CZEKAJĄ NA CIEBIE!");
                return playerActualHP;
            }
            else
            {
                Console.WriteLine("PORAŻKA, WRÓĆ JAK BĘDZIESZ SILNIEJSZY!");
                return playerActualHP;
            }
        }
        public static int quickgame(int pl_HP, int pl_MAXHP, int pl_Attack, int pl_Armor, int m_Attack, int m_Defence, int m_HP, int w_amin, int w_amax)
        {
            int playerActualHP = pl_HP;
            int playerMaxHP = pl_MAXHP;
            int playerAttack = pl_Attack;
            int playerArmor = pl_Armor;
            int monsterAttack = m_Attack;
            int monsterHP = m_HP;
            int monsterDefence = m_Defence;
            Random rand = new Random();



            while (playerActualHP > 0 && monsterHP > 0)
            {
                
                int weaponBonusDamage = rand.Next(w_amin, w_amax);
                playerAttack = playerAttack + weaponBonusDamage;
                monsterHP = monsterHP - (int)Math.Round(playerAttack - 0.1 * monsterDefence);


                if (monsterHP > 0)
                {
                    playerActualHP = playerActualHP - (int)Math.Round(monsterAttack - 0.1 * playerArmor);
                }
            }

            if (playerActualHP > 0)
            {
                Console.WriteLine("WYGRANA, NAGRODY CZEKAJĄ NA CIEBIE!");
                return playerActualHP;
            }
            else
            {
                Console.WriteLine("PORAŻKA, WRÓĆ JAK BĘDZIESZ SILNIEJSZY!");
                return playerActualHP;
            }
        }

        public static int dicegame(int rate)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            while (playerPoints <3 && enemyPoints < 3)
            {
                Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY RZUCIĆ KOŚCIĄ..."); 
                Console.ReadKey(); 

                playerRandomNum = random.Next(1, 7); 
                Console.WriteLine("WYLOSOWANA PRZEZ CIEBIE LICZBA: " + playerRandomNum);

                Console.WriteLine("...");
                Thread.Sleep(1000); 

                enemyRandomNum = random.Next(1, 7); 
                Console.WriteLine("KARCZMARZ RZUCA KOŚCIĄ I TRAFIA: " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine(playerPoints);
                    Console.WriteLine("WYGRYWASZ TĘ RUNDĘ!");
                    Console.WriteLine();
                }
                else if (playerRandomNum < enemyRandomNum) 
                {
                    enemyPoints++;
                    Console.WriteLine(enemyPoints);
                    Console.WriteLine("PRZECIWNIK WYGRYWA TĘ RUNDĘ!");
                    Console.WriteLine();
                }
                else 
                {
                    Console.WriteLine("REMIS!");
                    Console.WriteLine();
                }
                Console.WriteLine("WYNIK: " +playerPoints+" : "+enemyPoints);
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("WYGRYWASZ! "+playerPoints+" : "+enemyPoints);
                return 2 * rate;
            }
            else
            {
                Console.WriteLine("PORAŻKA!" + enemyPoints + " : " + playerPoints);
                return 0;
            }            
        }
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            QuizQuestion quizQuestion = new QuizQuestion();
            Level level = new Level();
            Experience experience = new Experience(level);
            Gold gold = new Gold();
            Weapon weapon = new Weapon();
            Armour armour = new Armour();
            Helmet helmet = new Helmet();
            Locations Locations = new Locations();
            var list_1 = Locations.CreateLoc_1();
            var list_2 = Locations.CreateLoc_2();
            var list_3 = Locations.CreateLoc_3();
            Locations = new Locations("Równiny", 1, 10);
            Locations = new Locations("Czarny Las", 11, 20);
            Locations = new Locations("Przeklęta Dolina", 21, 30);
            Console.CursorVisible = false;
            initial_text();
            history();
            string name = "WYBÓR ŚCIEŻKI BOHATERA";
            string desc = "WYBIERZ, W ŚLADY KTÓREGO MISTRZA CHCESZ PODĄŻAĆ:\n \t a) GIMLI - Krasnolud\n \t b) LEGOLAS - Elf\n \t c) GANDALF - Czarodziej\n \t d) ARAGORN - Wojownik";
            int exp = 11;
            int g = 10;
            int lvl_r = 0;
            Quest quest = new Quest(name, desc, exp, g, lvl_r, 0);
            quest.getQuestInfo();
            string choice = "";
            while (choice == "")
            {
                try
                {
                    Console.Write("KTÓREGO BĘDZIESZ UCZNIEM? (PODAJ INDEKS a-d) ");
                    choice = Console.ReadLine();
                    if (choice != "a" && choice != "b" && choice != "c" && choice != "d")
                    {
                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                        choice = "";
                    }
                }
                catch (Exception)
                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

            }
            string hero_class;
            if (choice == "a")
            {
                hero_class = "Krasnolud";
                weapon = new Weapon("Wyszczerbiony topór", 1, 6, 1);
                armour = new Armour("Podarte ubranie", 1, 5, 1);
                helmet = new Helmet("Czapka", 1, 1);
                
            }
            else if (choice == "b")
            {
                hero_class = "Elf";
                weapon = new Weapon("Zbutwiały łuk", 2, 5, 1);
                armour = new Armour("Podarte ubranie", 1, 5, 1);
                helmet = new Helmet("Czapka", 1, 1);
            }
            else if (choice == "c")
            {
                hero_class = "Czarodziej";
                weapon = new Weapon("Złamana różdżka", 3, 4, 1);
                armour = new Armour("Podarta szata", 1, 5, 1);
                helmet = new Helmet("Kapelusz", 1, 1);
            }
            else
            {
                hero_class = "Wojownik";
                weapon = new Weapon("Sztylet", 2, 7, 1);
                armour = new Armour("Podarte ubranie", 1, 5, 1);
                helmet = new Helmet("Czapka", 1, 1);
            }
            Hero hero = new Hero(level, helmet, weapon, armour);
            hero.setClass(hero_class);
            Console.WriteLine("GRATULACJE! WYBRAŁEŚ KLASĘ: " + hero_class);
            Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
            Console.WriteLine();
            Console.WriteLine();
            quest.addToCount();
            gold.addGold(quest.Gold_gain);
            experience.addExp(quest.Exp_gain);
            hero.actualMax_HP();
            hero.actualArmor();
            hero.actualAttackDamage();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("OTRZYMANO NOWY EKWIPUNEK!");
            Console.WriteLine();
            weapon.getInfo();
            Console.WriteLine();
            armour.getInfo();
            Console.WriteLine();
            helmet.getInfo();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY PÓJŚĆ DALEJ...");
            Console.ReadKey();
            Console.Clear();
            bool finish = false;
            List <string> actions = new List <string>();
            actions.Add("1. KOLEJNA MISJA");
            actions.Add("2. WYPRAWA");
            actions.Add("3. KARCZMA");
            actions.Add("4. SKLEP");
            actions.Add("5. STATYSTYKI POSTACI");
            actions.Add("6. EKWIPUNEK");
            actions.Add("7. STATYSTYKI POKONANYCH POTWORÓW");
            actions.Add("8. PODDAJ SIĘ");
            while (finish==false)
            {
                Console.WriteLine("WYBIERZ, CO DALEJ CHCESZ ROBIĆ: ");
                foreach (string action in actions)
                {
                    Console.WriteLine(action);
                }
                int act = 0;
                while (act == 0)
                {
                    try
                    {
                        Console.Write("CO WYBIERASZ? (PODAJ INDEKS 1-9) ");
                        act = Convert.ToInt32(Console.ReadLine());
                        if (act<1 || act>9)
                        {
                            Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                            act = 0;
                        }
                    }
                    catch (Exception)
                    { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                    
                }
                Console.WriteLine();
                if (act==1)
                {
                    if (quest.getCount() == 9)
                    {
                        name = "STAŃ SIĘ BOHATEREM!";
                        desc = "ZNISZCZ PIERŚCIEŃ I STAW CZOŁA POTĘŻNEMU SAURONOWI!";
                        exp = 0;
                        g = 0;
                        lvl_r = 30;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        if (lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("DOTARŁEŚ NA SKRAJ GÓRY");
                            Console.WriteLine("MUSISZ TERAZ ZNISZCZYĆ PIERŚCIEŃ --- WRZUCAJĄC GO DO GÓRY PRZEZNACZENIA!");
                            Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK BY TO ZROBIĆ!");
                            Console.ReadKey();
                            Console.WriteLine("ZNISZCZENIE PIERŚCIENIA MOCNO CIĘ OSŁABIA - TRACISZ 1/3 PUNKTÓW ŻYCIA");
                            hero.setActual_HP((int)(hero.getActualHP() * 2 / 3));
                            Console.WriteLine("MUSISZ JEDNAK WYPEŁNIĆ PRZEZNACZENIE I STAWIĆ CZOŁA SAURONOWI");
                            if (turngame(hero.getActualHP(), hero.getMAXHP(), hero.getActualAttackDamage(), hero.getActualArmor(), 45, 50, 180, hero.Weapon.AtackMin, hero.Weapon.AtackMax) > 0)
                            {
                                Console.WriteLine("SAURON NIE ŻYJE! CAŁE ŚRÓDZIEMIE BĘDZIE CIĘ WYCHWALAĆ PO WIEKI!");
                                Console.WriteLine("UDOWODNIŁEŚ WSZYSTKIM, ŻE JESTEŚ GODNYM MIANA BOHATERA!");
                                Console.WriteLine("TUTAJ TWOJA WĘDRÓWKA SIĘ KOŃCZY");
                                Console.WriteLine();
                                Console.WriteLine("DZIĘKUJĘ ZA WSPÓLNĄ PODRÓŻ! MAM NADZIEJĘ, ŻE BAWIŁEŚ SIĘ DOBRZE :) ");
                                Console.WriteLine();
                                Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY WYJŚĆ Z GRY...");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                                hero.setActual_HP(1);
                        }
                    }
                    if (quest.getCount() == 8)
                    {
                        name = "WALKA ZE STRAŻNIKAMI!";
                        desc = "ZBLIŻASZ SIĘ DO KOŃCA PRZYGODY, WCHODZĄC W GŁĄB MORDORU NA DRODZE DO SAURONA STOI TYLKO ON --- STRAŻNIK!";
                        exp = 600;
                        g = 500;
                        lvl_r = 25;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        if (lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (hero.getClass()=="Czarodziej")
                            {
                                Console.WriteLine("STAŃ DO WALKI Z SARUMANEM - POTĘŻNYM CZARNOKSIĘŻNIKIEM");
                            }
                            else
                                Console.WriteLine("W SZRANKI Z TOBĄ STAJE AZOG PLUGAWY - POKONAJ GO!");
                            if (turngame(hero.getActualHP(), hero.getMAXHP(), hero.getActualAttackDamage(), hero.getActualArmor(), 65, 45, 150, hero.Weapon.AtackMin, hero.Weapon.AtackMax) > 0)
                            {
                                Console.WriteLine("STRAŻNIK NIE ŻYJE! DROGA DO GÓRY PRZEZNACZENIA ZOSTAŁA OCZYSZCZONA!");
                                Console.WriteLine("ZADANIE WYKONANE!");
                                Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                                Console.WriteLine();
                                Console.WriteLine();
                                quest.addToCount();
                                gold.addGold(quest.Gold_gain);
                                experience.addExp(quest.Exp_gain);
                                hero.actualMax_HP();
                                hero.actualArmor();
                                hero.actualAttackDamage();

                            }
                            else
                                hero.setActual_HP(1);
                        }
                    }
                    if (quest.getCount() == 7)
                    {
                        name = "WĘDRÓWKA W GŁĘBIE DOLINY!";
                        desc = "POKONAJ 10 PRZECIWNIKÓW W PRZEKLĘTEJ DOLINIE!";
                        exp = 550;
                        g = 270;
                        lvl_r = 20;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        if (lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (Locations.getLoc3_c() < 10)
                            {
                                Console.WriteLine("WRÓĆ JAK POKONASZ WIĘCEJ PRZECIWNIKÓW W PRZEKLĘTEJ DOLINIE: " + Locations.getLoc3_c() + " / " + "10");
                            }
                            else
                            {
                                Console.WriteLine("ZADANIE WYKONANE!");
                                Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                                Console.WriteLine();
                                Console.WriteLine();
                                quest.addToCount();
                                gold.addGold(quest.Gold_gain);
                                experience.addExp(quest.Exp_gain);
                                hero.actualMax_HP();
                                hero.actualArmor();
                                hero.actualAttackDamage();
                                if (hero.getClass() == "Krasnolud")
                                {
                                    weapon = new Weapon("Święty młot", 14, 20, 20);
                                    armour = new Armour("Święta zbroja", 12, 25, 20);
                                    helmet = new Helmet("Święty hełm", 11, 20);

                                }
                                if (hero.getClass() == "Elf")
                                {
                                    weapon = new Weapon("Łuk myśliwski", 14, 20, 20);
                                    armour = new Armour("Strój myśliwski", 12, 25, 20);
                                    helmet = new Helmet("Czapka myśliwska", 11, 20);
                                }
                                if (hero.getClass() == "Czarodziej")
                                {
                                    weapon = new Weapon("Mistyczna różdżka", 14, 20, 20);
                                    armour = new Armour("Mistyczna zbroja", 12, 25, 20);
                                    helmet = new Helmet("Kapelusz mistyka", 11, 20);
                                }
                                if (hero.getClass() == "Wojownik")
                                {
                                    weapon = new Weapon("Łamacz kości", 14, 20, 20);
                                    armour = new Armour("Kościana zbroja płytowa", 12, 25, 20);
                                    helmet = new Helmet("Czaszka poległego", 11, 20);
                                }
                                Console.WriteLine("OTRZYMANO NOWY EKWIPUNEK!");
                                Console.WriteLine();
                                weapon.getInfo();
                                Console.WriteLine();
                                armour.getInfo();
                                Console.WriteLine();
                                helmet.getInfo();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Thread.Sleep(2000);
                                Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY PÓJŚĆ DALEJ...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    if (quest.getCount() == 6)
                    {
                        name = "WYPRAWA DO KOPALNI MORII!";
                        desc = "ZAWALCZ Z ORKAMI I POSTARAJ SIĘ NIE ZBUDZIĆ BARLOGA!";
                        exp = 500;
                        g = 250;
                        lvl_r = 16;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        if (lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("NAPADA CIE HORDA ORKÓW - STAW IM CZOŁA, ŻEBY IŚĆ DALEJ!");
                            if (turngame(hero.getActualHP(), hero.getMAXHP(), hero.getActualAttackDamage(), hero.getActualArmor(), 38, 18, 104, hero.Weapon.AtackMin, hero.Weapon.AtackMax) > 0)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine("OKROWIE POKONANI!");
                                maze.Game();
                                if(maze.getExit()==1)
                                {
                                    Console.WriteLine("WYBRAŁEŚ, ŹLE... ");
                                    Console.WriteLine("POLEGŁEŚ... ZADANIE NIEZALICZONE");
                                    hero.setActual_HP(1);
                                }
                                if (maze.getExit()==2)
                                {
                                    Console.WriteLine("UDAŁO SIĘ! WYDOSTAŁEŚ SIĘ Z KOPALNI");
                                    Console.WriteLine("ZADANIE WYKONANE!");
                                    Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    quest.addToCount();
                                    gold.addGold(quest.Gold_gain);
                                    experience.addExp(quest.Exp_gain);
                                    hero.actualMax_HP();
                                    hero.actualArmor();
                                    hero.actualAttackDamage();

                                }
                                Thread.Sleep(1000);

                            }
                        }
                    }
                    if (quest.getCount() == 5)
                    {
                        name = "PRZECHADZKA PO LESIE!";
                        desc = "POKONAJ 10 PRZECIWNIKÓW W CZARNYM LESIE!";
                        exp = 330;
                        g = 170;
                        lvl_r = 12;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        if (lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (Locations.getLoc2_c() < 10)
                            {
                                Console.WriteLine("WRÓĆ JAK POKONASZ WIĘCEJ PRZECIWNIKÓW W CZARNYM LESIE: " + Locations.getLoc2_c() + " / " + "10");
                            }
                            else
                            {
                                Console.WriteLine("ZADANIE WYKONANE!");
                                Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                                Console.WriteLine();
                                Console.WriteLine();
                                quest.addToCount();
                                gold.addGold(quest.Gold_gain);
                                experience.addExp(quest.Exp_gain);
                                hero.actualMax_HP();
                                hero.actualArmor();
                                hero.actualAttackDamage();
                            }
                        }
                    }
                    if (quest.getCount() == 4)
                    {
                        name = "ZBIERZ DRUŻYNĘ!";
                        desc = "UDOWODNIJ SWOJĄ WARTOŚĆ - WYKAŻ SIĘ ZNAJOMOŚCIĄ I ZBIERZ KOMPANÓW Z INNĄ KLASĄ BOHATERA!";
                        exp = 300;
                        g = 230;
                        lvl_r = 10;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        int prop_ans = 0;
                        if (lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (hero.getClass() == "Krasnolud")
                            {
                                prop_ans = prop_ans + quizQuestion.normal();
                                prop_ans = prop_ans + quizQuestion.normal1();
                                prop_ans = prop_ans + quizQuestion.elf();
                                prop_ans = prop_ans + quizQuestion.czarodziej();
                                prop_ans = prop_ans + quizQuestion.wojownik();
                            }
                            if (hero.getClass() == "Elf")
                            {
                                prop_ans = prop_ans + quizQuestion.normal();
                                prop_ans = prop_ans + quizQuestion.normal1();
                                prop_ans = prop_ans + quizQuestion.krasnolud();
                                prop_ans = prop_ans + quizQuestion.czarodziej();
                                prop_ans = prop_ans + quizQuestion.wojownik();
                            }
                            if (hero.getClass() == "Wojownik")
                            {
                                prop_ans = prop_ans + quizQuestion.normal();
                                prop_ans = prop_ans + quizQuestion.normal1();
                                prop_ans = prop_ans + quizQuestion.elf();
                                prop_ans = prop_ans + quizQuestion.czarodziej();
                                prop_ans = prop_ans + quizQuestion.krasnolud();
                            }
                            if (hero.getClass() == "Czarodziej")
                            {
                                prop_ans = prop_ans + quizQuestion.normal();
                                prop_ans = prop_ans + quizQuestion.normal1();
                                prop_ans = prop_ans + quizQuestion.elf();
                                prop_ans = prop_ans + quizQuestion.krasnolud();
                                prop_ans = prop_ans + quizQuestion.wojownik();
                            }
                        }
                        if (prop_ans == 4)
                        {
                            Console.WriteLine("UDAŁO CI SIĘ PRZEJŚĆ TEST --- NIEZNAJOMI GODZĄ SIĘ NA TO BY DOŁĄCZYĆ DO TWOJEJ DRUŻYNY");
                            Console.WriteLine("TERAZ RAZEM Z NIMI BĘDZIESZ PRZEMIERZAŁ ZŁOWROGI ŚWIAT ŚRÓDZIEMIA");
                            Console.WriteLine("ZADANIE WYKONANE!");
                            Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                            Console.WriteLine();
                            Console.WriteLine();
                            quest.addToCount();
                            gold.addGold(quest.Gold_gain);
                            experience.addExp(quest.Exp_gain);
                            hero.actualMax_HP();
                            hero.actualArmor();
                            hero.actualAttackDamage();

                        }
                        if (prop_ans == 5)
                        {
                            Console.WriteLine("UDAŁO CI SIĘ PRZEJŚĆ TEST --- NIEZNAJOMI SĄ ZDZIWIENI TWOJĄ WIEDZĄ I Z RADOŚCIĄ GODZĄ SIĘ NA TO BY DOŁĄCZYĆ DO TWOJEJ DRUŻYNY");
                            Console.WriteLine("TERAZ RAZEM Z NIMI BĘDZIESZ PRZEMIERZAŁ ZŁOWROGI ŚWIAT ŚRÓDZIEMIA");
                            Console.WriteLine("ZADANIE WYKONANE!");
                            Console.WriteLine("BONUSOWE DOŚWIADCZENIE ZA WYKONANE OSIĄGNIĘCIE: + 80 PUNKTÓW DOŚWIADCZENIA");
                            Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain+80 + " PUNKTÓW DOŚWIADCZENIA");
                            Console.WriteLine();
                            Console.WriteLine();
                            quest.addToCount();
                            gold.addGold(quest.Gold_gain);
                            experience.addExp(quest.Exp_gain + 80);
                            hero.actualMax_HP();
                            hero.actualArmor();
                            hero.actualAttackDamage();
                        }
                        if (prop_ans >=4)
                        {
                            if (hero.getClass() == "Krasnolud")
                            {
                                weapon = new Weapon("Topór bojowy", 5, 12, 10);
                                armour = new Armour("Niewykończona zbroja", 6, 12, 10);
                                helmet = new Helmet("Niewykończony hełm", 7, 10);

                            }
                            if (hero.getClass() == "Elf")
                            {
                                weapon = new Weapon("Długi łuk", 4, 13, 10);
                                armour = new Armour("Skórzany pancerz", 6, 14, 10);
                                helmet = new Helmet("Skórzany kaptur", 5, 10);
                            }
                            if (hero.getClass() == "Czarodziej")
                            {
                                weapon = new Weapon("Pałka bojowa", 5, 12, 10);
                                armour = new Armour("Prosta szata", 6, 12, 10);
                                helmet = new Helmet("Jedwabny kapelusz", 7, 10);
                            }
                            if (hero.getClass() == "Wojownik")
                            {
                                weapon = new Weapon("Niewykończony miecz", 5, 12, 10);
                                armour = new Armour("Stalowy napierśnik", 6, 12, 10);
                                helmet = new Helmet("Stalowy hełm", 7, 10);
                            }
                            Console.WriteLine("OTRZYMANO NOWY EKWIPUNEK!");
                            Console.WriteLine();
                            weapon.getInfo();
                            Console.WriteLine();
                            armour.getInfo();
                            Console.WriteLine();
                            helmet.getInfo();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Thread.Sleep(2000);
                            Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY PÓJŚĆ DALEJ...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    if (quest.getCount() == 3)
                    {
                        name = "NASZ SKARB!";
                        desc = "ODBIERZ PIEŚCIEŃ GOLLUMOWI! (JEŻELI PÓJDZIE CI SŁABO - ODPOWIEDZI ZNAJDUJĄ SIĘ W PLIKU W FOLDERZE Z GRĄ) ";
                        exp = 120;
                        g = 70;
                        lvl_r = 7;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        if (lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("SPRÓBUJ ODPOWIEDZIEĆ NA ZAGADKI GOLLUMA, ABY OTRZYMAĆ OD NIEGO PIERŚCIEŃ (ODPOWIEDŹ NALEŻY WPISAĆ MAŁYMI LITERAMI)");
                            int pts = 0;
                            Thread.Sleep(4000);
                            while (pts!=5)
                            {
                                string answer;
                                Console.Clear();
                                if (pts == 0)
                                {
                                    Console.WriteLine("ZAGADKA NR 1:");
                                    Console.WriteLine("Korzeni nie widziało niczyje oko,\na przecież to coś sięga bardzo wysoko,\nod drzew wybujało wspanialej\nchociaż nie rośnie wcale.");
                                    answer = Console.ReadLine();


                                    if (answer == "góra")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("POPRAWNA ODPOWIEDŹ");
                                        Console.WriteLine();
                                        pts++;
                                    }
                                }
                                if (pts==1)
                                {
                                    Console.WriteLine("ZAGADKA NR 2:");
                                    Console.WriteLine("Nie ma skrzydeł, a trzepocze, nie ma ust, a mamrocze,\nnie ma nóg, a pląsa, nie ma zębów, a kąsa. ");
                                    answer = Console.ReadLine();
                                    if (answer == "wiatr")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("POPRAWNA ODPOWIEDŹ");
                                        Console.WriteLine();
                                        pts++;
                                    }
                                }
                                if (pts == 2)
                                {
                                    Console.WriteLine("ZAGADKA NR 3:");
                                    Console.WriteLine("Nie można tego zobaczyć ani dotknąć palcami,\nnie można wyczuć węchem ani usłyszeć uszami;\njest pod górami, jest nad gwiazdami,\npustej jaskini nie omija,\npo nas zostanie, było przed nami,\nżycie gasi, a śmiech zabija.");
                                    answer = Console.ReadLine();
                                    if (answer == "ciemność")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("POPRAWNA ODPOWIEDŹ");
                                        Console.WriteLine();
                                        pts++;
                                    }
                                }
                                if(pts == 3)
                                {
                                    Console.WriteLine("ZAGADKA NR 4:");
                                    Console.WriteLine("Nie oddycha, a żyje, nie pragnie, a wciąż pije.  ");
                                    answer = Console.ReadLine();
                                    if (answer == "ryba")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("POPRAWNA ODPOWIEDŹ");
                                        Console.WriteLine();
                                        pts++;
                                    }
                                }
                                if (pts == 4)
                                {
                                    Console.WriteLine("ZAGADKA NR 5:");
                                    Console.WriteLine("Coś, przed czym w świecie nic nie uciecze,\nco gnie żelazo, przegryza miecze,\npożera ptaki, zwierzęta, ziele,\nnajtwardszy kamień na mąkę miele,\nkrólów nie szczędzi, rozwala mury,\nponiża nawet najwyższe góry. ");
                                    answer = Console.ReadLine();
                                    if (answer == "czas")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("POPRAWNA ODPOWIEDŹ");
                                        Console.WriteLine();
                                        pts++;
                                    }
                                }
                                

                            }
                            Console.WriteLine();
                            Console.WriteLine("NIE ODPUSZCZĘ CI TAK ŁATWO!!!");
                            Console.WriteLine("ABY ZDOBYĆ PIERŚCIEŃ BĘDZIESZ MUSIAŁ MNIE POKONAĆ W WALCE!");
                            if (turngame(hero.getActualHP(), hero.getMAXHP(), hero.getActualAttackDamage(), hero.getActualArmor(), 12, 8, 74, hero.Weapon.AtackMin, hero.Weapon.AtackMax)> 0)
                            {
                                Console.WriteLine("ZADANIE WYKONANE!");
                                Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                                Console.WriteLine("NOWY PRZEDMIOT W EKWIPUNKU: JEDYNY PIEŚCIEŃ");
                                Console.WriteLine();
                                Console.WriteLine();
                                quest.addToCount();
                                gold.addGold(quest.Gold_gain);
                                experience.addExp(quest.Exp_gain);
                                hero.actualMax_HP();
                                hero.actualArmor();
                                hero.actualAttackDamage();
                            }
                            else
                            {
                                Console.WriteLine("TYM RAZEM, ZAWIODŁEŚ...");
                                    hero.setActual_HP(1);
                            }

                            }
                    }
                    if (quest.getCount() == 2)
                    {
                        name = "MIŁOŚNIK RÓWNIN!";
                        desc = "POKONAJ 10 PRZECIWNIKÓW NA RÓWNINACH!";
                        exp = 100;
                        g = 30;
                        lvl_r = 4;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        if(lvl_r > hero.getHeroLevel())
                        {
                            Console.WriteLine("MASZ ZA MAŁY POZIOM, ABY PODJĄĆ SIĘ TEJ MISJI!");
                            Console.WriteLine("WRÓĆ JAK STANIESZ SIĘ SILNIESZY!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (Locations.getLoc1_c()<10)
                            {
                                Console.WriteLine("WRÓĆ JAK POKONASZ WIĘCEJ PRZECIWNIKÓW W RÓWNINACH: "+Locations.getLoc1_c()+" / "+"10");
                            }
                            else
                            {
                                Console.WriteLine("ZADANIE WYKONANE!");
                                Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                                Console.WriteLine();
                                Console.WriteLine();
                                quest.addToCount();
                                gold.addGold(quest.Gold_gain);
                                experience.addExp(quest.Exp_gain);
                                hero.actualMax_HP();
                                hero.actualArmor();
                                hero.actualAttackDamage();
                            }
                        }
                    }
                    if (quest.getCount() == 1)
                    {
                        name = "WYKAŻ SIĘ!";
                        desc = "UDOWODNIJ, ŻE JESTEŚ GODZIEN MIANA BOHATERA";
                        exp = 20;
                        g = 10;
                        lvl_r = 1;
                        quest = new Quest(name, desc, exp, g, lvl_r, quest.getCount());
                        quest.getQuestInfo();
                        Console.WriteLine();
                        Console.WriteLine("KLIKAJ LEWĄ LUB PRAWĄ STRZAŁKĘ, W ZALEŻNOŚCI, PO KTÓREJ STRONIE POJAWI SIĘ POTWÓR!");
                        Console.WriteLine("POMYŁKA BĘDZIE SKUTKOWAŁA POWTÓRZENIEM ZADANIA!");
                        Thread.Sleep(7000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("5");
                        Thread.Sleep(500);
                        Console.WriteLine("4");
                        Thread.Sleep(500);
                        Console.WriteLine("3");
                        Thread.Sleep(500);
                        Console.WriteLine("2");
                        Thread.Sleep(500);
                        Console.WriteLine("1");
                        Thread.Sleep(500);
                        Console.Clear();
                        List<string> monster = new List<string>();
                        monster.Add("         .AMMMMMMMMMMA.          ");
                        monster.Add("        .AV. :::.:.:.::MA.        ");
                        monster.Add("      A' :..        : .:`A       ");
                        monster.Add("     A'..              . `A.     ");
                        monster.Add("    A' :.    :::::::::  : :`A    ");
                        monster.Add("    M  .    :::.:.:.:::  . .M    ");
                        monster.Add("    M  :   ::.:.....::.:   .M    ");
                        monster.Add("    V : :.::.:........:.:  :V    ");
                        monster.Add("   A  A:    ..:...:...:.   A A   ");
                        monster.Add("  .V  MA:.....:M.::.::. .:AM.M   ");
                        monster.Add(" A'  .VMMMMMMMMM:.:AMMMMMMMV: A  ");
                        monster.Add(":M .  .`VMMMMMMV.:A `VMMMMV .:M: ");
                        monster.Add(" V.:.  ..`VMMMV.:AM..`VMV' .: V  ");
                        monster.Add("  V.  .:. .....:AMMA. . .:. .V   ");
                        monster.Add("   VMM...: ...:.MMMM.: .: MMV    ");
                        monster.Add("       `VM: . ..M.:M..:::M'      ");
                        monster.Add("         `M::. .:.... .::M       ");
                        monster.Add("          M:.  :. .... ..M       ");
                        monster.Add("          V:  M:. M. :M .V       ");
                        monster.Add("          `V.:M.. M. :M.V'");
                        int points = 0;
                        while (points!=5)
                        {
                            Random rd = new Random();
                            int rolled = rd.Next(1,101);
                            if (rolled < 51)
                            {
                                foreach (string m in monster)
                                {
                                    Console.WriteLine(m);
                                }
                                Console.WriteLine();
                                ConsoleKeyInfo dir = new ConsoleKeyInfo();
                                dir = Console.ReadKey();
                                if (dir.Key == ConsoleKey.LeftArrow)
                                {
                                    points++;
                                }
                                else
                                {
                                    points = 0;
                                    Console.Clear();
                                    Console.WriteLine("POMYŁKA!");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                foreach (string m in monster)
                                {
                                    Console.WriteLine("                                                                                                                                                             " + m);

                                }
                                Console.WriteLine();
                                ConsoleKeyInfo dir = new ConsoleKeyInfo();
                                dir = Console.ReadKey();
                                if (dir.Key == ConsoleKey.RightArrow)
                                {
                                    points++;

                                }
                                else
                                {
                                    points = 0;
                                    Console.Clear();
                                    Console.WriteLine("POMYŁKA!");
                                    Console.WriteLine();
                                }
                            }
                        }
                        Thread.Sleep(500);
                        Console.WriteLine("GRATULACJE! UDAŁO CI SIĘ DOWIEŚĆ SWOJEJ WARTOŚCI!");
                        Console.WriteLine("OTRZYMANO: " + quest.Gold_gain + " SZTUK ZŁOTA --- " + quest.Exp_gain + " PUNKTÓW DOŚWIADCZENIA");
                        Console.WriteLine();
                        Console.WriteLine();
                        quest.addToCount();
                        gold.addGold(quest.Gold_gain);
                        experience.addExp(quest.Exp_gain);
                        hero.actualMax_HP();
                        hero.actualArmor();
                        hero.actualAttackDamage();


                    }

                }
                if (act==2)
                {
                    Console.Clear();
                    Dictionary <int, int> lvl_values = new Dictionary<int, int>();
                    lvl_values = Locations.ReturnLoc_lvls();
                    int it = 0;
                    string act_2 = "";
                    while (act_2 == "")
                    {
                        try
                        {
                            Console.Write("CZY CHCESZ WYŚWIETLIĆ INFORMACJE O POTWORACH? (tak/nie) ");
                            act_2 = Console.ReadLine();
                            if (act_2!="tak"&& act_2!="nie")
                            {
                                Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                act_2 = "";
                            }
                        }
                        catch (Exception)
                        { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                    }
                    if (act_2 == "tak")
                    {
                        foreach (KeyValuePair<int, int> kvp in lvl_values)
                        {
                            Console.WriteLine(Locations.ReturnLocations()[it] + ": ZAKRES POZIOMU BOHATERA: (" + kvp.Key + "-" + kvp.Value + ")");
                            Console.WriteLine("WYSTĘPUJĄTE TAM POTWORY: ");
                            if (it == 0)
                            {
                                foreach (Monsters m in list_1)
                                {
                                    m.showInfo();
                                }

                            }
                            if (it == 1)
                            {
                                foreach (Monsters m in list_2)
                                {
                                    m.showInfo();
                                }

                            }
                            if (it == 2)
                            {
                                foreach (Monsters m in list_3)
                                {
                                    m.showInfo();
                                }

                            }
                            it++;
                        }
                    }
                    else
                    {
                        foreach (KeyValuePair<int, int> kvp in lvl_values)
                        {
                            Console.WriteLine(Locations.ReturnLocations()[it] + ": ZAKRES POZIOMU BOHATERA: (" + kvp.Key + "-" + kvp.Value + ")");
                            it++;
                        }
                    }
                    Console.WriteLine();
                    string act_1 = "";
                    while (act_1 == "")
                    {
                        try
                        {
                            Console.Write("CZY CHCESZ PODJĄĆ SIĘ WYZWANIA, DLA SWOJEGO PRZEDZIAŁU POZIOMOWEGO? (tak/nie) ");
                            act_1 = Console.ReadLine();
                            if (act_1 != "tak" && act_1 !="nie")
                            {
                                Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                act_1 = "";
                            }
                        }
                        catch (Exception)
                        { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                    }
                    if(act_1=="tak")
                    {
                        Console.WriteLine("WYBIERZ SPOSÓB WALKI: (WPISUJĄC 1/2)");
                        Console.WriteLine("1. SZYBKA WALKA");
                        Console.WriteLine("2. WALKA TUROWA");
                        int act_3 = 0;
                        while (act_3 == 0)
                        {
                            try
                            {
                                Console.Write("WYBIERZ SPOSÓB WALKI: ");
                                act_3 = Convert.ToInt32(Console.ReadLine());
                                if (act_3 < 1 || act_3 > 2)
                                {
                                    Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                    act_3 = 0;
                                }
                            }
                            catch (Exception)
                            { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                        }
                        int m_def = 0;
                        int m_hp = 0;
                        int m_attack = 0;
                        int gold_to_hero = 0;
                        int exp_to_hero = 0;
                        
                        while(act_3==2)
                        {
                            if (hero.getHeroLevel() > 0 && hero.getHeroLevel() < 11)
                            {
                                Random random = new Random();
                                int result = random.Next(0, list_1.Count());
                                Console.Clear();
                                Console.WriteLine("ZAWALCZYSZ Z: ");
                                list_1[result].showInfo();
                                m_def = list_1[result].MonsterDefence;
                                m_hp = list_1[result].MonsterHP;
                                m_attack = list_1[result].MonsterAttack;
                                gold_to_hero = list_1[result].MonsterGOLDToHero;
                                exp_to_hero = list_1[result].MonsterEXPToHero;
                            }
                            if (hero.getHeroLevel() > 10 & hero.getHeroLevel() < 21)
                            {
                                Random random = new Random();
                                int result = random.Next(0, list_2.Count());
                                Console.Clear();
                                Console.WriteLine("ZAWALCZYSZ Z: ");
                                list_2[result].showInfo();
                                m_def = list_2[result].MonsterDefence;
                                m_hp = list_2[result].MonsterHP;
                                m_attack = list_2[result].MonsterAttack;
                                gold_to_hero = list_2[result].MonsterGOLDToHero;
                                exp_to_hero = list_2[result].MonsterEXPToHero;
                            }
                            if (hero.getHeroLevel() > 20 && hero.getHeroLevel() < 31)
                            {
                                Random random = new Random();
                                int result = random.Next(0, list_3.Count());
                                Console.Clear();
                                Console.WriteLine("ZAWALCZYSZ Z: ");
                                list_3[result].showInfo();
                                m_def = list_3[result].MonsterDefence;
                                m_hp = list_3[result].MonsterHP;
                                m_attack = list_3[result].MonsterAttack;
                                gold_to_hero = list_3[result].MonsterGOLDToHero;
                                exp_to_hero = list_3[result].MonsterEXPToHero;
                            }
                            int x = turngame(hero.getActualHP(), hero.getMAXHP(), hero.getActualAttackDamage(), hero.getActualArmor(), m_attack, m_def, m_hp, hero.Weapon.AtackMin, hero.Weapon.AtackMax);
                            if (x > 0)
                            {
                                if (hero.getHeroLevel() > 0 && hero.getHeroLevel()<11)
                                {
                                    Locations.addLoc1_c();
                                }
                                if (hero.getHeroLevel() > 10 && hero.getHeroLevel() < 21)
                                {
                                    Locations.addLoc2_c();
                                }
                                if (hero.getHeroLevel() > 20 && hero.getHeroLevel() < 31)
                                {
                                    Locations.addLoc3_c();
                                }
                                experience.addExp(exp_to_hero);
                                gold.addGold(gold_to_hero);
                                int increase = hero.getMAXHP();
                                hero.actualMax_HP();
                                increase -= hero.getMAXHP();
                                hero.setActual_HP(x - increase);
                                hero.actualAttackDamage();
                                hero.actualArmor();
                                Console.WriteLine("OTRZYMANO: " + gold_to_hero + " SZTUK ZŁOTA --- " + exp_to_hero + " PUNKTÓW DOŚWIADCZENIA");
                                Console.WriteLine();
                                Thread.Sleep(500);
                                string repeat = "";
                                Console.Write("CZY CHCESZ ZAWALCZYĆ Z KOLEJNYM PRZECIWNIKIEM? ");
                                repeat = Console.ReadLine();
                                if (repeat != "tak")
                                {
                                    act_3 = 0;
                                }
                            }
                            else
                            {
                                hero.setActual_HP(1);
                                act_3 = 0;

                            }
                        }
                        while(act_3==1)
                        {
                            if (hero.getHeroLevel() > 0 && hero.getHeroLevel() < 11)
                            {
                                Random random = new Random();
                                int result = random.Next(0, list_1.Count());
                                Console.Clear();
                                Console.WriteLine("ZAWALCZYSZ Z: ");
                                list_1[result].showInfo();
                                m_def = list_1[result].MonsterDefence;
                                m_hp = list_1[result].MonsterHP;
                                m_attack = list_1[result].MonsterAttack;
                                gold_to_hero = list_1[result].MonsterGOLDToHero;
                                exp_to_hero = list_1[result].MonsterEXPToHero;
                            }
                            if (hero.getHeroLevel() > 10 & hero.getHeroLevel() < 21)
                            {
                                Random random = new Random();
                                int result = random.Next(0, list_2.Count());
                                Console.Clear();
                                Console.WriteLine("ZAWALCZYSZ Z: ");
                                list_2[result].showInfo();
                                m_def = list_2[result].MonsterDefence;
                                m_hp = list_2[result].MonsterHP;
                                m_attack = list_2[result].MonsterAttack;
                                gold_to_hero = list_2[result].MonsterGOLDToHero;
                                exp_to_hero = list_2[result].MonsterEXPToHero;
                            }
                            if (hero.getHeroLevel() > 20 && hero.getHeroLevel() < 31)
                            {
                                Random random = new Random();
                                int result = random.Next(0, list_3.Count());
                                Console.Clear();
                                Console.WriteLine("ZAWALCZYSZ Z: ");
                                list_3[result].showInfo();
                                m_def = list_3[result].MonsterDefence;
                                m_hp = list_3[result].MonsterHP;
                                m_attack = list_3[result].MonsterAttack;
                                gold_to_hero = list_3[result].MonsterGOLDToHero;
                                exp_to_hero = list_3[result].MonsterEXPToHero;
                            }
                            int previous_hp = hero.getActualHP();
                            int x = quickgame(hero.getActualHP(), hero.getMAXHP(), hero.getActualAttackDamage(), hero.getActualArmor(), m_attack, m_def, m_hp, hero.Weapon.AtackMin, hero.Weapon.AtackMax);
                            if (x > 0)
                            {
                                if (hero.getHeroLevel() > 0 && hero.getHeroLevel() < 11)
                                {
                                    Locations.addLoc1_c();
                                }
                                if (hero.getHeroLevel() > 10 && hero.getHeroLevel() < 21)
                                {
                                    Locations.addLoc2_c();
                                }
                                if (hero.getHeroLevel() > 20 && hero.getHeroLevel() < 31)
                                {
                                    Locations.addLoc3_c();
                                }
                                experience.addExp(exp_to_hero);
                                gold.addGold(gold_to_hero);
                                int increase = hero.getMAXHP();
                                hero.actualMax_HP();
                                increase -= hero.getMAXHP();
                                hero.setActual_HP(x - increase);
                                hero.actualAttackDamage();
                                hero.actualArmor();
                                Console.WriteLine("POZOSTAŁE PUNKTY ŻYCIA BOHATERA: "+hero.getActualHP());
                                Console.WriteLine("OTRZYMANO: " + gold_to_hero + " SZTUK ZŁOTA --- " + exp_to_hero + " PUNKTÓW DOŚWIADCZENIA");
                                Console.WriteLine();
                                Thread.Sleep(500);
                                string repeat = "";
                                Console.Write("CZY CHCESZ ZAWALCZYĆ Z KOLEJNYM PRZECIWNIKIEM? ");
                                repeat = Console.ReadLine();
                                if (repeat != "tak")
                                {
                                    act_3 = 0;
                                }
                            }
                            else
                            {
                                hero.setActual_HP(1);
                                act_3 = 0;

                            }
                        }
                        
                    }
                }
                if (act==3)
                {
                    Console.WriteLine("WITAJ W KARCZMIE POD ROZBRYKANYM KUCYKIEM!");
                    Console.WriteLine("JEST TO MIEJSCE ROZRYWKI ORAZ ODPOCZYNKU PRZY KUFLU PIWA!");
                    Console.WriteLine("WYBIERZ DZIAŁANIE:");
                    Console.WriteLine("1. GRA W KOŚCI!");
                    Console.WriteLine("2. KUP PIWO");
                    int act_4 = 0;
                    while (act_4 == 0)
                    {
                        try
                        {
                            Console.Write("CO WYBIERASZ? (PODAJ INDEKS 1-2) ");
                            act_4 = Convert.ToInt32(Console.ReadLine());
                            if (act_4 < 1 || act_4 > 2)
                            {
                                Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                act_4 = 0;
                            }
                        }
                        catch (Exception)
                        { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

                    }
                    if(act_4==1)
                    {
                        int act_5 = 0;
                        while (act_5 == 0)
                        {
                            try
                            {
                                Console.Write("WYBIERZ O JAKĄ STAWKĘ CHCESZ ZAGRAĆ: ");
                                act_5 = Convert.ToInt32(Console.ReadLine());
                                if (act_5>gold.getGold())
                                {
                                    Console.WriteLine("NIE MASZ TYLE ZŁOTA!");
                                    act_5 = 0;
                                }
                                if(act_5<0)
                                {
                                    Console.WriteLine("PODAJ POPRWANĄ WARTOŚĆ");
                                    act_5 = 0;

                                }
                            }
                            catch (Exception)
                            { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

                        }
                        gold.addGold(-act_5);
                        int res_dice = dicegame(act_5);
                        if (res_dice > 0)
                        {
                            Console.WriteLine("PODWAJASZ STAWKĘ!");
                            gold.addGold(res_dice);
                            Console.WriteLine("OBECNY STAN KONTA: "+gold.getGold());
                        }
                        else
                        {
                            Console.WriteLine("STRACIŁEŚ " +act_5 +" SZTUK ZŁOTA");
                            Console.WriteLine("OBECNY STAN KONTA: " + gold.getGold());
                        }
                    }
                    if(act_4==2)
                    {
                        Console.WriteLine("STAN SAKIEWKI ZE ZŁOTEM: "+gold.getGold()+" SZTUK ZŁOTA");
                        Console.WriteLine("KTÓRY TRUNEK WYBIERASZ?");
                        Console.WriteLine("1. BROWAR GERMAŃSKI --- CENA: 50 SZTUK ZŁOTA --- ODNAWIA: 25% PUNKTÓW ZDROWIA");
                        Console.WriteLine("2. SPECJAŁ KARCZMARZA --- CENA: 100 SZTUK ZŁOTA --- ODNAWIA: 50% PUNKTÓW ZDROWIA");
                        Console.Write("3. KRASNOLUDZKA BECZKA PIWA --- CENA: 200 SZTUK ZŁOTA --- ODNAWIA: 100% PUNKTÓW ZDROWIA ");
                        
                        int act_5 = 0;
                        int check = 0;
                        int rise=0;
                        while (act_5 == 0)
                        {
                            try
                            {
                                act_5 = Convert.ToInt32(Console.ReadLine());
                                if (act_5==1 && gold.getGold()<50)
                                {
                                    Console.WriteLine("NIE POKAZUJ SIĘ TU WIĘCEJ Z PUSTYMI KIESZENIAMI! --- ZOSTAŁEŚ WYRZUCONY Z KARCZMY!");
                                    act_5 = 0;
                                    break;
                                }
                                if (act_5 == 2 && gold.getGold() < 100)
                                {
                                    Console.WriteLine("NIE POKAZUJ SIĘ TU WIĘCEJ Z PUSTYMI KIESZENIAMI! --- ZOSTAŁEŚ WYRZUCONY Z KARCZMY!");
                                    act_5 = 0;
                                    break;
                                }
                                if (act_5 == 3 && gold.getGold() < 200)
                                {
                                    Console.WriteLine("NIE POKAZUJ SIĘ TU WIĘCEJ Z PUSTYMI KIESZENIAMI! --- ZOSTAŁEŚ WYRZUCONY Z KARCZMY!");
                                    act_5 = 0;
                                    break;
                                }
                                if (act_5 < 1 || act_5 > 3)
                                {
                                    Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                    act_5 = 0;
                                }
                            }
                            catch (Exception)
                            { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }

                        }
                        if (act_5 == 1)
                        {
                            gold.addGold(-50);
                            rise = (int) 0.25 * hero.getMAXHP();
                            hero.setActual_HP(hero.getActualHP()+rise);
                            check = hero.getActualHP();
                            if(check>hero.getMAXHP())
                            {
                                hero.setActual_HP(hero.getMAXHP());
                            }

                        }
                        if (act_5 == 2)
                        {
                            gold.addGold(-100);
                            rise = (int)0.5 * hero.getMAXHP();
                            hero.setActual_HP(hero.getActualHP() + rise);
                            check = hero.getActualHP();
                            if (check > hero.getMAXHP())
                            {
                                hero.setActual_HP(hero.getMAXHP());
                            }
                        }
                        if (act_5 == 3)
                        {
                            gold.addGold(-200);
                            rise = (int)0.25 * hero.getMAXHP();
                            hero.setActual_HP(hero.getMAXHP());
                        }

                    }
                }
                if (act==4)
                {
                    string x = "";
                    Console.WriteLine("WITAMY W SKLEPIE! TUTAJ UZBROISZ SIĘ PO ZĘBY!");
                    Console.WriteLine("STAN SAKIEWKI ZE ZŁOTEM --- "+gold.getGold());
                    if(hero.getHeroLevel()<5)
                    {
                        Console.WriteLine("NA RAZIE NIE MASZ TU CZEGO SZUKAĆ - WRÓĆ JAK BĘDZIESZ SILNIEJSZY");
                        Console.WriteLine();
                    }
                    else if (hero.getClass() == "Wojownik")
                    {
                        Console.WriteLine("OOO WOJOWNIK - MIŁO CIĘ WIDZIEĆ!");
                        Console.WriteLine("WYBIERZ COŚ DLA SIEBIE!");
                        if (hero.getHeroLevel() >= 5 && hero.getHeroLevel() < 15)
                        {
                            Console.WriteLine("BROŃ: ZARDZEWIAŁY MIECZ - ATAK (3~10)");
                            Console.WriteLine("ZBROJA: LEKKI PANCERZ - PANCERZ: 5 - PUNKTY ŻYCIA: 9");
                            Console.WriteLine("HEŁM: LEKKI HEŁM - PANCERZ: 5");
                            Console.WriteLine("KOSZT ZESTAWU: 240 SZTUK ZŁOTA");
                            while (x=="")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x == "tak")
                            {
                                if (gold.getGold() >= 240)
                                {
                                    gold.addGold(-240);
                                    weapon = new Weapon("Zardzewiały miecz", 3, 10, 5);
                                    armour = new Armour("Lekki pancerz", 5, 9, 5);
                                    helmet = new Helmet("Lekki hełm", 5, 5);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                        }
                        if (hero.getHeroLevel() >= 15 && hero.getHeroLevel() < 25)
                        {
                            Console.WriteLine("BROŃ: DŁUGI MIECZ - ATAK (9~15)");
                            Console.WriteLine("ZBROJA: KOLCZUGA - PANCERZ: 15 - PUNKTY ŻYCIA: 25");
                            Console.WriteLine("HEŁM: PRZYŁBICA - PANCERZ: 18");
                            Console.WriteLine("KOSZT ZESTAWU: 500 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 500)
                                {
                                    gold.addGold(-500);
                                    weapon = new Weapon("Długi miecz", 9, 15, 15);
                                    armour = new Armour("Kolczuga", 6, 15, 15);
                                    helmet = new Helmet("Przyłbica", 18, 15);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                                
                        }
                        if (hero.getHeroLevel() >= 25)
                        {
                            Console.WriteLine("BROŃ: MISTRZOWSKI MIECZ DWURĘCZNY - ATAK (20~24)");
                            Console.WriteLine("ZBROJA: STAROŻYTNA ZBROJA WOJENNA - PANCERZ: 25 - PUNKTY ŻYCIA: 40");
                            Console.WriteLine("HEŁM: CIĘŻKI HEŁM WOJENNY - PANCERZ: 40");
                            Console.WriteLine("KOSZT ZESTAWU: 1000 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 1000)
                                {
                                    gold.addGold(-1000);
                                    weapon = new Weapon("Mistrzowski miecz dwuręczny", 20, 24, 25);
                                    armour = new Armour("Starożytna zbroja wojenna", 25, 40, 25);
                                    helmet = new Helmet("Ciężki hełm wojenny", 40, 25);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                    }
                    else if (hero.getClass() == "Czarodziej")
                    {
                        Console.WriteLine("OOO CZARODZIEJ - MIŁO CIĘ WIDZIEĆ!");
                        Console.WriteLine("WYBIERZ COŚ DLA SIEBIE!");
                        if (hero.getHeroLevel() >= 5 && hero.getHeroLevel() < 15)
                        {
                            Console.WriteLine("BROŃ: RÓŻDŻKA - ATAK (3~10)");
                            Console.WriteLine("ZBROJA: LEKKA SZATA - PANCERZ: 5 - PUNKTY ŻYCIA: 9");
                            Console.WriteLine("HEŁM: KAPELUSZ NOWICJUSZA - PANCERZ: 5");
                            Console.WriteLine("KOSZT ZESTAWU: 240 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 240)
                                {
                                    gold.addGold(-240);
                                    weapon = new Weapon("Różdżka", 3, 10, 5);
                                    armour = new Armour("Lekka szata", 5, 9, 5);
                                    helmet = new Helmet("Kapelusz nowicjusza", 5, 5);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                        if (hero.getHeroLevel() >= 15 && hero.getHeroLevel() < 25)
                        {
                            Console.WriteLine("BROŃ: KOSTUR MAGA - ATAK (9~15)");
                            Console.WriteLine("ZBROJA: UBRANIE MAGA - PANCERZ: 15 - PUNKTY ŻYCIA: 25");
                            Console.WriteLine("HEŁM: KAPTUR MAGA - PANCERZ: 18");
                            Console.WriteLine("KOSZT ZESTAWU: 500 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 500)
                                {
                                    gold.addGold(-500);
                                    weapon = new Weapon("Kostur maga", 9, 15, 15);
                                    armour = new Armour("Ubranie maga", 6, 15, 15);
                                    helmet = new Helmet("Kaptur maga", 18, 15);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                        if (hero.getHeroLevel() >= 25)
                        {
                            Console.WriteLine("BROŃ: STAROŻYTNA CZARODZIEJSKA LASKA - ATAK (20~24)");
                            Console.WriteLine("ZBROJA: SZATA MISTRZA SZTUK MAGICZNYCH - PANCERZ: 25 - PUNKTY ŻYCIA: 40");
                            Console.WriteLine("HEŁM: STAROŻYTNA CZAPKA MISTRZA SZTUK MAGICZNYCH - PANCERZ: 40");
                            Console.WriteLine("KOSZT ZESTAWU: 1000 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 1000)
                                {
                                    gold.addGold(-1000);
                                    weapon = new Weapon("Starożytna czarodziejska laska", 20, 24, 25);
                                    armour = new Armour("Szata mistrza sztuk magicznych", 25, 40, 25);
                                    helmet = new Helmet("Starożytna czapka mistrza sztuk magicznych", 40, 25);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }    
                            
                        }
                    }
                    else if(hero.getClass() == "Elf")
                    {
                        Console.WriteLine("OOO ELF - MIŁO CIĘ WIDZIEĆ!");
                        Console.WriteLine("WYBIERZ COŚ DLA SIEBIE!");
                        if (hero.getHeroLevel() >= 5 && hero.getHeroLevel() < 15)
                        {
                            Console.WriteLine("BROŃ: KRÓTKI ŁUK - ATAK (3~10)");
                            Console.WriteLine("ZBROJA: UBRANIE ZWIADOWCY - PANCERZ: 5 - PUNKTY ŻYCIA: 9");
                            Console.WriteLine("HEŁM: CZAPKA ZWIADOWCY - PANCERZ: 5");
                            Console.WriteLine("KOSZT ZESTAWU: 240 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 240)
                                {
                                    gold.addGold(-240);
                                    weapon = new Weapon("Krótki łuk", 3, 10, 5);
                                    armour = new Armour("Ubranie zwiadowcy", 5, 9, 5);
                                    helmet = new Helmet("Czapka zwiadowcy", 5, 5);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                        if (hero.getHeroLevel() >= 15 && hero.getHeroLevel() < 25)
                        {
                            Console.WriteLine("BROŃ: ŁUK WIERZBOWY - ATAK (9~15)");
                            Console.WriteLine("ZBROJA: LEKKI ELFI PANCERZ - PANCERZ: 15 - PUNKTY ŻYCIA: 25");
                            Console.WriteLine("HEŁM: LEKKI ELFICKI HEŁM - PANCERZ: 18");
                            Console.WriteLine("KOSZT ZESTAWU: 500 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 500)
                                {
                                    gold.addGold(-500);
                                    weapon = new Weapon("Łuk wierzbowy", 9, 15, 15);
                                    armour = new Armour("Lekki elfi pancerz", 6, 15, 15);
                                    helmet = new Helmet("Lekki elficki hełm", 18, 15);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                        if (hero.getHeroLevel() >= 25)
                        {
                            Console.WriteLine("BROŃ: łUK Z POROŻA - ATAK (20~24)");
                            Console.WriteLine("ZBROJA: WZMOCNIONA ELFICKA ZBROJA - PANCERZ: 25 - PUNKTY ŻYCIA: 40");
                            Console.WriteLine("HEŁM: WZMOCNIONY ELFICKI HEŁM - PANCERZ: 40");
                            Console.WriteLine("KOSZT ZESTAWU: 1000 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 1000)
                                {
                                    gold.addGold(-1000);
                                    weapon = new Weapon("Łuk z poroża", 20, 24, 25);
                                    armour = new Armour("Wzmocniona elficka zbroja", 25, 40, 25);
                                    helmet = new Helmet("Wzmocniony elficki hełm", 40, 25);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                    }
                    else if(hero.getClass() == "Krasnolud")
                    {
                        Console.WriteLine("OOO KRASNOLUD - MIŁO CIĘ WIDZIEĆ!");
                        Console.WriteLine("WYBIERZ COŚ DLA SIEBIE!");
                        if (hero.getHeroLevel()>=5 && hero.getHeroLevel()<15)
                        {
                            Console.WriteLine("BROŃ: TOPÓR - ATAK (3~10)");
                            Console.WriteLine("ZBROJA: DREWNIANA ZBROJA - PANCERZ: 5 - PUNKTY ŻYCIA: 9");
                            Console.WriteLine("HEŁM: ZARDZEWIAŁY HEŁM - PANCERZ: 5");
                            Console.WriteLine("KOSZT ZESTAWU: 240 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 240)
                                {
                                    gold.addGold(-240);
                                    weapon = new Weapon("Topór", 3, 10, 5);
                                    armour = new Armour("Drewniana zbroja", 5, 9, 5);
                                    helmet = new Helmet("Zardzewiały hełm", 5, 5);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                        if (hero.getHeroLevel() >= 15 && hero.getHeroLevel() < 25)
                        {
                            Console.WriteLine("BROŃ: STARY TOPÓR WOJENNY - ATAK (9~15)");
                            Console.WriteLine("ZBROJA: ZDOBIONY PANCERZ - PANCERZ: 15 - PUNKTY ŻYCIA: 25");
                            Console.WriteLine("HEŁM: SZYSZAK - PANCERZ: 18");
                            Console.WriteLine("KOSZT ZESTAWU: 500 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 500)
                                {
                                    gold.addGold(-500);
                                    weapon = new Weapon("Stary topór wojenny", 9, 15, 15);
                                    armour = new Armour("Zdobiony pancerz", 6, 15, 15);
                                    helmet = new Helmet("Szyszak", 18, 15);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                        if (hero.getHeroLevel() >= 25)
                        {
                            Console.WriteLine("BROŃ: MŁOT WOJENNY - ATAK (20~24)");
                            Console.WriteLine("ZBROJA: CIĘŻKA ZBROJA KRASNOLUDA - PANCERZ: 25 - PUNKTY ŻYCIA: 40");
                            Console.WriteLine("HEŁM: ZAMKNIĘTY KRASNOLUDZKI HEŁM - PANCERZ: 40");
                            Console.WriteLine("KOSZT ZESTAWU: 1000 SZTUK ZŁOTA");
                            while (x == "")
                            {
                                try
                                {
                                    Console.Write("CZY CHCESZ ZAKUPIĆ ZESTAW? ");
                                    x = Console.ReadLine();
                                    if (x != "tak" && x != "nie")
                                    {
                                        Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ");
                                        x = "";
                                    }
                                    else
                                        break;
                                }
                                catch (Exception)
                                { Console.WriteLine("BŁĄD, PODAJ POPRAWNĄ WARTOŚĆ"); }
                            }
                            if (x=="tak")
                            {
                                if (gold.getGold() >= 1000)
                                {
                                    gold.addGold(-1000);
                                    weapon = new Weapon("Młot wojenny", 20, 24, 25);
                                    armour = new Armour("Ciężka zbroja krasnoluda", 25, 40, 25);
                                    helmet = new Helmet("Zamknięty krasnoludzki hełm", 40, 25);
                                    Console.WriteLine("ZESTAW ZAKUPIONY");

                                }
                                else
                                {
                                    Console.WriteLine("NIE MASZ WYSTARCZAJĄCO ZŁOTA!");
                                }
                                x = "";
                            }
                            
                        }
                    }
                }
                if (act==5)
                {
                    hero.GetInfo();
                    Console.WriteLine("ILOŚĆ ZŁOTA: "+gold.getGold());
                    Console.WriteLine("POZIOM BOHATERA: "+level.getLvl());
                    Console.WriteLine("DOŚWIADCZENIE: "+experience.getExp()+ " / "+experience.getExp_max());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY PÓJŚĆ DALEJ...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (act==6)
                {
                    weapon.getInfo();
                    Console.WriteLine();
                    armour.getInfo();
                    Console.WriteLine();
                    helmet.getInfo();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    Console.WriteLine("NACIŚNIJ DOWOLNY PRZYCISK, ABY PÓJŚĆ DALEJ...");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (act==7)
                {
                    Console.WriteLine("OGÓŁEM POKONANYCH POTWORÓW: --- " + (Locations.getLoc1_c() + Locations.getLoc2_c()+Locations.getLoc3_c()));
                    Console.WriteLine();
                    Console.WriteLine("POKONANYCH POTWORÓW Z LOKACJI: RÓWNINY --- "+ Locations.getLoc1_c());
                    Console.WriteLine("POKONANYCH POTWORÓW Z LOKACJI: CZARNY LAS --- " + Locations.getLoc2_c());
                    Console.WriteLine("POKONANYCH POTWORÓW Z LOKACJI: PRZEKLĘTA DOLINA --- " + Locations.getLoc3_c());
                    Thread.Sleep(2000);

                }
                if (act==8)
                {
                    finish= true;
                    Console.WriteLine("UCIEKAJ TCHÓRZU...");
                }
            }

            
        }
    }
}

            






