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
          while(true)
          {
            ViewMenu();
            
            int Enter = int.Parse (Console.ReadLine());

            if (Enter == 0)
            {
                return;
            }

            while (Enter == 1)
            {
                ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                break;
            }
            while (Enter == 2)
            {
                ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                break;
            }
         }
            

        }


        private static Shape CreateShape(ShapeType shapeType) //här tar 
       {
           double Length = ReadDoubleGreaterThanZero("Enter the Length"); // här skickar vi ut texten till klassen read....
          

          Console.WriteLine("Enter the Width"); 
           int Width = int.Parse(Console.ReadLine());

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
       }

       private static double ReadDoubleGreaterThanZero(string prompt)
       {
           Console.WriteLine(prompt); //här skriver vi ut stringen från create shape metoden!
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
