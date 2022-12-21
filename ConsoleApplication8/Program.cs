using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
             Console.WriteLine("Ent num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ent num2");
            num2 = int.Parse(Console.ReadLine()); 
            for(int i=num1; i<=num2;i++)
            { int sum=0;
                for(int j=1;j<i;j++)
                {if (i % j ==0)
                    sum+=j;
                }
                if(sum==i)
                    Console.WriteLine("{0}",i);
            }
        }
    }
}
