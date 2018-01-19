using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass objMyClass = new MyClass();
            int sum = objMyClass.Sum(1, 2);
        }


    }

    public class MyClass
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
