using System;
using Sys = Cosmos.System;


namespace OSIRIS
{
    public class Kernel : Sys.Kernel
    {


        private void log(string value, System.ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected override void BeforeRun()
        {
            log("System loaded successfully!",ConsoleColor.DarkGreen);

            log("Welcome OSIRIS OS version 0.0.0.1");
            log("by Matheus Grijo | Github github.com/matheusgrijo", ConsoleColor.Green);
            

        }

        protected override void Run()
        {
            log("Secure operating system for bitcoin wallet generation!");
            log("Choose one of the options");
            log("");
            log("-----------------------------------------------------");
            log(":: Menu :: ");
            log(" 1 - Generate Private Key Bitcoin ");
            log(" 2 - Generate Private Key and Public Key Bitcoin ");
            log(" 3 - About ");
            log(" 4 - Play Snake Game :) ");
            log(" 5 - Reboot");
            log(" 6 - Shutdown");

            log(" * Press number option");
            var input = Console.ReadLine();
            log(input);


            
            if (input.Trim().Equals("1"))
            {
                

                log(" Generate Private Key ...");
                Key.generate();

                log("=============================================================");

                log("PRIVATE KEY FORMAT BINARY:");
                log(Key.getBinary(), ConsoleColor.Green);

                log("PRIVATE KEY FORMAT HEXDECIMAL:");
                log(Key.getHex(), ConsoleColor.Green);


                log("=============================================================");
                log(" OK! ");
                Console.ReadLine();
                
            }

            if (input.Trim().Equals("2"))
            {
                log("Under Construction...", ConsoleColor.Cyan);
                Console.ReadLine();
            }
            if (input.Trim().Equals("3"))
            {
                log("Under Construction...", ConsoleColor.Cyan);
                Console.ReadLine();
            }
            if (input.Trim().Equals("4"))
            {
                CaOS_.Snake snk = new CaOS_.Snake();
                snk.Run();
            }
            if (input.Trim().Equals("5"))
            {
                log("Reboot...", ConsoleColor.Cyan);
                Sys.Power.Reboot();
            }
            if (input.Trim().Equals("6"))
            {
                log("Now you can power off your system!",ConsoleColor.Cyan);
                Stop();
            }



            Console.Clear();


        }

       



        

    }
}
