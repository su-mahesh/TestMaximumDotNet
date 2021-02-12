using System;

namespace TestMaximumNameSpace
{
    public class TestMaximum
    {
        public int GetMaximumInteger(int FirstNumber, int SecondNumber, int ThirdNumber)
        {
            if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
                return FirstNumber;
            else if (SecondNumber > ThirdNumber)
                return SecondNumber;
            else
                return ThirdNumber;           
        }
        static void Main(string[] args)
        {

        }
    }
}
