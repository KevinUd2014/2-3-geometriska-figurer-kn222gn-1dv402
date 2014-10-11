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
            while (true)  // meddans den här är true så kommer olika alternativ visas och skickas till de olika metoderna.
            {
                ViewMenu(); // kopplar denna till view menu där jag ger dom olika alternativen värden som den senare skickar vidare.

                int Enter = int.Parse(Console.ReadLine()); // skapar ett värde

                if (Enter == 0)
                {
                    return; //returnerar och avslutar
                }

                while (Enter == 1) //breakar programmet och kör för en Ellipse
                {
                    ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                    break;
                }
                while (Enter == 2) //breakar programmet och kör för en Rektangel
                {
                    ViewShapeDetail(CreateShape(ShapeType.Rectangle)); //vet inte riktigt hur detta funkar men den skickar info mellan de olika metoderna, View, create.
                    break;
                }
            }


        }


        private static Shape CreateShape(ShapeType shapeType) //här har vi en metod som kommer skapa antingen en ellipse eller rektangel
        {
            double Length = ReadDoubleGreaterThanZero("Enter the Length"); // här skickar vi ut texten till klassen read....


            double Width = ReadDoubleGreaterThanZero("Enter the Width");

            if (shapeType == ShapeType.Ellipse) // här säger vi att om nu shareType är en Ellipse så ska vi köra detta!
            {
                Ellipse ellipse = new Ellipse(Length, Width); // här refererar vi till Ellipse classen och får informationen där ifrån!
                return ellipse;
            }

            if (shapeType == ShapeType.Rectangle) // och om nu chareType är en Rectangle så kör vi detta!
            {
                Rectangle rectangle = new Rectangle(Length, Width); // och vi ska räkna ut vad rektangelns längd och bredd är!!
                return rectangle;
            }
            else
            {
                return null;
            }
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
             
            while (true)
            {
                Console.WriteLine(prompt);//här skriver vi ut stringen från create shape metoden!
                double Entry = double.Parse (Console.ReadLine());

                if (Entry > 0)
                {
                    return Entry;
                }
                else
                {
                    Console.WriteLine("wrong!");
                }

            }
        }
        private static void ViewMenu()
        {
            Console.WriteLine("press 0 to Cancel.");
            Console.WriteLine("Press 1 for new Ellipse.");
            Console.WriteLine("Press 2 for new Rectangle.");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("Choose a new project [0-2]!");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine(shape.ToString());
        }

        
    }
}
