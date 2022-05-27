using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class Color
    {
        private decimal red;
        private decimal green;
        private decimal blue;
        private decimal alpha;
        
        public decimal Red { get { return red; } set { red = value; } }
        public decimal Green { get { return green; } set { green = value; } }
        public decimal Blue { get { return blue; } set { blue = value; } }
        public decimal Alpha { get { return alpha; } set { alpha = value; } }
        

        public Color(decimal red, decimal green, decimal blue, decimal alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public decimal grayScale()
        {
            decimal result = (red + green + blue) / 3;
            return Math.Round(result, 2);
        }

    }
}
