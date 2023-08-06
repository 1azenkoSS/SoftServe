using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace HW_4
{
    internal class Person
    {
        private string _name;
        private DateTime _birthYear;

        public string Name { set { _name = value; } get { return _name; } }
        public DateTime BirthYear { set { _birthYear = value; } get { return _birthYear; } }

        public Person() { }

        public Person(string name, DateTime birthYear)
        {
            this._name = name;
            this._birthYear = birthYear;
        }
        public void Input()
        {
            Console.WriteLine("Enter your name: ");
            _name = Console.ReadLine();

            Console.WriteLine("Enter your birthday date");
            _birthYear = DateTime.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Your name is " + _name + "\nYou're: " + GetAge());
        }

        public int GetAge()
        {
            DateTime a = DateTime.Now;
            int age = a.Year - _birthYear.Year;
            return age;
        }

        public string ChangeName()
        {
            if(GetAge() < 16)
            {
                _name = "Very Young";
            }
            return _name;
        }
        public static bool operator == (Person first, Person second)
        {
            return (first._name == second._name) && (first._birthYear == second._birthYear);
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first._name == second._name) && (first._birthYear == second._birthYear);
        }

        public override string ToString()
        {
            return "Your name is: " + _name + "\nYu're:  " + GetAge();
        }
    }
}