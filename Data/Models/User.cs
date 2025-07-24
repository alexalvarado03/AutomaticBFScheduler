﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFConfigApp.Data.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; } = "";

        public string HashedPassword { get; set; } = "";
    }
}
