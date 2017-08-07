using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext(@"C:\Users\Alumno\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Pruebas.mdf");
            Table<Cliente> Cliente = db.GetTable<Cliente>();
            db.Log = Console.Out;
            IQueryable<Cliente> query1 =
                from cliente1 in Cliente
                where cliente1.Name == "Pedro"
                select cliente1;
            foreach (var cliente in Cliente)
            {
                Console.WriteLine("ID={0}, Name={1}", cliente.Id, cliente.Name);
                Console.ReadLine();
            }
        }
    }

    [Table(Name = "Cliente")]
    public class Cliente
    {
        public Guid Id
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public int Phone
        {
            get
            {
                return this.Phone;
            }
            set
            {
                this.Phone = value;
            }
        }
        public string Address
        {
            get
            {
                return this.Address;
            }
            set
            {
                this.Address = value;
            }
        }
    }
}
