using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        public string _tool;
        public string _name;
        public int _age;
        public string Tool { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Builder(string tool, string name, int age)
        {
            this._tool = tool;
            this._name = name;
            this._age = age;
        }

        public Builder() 
        {
            
        }
        public void Output()
        {
            Console.WriteLine(_name + "\nAge: " + _age + "\nBuilder tool: " + _tool);
        }

        public void Create()
        {
            Console.WriteLine("Enter the builder name: ");
            _name = Console.ReadLine();

            Console.WriteLine("Enter the builder age: ");
            _age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the builder tool: ");
            _tool = Console.ReadLine();
        }

        public void Destroy(string tool)
        {
            if (tool.ToLower() == _tool.ToLower())
            {
                _tool = null;
                Console.WriteLine($"We destroyed the builder's {tool}");
            }
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
