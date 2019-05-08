// Name: Luis Souza
// Date: 2019-04-16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class RandomNumber
    {
        protected Random random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
        protected int currentRandomNumber = 0;

        public RandomNumber()
        {

        }

        public int GenerateRandomNumber()
        {
            currentRandomNumber = random.Next();
            return currentRandomNumber;
        }

        public int GetCurrentRandomNumber() { return currentRandomNumber; }

    }
}