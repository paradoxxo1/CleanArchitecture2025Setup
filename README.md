İşte düzeltilmiş ve yeniden düzenlenmiş README dosyası. Açıklamaları daha akıcı ve doğal bir şekilde Türkçe olarak yeniden yazdım ve GitHub linkini belirttiğiniz şekilde güncelledim:

---

# 2025 Yılı Clean Architecture Kurulumu

Bu depoda, 2025 yılı projelerinizde başlangıç noktası olarak kullanabileceğiniz, güncel, modüler ve temiz bir Clean Architecture yapısı sunulmaktadır. Modern yazılım geliştirme pratiklerini destekleyen bu yapı, projelerinizi düzenli ve ölçeklenebilir bir şekilde geliştirmenize olanak tanır.

![Animasyon Açıklaması](https://miro.medium.com/v2/resize:fit:640/format:webp/0*-zb6YNGuvWK7-EAb.gif)


## Proje Detayları

### Mimari Yapı
- **Mimari Desen**: Clean Architecture
- **Tasarım Desenleri**:
  - Result Pattern (Sonuç Deseni)
  - Repository Pattern (Depo Deseni)
  - CQRS Pattern (Komut ve Sorgu Ayrımı Deseni)
  - UnitOfWork Pattern (İş Birimi Deseni)

### Kullanılan Kütüphaneler
- **MediatR**: CQRS uygulamaları ve mesajlaşma işlemleri için.
- **TS.Result**: Standartlaştırılmış sonuç modelleri oluşturmak için.
- **Mapster**: Nesneler arası eşleme işlemleri için.
- **FluentValidation**: Doğrulama süreçlerini kolaylaştırmak için.
- **TS.EntityFrameworkCore.GenericRepository**: Genel repository işlemleri için.
- **EntityFrameworkCore**: Veritabanı ile nesne ilişkisel eşleme (ORM) için.
- **OData**: Esnek sorgulama ve veri erişimi sağlamak için.
- **Scrutor**: Bağımlılık enjeksiyonu yönetimi ve dinamik servis kaydı için.
- **Microsoft.AspNetCore.Authentication.JwtBearer**: Kimlik doğrulama işlemleri için.

## Kurulum ve Kullanım
1. **Depoyu Klonlayın**:
   ```bash
   git clone https://github.com/paradoxxo1/CleanArchitecture2025Setup.git
   cd CleanArchitecture2025Setup
   ```

---


