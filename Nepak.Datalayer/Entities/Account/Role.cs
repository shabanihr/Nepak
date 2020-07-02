using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nepak.Datalayer.Entities.Account
{
    [Display(Name = "گروه كاربري")]
    public class Role
    {
        public Role()
        {
            
        }
       

        [Key]
        public int Id { get; set; }

        [Display(Name = "نام گروه کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RoleName { get; set; }



        #region Relation

        public virtual ICollection<UserRole> UsersRoles { get; set; }
        public ICollection<RoleAccesses> RoleAccesses { get; set; }

        #endregion
    }
}
