using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nepak.Datalayer.Entities.Account
{
    [Display(Name = "كاربران")]
    public class User
    {
        public User()
        {
            
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string UserName { get; set; }

        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }


        #region Relation

         public ICollection<UserRole> UserRole { get; set; }

        #endregion
       

    }

}

