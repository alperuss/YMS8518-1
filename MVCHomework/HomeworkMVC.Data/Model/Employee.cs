using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeworkMVC.Data.Model
{
    public class Employee
    {

    public int Id { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Name { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string SurName { get; set; }
        [Required,Range(18,70)]
    public int Age { get; set; }
    }
}

