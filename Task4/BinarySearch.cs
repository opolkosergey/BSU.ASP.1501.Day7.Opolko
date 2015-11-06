using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Search
    {
        public static int BinarySearch<T>(this T[] array, IComparer comparer, T element)
        {
            if ( comparer.Compare(array[0], element) > 0 || 
                 comparer.Compare(array[array.Length - 1], element) < 0)
                return -1;

            int firstIndex = 0,lastIndex = array.Length - 1;
            while (firstIndex < lastIndex)
            {
                var averageIndex = firstIndex + (lastIndex - firstIndex) / 2;
                if ( comparer.Compare(element,array[averageIndex]) < 0)
                    lastIndex = averageIndex;
                else firstIndex = averageIndex + 1;
            }
            if (comparer.Compare(array[lastIndex],element) == 0)
                return lastIndex;
            return -1;
        }
    }
}
