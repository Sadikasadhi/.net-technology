# .net-technology

1. Write a C# program to print Fibonacci series using Recursion and without using Recursion.

using System;

namespace Exercises
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements:");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            
            for(i=2;i<number;++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
<br>
OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156501447-70eccbc7-b161-4861-8205-830813d9f2ba.png)
<br>

2. Write a C# program to check whether the given number is Prime or not.

using System;

namespace Exercises
{
    class Primenumber
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for(i=2;i<=m;i++)
            {
                if(n%i==0)
                {
                    Console.Write("Number is not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("number is Prime");
        }
    }
}
<br>
OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156503073-68c48d68-2eec-44be-a726-a55696457a47.png)
<br>
![image](https://user-images.githubusercontent.com/97940468/156502938-ba88aa3d-2811-400a-a9e5-55286a4abd36.png)
<br>


3. Write a C# program to check whether the given element is Palindrome or not.

using System;

namespace Exercises
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is not Palindrome");
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156503582-7947dee9-9e51-4741-9d6e-f77e1e8e6a28.png)
<br>
![image](https://user-images.githubusercontent.com/97940468/156503708-f9f3b113-87c7-4329-bc82-10c2467bea71.png)
<br>

4. Write a C# program to print factorial of a number.
using System;

namespace Exercises
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter any Number:");
            number = int.Parse(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of" + number + "is:" + fact);
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156504485-7e1aa166-5edd-4a85-bed7-54e6fc19d1a5.png)
<br>

5. Write a C# program to check whether the given element is Armstrong or not.

using System;

namespace Exercises
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}

<br>
OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156505417-30854f3f-9737-4c38-93a3-d45dda4caef2.png)
<br> 
![image](https://user-images.githubusercontent.com/97940468/156505529-44ecf7cf-67bc-4446-a64f-518f1f90b11b.png)
<br>

6. Write a C# program to find the sum of Digits.

using System;

namespace Exercises
{
    class sum
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("sum is=" + sum);
        }
    }
}
OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156506346-808ed48e-ef28-4f1e-9b87-2c76bc6b75ea.png)
<br> 

7. Write a C# program to Reverse a given number.  

using System;

namespace Exercises
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number:");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /=10;
            }
            Console.Write("Reversed Number:" + reverse);
        }
    }
}
OUTPUT:<br> 
![image](https://user-images.githubusercontent.com/97940468/156506623-7e34867b-2718-4098-849d-e0db5797166b.png)
    <br> 

8. C# program to print a binary triangle.<br>
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

9. C# program to check whether the entered number is an Amicable Number or Not.
using System; 

namespace AmicableNumber
{

    class AmicableNumber
    {
        static void Main(String[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0;
            Console.WriteLine("\n -----AMICABLE NUMBERS-------\n");
            Console.Write("\nEnter the  First Number : ");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the  Second Number : ");
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
                Console.WriteLine("\nThe numbers{0} and {1} are amicable", num1,num2);
            }
            else
            {
                Console.WriteLine("\nThe numbers{0} and {1} are not amicable", num1, num2);
            }
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154634242-01f8d7cc-a01f-4cd7-acc7-284a589c2f88.png)
<br>
![image](https://user-images.githubusercontent.com/97940468/154634136-f3c0aad6-1959-489a-8a8f-d82711a909b5.png)

<br>
 
 10. C# program to Illustrate Multilevel Inheritance with visrtual Methods(displaying student details).<br>
 using System;

namespace Excercises
{

    class PersonalDetails
    {
        string name;
        int age;
        string gender;
        public PersonalDetails(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n-----PERSONAL DETAILS-------\n");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Gender:" + gender);
        }

    }
    class CourseDetails : PersonalDetails
    {
        int regNo;
        string course;
        int semester;
        public CourseDetails(string name, int age, string gender, int regNo, string course, int semester) : base(name, age, gender)
        {
            this.regNo = regNo;
            this.course = course;
            this.semester = semester;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\n----COURSE DETAILS-----\n");
            Console.WriteLine("Register Numbetr:" + regNo);
            Console.WriteLine("Course:" + course);
            Console.WriteLine("Semester:" + semester);
        }
    }
    class MarksDetails : CourseDetails
    {
        int[] marks = new int[5];
        int total;
        float average;
        string grade;
        int flagFail;
        public MarksDetails(string name, int age, string gender, int regNo, string course, int semester, int[] marks) : base(name, age, gender, regNo, course, semester)
        {
            total = 0;
            for (int i = 0; i < 5; i++)
            {
                this.marks[i] = marks[i];
                total += marks[i];
                if (marks[i] < 35)
                {
                    flagFail = 1;
                }
            }
            Calculate();
        }
        private void Calculate()
        {
            average = total / 5;
            if (flagFail == 1 || average < 40)
                grade = "Fail";
            else if (average >= 70)
                grade = "Distinction";
            else if (average >= 60)
                grade = "Firstclass";
            else if (average >= 50)
                grade = "second class";
            else
                grade = "Pass class";

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\n----MARKS DETAILS----\n");
            Console.Write("marks in 5 subjects:");
            for (int i = 0; i < 5; i++)
                Console.Write(marks[i] + "");
            Console.WriteLine();
            Console.WriteLine("Toatl:" + total);
            Console.WriteLine("Average:" + average);
            Console.WriteLine("Grade:" + grade);

        }
    }
    class Multilevel
    {
        public static void Main(string[] args)
        {
            MarksDetails Student1 = new MarksDetails("Sadika", 20, "Female", 20210005, "Msc", 1, new int[] { 77, 80, 98, 95, 90 });
            Student1.Display();
        }
    }
}


OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154634690-af9f0042-05eb-4d39-803f-e4812b40b5b6.png)
<br>

11. C# program to create a Gray code.<br>
using System;

namespace Exercises
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

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154635339-bd853d51-fab8-4b63-a37a-294b620db775.png)

<br>
12. C# program to calculate volume of 2 boxes and find the resultant volume after addition of 2 boxes by implementing operator overloading.<br>
using System;

namespace Exercises
{
    class Box
    {
        float width;
        float height;
        float length;
        public float Volume
        {
            get { return width * height * length; }
        }
        public Box(float width,float height,float length)
        {
            this.width = width;
            this.height = height;
            this.length = height;
        }
        public static float operator+(Box box1,Box box2)
        {
            return box1.Volume + box2.Volume;
        }
        public override String ToString()
        {
            return " box with width"+width+",height" + height + "and length" + length;
        }
        }
    class OperatorOverloading
    { 
        public static void Main()
        {
            Box box1 = new Box(10, 20, 30);
            Box box2 = new Box(25, 32, 15);
            Console.WriteLine("Volume of {0} is: {1}", box1, box1.Volume);
            Console.WriteLine("Volume of {0} is: {1}", box2, box2.Volume);
            Console.WriteLine("Volume after adding boxes: {0}",box1+box2);
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154636745-5306d598-cfcf-4a34-9ad7-a2719a0f22b5.png)
<br>

13. C# program to implement principle of Delegates(Converting input string to uppercase first, last and entire string).<br>
using System;

namespace Exercises
{

    class Delegates
    {
        delegate string UppercaseDelegate(string input);
        static string UppercaseFirst(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[0] = char.ToUpper(buffer[0]);
            return new string(buffer);
        }
        static string UppercaseLast(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[buffer.Length-1] = char.ToUpper(buffer[buffer.Length-1]);
            return new string(buffer);
        }
        static string UppercaseAll(string input)
        {
            return input.ToUpper();
        }
        static void WriteOutput(string input, UppercaseDelegate del)
        {
            Console.WriteLine("input String:{0}", input);
            Console.WriteLine("Output String:{0}", del(input));
        }
        static void Main()
        {
            WriteOutput("tom", new UppercaseDelegate(UppercaseFirst));
            WriteOutput("tom", new UppercaseDelegate(UppercaseLast));
            WriteOutput("tom", new UppercaseDelegate(UppercaseAll));
            Console.ReadLine();
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154637265-daa1bd10-4b40-4727-bbbc-757e2fd09907.png)
<br>

14. C# program to generate Register Number automatically for 100 students using static cnstructor.<br>
  using System;

namespace Exercises
{

    class RegisterNum
    {
        int regNo;
        static int startNum;
        static RegisterNum()
        {
            startNum = 20210000;
        }
        RegisterNum()
        {
            regNo = ++startNum;
        }
        public static void Main(string[] args)
        {
            for(int i=0;i<100;i++)
            {
                RegisterNum Student = new RegisterNum();
                Console.WriteLine("Student{0} : {1}", i + 1, Student.regNo);
            }
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154638059-4c4452f3-c4f9-4042-a085-ac36d5a08166.png)
![image](https://user-images.githubusercontent.com/97940468/154638265-a58ea4db-40e0-4508-ba48-3650e1c7e9cb.png)

<br>
15. C# program to find the frequency of the word "is" in a given sentence.

using System;

namespace Excercises
{
    class FrequencyIS
    {
        static void Main(string[] args)
        {
            int count = 0;
            string inputString;
            Console.WriteLine("\n---------Frequency of word 'is' --------");
            Console.Write("\n Enter the input string:");
            inputString = Console.ReadLine();
            char[] separator = { ',',' ', '.', '!', '\n' };
            string testString = inputString.ToLower();
            string[] outcomes = testString.Split(separator);
            foreach(String s in outcomes)
            {
                Console.WriteLine(s);
                if (s == "is")
                    count++;
            }
            Console.WriteLine("\n Number of 'is' in '"+inputString+"'is:"+count);
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156499718-33cddccc-243e-40c5-bd19-a554c928ba4f.png)
 <br>
 
16. C# program that benchmarks 2D, jagged array allocation.
 
 using System;
using System.Diagnostics;

namespace Exercises
{

    class BenchmarkAllocation
    {
        const int _max= 100000;
        static void Main(string[] args)
        {
            var Arr2D = new int[100, 100];
            var ArrJagged = new int[100][];
            for(int i=0;i<100;i++)
            {
                ArrJagged[i] = new int[100];
            }
            var Stopwatch2D = Stopwatch.StartNew();
            
            for(int i=0;i<_max;i++)
            {
                for(int j=0;j<100;j++)
                {
                    for(int k=0;k<100;k++)
                    {
                        Arr2D[j, k] = k;
                    }
                }
            }
            Stopwatch2D.Stop();
            var StopwatchJagged = Stopwatch.StartNew();
            
            for(int i=0;i<_max;i++)
            {
                for(int j=0;j<100;j++)
                {
                    for(int k=0;k<100;k++)
                    {
                        ArrJagged[j][k] = k;
                    }
                }
            }
            StopwatchJagged.Stop();
            Console.Write("\n Time taken for allocation in case of 2D array:");
            Console.WriteLine(Stopwatch2D.Elapsed.TotalMilliseconds + " milliseconds");
            Console.Write("\n Time taken for allocation in case of Jagged array:");
            Console.WriteLine(StopwatchJagged.Elapsed.TotalMilliseconds + " milliseconds");
        }
    }
}

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/156507883-5da15a48-adbe-4a1c-bc66-0ce9789049d0.png)
<br>

17. C# program to find the sum of the values on Diagonal of the matrix.










