using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace ClientWeb.User

{
    // Add profile data for application users by adding properties to the ApplicationUser class
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

        [Display(Name = "تلفن ثابت")]

        public override string PhoneNumber { get; set; }
        [Display(Name = "ایمیل")]

        public override string Email { get; set; }

        [Display(Name = "نام کاربری")]

        public override string UserName { get; set; }

        [Display(Name = "تاریخ ثبت نام")]

        public string RegisterDate { get; set; }
        #region Relations

        #endregion

        public string Image_url => $"/Files/UsersPhoto/{UserPhoto}";
        public string ImageThumb_url => $"/Files/UsersPhoto/Thumb/{UserPhoto}";
    }
}


