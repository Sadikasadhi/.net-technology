# .net-technology
1. C# program to print a binary triangle.<br>
using System;<br>

namespace Binarytriangle<br>
{<br>
    class Binarytriangle<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int number, digit = 1;<br>
            Console.Write("Enter the number of lines:");<br>
            number = Convert.ToInt32(Console.ReadLine());<br>
            for(int i=1; i<=number;i++)<br>
            {<br>
                for(int space=number-i;space>0;space--)<br>
                {<br>
                    Console.Write("");<br>
                }<br>
                for(int j=0;j<i;j++)<br>
                {<br>
                    Console.Write(digit + "");<br>
                    digit = (digit == 1) ? 0 : 1;<br>
                }<br>
                Console.Write("\n");<br>
            }<br>
        }<br>
    }<br>
}<br>

OUTPUT:<br>
![image](https://user-images.githubusercontent.com/97940468/154414928-3ac004c8-cb53-4386-875d-6ee631b90788.png)
