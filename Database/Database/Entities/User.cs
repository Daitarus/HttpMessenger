﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMessenger.Database.Database.Entities
{
    public class User
    {
        public string Name { get; set; }
        public Guid Token { get; set; }
    }
}