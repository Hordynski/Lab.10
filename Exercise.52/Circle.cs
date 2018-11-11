using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._52
{
    class Circle : Shape
    {
        private double _radius;

        public Circle(double Radius)
        {
            _radius = Radius;
        }

        public double CalculateCircumference()
        {
            var circumference = ((_radius) / (2 * Math.PI));
            return circumference;
        }

        public string FormatCalculatedCircumference()
        {
            double formattedCircumference = Math.Round(CalculateCircumference(), 2);
            var stringCircumference = Convert.ToString(formattedCircumference);
            return stringCircumference;
        }

        public double CalculateArea()
        {
            var calculatedArea = (Math.PI * ((_radius)*(_radius)));
            return calculatedArea;
        }

        public string FormatCalculatedArea()
        {
            var calculatedArea = Math.Round(CalculateArea(), 2);
            var stringArea = Convert.ToString(calculatedArea);
            return stringArea;
        }
    }
}
