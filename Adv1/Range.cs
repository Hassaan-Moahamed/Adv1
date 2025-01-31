using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    public class Range<T> where T : IComparable<T>
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }

        public Range(T minValue, T maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
        }

        public T Length()
        {
            dynamic max = MaxValue;
            dynamic min = MinValue;

            return max - min;
        }
    }
}
