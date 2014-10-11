using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uppgift_2._3_i_2010_visual_studio
{
    class Rectangle : Shape
    {
        public double Area
        {
            get 
            {
                return Length + Width;
            }
        }
        public double Perimeter
        {
            get 
            {
                return Length * 2 + Width * 2;
            }
        }
        public Rectangle(double length, double width)
            : base (length, width)
        {

        }
    
         
    }
}
