﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebRole2.Models
{
    public class RegisterModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string RegistrationId { get; set; }
    }

}