using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Locations
    {
        public string Name { get; private set; }
        public int MinLvl { get; private set; }
        public int MaxLvl { get; private set; }

        private int Loc1_c = 0;
        private int Loc2_c = 0;
        private int Loc3_c = 0;
        private int MainCounter = 0;
        public int getLoc1_c()
        {
            return Loc1_c;
        }
        public void addLoc1_c()
        {
            Loc1_c++;
            refreshMainCounter();
        }
        public int getLoc2_c()
        {
            return Loc2_c;
        }
        public void addLoc2_c()
        {
            Loc2_c++;
            refreshMainCounter();

        }

        public int getLoc3_c()
        {
            return Loc3_c;
        }
        public void addLoc3_c()
        {
            Loc3_c++;
            refreshMainCounter();
        }
        public void refreshMainCounter()
        {
            MainCounter = Loc1_c + Loc2_c + Loc3_c;
        }
        public int getMainCounter()
        {
            return MainCounter;
        }
        public static int rollEXP(int min, int max)
        {
            Random rand = new Random(); 
            return rand.Next(min, max);
        }
        public static int rollGOLD(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        private static List<string> My_List = new List<string>();
        private static Dictionary<int, int> Loc_lvls=new Dictionary<int, int>();
        public static void CreateList(string new_name, int m_lvl, int mx_lvl)
        {
            My_List.Add(new_name);
            Loc_lvls.Add(m_lvl, mx_lvl);

        }
        public Locations() { }
        public Locations(string nam_, int m_lvl, int mx_lvl)
        {
            Name = nam_;
            MinLvl = m_lvl;
            MaxLvl = mx_lvl;
            CreateList(Name, MinLvl, MaxLvl);

        }
        public static List <string> ReturnLocations()
        {
            return My_List;
        }
        public static Dictionary<int, int> ReturnLoc_lvls()
        {
            return Loc_lvls;
        }
        public static List<Monsters> CreateLoc_1()
        {
            List<Monsters> MonsersLoc_1 = new List<Monsters>()
        {
            new Monsters("Goblin", 2, 7, 5+rollEXP(1,8),5+ rollGOLD(3,8)),
            new Monsters("Bandzior", 2, 10, 5+rollEXP(1,8),5+ rollGOLD(3,8)),
            new Monsters("Warg", 4, 7, 5+rollEXP(7,8), 5+rollGOLD(3,12)),
            new Monsters("Pająk", 6, 8,5+ rollEXP(5,12), 5+rollGOLD(3,17)),
            new Monsters("Wielki Kruk", 3, 5, 5+rollEXP(1,11), 5+rollGOLD(3,8)),
        };
            return MonsersLoc_1;
        }
        public static List<Monsters> CreateLoc_2()
        {
            List<Monsters> MonsersLoc_2 = new List<Monsters>()
        {
            new Monsters("Ork", 8, 24, 10+rollEXP(10, 21), 10+rollGOLD(12, 33)),
            new Monsters("Ent", 4, 45, 10+rollEXP(19, 21), 10+rollGOLD(20, 33)),
            new Monsters("Hobgoblin", 5, 30, 10+rollEXP(20, 26), 10+rollGOLD(20, 33)),
            new Monsters("Wilkołak", 6, 29, 10+rollEXP(10, 31), 10+rollGOLD(19, 33)),
            new Monsters("Skrzydlata Bestia", 10, 25,10+ rollEXP(10, 42),10+ rollGOLD(12, 43)),
        };
            return MonsersLoc_2;
        }
        public static List<Monsters> CreateLoc_3()
        {
            List<Monsters> MonsersLoc_3 = new List<Monsters>()
        {
            new Monsters("Troll", 20, 70, 20+rollEXP(30,48), 20+rollGOLD(31, 58), 20),
            new Monsters("Ogr", 19, 107, 20+rollEXP(30,41), 20+rollGOLD(31, 68), 15),
            new Monsters("Smok", 27, 145, 20+rollEXP(40,69), 20+rollGOLD(41, 50), 25),
            new Monsters("Nazgul", 22, 111, 20+rollEXP(30,87),20+ rollGOLD(50, 80), 10),
        };
            return MonsersLoc_3;
        }


    }
}
