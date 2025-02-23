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

        #region one to one
        [InverseProperty(nameof(department.Manager))]
        public Department? department { get; set; }
        #endregion

        #region one to many
        [InverseProperty(nameof(department.employee))]
        public int? workforID { get; set; }// (fk)
  
        public Department? workfor { get; set; } //nav prop  
        #endregion
    }
}
