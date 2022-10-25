using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal class Teacher : Person
    {
        private string _explaning;
        public void Explain(string explaning)
        {
            _explaning = explaning;
            Console.WriteLine(explaning);
        }
    }
}
