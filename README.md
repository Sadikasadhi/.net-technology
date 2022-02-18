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
 
 3.C# Program to Illustrate Multilevel Inheritance with visrtual Methods(displaying student details).<br>
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

4. C# Program to create a Gray code.<br>
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
5. C# Program to calculate volume of 2 boxes and find the resultant volume after addition of 2 boxes by implementing operator overloading.<br>
using System;

namespace Box
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

6.C# Program to implement principle of Delegates(Converting input string to uppercase first, last and entire string).<br>






