using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkScale
{
    public class Screen
    {
        public string? text;
        public ConsoleColor? color;
 
        public Screen() { }
        public Screen(string text)
        {
            this.text = text;
        }
        public Screen(string text,ConsoleColor color)
        {
            this.text = text;
            this.color = color;
        }

        public void Work(Screen screen) 
        {
            if (screen.text == "allowed")
            {
                screen.color = ConsoleColor.Green;
            }
            else 
            {
                screen.color = ConsoleColor.Red;
            }

        }
    }
}
