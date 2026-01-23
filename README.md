# METASMERMER – Razor Pages Web Uygulaması

Bu repo, hızlıca bitirilmesi gereken bir işin canlıya alındıktan sonra technical debt olarak adlandırılan sorunlarını, mesleğime duyduğum saygıdan ötürü refactor ederek, yeniden oluşturulma sürecini içerir.

🔗 Canlı Sistem: https://metasmermer.net

---
Projenin ilerleyişi aşağıdaki şekildedir;
- Önce hızlıca çalışan bir sistem geliştirildi
- Canlı ortama alındı
- Teknik borçlar fark edildi
- Ardından proje refactor edilerek katmanlı mimariye taşındı

Bu sürecin **tüm aşamaları bilinçli olarak korunmaktadır**.

---

## 🌿 Branch Yapısı

Bu repository üç ana branch’ten oluşur:

### 🔹 `main` (Bu Branch)
Bu branch **vitrin ve rehber** amaçlıdır.

- Projenin genel hikâyesini açıklar
- Branch’lerin neyi temsil ettiğini anlatır

---

### 🔹 `legacy-branch`
👉 [Legacy branch’i incele](../../tree/legacy-branch)

Bu branch, projenin **ilk canlıya alınan halini** temsil eder.

- Monolitik ve tightly-coupled yapı
- Hızlı teslimat odaklı geliştirme
- Bilinçli olarak kabul edilmiş teknik borçlar
- Üretim ortamında çalışmış gerçek kod

Bu branch’te yer alan README dosyasında,
teknik borçlar ve mimari problemler **açıkça açıklanmıştır**.

---

### 🔹 `refactored-branch`
👉 [Refactor edilmiş branch’i incele](../../tree/refactored-branch)

Bu branch, legacy yapıdan yola çıkılarak yapılan **refactor çalışmasını** içerir.

- Katmanlı mimari (Domain, Application, Infrastructure, Web)
- Sorumlulukların ayrıldığı temiz yapı
- Daha okunabilir ve sürdürülebilir kod tabanı
- Mimari kararların açıklandığı README

Bu branch, projenin **nihai ve önerilen hali**dir.

---

## 🏷 Sürümler (Tag’ler)

- **v1.0-legacy-live**
  - İlk canlıya alınan sürüm
  - Monolitik yapı

- **v2.0-refactored**
  - Refactor edilmiş sürüm
  - Katmanlı mimari

---

## 🛠 Kullanılan Teknolojiler

- ASP.NET Core 9
- Razor Pages
- Entity Framework Core
- SQLite
- Nginx (Reverse Proxy)
- AWS EC2 (Ubuntu Linux)

---

## 🧠 Amaç

Bu repository şunları göstermek için hazırlanmıştır:

- Canlı sistem geliştirme ve yayınlama tecrübesi
- Teknik borcun fark edilmesi ve yönetilmesi
- Mevcut bir kod tabanının refactor edilmesi
- ASP.NET Core ile gerçek dünya uygulaması geliştirme yaklaşımı

---

## 📌 Not

Bu bir demo veya eğitim projesi değildir.  
Gerçek ihtiyaçlar, gerçek kararlar ve zaman içinde yapılan iyileştirmeleri yansıtır.
