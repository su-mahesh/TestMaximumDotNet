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
        public float GetMaximumFlaot(float FirstNumber, float SecondNumber, float ThirdNumber)
        {
            if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
                return FirstNumber;
            else if (SecondNumber > ThirdNumber)
                return SecondNumber;
            else
                return ThirdNumber;
        }
        public string GetMaximumString(string FirstString, string SecondString, string ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString) > 0)
                return FirstString;
            else if (SecondString.CompareTo(ThirdString) > 0)
                return SecondString;
            else
                return ThirdString;
        }

            static void Main(string[] args)
        {

        }
    }
}
