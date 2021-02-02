using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inheritance13.Models
{
    public class PersonalDetail
    {
        public PersonalDetail()
        {

        }

        public int PersonalDetailId { get; set; }

        [DisplayName("First Name")]
        [Required]
        [MaxLength(20), MinLength(3)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Required]
        [MaxLength(50), MinLength(5)]
        public string Address { get; set; }


        public Nullable<int> Age { get; set; }

        [DisplayName("Profession")]
        [Required]
        [MaxLength(50), MinLength(5)]
        public string Occupation { get; set; }
        public decimal Weight { get; set; }
        public DateTime DOB { get; set; }

        [DisplayName("Profile Image")]
        public string ImageLocation { get; set; }

        public string ErrorMsg { get; set; }
    }

    public class DoctorProfile : PersonalDetail
    {

        public DoctorProfile(List<PersonalDetail> persons) : base()
        {
        }
        public string Qualification { get; set; }
        public string HospitalClinic { get; set; }
        public string Speciality { get; set; }

    }
    public class TeacherProfile : PersonalDetail
    {
        public TeacherProfile(List<PersonalDetail> persons) : base()
        {
        }
        public string Qualification { get; set; }
        public string College { get; set; }
        public string AssociatedSubjects { get; set; }
    }
    public class StudentProfile : PersonalDetail
    {
        public StudentProfile(List<PersonalDetail> persons) : base()
        {
        }
        public string Faculty { get; set; }
        public string College_School { get; set; }
        public string Rollno { get; set; }

    }



}