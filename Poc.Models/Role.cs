using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [MaxLength(30)] public string RoleName { get; set; }

        [MaxLength(300)] public string RoleDescription { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}