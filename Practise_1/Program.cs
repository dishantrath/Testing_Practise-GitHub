using System;

namespace Practise_1
{

    
    class Program
    {
        private static int SumOfDigit;
        private static int valueOfDigit;
        private static int fValue;

        //private static int CompareSumOfDigit;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to experiment with");
            var value = Convert.ToInt32(Console.ReadLine());
            var nextMinNbr = MinimumNumberOfSum(value);
            Console.Write(nextMinNbr);
        }

        static int MinimumNumberOfSum(int value)
        {
            var referenceValue = value;
            while (value > 0)
            {
                SumOfDigit = SumOfDigit + value % 10;
                value = value / 10;
            }

            var finalValue = 0;

            while (SumOfDigit > 9 || SumOfDigit > 0)
            {
                finalValue = finalValue + SumOfDigit % 10;
                SumOfDigit = SumOfDigit / 10;
            }

            for (int i = referenceValue + 1; i > 0; i++)
            {
                valueOfDigit = i;
                fValue = i;
                var CompareSumOfDigit = 0;

                while (valueOfDigit > 0)
                {
                    CompareSumOfDigit = CompareSumOfDigit + valueOfDigit % 10;
                    valueOfDigit = valueOfDigit / 10;
                }

                var finalComparedValue = 0;

                while (CompareSumOfDigit>9 || CompareSumOfDigit>0)
                {
                    finalComparedValue = finalComparedValue + CompareSumOfDigit % 10;
                    CompareSumOfDigit = CompareSumOfDigit / 10;
                }

                if (finalValue == finalComparedValue)
                break;
            }

            return fValue;
        }
    }
}
