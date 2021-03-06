using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementCore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40,ErrorMessage ="Name can not exeed 40 caracteres")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage ="Invalide email acount")]
        public string Email { get; set; }
        [Required]
        public Dpt? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
