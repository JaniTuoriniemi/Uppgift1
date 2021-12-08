using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace uppgift1
{

    class Program
    {
        static void Main(string[] args)
        {    // Räknaren drivs av while loopen som är på tills variabeln ''pågår'' sätts till false när användaren avslutar programmet. 
            bool pågår = true;
            while (pågår)

            {

                Console.WriteLine("Välkommen till räknaren. \r\n  Välj ditt räknesätt");

                Console.WriteLine("  För att avsluta tryck 0. \r\n För addition tryck 1. \r\n För subtraktion tryck 2. \r\n För division tryck 3. \r\n För multiplikation tryck 4. ");

                bool kontrollen = double.TryParse(Console.ReadLine(), out double svar);
                if (kontrollen)
                    switch (svar)
                    {

                        case 0:
                            pågår = false;
                            Console.WriteLine("Avslutar");
                            break;
                        case 1: // Dessa subfunktioner utför beräkningarna.
                            Addition();
                            break;
                            case 2:
                            Subtraktion();
                            break;
                            case 3:
                              Division();
                            break;
                            case 4:
                             Multiplikation();
                            break;
                            // felhantering
                            default:
                             Console.WriteLine("Ange giltig nummer");
                            break;
                    }
                else // felhantering
                {
                    Console.WriteLine("Fel typ av input. Försök igen.");
                }
            }
        }
        public static double Inläs(int input_nr) // Används av beräkningsfunktionerna för att läsa input.
        {

            if (input_nr == 1)
            {
                Console.WriteLine("Ange första siffran");

            }
            else if (input_nr == 2)
            {
                Console.WriteLine("Ange andra siffran");
            }


            bool kontroll = double.TryParse(Console.ReadLine(), out double a);
            if (kontroll == false)// Funktionen körs igen vid ogiltig input.
            {
                Console.WriteLine("Fel typ av input");
                a = Inläs(input_nr);
            }
            return a;
        }

        private static void Addition()// Adderar två tal
        {
            Console.WriteLine("Beräknar summan av två tal");

            int input_nr = 1;
            double a = Inläs(input_nr);
            input_nr = 2;
            double b = Inläs(input_nr);

            double c = a + b;
            Console.WriteLine("summan är {0}", c);
        }
        private static void Subtraktion()// Subtraherar den första talet från den andra.
        {
            Console.WriteLine("Beräknar differensen mellan två tal");

            int input_nr = 1;
            double a = Inläs(input_nr);
            input_nr = 2;
            double b = Inläs(input_nr);

            double c = a - b;
            Console.WriteLine("Differensen är {0}", c);
        }
        private static void Multiplikation()// Multiplicerar två tal med varandra.
        {
            Console.WriteLine("Beräknar produkten av två tal");

            int input_nr = 1;
            double a = Inläs(input_nr);
            input_nr = 2;
            double b = Inläs(input_nr);

            double c = a * b;
            Console.WriteLine("Produkten är {0}", c);
        }
        private static void Division()// Dividerar den första talet med den andra.
        {
            Console.WriteLine("Beräknar kvoten mellan två tal");

            int input_nr = 1;
            double a = Inläs(input_nr);
            bool isinvalid = true;// Sätts till ''false'' om användaren inte välje 0 som täljare.
            input_nr = 2;
            double b = Inläs(input_nr);
            while (isinvalid)
            {// Om användaren valt 0 görs valet av täljare om tills det blir ett godkänt tal.
                if (b == 0)
                    {
                    Console.WriteLine("Man får inte dela med 0");
                         b=Inläs(input_nr);
                }
                else
                    isinvalid = false;
            }
                double c = a / b;
            Console.WriteLine("Kvoten är {0}", c);
        }

    }
}





    
    


            
    




















           
  
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
             

       



           

        

        
    
            


