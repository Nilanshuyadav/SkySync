﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Entities.Models
{
    public class Login
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }

}
