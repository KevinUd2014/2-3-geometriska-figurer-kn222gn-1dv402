using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uppgift_2._3_i_2010_visual_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                 // meddans den här är true så kommer olika alternativ visas och skickas till de olika metoderna.
                
                    ViewMenu(); // kopplar denna till view menu där jag ger dom olika alternativen värden som den senare skickar vidare.

                    string wrongEntry = (Console.ReadLine()); // skapar ett värde
                    int Enter;
                    try
                    {
                        Enter = int.Parse(wrongEntry);

                        switch (Enter)
                        {
                            case 0:
                                return; //returnerar och avslutar

                            case 1: //breakar programmet och kör för en Ellipse
                                ViewShapeDetail(CreateShape(ShapeType.Ellipse)); //viewShapeDetail vill att man ska skicka ner objektet och då startar jag createshape som väljer Ellipse eller Rectangle!!
                                break;

                            case 2: //breakar programmet och kör för en Rektangel
                                ViewShapeDetail(CreateShape(ShapeType.Rectangle)); //vet inte riktigt hur detta funkar men den skickar info mellan de olika metoderna, View, create.
                                break;
                            default:
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Wrong!! Number is not in the Range of 0 and 2!");// fångar upp detta om nu talet är utanför ramen!
                                Console.ResetColor();
                                break;
                        }
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Number is not in a valid format, please try again!"); // fångar upp detta om nu talet är utanför ramen!
                        Console.ResetColor();
                    }
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nPress any Key to continue or ESC to Exit!");
                    Console.ResetColor();
            }

            while (Console.ReadKey (true).Key != ConsoleKey.Escape);

        }

        private static Shape CreateShape(ShapeType shapeType) //här har vi en metod som kommer skapa antingen en ellipse eller rektangel
        {
            Console.Clear(); // rensar allt så att bara det valda fältet syns!
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (shapeType)// väljer om vi ska skriva ut detta beroende på vilken av dessa som personen kommer välja väljer personen 1 som är en ELLIPSE så väljer denna metod att starta ShapeType.Ellipse och skriver ut den Case:en
            {
                case ShapeType.Ellipse:
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("==                 Ellipse                 ==");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case ShapeType.Rectangle: // här hämtar vi Sharetype.Rectangle!
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("==               Rectangle                 ==");
                    Console.WriteLine("---------------------------------------------");
                    break;
            }
            Console.ResetColor();

            double Length = ReadDoubleGreaterThanZero("\n Enter the Length: "); // här skickar vi ut texten till klassen read....

            double Width = ReadDoubleGreaterThanZero("\n Enter the Width: ");

            if (shapeType == ShapeType.Ellipse) // här säger vi att om nu shareType är en Ellipse så ska vi köra detta!
            {
                Ellipse ellipse = new Ellipse(Length, Width); // här refererar vi till Ellipse classen och får informationen där ifrån!
                return ellipse;
            }
            
                    // och om nu chareType inte är Ellipse så kör den Charetype som en Rectangle och då kör vi detta!
            
                Rectangle rectangle = new Rectangle(Length, Width); // och vi ska räkna ut vad rektangelns längd och bredd är!!
                return rectangle;
            
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double Entry;
            while (true)
            {
                Console.Write(prompt);//här skriver vi ut stringen från create shape metoden!
                string WrongEntry = (Console.ReadLine());//gör om det som användaren skriver in för att felmeddelanden ska fungera
                try
                {
                    

                    Entry = double.Parse(WrongEntry); // här kollar vi om det som perosnen i fråga skrivit in kan funka som en double och om det gör det så kör programmet vidare och gör om stringen till ett värde!
                    
                    if (Entry > 0) // om Entry är större än 0
                    {
                        return Entry;// körs detta!
                    }
                    else // om mindre så körs detta!
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Wrong!! please re-enter a new value!! \n");
                        Console.ResetColor();
                    }
                }
                catch // och är det fel format så fångar detta upp det!
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n WRONG FORMAT!!  ({0}) is not a recognizable number!! \n", WrongEntry);
                    Console.ResetColor();
                }

            }
        }
        private static void ViewMenu() // anropas i main och skriver ut det som perosnen kommer mötas av först!
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("==            Geometriska Figurer               ==");
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("press 0 to Cancel.");
            Console.WriteLine("Press 1 for new Ellipse.");
            Console.WriteLine("Press 2 for new Rectangle.");
            Console.WriteLine("__________________________________________________\n");
            Console.Write("Choose a new project [0-2]! : ");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("==                Detaljer                 ==");
            Console.WriteLine("---------------------------------------------\n");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            

        }

        
    }
}
