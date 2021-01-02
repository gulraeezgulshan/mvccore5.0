using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName ="nvarchar(150)")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string CNIC { get; set; }

        public DateTime DOB { get; set; }

    }
}
