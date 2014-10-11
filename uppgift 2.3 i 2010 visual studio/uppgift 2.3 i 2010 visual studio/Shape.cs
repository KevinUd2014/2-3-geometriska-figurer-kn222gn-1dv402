using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uppgift_2._3_i_2010_visual_studio
{
    class Shape
    {
        private double _length;
        private double _width;

        public abstract double area
        {
            get; 
        }

        public double Length
        {
            get
          {
            return Length;
          }
            set 
          {
            if ( value <= 0 )
          {
                {throw new ArgumentException("The length is not even zero please try again");}
                Length = value;
          }
        
        }
        }
        public abstract double Perimeter
        {
            get
            {
                return Perimeter;
            }
        }

        public double Width
        {
            get
            {
                return Width;
            }
            set
            {
                if(value <= 0)
                {
                    {throw new ArgumentException("The Width is not even zero please try again");}
                    Width = value;
                }
            }
        }

         protected Shape(double length, double width)
        {
             Length = length;
             Width = width;

        }

        public override string ToString()
        {
            StringBuilder values = new StringBuilder();

            values.AppendFormat("(0) : (1) : (2:F1) : (3:F1) ", Length, Width, area, Perimeter);
            return values.ToString();

        }
        
       
    }

       public enum ShapeType { Ellipse, Rectangle }
}
