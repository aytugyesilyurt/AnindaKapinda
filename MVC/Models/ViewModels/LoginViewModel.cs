﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models.ViewModels
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
