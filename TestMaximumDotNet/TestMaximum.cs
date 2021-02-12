using System;

namespace TestMaximumNameSpace
{
    public class TestMaximum<E> where E : IComparable
    {
        E FirstValue;
        E SecondValue;
        E ThirdValue;


        public TestMaximum(E FirstValue, E SecondValue, E ThirdValue)
        {
            this.FirstValue = FirstValue;
            this.SecondValue = SecondValue;
            this.ThirdValue = ThirdValue;
        }

        public E GetMaximumValue()
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
