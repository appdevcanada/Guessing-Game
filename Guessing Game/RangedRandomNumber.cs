// Name: Luis Souza
// Date: 2019-04-16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class RangedRandomNumber : RandomNumber
    {
        protected int minimum = 0;
        protected int maximum = 0;

        public RangedRandomNumber()
        {
            minimum = 1;
            maximum = 10;
        }

        public RangedRandomNumber(int minimum, int maximum)
        {
            SetMaximum(maximum);
            SetMinimum(minimum);
        }

        public new int GenerateRandomNumber()
        {

            if (maximum == minimum)
            {
                return minimum;
            }

            if (minimum > maximum)
            {
                int maximumTemp = maximum;
                maximum = minimum;
                minimum = maximumTemp;
            }

            currentRandomNumber = random.Next(minimum, maximum + 1);
            return currentRandomNumber;
        }
        public void SetMinimum(int minimum)
        {
            if (minimum < 0)
            {
                minimum = 0;
            }
            this.minimum = minimum;
        }

        public void SetMaximum(int maximum)
        {
            if (maximum < 1)
            {
                maximum = 1;
            }

            this.maximum = maximum;
        }
        public int GetMinimum() { return minimum; }
        public int GetMaximum() { return maximum; }
    }
}
