using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Rectangle
    {
        double side1 { get; set; }
        double side2 { get; set; }
        public double Area
        {
            get { return this.AreaCalc(); }
        }
        public double Perimeter
        {
            get { return this.PerimeterCalc(); }
        }
        
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalc()
        {
            return this.side1 * this.side2;
        }

        public double PerimeterCalc()
        {
            return this.side1 + this.side2 + this.side1 + this.side2;
        }
    }
}
