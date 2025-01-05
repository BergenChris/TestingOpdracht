using NLog;

namespace AmusementParkScale
{
    internal class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Type on input?");
                Console.WriteLine("1.Manual");
                Console.WriteLine("2.API");
                Console.WriteLine("X. Exit");
                input = Console.ReadLine();
                logger.Info("User selected" + input);
                switch (input)
                {
                    case "1":
                        
                        ManualInput.ManualInputMethod();
                        break;
                    case "2":
                        var person = new Person();
                        person.Weigh();
                        Console.WriteLine("person from API = " + person.weight + "kg.");
                        Enter enter = new Enter(0,3, new DecisionBasedOnWeight(person));
                        Screen screen = new Screen();
                        if (enter.Work())
                        {
                            screen.Work("allowed");
                        }
                        else
                        {
                            screen.Work("NOT ALLOWED");
                        }

                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            }
            while (input != "X");
            
            

        }
    }
}
