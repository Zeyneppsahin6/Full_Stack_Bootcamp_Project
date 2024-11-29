# 🎬 Film Yönetim Projesi (ASP.NET Core MVC)

Bu proje, ASP.NET Core MVC kullanarak geliştirilen bir film yönetim uygulamasıdır. Kullanıcılar, film ekleme, listeleme, güncelleme ve silme gibi temel işlemleri gerçekleştirebilir. Ayrıca, filmler kategori bazında görüntülenebilir ve son eklenen filmler ayrı bir sayfada listelenebilir.

---

## 📋 Proje Özellikleri

- **CRUD İşlemleri:** Filmleri ekleme, listeleme, güncelleme ve silme.
- **Kategorilere Göre Filtreleme:** Animasyon, Bilim Kurgu, Dram, Komedi ve Macera kategorilerinde filmleri görüntüleme.
- **Son Eklenen Filmler Sayfası:** En son eklenen filmleri ayrı bir sayfada listeleme.
- **Arama Fonksiyonu:** Navbar üzerinde film adı ile arama yapma.
- **Resim Yükleme:** Filmlere ait posterleri bilgisayardan yükleme ve detay sayfasında görüntüleme.
- **Responsive Tasarım:** Telefon, tablet ve bilgisayar gibi farklı ekran boyutlarına uyumlu görünüm.

---

## 🚀 Kurulum Adımları

1. **Proje Dosyalarını İndirin:**
   git clone https://github.com/Zeyneppsahin6/Full_Stack_Mastery_Bootcamp_Project.git
   cd Full_Stack_Mastery_Bootcamp_Project

2. **Bağımlılıkları Yükleyin:**
   dotnet restore

3. **Veritabanı Yapılandırması:**
   appsettings.json dosyasını açın.

   "ConnectionStrings": {
   "database": "Server=(localdb)\\mssqllocaldb;Database=projeDB;Trusted_Connection=True;"
   }

4. **Veritabanı Oluşturma ve Migrasyon:**
   dotnet ef database update

5. **Projeyi Çalıştırın:**
   dotnet watch run

6. **Tarayıcıdan Erişin:**
   http://localhost:5000

---

## 🛠️ Kullanılan Teknolojiler

- **Backend: ASP.NET Core MVC**
- **Frontend: HTML, CSS, Bootstrap**
- **Veritabanı: Microsoft SQL Server**
- **Araçlar: Visual Studio Code, Entity Framework Core**

---

## 📂 Proje Yapılandırması

proje/
│
├── Controllers/
│   ├── FilmController.cs
│   └── HomeController.cs
│
├── Data/
│   └── DatabaseContext.cs
|
├── Migrations/
│   ├── 20241126235115_InitialCreate.cs
│   ├── 20241126235115_InitialCreateDesign.cs
│   └── DatabaseContextModelSnapshot.cs
|
├── Models/
│   ├── ErrorViewModels.cs
│   ├── Film.cs
│   └── Repository.cs
│
├── Data/
│   ├── DatabaseContext.cs
│   └── FilmRepository.cs
│
├── obj/
│   └── ...
|
├── Properties/
│   └── launchSettings.json
|
├── Views/
│   └── Film/
│       ├── Create.cshtml
│       ├── Delete.cshtml
│       ├── Edit.cshtml
│       ├── Details.cshtml
│       ├── Index.cshtml
│       └── Latest.cshtml
│
├── Home/
│   ├── Index.cshtml
│   └── Privacy.cshtml
|
├── Shared/
│   └── _Layout.cshtml
│   ├── _Layout.cshtml.css
│   ├── _Navbar.cshtml
│   ├── _ValidationScriptsPartial.cshtml
│   └── Error.cshtml
│
├── _ViewImports.cshtml
├── _ViewStart.cshtml
|
├── wwwroot/
│   ├── css/
│       ├── site.cshtml
│       └── styles.cshtml
│   ├── img/
│   ├── js/
│       └── site.js
│   └── lib/
│       └── ...
│
├── appsettings.Development.json
├── appsettings.json
├── Program.cs
├── proje.json
├── proje.sln
├── README.md
└── 

---
