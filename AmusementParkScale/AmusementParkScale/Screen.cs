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

        public void Work(string? text) 
        {
            this.text = text;
            if (text == "allowed")
            {
                this.color = ConsoleColor.Green;
            }
            else 
            {
                this.color = ConsoleColor.Red;
            }

        }
    }
}
