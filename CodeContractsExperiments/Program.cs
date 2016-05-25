using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeContractsExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("evren");

            person.PrintPerson();

            person.Rename(null);

            person.PrintPerson();

            Console.ReadKey();
        }
    }
}
