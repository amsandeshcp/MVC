using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Areas.Customer.Data
{
    public class DTOCustomerDetailsRegRequest
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Entery First Name")]
        [MinLength(5), MaxLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [JsonIgnore]
        [Display(Name = "Full Name")]
        public string FullName => this.FirstName + " " + this.LastName;

        [Display(Name = "Email")]
        [MinLength(3)]
        [Required(ErrorMessage = "Please Entery Valid Email Id")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Mobile")]
        [MinLength(10), MaxLength(10)]
        [Required(ErrorMessage = "Please Entery Valid Phone Number")]
        [Phone]
        public string ContactNumber { get; set; }

        [MinLength(5), MaxLength(10)]
        [Required(ErrorMessage = "Please Entery valid password")]
        public string Password { get; set; }
    }
}