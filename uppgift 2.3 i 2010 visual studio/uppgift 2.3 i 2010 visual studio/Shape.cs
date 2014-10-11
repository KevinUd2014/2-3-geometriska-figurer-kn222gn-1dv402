using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uppgift_2._3_i_2010_visual_studio
{
    abstract class Shape
    {
        private double _length; // två variablar
        private double _width;

        public abstract double Area // ska troligen skicka in arean!
        {
            get; 
        }

        public double Length //här skickar vi in längden och kollar så att den är av rätt storlek
        {
            get
          {
            return _length;
          }
          
            set 
          {
            if ( value <= 0 ) // och skriver ut om den nu skulle vara av fel storlek
            {
                {throw new ArgumentException("The length is not even zero please try again");}
            }
            _length = value; // value är det värde som nu Längden får!
        
          }
        }
        public abstract double Perimeter // här får bara perimeter ett värde från antingen Ellipse eller Rektangel
        {
            get;
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if(Width <= 0)
                {
                    {throw new ArgumentException("The Width is not even zero please try again");}
                }
                _width = value;
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

            values.AppendFormat("(0) : (1) : (2:F1) : (3:F1) ", Length, Width, Area, Perimeter);
            return values.ToString();

        }
        
       
    }

       public enum ShapeType { Ellipse, Rectangle }
}
