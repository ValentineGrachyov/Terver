using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Terver
{
    public class Base_Logic
    {
        public BigInteger Factorial(BigInteger num)
        {
            BigInteger result = 1;

            if (num == 1 || num == 0)
            {
                return result;
                
            }

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }

        //Размещение без повторений
        public BigInteger Accommodation(BigInteger n, BigInteger r)
        {
            if ((n < r) || n < 0 || r < 0) { return -1; }
            
            BigInteger result = 1;

            result = Factorial(n) / Factorial(n - r);

            return result;
        }

        //Размещение с повторениями
        public BigInteger Accommodation_WithRepeat(BigInteger n, BigInteger r)
        {
            if ( n <= 0 || r < 0 ) { return -1; }

            BigInteger result = 1;

            result = (BigInteger) Math.Pow((Double)n,(Double)r);

            return result;
        }

        //Перестановка без повторений
        public BigInteger Permutations(BigInteger n) => Factorial(n);

        //перестановки с повторением
        public BigInteger Permutations_WithRepeat(BigInteger n, List<BigInteger> r)
        {
            if(n<=0 || r.Where(x => x < 0).ToList().Any() || r.Sum(x => (long) x) != n) { return -1; }


            BigInteger result = 1;
            BigInteger numerator = Factorial(n);
            BigInteger denumerator = 1; 
            
            foreach(var el in r) { denumerator *= Factorial(el); }

            result = numerator / denumerator;
            return result;
        }

        //Сочетания без повторений
        public BigInteger Combination(BigInteger n, BigInteger r)
        {
            if ((n < r) ||  r < 0) { return -1; }

            BigInteger result = 1;
            BigInteger numerator = Factorial(n);
            BigInteger denumerator = Factorial(r)*Factorial(n-r);

            result = numerator / denumerator;

            return result;
        }

        //Сочетания с повторением
        public BigInteger Combination_WithRepeat(BigInteger n, BigInteger r)
        {
            if ( n <0  || r < 0) { return -1; }

            BigInteger result = 1;
            BigInteger numerator = Factorial(n + r - 1);
            BigInteger denumerator = Factorial(r) * Factorial(n - 1);

            result = numerator / denumerator;

            return result;
        }
    }
}
