﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eticaretwebsite1.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lütfen Adres Giriniz...")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen Şehir Giriniz...")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen İlçe Giriniz...")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen Mahalle Giriniz...")]
        public string Mahalle { get; set; }
        [Required(ErrorMessage = "Lütfen Posta Kodu Giriniz...")]
        public string PostaKodu { get; set; }
    }
}