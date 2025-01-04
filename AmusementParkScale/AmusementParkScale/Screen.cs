using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkScale
{
    public class Screen
    {
        public string text = "";
        public ConsoleColor color = ConsoleColor.Black;

     
 
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

        public void Work(string text) 
        {
            this.text = text;
            if (text == "allowed")
            {
                this.color = ConsoleColor.Green;
                Console.ForegroundColor = this.color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
            else 
            {
                this.color = ConsoleColor.Red;
                Console.ForegroundColor = this.color;
                Console.WriteLine(text);
                Console.ResetColor();
            }

        }
    }
}
