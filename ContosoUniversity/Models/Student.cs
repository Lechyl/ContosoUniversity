using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [MinLength(2)]
        [StringLength(50, ErrorMessage = "Names cannot be longer than 50 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First Character has to be First Letter")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [MinLength(2)]
        [StringLength(50, ErrorMessage = "Names cannot be longer than 50 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First Character has to be First Letter")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}