using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person() {Id=1, Name="Pedro", Surname="Hurtado"},
                new Person() { Id = 2, Surname = "Lopez" }
            };

            //validate persons
            var generics = ToGeneric(persons);

            //insert into table(...) values(111,2)
            foreach (var generic in generics)
            {
                var table = generic.Type.Name;
                var sql = "INSERT INTO " + table.ToUpper();
                var properties = generic.Type.GetProperties;
                foreach (var property in properties)
                {
                    var value = property.GetValue(generic.Obj);
                    var attributes = property.GetCustomAttributes(true);
                }
            }
        }
    }

    public static List<Generic> ToGeneric(IEnumerable<Object> list)
    {
        return list.Select(c => new Generic { Obj = c, Type = c.GetType() }).ToList();
        /* var generics = new List<Generic>();
        foreach (var obj in list)
        {
            generics.Add(new Generic() { Obj = obj, Type = obj.GetType() });
        }
        return generics; */
    }

    public class Generic
    {
        public Object Obj { get; set; }
        public Type Type { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        [StringDataBase(Lenght = 50)]
        public string Name { get; set; }
        [StringDataBase(Lenght = 15, Required = false)]
        public string Surname { get; set; }
        public void Save()
        {

        }
    }
    public interface IValid
    {
        bool IsValid(string value);
    }
    public class StringDataBaseAttribute : Attribute
    {
        public StringDataBaseAttribute()
        {
            this.Required = true;
        }
        public int Lenght { get; set; }
        public bool Required { get; set; }
        public bool IsValid(string value)
        {
            return true;
        }
    }
}
