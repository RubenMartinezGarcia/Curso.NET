using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EjercicioSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                                        Initial Catalog=Cliente;
                                                        Integrated Security=True;
                                                        Connection Timeout=30;
                                                        Encrypt=false;
                                                        TrustServerCertificate=True;
                                                        ApplicationIntent=ReadWrite;
                                                        MultiSubnetFailover=False"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE", connection);
                cmd.Parameters.Add("@Id", sqlDbType.int);
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Dispose();
                    Console.WriteLine();
                }
            }
        }
    }

    public class Cliente : IDisposable
    {
        public Guid Id { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
