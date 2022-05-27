using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antraOOP
{
    public class Ball : Color
    {
        private int size;
        public int Size { get { return size; } }

        public Color Color { get { return Color; } }

        public Ball(int size, decimal red, decimal green, decimal blue, decimal alpha = 255)
            : base(red, green, blue, alpha)
        {
            this.size = size;
        }

        public int thrown = 0;

        public void pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                thrown++;
            }
        }

        public int numOfThrown()
        {
            return thrown;
        }
    }
}
