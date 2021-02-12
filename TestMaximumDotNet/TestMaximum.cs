using System;

namespace TestMaximumNameSpace
{
    public class TestMaximum
    {
        public E GetMaximumValue<E>(E FirstNumber, E SecondNumber, E ThirdNumber) where E : IComparable
        {
            if (FirstNumber.CompareTo(SecondNumber) > 0 && FirstNumber.CompareTo(ThirdNumber) > 0)
                return FirstNumber;
            else if (SecondNumber.CompareTo(ThirdNumber) > 0)
                return SecondNumber;
            else
                return ThirdNumber;           
        }
            static void Main(string[] args)
        {

        }
    }
}
