﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }

        // Relations
        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
    }
}
