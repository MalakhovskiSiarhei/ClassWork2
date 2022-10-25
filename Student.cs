using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal class Student : Person
    {
        private string _study = "Я учусь";
        void Study(string study)
        {
            _study = study;
            Console.WriteLine(study);
        }
        public void ShowAge(int Age)
        {
            Console.WriteLine($"Мой возраст {Age} лет");
        } 

    }
}
