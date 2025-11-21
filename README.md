# 📚 E-Ticaret Web Sitesi (Kitap Satış) - ASP.NET MVC

Bu proje, ASP.NET MVC mimarisi kullanılarak geliştirilmiş, kitap satışı odaklı bir e-ticaret web uygulamasıdır. Kullanıcılar ürünleri görüntüleyebilir, sepete ekleyebilir, hesap oluşturabilir ve sipariş verebilir. Yönetici paneli ile ürün, kategori ve sipariş yönetimi yapılabilmektedir.

---

## 🚀 Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| **ASP.NET MVC** | Web uygulaması mimarisi |
| **Entity Framework** | ORM ve veri erişimi |
| **SQL Server** | Veritabanı |
| **ASP.NET Identity** | Kullanıcı kimlik doğrulama ve rol yönetimi |
| **Bootstrap** | Arayüz tasarımı |
| **C#** | Backend programlama dili |

---

## 📂 Proje Yapısı

### **🧭 Controllers**
- `HomeController` – Ana sayfa ve genel sayfalar
- `ProductController` – Ürün listeleme ve detay
- `CartController` – Sepet işlemleri
- `OrderController` – Sipariş oluşturma ve görüntüleme
- `AccountController` – Giriş / Kayıt işlemleri
- `AdminController` – Yönetici paneli işlemleri
- `CategoryController` – Kategori yönetimi

### **🗃 Models**
- `Product`, `Category`, `Order`, `OrderState`
- Kullanıcı modelleri: `ApplicationUser`, `ApplicationRole`
- View modelleri: `Login`, `Register`, `OrderDetails`, `UserProfile`

### **🔐 Identity**
Kullanıcı kayıt, rol tanımı ve giriş işlemleri ASP.NET Identity üzerinden yapılır.

Rol örnekleri:
- **Admin**
- **User**

### **👤 Kullanıcı Özellikleri**
- Ürün inceleme
- Sepete ekleme / silme
- Sipariş oluşturma
- Kullanıcı profil sayfası

### **🛠 Admin Özellikleri**
- Ürün ekleme / düzenleme / silme
- Kategori yönetimi
- Sipariş takibi
- Kullanıcı yönetimi
