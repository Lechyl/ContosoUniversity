using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using ContosoUniversity.Models;


namespace ContosoUniversity.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> instructors { get; set; }
        public IEnumerable<Course> courses { get; set; }
        public IEnumerable<Enrollment> enrollments { get; set; } 
    }
}