using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nepak.Datalayer.Entities.Account
{
    [Display(Name = "دسترسي كاربران")]
    public class UserRole
    {
        public UserRole()
        {

        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "آدي كاربر")]
        public int UserId { get; set; }

        [Display(Name = "آی دی گروه كاربری")]
        public int RoleId { get; set; }


        #region Relation

        public Role Role { get; set; }
        public User User { get; set; }

        #endregion


    }
}
