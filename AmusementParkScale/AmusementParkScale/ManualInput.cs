using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkScale
{
    static public class ManualInput
    {
        public static void ManualInputMethod() 
        {
            int fails = 0;
            int maxFails = 3;
            double weight = 0;
            bool loop = true;
        
            Console.WriteLine("How many times can there be an error? ");
            try
            {
                maxFails = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Wrong input, default value = 3.");
            }
            while (loop && fails < maxFails)
            { 
                Console.WriteLine("How much does the person weigh ?");
                Console.WriteLine("-----negative value to exit-----");
                string input = Console.ReadLine();
                try
                {
                    weight = Convert.ToDouble(input);
                    if (weight >= 0)
                    {
                        
                        Person person = new Person(weight);
                        Console.WriteLine("person = " + person.weight + "kg.");
                        Enter enter = new Enter(fails, maxFails, new DecisionBasedOnWeight(person));
                        Screen screen = new Screen();
                        if (enter.Work())
                        {
                            screen.Work("allowed");
                        }
                        else
                        {
                            screen.Work("NOT ALLOWED");
                        }
                    }
                    else
                    {
                        loop = false;
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("-----");
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    fails++;
                }
            }
        }
    }
}
