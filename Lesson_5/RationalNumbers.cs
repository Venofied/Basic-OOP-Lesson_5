using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class RationalNumbers
    {
        private double _numerator;

        private double _denominator;

        public double Denominator
        {
            get { return _denominator; }
            set { _denominator = value; }
        }

        public double Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        internal RationalNumbers(double numerator, double denominator)
        {
            Denominator = denominator;
            Numerator = numerator;
        }
        private double result()
        {
            return Numerator / Denominator;
        }
        public static bool operator ==(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return false;
            }
            else
            {
                return r1.Equals(r2);
            }
        }
        public static bool operator !=(RationalNumbers r1, RationalNumbers r2)
        {
            if (r1.Equals(r2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator >(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return false;
            }
            else
            {
                if (r1.result() > r2.result())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool operator <(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return false;
            }
            else
            {
                if (r1.result() < r2.result())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator <=(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            { 
                return false;
            }
            {
                if (r1.result() <= r2.result())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool operator >=(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return false;
            }
            else
            {
                if (r1.result() >= r2.result())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            }
        public static RationalNumbers operator +(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return null;
            }
            else
            {
                return new RationalNumbers( r1.Numerator + r2.Numerator, r1.Denominator + r2.Denominator);
            }
        }
        public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return null;
            }
            else
            {
                return new RationalNumbers(r1.Numerator - r2.Numerator, r1.Denominator - r2.Denominator);
            }
        }

        public static RationalNumbers operator ++(RationalNumbers r1)
        {
            if (r1 is null)
            {
                return null;
            }
            else
            {
                r1.Numerator++;
                r1.Denominator++;
                return r1;
            }
        }

        public static RationalNumbers operator --(RationalNumbers r1)
        {
            if (r1 is null)
            {
                return null;
            }
            else
            {
                r1.Numerator--;
                r1.Denominator--;
                return r1;
            }
        }
        /// <summary>
        /// Вывод в Int
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return result().ToString();
        }

        public static explicit operator float(RationalNumbers r1)
        {
            return (float)r1.result();
        }

        public static explicit operator int(RationalNumbers r1)
        {
            return (int)r1.result();
        }

        public static RationalNumbers operator *(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return null;
            }
            else
            {
                return new RationalNumbers(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
            }
        }

        public static RationalNumbers operator /(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return null;
            }
            else
            {
                return new RationalNumbers(r1.Numerator / r2.Numerator, r1.Denominator / r2.Denominator);
            }
        }
        public static RationalNumbers operator %(RationalNumbers r1, RationalNumbers r2)
        {
            if ((r1 is null) && (r2 is null))
            {
                return null;
            }
            else
            {
                return new RationalNumbers(r1.Numerator % r2.Numerator, r1.Denominator % r2.Denominator);
            }
        }

    }
}
