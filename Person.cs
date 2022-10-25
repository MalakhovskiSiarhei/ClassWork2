using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal class Person
    {
        private string ?_hello;
        protected int Age;
        public void Greet(string hello) 
        {
            _hello = hello;
            Console.WriteLine(hello);
        
        }

        public void SetAge(int age) 
        { 
            Age = age;
            Console.WriteLine(age);
            //age = Convert.ToInt32(Console.ReadLine());

        }

    }
}
