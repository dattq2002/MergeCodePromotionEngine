using Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.DTOs
{
    public class UserModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public string RoleName { get; set; }
    }

    public class MemberModel
    {
        [Required]
        public string PhoneNumber { get; set; }
    }
}