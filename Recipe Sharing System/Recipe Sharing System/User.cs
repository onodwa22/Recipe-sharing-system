﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe_Sharing_System
{
    public class User
    {
        public string Username{get; set;}
        public string Password { get; set;}
        public string Email { get; set;}

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
