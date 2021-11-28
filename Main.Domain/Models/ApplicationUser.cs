using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Main.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
                
        }
        [StringLength(200)]
        [Required]
        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }
        [Display(Name = "تصویر پروفایل")]

        public string UserPhoto { get; set; }

        [Display(Name = "تلفن همراه")]
        [StringLength(12)]
        public string Mobile_1 { get; set; }

    }
}
