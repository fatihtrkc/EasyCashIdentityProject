using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public AppUser()
        {
            CustomerAccounts = new List<CustomerAccount>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string? County { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }
        public int? ConfirmCode { get; set; }

        // Relations
        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
    }
}
