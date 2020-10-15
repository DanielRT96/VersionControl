using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace webService.Entities
{
    class RateData
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public decimal Value { get; set; }
    }
}
