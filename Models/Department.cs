using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    internal class Department
    {

        public int ID { get; set; }
        public String DepName { get; set; }

        #region one to one
        //[ForeignKey("Manager")]
        [ForeignKey(nameof(Department.Manager))] //data annotation
        public int empId { get; set; } //fk
        public Employee Manager { get; set; }//navigational prop  
        #endregion

        public List<Employee> employee { get; set; } //relationship one to many

    }
}
