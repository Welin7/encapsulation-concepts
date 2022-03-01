using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        public Person(string name, int mass, double hight)
        {
            this.Name = name;
            this.Mass = mass;
            this.Hight = hight;
        }
        
        public string? Name { get; private set; }
        public int Mass {get; private set;}
        public double Hight { get; private set;}

        //Access via property public get
        public double IMC => CalculeIMC();

        //Business rule hide for modifier private
        private double CalculeIMC()
        {
          return this.Mass / (Math.Pow(this.Hight, 2));
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Mass} - {this.Hight}";
        }
    }
}
