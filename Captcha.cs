using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Written_Work_1
{
     public class Captcha
    {
        public static void MainCaptcha()
        {
        start:
            Console.Clear();
            Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
            Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
            Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
            Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
            Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
            Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");

            string userinput;
            int usercaptcha;
            Random randomcaptcha = new Random();

            int captcha1 = randomcaptcha.Next(1, 49);
            int captcha2 = randomcaptcha.Next(1, 49);

            int Captcha_Answer = (captcha1 + captcha2);
            Console.Write("Place your name here: ");


            Console.WriteLine("Please answer this captcha to proceed " + "\"" + captcha1 + " + " + captcha2 + "\"");
            Console.Write("Place your answer here: ");
            userinput = Console.ReadLine();

            while (!int.TryParse(userinput, out usercaptcha))
            {
                Console.Clear();

                Console.WriteLine(userinput + " is not a valid number");
                Console.WriteLine("Press enter to retry captcha...");
                Console.ReadLine();
                
                Console.Clear();

                goto start;
            }

            if (usercaptcha != Captcha_Answer) 
            {
                Console.Clear();

                Console.WriteLine(userinput + " is not the sum of the given number");
                Console.WriteLine("Press enter to retry captcha...");
                Console.ReadLine();

                Console.Clear();

                goto start;
            }
            else
            {
                Console.Clear();

                Console.WriteLine("You may now proceed");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

                Console.Clear();
            }

        }
    }
}
