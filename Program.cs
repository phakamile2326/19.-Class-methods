using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_methods
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight = aWeight;
            this.name = aName;
            this.age = aAge;
        }

        // you now have a one stop shop to test obesity of your students

        public bool IsObese()
        {
            if (weight > 60)
            {
                return false;
            }
            else return true;
        }
    }
}


        
    

