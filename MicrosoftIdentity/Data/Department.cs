﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace MicrosoftIdentity.Data
{
    public partial class Department
    {
        public Department()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DocName { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}