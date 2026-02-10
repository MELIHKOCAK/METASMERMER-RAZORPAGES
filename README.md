# METASMERMER – RAZOR WEB PAGES UGULAMASI - REFACTORED

Bu branch, projenin **Refactor Edilme Sürecini** temsil eder, Bu branch’te yer alan README dosyasında, refactor süreci anlatılmaktadır.

🔗 Canlı Sistem: https://metasmermer.net

---
Web Site Aktörleri;

![Web Sitede Bulunan Aktörler](https://github.com/user-attachments/assets/645ac5d2-aea5-4eb3-886b-b62517db1138)

```
📦 MetasMermer
├─ MetasMermer.sln
├─ MetasMermer.Repository
│  ├─ MetasMermer.Repositories.csproj
│  ├─ Extensition/
│  ├─ Migrations/
│  ├─ GenericRepository.cs
│  ├─ IGenericRepository.cs
│  ├─ IUnitOfWork.cs
│  ├─ UnitOfWork.cs
│  ├─ BaseEntity.cs
│  └─ EFCORE
│       ├─ MetasMermerDbContext.cs
│       ├─ Abouts
│       *      ├─ About.cs
│       *      └─ AboutConfig.cs
│       *
│       └─ Whatsapps
│              ├─ Whatsapp.cs
│              └─ WhatsappConfig.cs
├─ MetasMermer.Services
│  ├─ MetasMermer.Services.csproj
│  ├─ Extensition/
│  ├─ ServiceAssembly.cs
│  ├─ Abouts
|  *    ├─ IAboutService.cs
|  *    ├─ AboutService.cs
│  *    ├─ AboutDto.cs
│  *    ├─ AboutDtoValidator.cs
│  *    └─ Update
│  *          └─ UpdateAboutDto.cs 
|  *
│  └─ Whatsapps
│       ├─ IWhatsappService.cs
|       ├─ WhatsappService.cs
│       ├─ WhatsappDto.cs
│       ├─ WhatsappDtoValidator.cs
│       └─ Update
│             └─ UpdateWhatsappDto.cs
└─ MetasMermer.UI
   ├─ MetasMermer.UI.csproj
   ├─ appsettings.Development.json
   ├─ appsettings.json
   ├─ package.json
   ├─ metasmermer.db
   ├─ Properties/
   ├─ Program.cs
   ├─ Pages
   │  ├─ Error.cshtml
   │  ├─ Gallery.cshtml
   │  ├─ Index.cshtml
   │  ├─ Sitemap.cshtml
   │  ├─ Admin
   │  │     ├─ About.cshtml
   │  │     *
   │  │     *
   │  │     *
   │  │     └─ _ViewStart.cshtml
   │  └─ Shared
   │        ├─ _AdminLayout.cshtml
   │        ├─ _Layout.cshtml
   │        ├─ _Navbar.cshtml
   │        ├─ _Projects.cshtml
   |        ├─ _ViewImports.cshtml
   │        ├─ _ViewStart.cshtml
   │        └─ Components
   │              ├─ About
   │              *     ├─ Default.cshtml
   │              *     └─ AboutViewComponent.cs
   │              *
   │              └─ Whatsapp
   │                    ├─ Default.cshtml
   │                    └─ WhatsappViewComponent.cs
   └─ wwwroot
      ├─ fonts/
      ├─ img/
      ├─ favicon.ico
      ├─ javascript
      │   └─ site.js
      ├─ css
      │   ├─ admin.css
      │   ├─ main.css
      │   └─ main.css.map
      └─ scss
          ├─ main.scss
          ├─ vendors
          ├─   └─ _all.min.css
          ├─ abstracts
          │    ├─ _mixin.scss
          │    └─ _variables.scss
          ├─ base
          │    ├─ _base.scss
          │    └─ _typography.scss
          └─ components
               ├─ _about.scss
               *
               *
               *
               └─ _whatsapp.scss
```

---
* Projede **Katmanlı Mimari** alınarak tekrardan düzenlendi. **Fonksiyonel** bazlı klasörleme tercih edildi.
---
* Projede veriye erişim teknolojisinde ORM aracı olan **EF Core** Kullanılmıştır. Veriler **DATA ACCES LAYER** katmanında **Repository Pattern** ve **UnitOfWork Pattern** uygulanarak elde edilip, hiç bir işlem yapılmadan direkt SERVICE katmanına aktarılmıştır.
---
* Projede gerekli nesne üretimleri ilgili sınıflarda Primary Constructor yöntemiyle **Dependency Injection** ile oluşturulmuştur. Yerleşik olarak gelen **IOC** kullanılmıştır.
---
* Projede Program.cs dosyası falza şişirilmeden gerekli konfigürasyon ayarları extensition metodlar ile sağlanmıştır.
---
 * Proje tamamen asenkron yapı üzerine inşaa edilmiştir.
---
 * Projede **Fluent Validation** kullanılarak hatalar önlenmeye çalışıldı.
---
 * Projede DTO Eşleştirmede  **Mapster** kütüphanesi tercih edilmiştir.
---
 * Projede Anlamlı İsimlendirmeler Kullanılarak Okunabilirlik Artırılmıştır.
---
 * Projede **SCSS** kullanılarak 1000 satırı aşan CSS dosyaları anlamlı klasörlere ve parçalara ayrılarak daha yönetilebilir şekilde düzenlendi.
---
 * Projede **ViewComponent** Ve **Partial View** Kullanılarak HTML sayfalarında daha iyi bir düzen sağlanmıştır.
