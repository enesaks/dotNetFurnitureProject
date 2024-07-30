# .Net Furniture Project

**dotNetFurnitureProject**, ASP.NET Core 6.0 MVC kullanarak hazırladığımız kapsamlı bir mobilya web uygulamasıdır. Kullanıcılar, mobilya ürünleri görüntüleyebilir ve mesaj gönderebilir. Yönetici paneli kullanarak mobilya ürünleri ekleme, silme, güncelleme ve kategori yönetimi gibi CRUD işlemlerini gerçekleştirebilirsiniz. 

**Projede Kullandığım Teknolojiler:**
- ASP.NET Core 6.0 MVC
- Entity Framework Core
- LINQ
- PostgreSQL
- SweatAlert

## Çalıştırma Talimatları

### Gereksinimler
- [Furniture Project](https://github.com/enesaks/dotNetFurnitureProject) 
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) veya üzeri
- [PostgreSQL](https://www.postgresql.org/download/) veritabanı sunucusu

### Kurulum

1. **Depoyu Klonlayın**

```bash
git clone https://github.com/enesaks/dotNetFurnitureProject.git
```

2.	**Proje Dizini İçine Girin**

  ```bash
  cd dotNetMenuProject
```
3.	**Bağımlılıkları Yükleyin**
 ```bash
   dotnet restore
```
4.	**Veritabanını Uygulayın**
   •	PostgreSQL veritabanınızı oluşturun ve bağlantı dizesini yapılandırma dosyanıza ekleyin. Context dosyasındaki [optionsBuilder.UseNpgsql](https://github.com/enesaks/dotNetFurnitureProject/blob/main/dotNetFurnitureProject/DataAccess/Context/FurnitureContext.cs) kısmını uygun veritabanı bağlantı dizesi ile güncelleyin.
  	
5.	**Veritabanı Göçlerini Uygulayın**
 ```bash
   dotnet ef database update
```

Bu talimatları takip ederek projeyi kolaylıkla çalıştırabilirsiniz.

**Proje Ressimleri**
<img width="1470" alt="Ekran Resmi 2024-07-30 20 31 16" src="https://github.com/user-attachments/assets/efd997cb-0058-495e-adc5-48da454b2ba5">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 31 29" src="https://github.com/user-attachments/assets/1fe81e68-9e20-4e7e-ac9c-046c4307f146">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 31 38" src="https://github.com/user-attachments/assets/e2e0d772-a7b4-446b-b79f-f7fde8e2e240">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 31 46" src="https://github.com/user-attachments/assets/3966c27b-84ab-4d16-a0ef-69e4a7052c94">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 31 58" src="https://github.com/user-attachments/assets/a6fcb6c4-76d2-4924-aeb9-53c0fb7ab406">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 32 07" src="https://github.com/user-attachments/assets/deba9623-5435-47db-8c4d-d5664664df29">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 32 14" src="https://github.com/user-attachments/assets/3765e5fd-e761-4362-95a8-8a8731e6f7d2">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 32 23" src="https://github.com/user-attachments/assets/4efd2225-9963-4201-9a95-a0dc1aa09e3e">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 32 48" src="https://github.com/user-attachments/assets/bdee155d-8c53-4453-97d1-5a66e97dd0ab">
<img width="1470" alt="Ekran Resmi 2024-07-30 20 33 02" src="https://github.com/user-attachments/assets/6aba536b-48d3-4ac6-b582-84616d9f1d12">
<img width="1143" alt="Ekran Resmi 2024-07-30 20 36 12" src="https://github.com/user-attachments/assets/a3102107-a07c-4d21-8660-ba42df3b56fc">
