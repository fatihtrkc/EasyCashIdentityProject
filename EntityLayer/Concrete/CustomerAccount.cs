﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public CustomerAccount()
        {
            CreationDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string AccountNo { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public string BankBranch { get; set; }
        public DateTime CreationDate { get; set; }

        // Relations
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
