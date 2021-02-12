using System;

namespace TestMaximumNameSpace
{
    public class TestMaximum<E> where E : IComparable
    {
        public E GetMaximumValue(E FirstValue, E SecondValue, E ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
                return FirstValue;
            else if (SecondValue.CompareTo(ThirdValue) > 0)
                return SecondValue;
            else
                return ThirdValue;           
        }
    }
}
