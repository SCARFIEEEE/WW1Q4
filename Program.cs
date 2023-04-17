using System;
using System.Security.Cryptography.X509Certificates;

namespace Written_Work_1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            bool userisin = true;
            string inputuserisin;
            char usercaptchayes;

            while (userisin)
            {

                string username;

                Console.WriteLine("Hello user! I am AgeFinderrz your age finder application");
                Console.WriteLine("press enter to continue...");
                Console.ReadLine();

                Console.Clear();

                Console.WriteLine("What is your name user?");
                Console.Write("Place your name here: ");
                username = Console.ReadLine();

                captcha_start:

                bool booluserage = true;

                Console.Clear();

                Console.WriteLine("do you want to answer a captcha to prove you are not a robot?");
                Console.WriteLine("Type \"Y\" if yes and \"N\" if you wish to exit.");
                Console.WriteLine("Place your answer here: ");
                inputuserisin = Console.ReadLine();

                //check if character
                while (!char.TryParse(inputuserisin, out usercaptchayes))
                {
                    Console.WriteLine("Please input a valid character");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine("do you want to answer a captcha to prove you are not a robot?");
                    Console.WriteLine("Type \"Y\" if yes and \"N\" if you wish to exit.");
                    Console.WriteLine("Place your answer here: ");

                    inputuserisin = Console.ReadLine();
                }
                if (usercaptchayes == 'Y' || usercaptchayes == 'y')
                {
                    Captcha.MainCaptcha();

                    string inputuserage;
                    int intuserage;

                    Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
                    Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
                    Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
                    Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
                    Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
                    Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");

                    Console.WriteLine("How do you classify yourself?");
                    Console.WriteLine("[1]  Children    (1 year   - 12 years)");
                    Console.WriteLine("[2]  Teen        (13 years - 17 years)");
                    Console.WriteLine("[3]  Adult       (18 years - 64 years)");
                    Console.WriteLine("[4]  Older adult (65 years - older)");

                    Console.WriteLine("\nPlace your answer here: ");
                    inputuserage = Console.ReadLine();

                    //check if integer
                    while (!int.TryParse(inputuserage, out intuserage))
                    {
                        Console.Clear();

                        Console.WriteLine("Please input a valid choice");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();

                        Console.Clear();
                        
                        Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
                        Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
                        Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
                        Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
                        Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
                        Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");

                        Console.WriteLine("How do you classify yourself?");
                        Console.WriteLine("[1]  Children    (1 year   - 12 years)");
                        Console.WriteLine("[2]  Teen        (13 years - 17 years)");
                        Console.WriteLine("[3]  Adult       (18 years - 64 years)");
                        Console.WriteLine("[4]  Older adult (65 years - older)");

                        Console.WriteLine("\nPlace your answer here: ");
                        inputuserage = Console.ReadLine();
                    }

                    //check if 1 - 4
                    while (intuserage < 1 || intuserage > 4)
                    {
                        Console.Clear();

                        Console.WriteLine("Please input a valid choice");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
                        Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
                        Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
                        Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
                        Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
                        Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");

                        Console.WriteLine("How do you classify yourself?");
                        Console.WriteLine("[1]  Children    (1 year   - 12 years)");
                        Console.WriteLine("[2]  Teen        (13 years - 17 years)");
                        Console.WriteLine("[3]  Adult       (18 years - 64 years)");
                        Console.WriteLine("[4]  Older adult (65 years - older)");

                        Console.Write("\nPlace your answer here: ");
                        inputuserage = Console.ReadLine();
                        int.TryParse(inputuserage, out intuserage);
                    }

                    switch(intuserage)
                    {
                        case 1:
                            {
                                Console.Clear();

                                Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
                                Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
                                Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
                                Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
                                Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
                                Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();

                                Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
                                Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
                                Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
                                Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
                                Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
                                Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();

                                Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
                                Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
                                Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
                                Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
                                Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
                                Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");
                            }
                            break;
                        case 4:
                            {
                                Console.Clear();

                                Console.WriteLine("           _____ ______ ______ _____ _   _ _____  ______ _____  _____   ______");
                                Console.WriteLine("     /\\   / ____|  ____|  ____|_   _| \\ | |  __ \\|  ____|  __ \\|  __ \\ |___  /");
                                Console.WriteLine("    /  \\ | |  __| |__  | |__    | | |  \\| | |  | | |__  | |__) | |__) |   / / ");
                                Console.WriteLine("   / /\\ \\| | |_ |  __| |  __|   | | | . ` | |  | |  __| |  _  /|  _  /   / /  ");
                                Console.WriteLine("  / ____ \\ |__| | |____| |     _| |_| |\\  | |__| | |____| | \\ \\| | \\ \\  / /__ ");
                                Console.WriteLine(" /_/    \\_\\_____|______|_|    |_____|_| \\_|_____/|______|_|  \\_\\_|  \\_\\/_____|\n");
                            }
                            break;
                    }
                }
                else if (usercaptchayes == 'N' || usercaptchayes == 'n')
                {
                    userisin = false;
                }
                else
                {
                    Console.WriteLine("Please input a valid character");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                    Console.Clear();

                    goto captcha_start;
                }
            }
        }
    }
}