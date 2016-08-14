using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Calculator
{
    public /*static*/ class FibonacciCalculator
    {
        private long nz2 = 1;
        private long nz1 = 1;

        public /*static*/ long /* int : passage en long au moment du Test5 */ Compute(int i)
        {
            Debug.WriteLine("Compute " + i);

            if (i < 0)
                throw new FibonacciOutOfRangeException();

            if (i == 0)
                return 0;

            // Red
            //return 0;

            // Green
            if (i <= 2)
                return 1;

            long nz0 = 0;

            for (int k = 2; k < i; k++)
            {
                nz0 = nz1 + nz2;
                nz2 = nz1;
                nz1 = nz0;
            }

            return nz0;
        }
    }
}