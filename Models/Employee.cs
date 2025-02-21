using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    internal class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //[InverseProperty(nameof(department.Manager))]
        public Department? department { get; set; }
    }
}
