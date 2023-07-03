﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjectLayer.Dtos.AppUserDtos
{
    public class AppUserSignUpDto
    {
        //[Required(ErrorMessage ="This field is required.")]
        //[Display(Name ="Name :  ")]
        //[MaxLength(30, ErrorMessage ="Max 30 characters can be entered.")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
    }
}