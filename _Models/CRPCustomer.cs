using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Models
{
    public class CRPCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string PaymentTime { get; set; }
        public double TotalCost { get; set; }
        public double  Payment { get; set; }
        public double Returnchange { get; set; }
    }
}
