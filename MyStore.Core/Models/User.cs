﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Adress Adress { get; set; }
    }
}
