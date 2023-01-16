using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    public class ExecutionСonditions : Сustomer
    {
        public DateTime Deadlines { get; set; }
        public int Cost { get; set; }
        public bool ConditionsAccepted { get; set; }
        public bool ConditionsRejected { get; set; }


    }
}
