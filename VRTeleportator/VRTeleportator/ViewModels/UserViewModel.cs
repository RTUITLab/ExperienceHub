﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VRTeleportator.Models;

namespace VRTeleportator.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public List<UserLessons> Lessons { get; set; }


    }
}