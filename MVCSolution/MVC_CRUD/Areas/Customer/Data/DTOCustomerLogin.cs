using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Areas.Customer.Data
{
    public class DTOLoginRequest
    {
        [Display(Name = "Email/Mobile")]
        public string Email_Mobile { get; set; }

        public string Password { get; set; }
    }

    public class DTOLoginResponse
    {
    }
}