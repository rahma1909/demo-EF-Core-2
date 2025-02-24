using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    //if i have attr relationship
    internal class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        //public List<Student> Students { get; set; }
        //public List<Course> courses { get; set; }
        public double Grade { get; set; }
    }
}
