using System;

namespace Graycode
{
    class Graycode
    {
        static int getGray(int n)
        {
            return n ^ (n >> 1);
        }
        static void Main(string[] args)
        {
            int InputNum, GrayNum;
            Console.Write("\n Enter the decimal number:");
            InputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Binary equivalent of {0}: {1}", InputNum, Convert.ToString(InputNum, 2));
            GrayNum = getGray(InputNum);
            Console.WriteLine("\n Gray code equvalent of {0} : {1}", InputNum, Convert.ToString(GrayNum, 2));
        }

    }
}
