using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTRGame
{
    internal class Hero
    {
        public Level Level { get; set; }
        public Armour Armour { get; set; }
        public Weapon Weapon { get; set; }
        public Helmet Helmet { get; set; }

        public Hero(Level lvl, Helmet hel, Weapon wea, Armour arm)
        {
            Level = lvl;
            Weapon = wea;
            Armour = arm;
            Helmet = hel;
        }
        public int getHeroLevel()
        {
            return Level.getLvl();
        }
        private string Class;
        public void setClass(string c)
        {
            this.Class = c;
        }
        public string getClass()
        { 
            return Class;
        }
        private int Actual_HP=16;
        private int Max_HP=0;
        public void actualMax_HP()
        {
            Max_HP = 1+Level.getLvl()*10+Armour.HP;
        }
        public void setActual_HP(int x)
        {
            Actual_HP =  x;
        }
        private int Armor;
        public void actualArmor()
        {
            Armor=1+Level.getLvl()+Helmet.Armor+2*Armour.DmgReduction;
        }
        private int AttackDamage;
        public void actualAttackDamage()
        {
            AttackDamage = 1 + Level.getLvl() * 2;
        }
        public int getActualAttackDamage()
        {
            return AttackDamage;
        }
        public int getActualHP()
        {
            return Actual_HP;
        }
        public int getActualArmor()
        {
            return Armor;
        }
        public int getMAXHP()
        {
            return Max_HP;
        }
        public int getMinAttack()
        {
            return Weapon.AtackMin;
        }
        public int getMaxAttack()
        {
            return Weapon.AtackMax;
        }
        
        public void GetInfo()
        {
            Console.WriteLine("STATYSTYKI TWOJEGO BOHATERA:");
            Thread.Sleep(1500);
            Console.WriteLine("PUNKTY ŻYCIA: " + Actual_HP + " / " + Max_HP);
            Thread.Sleep(1500);
            int min = AttackDamage + Weapon.AtackMin;
            int max = AttackDamage + Weapon.AtackMax;
            Console.WriteLine("OBRAŻENIA " + min + " ~ " + max);
            Thread.Sleep(1500);
            Console.WriteLine("PANCERZ: " + Armor);
            Thread.Sleep(1500);
        }


    }
}
