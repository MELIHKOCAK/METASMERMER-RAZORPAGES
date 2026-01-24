# METASMERMER – RAZOR WEB PAGES UGULAMASI - LEGACY

Bu branch, projenin **ilk canlıya alınan halini** temsil eder, Bu branch’te yer alan README dosyasında, teknik borçlar ve mimari problemler **açıkça açıklanmıştır**.

🔗 Canlı Sistem: https://metasmermer.net

---
Projenin mevcut klasör yapısı;
```
📦 RazorPages.Deneme
wwwroot
│  ├─ css
│  │  ├─ admin.css
│  │  ├─ all.min.css
│  │  └─ site.css
│  ├─ fonts/
│  ├─ img
│  │  ├─ gallery/
│  │  ├─ anagoruntu.webp
│  │  ├─ .
│  │  ├─ .
│  │  └─ WhatsApp.svg
│  ├─ js
│  │  └─ site.js
│  ├─ webfonts/
│  └─ favicon.ico
├─ EFCORE
│  ├─ About.cs
|  ├─ AboutDetails.cs
│  ├─ Contact.cs
│  ├─ DenemeDbContext.cs
│  ├─ Footer.cs
│  ├─ Gallery.cs
│  ├─ Hero.cs
│  ├─ Services.cs
│  ├─ Users.cs
│  └─ Whatsapp.cs
├─ Migrations/
├─ Pages
│  ├─ Admin
│  │  ├─ _ViewStart.cshtml
│  │  ├─ About.cshtml
│  │  ├─ Contact.cshtml
│  │  ├─ Dashboard.cshtml
│  │  ├─ Footer.cshtml
│  │  ├─ GalleryImageAdd.cshtml
│  │  ├─ GalleryImageDelete.cshtml
│  │  ├─ Hero.cshtml
│  │  ├─ Logout.cshtml
│  │  ├─ Services.cshtml
│  │  └─ Whatsapp.cshtml
│  ├─ Shared
│  │  ├─ _AdminLayout.cshtml
│  │  └─ _Layout.cshtml
│  ├─ _ViewImports.cshtm
│  ├─ _ViewStart.cshtml
│  ├─ AdminIndex.cshtml
│  ├─ Error.cshtml
│  ├─ Galeri.cshtml
│  └─ Index.cshtml
├─ appsettings.json
├─ Program.cs
└─ realMyDb.db
```
---
* Klasör yapısı incelendiğinde bir mimari esas alınmadığı açıkca ortadadır. Bunun getirisi olarak da karmaşıklık ortaya çıkıyor. Bunu gidermek içinde **Separation Of Corners** temelinde **Katmanlı Mimari** tercih edilerek proje refactor edilecektir.
---
* Projede veriye EF Core üzerinden erişirken her sayfada aynı neredeyse aynı kodlar yazılmıştır, bu durumda **DRY** prensibine aykırı olduğu için projede **Repository Pattern** uygulanacaktır.
---
* Projede nesne üretimleri, **Dependency Injection** tasarımı dışında oluşturulmuştur. Bu da projede **Tight Coupling** oluşturarak değişime karşı direnç gösteriyor aynı zamanda da nesnelerin yaşam döngüsü **Garbage Collector'a** bırakılıyor, haliyle beklenmedik performans düşüşleri ile karşılaşılabilir.

  BAKINIZ;
  ```  
  public class HeroModel : PageModel
  {
      public DenemeDbContext context = new();

      [BindProperty]
      public string _CompanyName { get; set; }

      public void OnPostUpdateCompanyName()
      {
          var companyName = context.Heros.FirstOrDefault();
          companyName.CompanyName = _CompanyName;
          context.SaveChanges();
          RedirectToPage();
      }

      public void OnGet()
      {
      }
  }
  ```
---
 * Proje genelinde senkron yapı kullanıldığı için uygulama canlı da yüksek trafik ile karşılaştığında yavaşlama kaçınılmaz olacaktır. O yüzden senkron işlemler asenkron işlemlerlerle değiştirilecektir.
 ---
* Projenin herhangi bir bölümünde **Input Validation**, **Database Validation** gibi validasyonlar bulunmamaktadır. Bu durumda uygulamayı canlıda tehlikeye atmaktadır.

  Aşağıda bulunan kod bloğunda view tarafından gelen verilerin boş olma durumu söz konusu olabilir bu durumun engellenmesi gerekmektedir. Bakınız;

  ```
  public class FooterModel : PageModel
  {
      public DenemeDbContext context = new();
      
      [BindProperty]
      public string _NewFacebookLink { get; set; }

      [BindProperty]
      public string _NewInstagramLink { get; set; }

      public void OnGet()
      {
      }

      public void OnPostUpdateFooter()
      {
          var footer = context.Footer.FirstOrDefault();
          footer.FacebookLink = _NewFacebookLink;
          footer.InstagramLink = _NewInstagramLink;
          context.SaveChanges();
          RedirectToPage();
      }
  }
  ```
---
* Projede anlanmalı isimlendirmeler yapılmamıştır, bunlar açıklayıcı anlamlı isimlerle değiştirilecektir. Bakınız;
```
public class FooterModel : PageModel
{
    public DenemeDbContext context = new();
    .
    .
}
```
---
* Projede **SQL Connection** bilgisi **Context** sınıfının içerisinde static olarak tutulmaktadır, eğer database dosyasının yeri değişirse proje tekrardan compile edilmesi gerekmekte, bu bağımlılıktan kurtulmak içinde **SQL Connection** bilgisi harici bir dosyada tutulacaktır.
---
* Projede **.cshtml** sayfalarında HTML etiketleri arasında C# kod kullanımı mevcuttur, bu da yapının okunabilirliğini azalmakta. Kod İşlemleri arka planda yapılarak kullanıcıya sadece değerler gösterilecektir. Bakınız;
```
@page
@model RazorPages.Deneme.Pages.Admin.HeroModel
@{
    var companyName = Model.context.Heros.FirstOrDefault()!.CompanyName;
}
<style>
    .mb20px {
        margin-bottom: 20px;
    }
</style>

<div id="content">
    <!-- Bu Template Üzerine Diğer Sayfalarınıda 

    Tasarla Unutma Bir Form İçerisinde olmalılar. asp-for ve asp-page-handler tag helperlarını iyi araştır -->
    <form method="post">
        <div class="mb20px" id="mevcutDeger">
            <label for="">Mevcut Şirket İsmi: " <u>@companyName</u> "</label>
        </div>

        <div class="mb20px" id="yeniDeger">
            <label>Yeni Şirket İsmi: </label>
            <input asp-for="_CompanyName" type="text" name="_CompanyName" placeholder="Şirket İsmini Giriniz...">
        </div>

        <div id="confirm">
            <input asp-page-handler="UpdateCompanyName" type="submit" id="cta" value="ONAYLA">
        </div>
    </form>
</div>
```
---
* Projede Css dosyalarındaki gereksiz seçiciler, Media Queryler ve tek bir Css dosyası üzerinden bütün site arayüzünü biçimlendirmeğe çalışmak, benim **CSS HELL** olarak isimlendirdiğim bir cehenneme dönüşerek muhteşem bir karmaşıklık oluşturmakta. 

  Bu duruma karşı daha anlamlı isimlendirme yaparak, Css dosyalarına sayfalara göre ayırarak, **SCSS** ön işlemcisinin özelliklerini kullanarak ve utility-first yaklaşımı ile **Tailwind** kullanarak önüne geçilecektir.
