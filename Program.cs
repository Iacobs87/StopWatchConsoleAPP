using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace StopWatchConsoleAPP
{



    class Program
    {
        static void Main(string[] args)
        {
            string command;
            var myStopwatch = new StopWatch();

            try
            {
                Console.WriteLine("Hello my brother from another mother! Please let me now your action by typping the action name\n" +
                "Start\n" +
                "Stop\n" +
                "Exit\n");

                command = Console.ReadLine();


                while (!string.IsNullOrEmpty(command) && (command != "exit"))
                {

                    switch (command.ToLower())
                    {
                        case "start":
                            myStopwatch.Start();
                            Console.WriteLine("Please let me know when to stop by typing: Stop");
                            command = Console.ReadLine();
                            break;
                        case "stop":
                            myStopwatch.Stop();
                            Console.WriteLine("The total duration measured is: {0}\n", myStopwatch.Duration.ToString(@"hh\:mm\:ss"));
                            Console.WriteLine("To start again the StopWatch type: Start\n" +
                                "If you want to exit this awsome aplication please type: exit\n"
                                );
                            command = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Please type a valid command");
                            command = Console.ReadLine();
                            break;
                    }
                }

            }

            catch (Exception)
            {

                Console.WriteLine("Invalid Operation");
            }

            

                        
                


            


        }
    }
}
