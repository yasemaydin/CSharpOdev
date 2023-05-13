# C# Proje Ödevi

Projede 4 tane arabirim ve 4 tane sınıf kullandım.

### Arabirimler
* ILokasyon
* IMusteri
* IRezervasyon
* IUcak

### Sınıflar
* Lokasyon
* Musteri
* Rezervasyon
* Ucak

#### ILokasyon
* Lokasyon bilgileri için gerekli olan alanlar (kalkış yeri ve varış yeri) ve lokasyon oluşturmak için kullanılan bir metod var.

#### IMusteri
* Müşteri bilgileri için gerekli olan alanlar (T.C. Kimlik Numarası, ad, soyad, telefon, yaş, cinsiyet, engel) ve müşteri oluşturmak için kullanılan bir metod var.

#### IRezervasyon
* Rezervasyon bilgileri için gerekli olan alanlar (bilet numarası, ücret, uçuş tarihi, koltuk numarası) var.

#### IUcak
* Uçak bilgileri için gerekli olan alanlar (kod, kapasite) ve uçak oluşturmak için kullanılan bir metod var.

#### Lokasyon
* lokasyonlar dizisine verileri eklemek ve kullanıcının seçim yapması için gerekli olan metodları içerir.

#### Musteri
* Müşteri bilgilerini kullanıcıdan almak, veri tiplerini ve boyutlarını kontrol etmek için gerekli olan metodları içerir.

#### Rezervasyon
* Ücret verisi ve rastgele tarihler oluşturmak için, kullanıcıdan tarih ve koltuk seçimi almak ve veri tiplerini kontrol etmek için gerekli olan metodları içerir.

#### Ucak
* Uçak bilgilerini gerekli alanlara atamak için ucakOlustur adlı metodu çalıştırır.

### Uygulama Çalışma Mantığı

Uçak bilgisi ve lokayon bilgileri uygulama içerisine gömülüdür. Yani otomatik olarak uçak bilgisi atanır ve kullanıcı oluşturulan lokasyon dizisinden bir lokasyon seçer.

* T.C. Kimlik Numarası girilir. Girilen değerin sayı olması ve 11 haneli olması gerekir.
* Ad bilgisi girilir.
* Soyad bilgisi girilir.
* Telefon numarası girilir. Girilen değerin sayı olması ve 11 haneli olması gerekir.
* Yaş bilgisi girilir. Girilen değerin sayı olması ve 0 ile 100 arasında olması gerekir.
* Cinsiyet seçilir. Cinsiyet seçmek için 1 veya 2 rakamını girdi olarak vermeniz gerekmektedir.
* Engelli durumu seçilir. Engelli durumu seçmek için 1 veya 2 rakamını girdi olarak vermeniz gerekmektedir.
* Lokasyon listesi ekrana yazdırılır. Lokasyon seçmek için sıra numarasını girmeniz gerekmektedir.
* Tarih listesi ekrana yazdırılır. Tarih seçmek için sıra numarasını girmeniz gerekmektedir.
* Koltuk listesi ekrana yazdırılır. Koltuk seçmek için sıra numarasını girmeniz gerekmektedir.