using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    class Person
    {
        static void Main(string[] args)
        {
            var pedro = new Person() { Name = "Pedro" };
            var juan = new Person() { Name = "Juan" };
            var hermanos = pedro + juan;
            var codePedro = pedro.GetHashCode();
            var codeJuan = juan.GetHashCode();
            var result2 = pedro.Equals(juan);
            if (pedro == juan)
            {

            };
            var dictionary = new Dictionary<int, Person>();
            var persons = new List<Person>()
            {
                new Person(){Name="Pedro"},
                new Person(){Name="Juan"},
                new Person(){Name="Fernando"}
            };
            var result = persons.Where(c => c.Name.Contains('o'));
            var integers = new List<int>()
            {
                0,1,2,3,4,5,6,7,8,9
            };
        }

        public string Name { get; set; }
        public static Person operator +(Person a, Person b)
        {
            return new Person() { Name = a.Name + " " + b.Name + " son hermanos" };
        }
    }
}
