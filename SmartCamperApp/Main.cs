using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCamperApp
{
    class Main
    {
        public static bool hasQuit = false;
        public Main()
        {

            //call startup
            Startup();

            //run app while has not quit


            //Star Wars reference for the win

        }

        public static void Startup()
        {

            PrimaryCall();
        }


        public static void PrimaryCall()
        {
            while (!hasQuit)
            {
                if (!hasQuit)
                {
                    MainLoop();
                }
            }
        }

        public static void MainLoop()
        {
            Console.WriteLine("Smart Camper Started");
            Console.ReadKey();
        }
    }
}
