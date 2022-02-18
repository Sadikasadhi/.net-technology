# .net-technology
1. C# program to print a binary triangle.<br>
using System;

namespace Exercises<br>
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

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154416346-aab9b949-daaf-48d4-b745-2c70aead6524.png)

<br>
2. C# Program to check whether the entered number is an Amicable Number or Not.
using System; 

namespace AmicableNumber
{

    class AmicableNumber
    {
        static void Main(String[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0;
            Console.WriteLine("\n -----AMICABLE NUMBERS-------\n");
            Console.Write("Enter the  First Number : ");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<num1;i++)
            {
                if (num1%i == 0)
                {
                    sum1 += i;
                }
            }
            for (int i=1;i<num2;i++)
            {
                if (num2 % i == 0)
                {
                    sum2 += i;
                }
            }
            if (sum1 == num2 && sum2 == num1)
            {
                Console.WriteLine("The numbers{0} and {1} are amicable", num1,num2);
            }
            else
            {
                Console.WriteLine("The numbers{0} and {1} are not amicable", num1, num2);
            }
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154632659-4654e7b7-f50c-49c3-b37c-d9506b5c989e.png)<br>
![image](https://user-images.githubusercontent.com/97940468/154632140-21df100a-f40a-45bc-8419-79cc3347db3e.png)
<br>
 
 3.C# Program to Illustrate Multilevel Inheritance with visrtual Methods(displaying student details).


