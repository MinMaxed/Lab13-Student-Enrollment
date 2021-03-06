﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    public class Course
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int MaxStudents { get; set; }
  
    }
}
