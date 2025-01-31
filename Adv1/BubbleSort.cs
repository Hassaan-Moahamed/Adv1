using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    public static class BubbleSort<T> where T : IComparable
    {
        public static void Sort(T[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < Array.Length - i - 1; j++)
                {
                    if (Array[j].CompareTo(Array[j + 1]) == 1)
                    {
                        T Temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = Temp;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }
        }
    }
}
