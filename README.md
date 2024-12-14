# CrazyMusicians API

Bu proje, bir grup çılgın müzisyeni yönetmek için basit bir ASP.NET Core Web API'sidir. API, CRUD işlemleri (Create, Read, Update, Delete) sağlar ve müzisyenlerin adlarına göre arama yapma yeteneğine sahiptir.

## İçindekiler
- [Giriş](#giriş)
- [Teknolojiler](#teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Endpointler](#endpointler)
- [Çıktı](#çıktı)
- [Lisans](#lisans)

## Giriş

CrazyMusicians API, müzisyen verilerini yönetmek için tasarlanmış bir web API uygulamasıdır. Bu API, müzisyenlerin bilgilerini listeleme, arama yapma, ekleme, güncelleme ve silme gibi işlemleri destekler.

## Teknolojiler
- .NET 7
- ASP.NET Core Web API
- C#

## Kurulum
1. Bu repoyu klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/CrazyMusiciansAPI.git
   ```
2. Proje dizinine gidin:
   ```bash
   cd CrazyMusiciansAPI
   ```
3. Gerekli bağımlılıkları yükleyin ve projeyi çalıştırın:
   ```bash
   dotnet run
   ```

## Kullanım
Proje çalıştırıldığında API'ye aşağıdaki endpointler üzerinden erişebilirsiniz. Postman, Swagger veya başka bir HTTP istemcisi kullanarak test edebilirsiniz.

## Endpointler

### Tüm Müzisyenleri Listele
**GET** `/api/CrayzMusicians`

Bu endpoint, mevcut tüm müzisyenleri döndürür.

#### Örnek İstek
```bash
GET http://localhost:5000/api/CrayzMusicians
```

#### Örnek Yanıt
```json
[
  {
    "id": 1,
    "name": "John Doe",
    "job": "Guitarist",
    "enjoyProperty": "Rock Music"
  },
  {
    "id": 2,
    "name": "Jane Smith",
    "job": "Pianist",
    "enjoyProperty": "Classical Music"
  }
]
```

### Müzisyen Ara
**GET** `/api/CrayzMusicians/search?name={name}`

Adına göre müzisyenleri arar.

#### Örnek İstek
```bash
GET http://localhost:5000/api/CrayzMusicians/search?name=John
```

#### Örnek Yanıt
```json
[
  {
    "id": 1,
    "name": "John Doe",
    "job": "Guitarist",
    "enjoyProperty": "Rock Music"
  }
]
```

### Yeni Müzisyen Ekle
**POST** `/api/CrayzMusicians`

Yeni bir müzisyen ekler.

#### Örnek İstek
```json
POST http://localhost:5000/api/CrayzMusicians
Content-Type: application/json

{
  "id": 3,
  "name": "Michael Jackson",
  "job": "Singer",
  "enjoyProperty": "Pop Music"
}
```

#### Örnek Yanıt
```json
{
  "id": 3,
  "name": "Michael Jackson",
  "job": "Singer",
  "enjoyProperty": "Pop Music"
}
```

### Müzisyen Özelliğini Güncelle
**PATCH** `/api/CrayzMusicians/{id}`

Bir müzisyenin keyfi bir özelliğini günceller.

#### Örnek İstek
```json
PATCH http://localhost:5000/api/CrayzMusicians/3
Content-Type: application/json

"New Enjoy Property"
```

### Müzisyen Güncelle
**PUT** `/api/CrayzMusicians/{id}`

Bir müzisyenin tüm bilgilerini günceller.

#### Örnek İstek
```json
PUT http://localhost:5000/api/CrayzMusicians/3
Content-Type: application/json

{
  "id": 3,
  "name": "Michael Jordan",
  "job": "Basketballer",
  "enjoyProperty": "Basketball"
}
```

### Müzisyen Sil
**DELETE** `/api/CrayzMusicians/{id}`

Belirtilen ID'ye sahip müzisyeni siler.

#### Örnek İstek
```bash
DELETE http://localhost:5000/api/CrayzMusicians/3
```

#### Yanıt
HTTP 204 (No Content)

## Çıktı
Müzisyenlerin listesi veya CRUD işlemleri sonucunda oluşan yanıtlar JSON formatında döner.

## Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakınız.
