using System;
using System.Collections.Generic;
using System.Text;

namespace University.Core.Domain
{
    public class Student
    {

        public String StudentId { get; set; }

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        public String StreetAddress { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        public String ZipCode { get; set; }

        public String PhoneNumber { get; set; }

        public String Email { get; set; }

        public StudentStatus Status { get; set; }

        public Term EnrollmentTerm { get; set; }

    }
}
