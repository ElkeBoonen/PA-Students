using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_OO
{
    class Patient
    {
        public string Name { get ; private set; }
        public int Year { get; private set; }
        public int Age { get; private set; }
        public bool Covid { get; set; }

        public Patient()
        {
            Name = "Jane Doe";
            Year = 2000;
            Covid = false;
            Age = CalculateAge();
        }

        public Patient(string name, int year, bool covid)
        {
            Name = name;
            Year = year;
            Covid = covid;
            Age = CalculateAge();
        }

        public string Hello()
        {
            return $"Hello from {this.ToString()}!";
        }

        private int CalculateAge()
        {
            return DateTime.Now.Year - Year;
        }

        public override string ToString()
        {
            return $"{Name}, born in {Year} - Covidstatus: {Covid}";
        }
    }
}
