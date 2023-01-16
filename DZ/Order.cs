using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime DateOfChange { get; set; }
        public char ProductName { get; set; }
        public int ReleaseProgram { get; set; }
        public char Requirements { get; set; }
        public DateTime Deadlines { get; set; }
       public char OrderStatus { get; set; }

    }
}
