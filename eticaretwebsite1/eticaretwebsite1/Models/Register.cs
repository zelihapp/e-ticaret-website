﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eticaretwebsite1.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string Username { get; set; }
        [Required]
        [DisplayName("Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Geçersiz Email Adresi Girildi!")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Girilen Şifreler Aynı Değil")]
        [DisplayName("Şifreniz Tekrar")]
        public string RePassword { get; set; }
    }
}