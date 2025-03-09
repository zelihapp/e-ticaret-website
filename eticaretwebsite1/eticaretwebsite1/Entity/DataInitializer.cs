using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eticaretwebsite1.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="EDEBIYAT KITAPLARI", Description="EDEBIYAT KITAPLARI ÜRÜNLERI"},
                new Category() {Name="COCUK KITAPLARI", Description="COCUK KITAPLARI ÜRÜNLERI"},
                new Category() {Name="BILIM VE MUHENDISLIK KITAPLARI", Description="BILIM VE MUHENDISLIK ÜRÜNLERI"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() {Name="Insanligimi Yitirirken",Description="Edebiyat Kitaplari Urunleri",Price=36.30,Stock=125,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,image="1.jpg"},
                new Product() {Name="Bu Ne Bicim Pinokyo",Description="Cocuk Kitaplari Urunleri",Price=82.95,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,image="2.jpg"},
                new Product() {Name="Uzaya Giden Tren",Description="Cocuk Kitaplari Urunleri",Price=49.70,Stock=300,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=2,image="3.jpg"},
                new Product() {Name="Bilim Tarihi",Description="Bilim Ve Muhendislik Urunleri",Price=69.60,Stock=500,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,image="4.jpg"}
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}