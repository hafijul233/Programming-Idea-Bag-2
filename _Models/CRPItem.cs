using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Models
{
    public class CRPItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity{get; set;}
        public double Unitprize { get; set; }
        public double TotalPrize { get; set; }

    }
}
