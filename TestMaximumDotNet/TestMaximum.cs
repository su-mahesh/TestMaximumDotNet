using System;
using System.Linq;

namespace TestMaximumNameSpace
{
    public class TestMaximum<E> where E : IComparable
    {
        E[] InputArray;


        public TestMaximum(E[] InputArray)
        {
            this.InputArray = InputArray;
        }

        public E[] SortArray(E[] InputArray)
        {
            Array.Sort(InputArray);
            return InputArray;
        }

        public E GetMaximumValue()
        {
            E[] SortedInputArray = SortArray(InputArray);
            return SortedInputArray.Last();
        }
    }
}
