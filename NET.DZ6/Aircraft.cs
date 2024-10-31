using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NET.DZ6
{
    internal class Aircraft
    {
        string Name;
        string Manufacturer;
        int Yearofmanufacture;
        string Type;
        public Aircraft() { }   
        public Aircraft(string name, string manufacturer, int yearofmanufacture, string type)
        {
            Name = name;
            Manufacturer = manufacturer;
            Yearofmanufacture = yearofmanufacture;
            Type = type;
        }
        public void Enter()
        {
            Console.WriteLine("Name ->");
            Name = Console.ReadLine();
            Console.WriteLine("Manufacturer ->");
            Manufacturer = Console.ReadLine();
            Console.WriteLine("Yearofmanufacture ->");
            Yearofmanufacture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type ->");
            Type = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Yearofmanufacture);
            Console.WriteLine(Type);
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string manufacturer
        {
            get { return Manufacturer; }
            set { Manufacturer = value; }
        }
        public int yearofmanufacture
        {
            get { return Yearofmanufacture; }
            set { Yearofmanufacture = value; }
        }
        public string type
        {
            get { return Type; }    
            set { Type = value; }
        }
    }
}
