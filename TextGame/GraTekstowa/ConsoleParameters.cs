using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace LOTRGame
{
    class ConsoleParameters
    {
        private string Color_f;
        public void set_Color_f(string c_f)
        {
            Color_f = c_f;
        }
        public string get_Color_f()
        {
            return Color_f;
        }
        private string Color_b;
        public void set_Color_b(string c_b)
        {
            Color_b = c_b;
        }
        public string get_Color_b()
        {
            return Color_b;
        }
        private int Height=Console.WindowHeight;
        private int Width=Console.WindowWidth;
        public void setWindowSize()
        {
            Console.SetWindowSize((int)(Width * 1.7), (int)(Height * 1.7));
        }
        public ConsoleParameters(string color_f, string color_b)
        {
            Color_b = color_b;
            Color_f = color_f;
        }
        public void setDetails()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;
            for (int i=0;i<colors.Count();i++)
            {
                if (Color_f == Convert.ToString(colors[i]))
                {
                    Console.ForegroundColor = colors[i];
                }
            }
            for (int i = 0; i < colors.Count(); i++)
            {
                if (Color_b == Convert.ToString(colors[i]))
                {
                    Console.BackgroundColor = colors[i];
                }
            }

        }
    }
}
