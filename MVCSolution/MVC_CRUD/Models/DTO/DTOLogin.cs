using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Models.DTO
{
    public class DTOLoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class DTOLoginResponse
    {
    }
}