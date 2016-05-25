using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace CodeContractsExperiments
{
    public class Person
    {
        private string name = "";

        public Person(string name)
        {
            this.name = name;
        }

        public void Rename(string name) {
            Contract.Requires(!string.IsNullOrWhiteSpace(name), "name must be a non-null, non-empty string");
            this.name = name;
        }

        public void PrintPerson() {
            string name = Char.ToUpper(this.name[0]) + this.name.Substring(1);

            Console.WriteLine(name);
        }
    }
}
