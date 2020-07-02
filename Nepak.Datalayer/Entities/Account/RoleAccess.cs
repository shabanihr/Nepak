using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nepak.Datalayer.Entities.Account
{
    [Display(Name = "دسترستی گروه كاربری")]
    public partial class RoleAccess
    {
        public RoleAccess()
        {

        }
        public int Id { get; set; }

        [Display(Name = "كنترلر")]
        public string Controller { get; set; }

        [Display(Name = "اكشن")]
        public string Action { get; set; }

        [Display(Name = "آی دی رول")]
        public int RoleId { get; set; }


        #region MyRegion
        public Role Role { get; set; }

        #endregion

    }
}
