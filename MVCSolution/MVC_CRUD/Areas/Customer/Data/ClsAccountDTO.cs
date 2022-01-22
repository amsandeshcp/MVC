using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Areas.Customer.Data
{
    public class ClsAccountDTO
    {
        public DTOLoginRequest LoginRequest { get; set; }
        public DTOCustomerDetailsRegRequest SignUpRequest { get; set; }
    }

    public class ClsAccountForgetPasswordRequest
    {
        [Display(Name = "Email/Mobile")]
        [Required(ErrorMessage = "Please Enter valid Mobile number or email ID.")]
        [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 10)]
        public string Email_Mobile { get; set; }
    }
}