using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Models
{
    public class Employee
    {
        [Key] public int EmployeeId { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Employee name is a required filed!")]
        public string EmployeeName { get; set; } = String.Empty;

        public string Address { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Employee city is a required field!")]
        public string City { get; set; }

        [MaxLength(10)]
        public string ZipCode { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(200)]
        public string Skillsets { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage = "Employee phone number is a required field!")]
        public string Phone { get; set; } = String.Empty;

        [MaxLength(100)]
        [Required(ErrorMessage = "Employee email is a required field")]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;

        [MaxLength(200)]
        public string Avatar { get; set; }
    }
}