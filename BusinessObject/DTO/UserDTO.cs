﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class UserDTO
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int IsManager { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int IsStaff { get; set; }
    }
}