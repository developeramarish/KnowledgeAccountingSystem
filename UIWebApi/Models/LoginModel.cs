﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UIWebApi.Models
{
    public class LoginModel
    {
        //[Required]
        public string Email { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}