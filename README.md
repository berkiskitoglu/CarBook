# 🚗 CarBook - Araç Kiralama Projesi

## Proje Hakkında

CarBook, kullanıcıların araç kiralama işlemleri yapabileceği, araçların detaylarına ulaşabileceği, lokasyona göre fiyatları görüntüleyebileceği ve kiralama işlemlerini kolayca gerçekleştirebileceği bir platformdur. Admin paneli üzerinden araçlar, lokasyonlar, bloglar, referanslar ve diğer içerikler yönetilebilir. Ayrıca, kullanıcılar araçlarla ilgili yorumlar yapabilir ve bu yorumları inceleyebilirler.

Bu proje, ASP.NET Core 9.0 Web API ve MVC ile geliştirilmiştir ve Onion Architecture mimarisi kullanılarak yapılandırılmıştır. CQRS, Mediator, Repository design pattern'ları ile uygulamanın sürdürülebilirliği ve ölçeklenebilirliği artırılmıştır. JWT, SignalR ve FluentValidation gibi teknolojiler ile güvenlik, canlı veri takibi ve doğrulama işlemleri yapılmaktadır.

## 💻 Kullanılan Teknolojiler

- **ASP.NET Core 9.0 - Web API ve MVC**
- **MSSQL - Veritabanı yönetimi**
- **Stored Procedure Kullanımı**
- **Entity Framework Code First - ORM aracı**
- **SignalR - Gerçek zamanlı veri iletişimi**
- **Json Web Token (JWT) - Kullanıcı kimlik doğrulama ve güvenliği**
- **Postman - API test aracı**
- **HTML, CSS, JavaScript, Bootstrap - Frontend teknolojileri**
- **Onion Architecture - Mimari yapı**
- **CQRS - Command Query Responsibility Segregation**
- **Mediator - İç iletişim yönetimi**
- **Repository Design Pattern - Veritabanı işlemlerinin yönetimi**

## ✅ Öne Çıkan Özellikler

- **Lokasyona Göre Araç Filtreleme ve Kiralama**: Kullanıcılar, araçları lokasyona göre filtreleyip kiralayabilirler.
- **Araç Detaylarını Görüntüleme**: Seçilen aracın tüm özellikleri ve fiyat bilgisi gösterilebilir.
- **Admin Paneli**: Admin, araç bilgilerini, lokasyonları, blogları, referansları ve diğer içerikleri yönetebilir.
- **SignalR ile Canlı Veri Takibi**: Gerçek zamanlı veri takibi ve bildirimler.
- **JWT ile Kimlik Doğrulama**: Kullanıcı güvenliği sağlanır.
- **İstatistik ve Dashboard**: Admin panelinde proje ile ilgili detaylı istatistik ve grafikler.
- **Yabancı Dil Desteği**: Çok dilli kullanım desteği.

## 🛠️ Teknik Özellikler

- **MSSQL Veritabanı**: SQL Server, veritabanı yönetimi ve işlemleri için kullanılmıştır. Güçlü veri tutarlılığı ve işlem desteği sunar.
- **ASP.NET Core 9.0**: Uygulama backend'i, yüksek performans ve modüler yapı sağlayan ASP.NET Core 8.0 ile geliştirilmiştir.
- **Postman**: API dokümantasyonu ve test işlemleri için  Postman kullanılarak API'lerin doğruluğu ve işlevselliği sağlanmıştır.
- **Onion Architecture**: Uygulama, bağımsız katmanlar ve açık veri akışları kullanılarak tasarlanmış, bakım ve genişletilebilirlik açısından güçlü bir yapı oluşturulmuştur.
- **CQRS ve Mediator**: Komut ve sorguların ayrılması ile daha etkili veri yönetimi sağlanmış, uygulama içindeki iş akışları Mediator desenini kullanarak düzenlenmiştir.
- **SignalR**: Gerçek zamanlı veri aktarımı için SignalR entegrasyonu gerçekleştirilmiş, kullanıcı etkileşimi anlık olarak güncellenmiştir.
- **Json Web Token (JWT)**: Kullanıcı güvenliğini sağlamak amacıyla, kimlik doğrulama işlemleri JWT ile yapılmış, güvenli erişim sağlanmıştır.

## 🖼️ Proje Görselleri
![](https://github.com/berkiskitoglu/CarBook/blob/master/img/veritabani.png)
![](https://github.com/berkiskitoglu/CarBook/blob/master/anasayfa.png)
![](https://github.com/berkiskitoglu/CarBook/blob/master/img/arac-2.png)
![](https://github.com/berkiskitoglu/CarBook/blob/master/img/arac-3.png)
![](https://github.com/berkiskitoglu/CarBook/blob/master/img/arac-4.png)
![](https://github.com/berkiskitoglu/CarBook/blob/master/img/arac-5.png)
![](https://github.com/berkiskitoglu/CarBook/blob/master/img/arac-6.png)

