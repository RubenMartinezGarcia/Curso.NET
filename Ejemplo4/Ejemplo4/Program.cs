using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            var caja = new Caja() { };
            caja.Total += Caja_Total;
            caja.Total -= Caja_Total;
        }

        private static void Caja_Total(object o, TotalEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    class Ticket
    {

    }

    class Caja
    {
        public event TotalEventHadler Total;
        public Caja()
        {
            this.tickets = new List<Ticket>();
        }
        public virtual void OnTotal(TotalEventArgs e)
        {
            var handler = Total;
            if (null != handler)
            {
                handler(this, e);
            }
        }
        public int Id { get; set; }
        public List<Ticket> tickets { get; private set; }
    }

    public delegate void TotalEventHadler(object o, TotalEventArgs e);

    public class TotalEventArgs:EventArgs
    {
        public TotalEventArgs(int id, decimal total)
        {
            Id = id;
            Total = total;
        }
        public int Id { get; private set; }
        public decimal Total { get; private set; }
    }
}
