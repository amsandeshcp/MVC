using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;

namespace MVC_CRUD.Areas.Customer.Data
{
    public class DTOLoginRequest
    {
        [Display(Name = "Email/Mobile")]
        [Required(ErrorMessage = "Please Enter valid Mobile number or email ID.")]
        [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 10)]
        public string Email_Mobile { get; set; }

        [Required(ErrorMessage = "Please Enter valid Password")]
        [StringLength(20, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class DTOLoginResponse
    {
        public dynamic MSG { get; set; }
        public dynamic Data { get; set; }
        public HttpStatusCode Code { get; set; }
    }
}