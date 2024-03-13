using Exceptions_Homework.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Models
{
    public class Customer: BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age {  get; set; }
    }
}
