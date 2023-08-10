using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {

        public string _language;
        public string _name;
        public int _age;
        public string _tool;

        public string Tool { get { return _language; } set { _language = value; } }
        public string Name { get; set; }
        public int Age { get; set; }

        public Programmer(string language, string name, int age)
        {
            this._language = language;
            this._name = name;
            this._age = age;
        }

        public Programmer()
        {

        }

        public void Output()
        {
            Console.WriteLine(_name + "\nAge: " + _age + "\nProgrammer language: " + _language);
        }

        public void Create()
        {
            Console.WriteLine("Enter the programmer name: ");
            _name = Console.ReadLine();

            Console.WriteLine("Enter the programmer age: ");
            _age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the programmer language: ");
            _language = Console.ReadLine();
        }

        public void Destroy(string language)
        {
            if (language.ToLower() == _language.ToLower())
            {
                _language = null;
                Console.WriteLine($"{language} was destroyed");
            }
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
