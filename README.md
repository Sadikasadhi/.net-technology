# .net-technology
1. C# program to print a binary triangle.
using System;

namespace Binarytriangle
{
    class Binarytriangle
    {
        static void Main(string[] args)
        {
            int number, digit = 1;
            Console.Write("Enter the number of lines:");
            number = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=number;i++)
            {
                for(int space=number-i;space>0;space--)
                {
                    Console.Write("");
                }
                for(int j=0;j<i;j++)
                {
                    Console.Write(digit + "");
                    digit = (digit == 1) ? 0 : 1;
                }
                Console.Write("\n");
            }
        }
    }
}

OUTPUT:
![image](https://user-images.githubusercontent.com/97940468/154414928-3ac004c8-cb53-4386-875d-6ee631b90788.png)
