using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class ValueValidator
    {
        public static void AssertStringOnlengs(string value, int maxLength, string propertyname)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{(propertyname)} должен быть меньше ({maxLength}) символов в длинну");
            }
        }

        public static void AssertValueInRange(double value,double min, double max, string propertyName)
        {
            if (value < min | value > max)
            {
                throw new ArgumentException($"{(propertyName)} должен быть больше {(min)} меньше {(max)} символов в длинну");
            }
        }
    }
}
