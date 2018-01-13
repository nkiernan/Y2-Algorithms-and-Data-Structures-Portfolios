using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Person : IComparable
    {
        private int age;
        private string name;

        //constructor with one argument
        public Person(string name)
        {
            this.name = name;
        }

        //property for name
        public string Name
        {
            get { return name; }
            set { name = value;  }
        }

        public int CompareTo(Object obj) //implementation of CompareTo
        {                               //for IComparable
            Person other = (Person)obj;
            return Name.CompareTo(other.Name); //uses Name for comparison

        } 
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }                                         
    }
}
