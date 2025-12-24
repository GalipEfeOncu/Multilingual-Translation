# 🌍 Çoklu Dil Çeviri Uygulaması - Dönem Ödevi

Bu proje, C# kullanılarak geliştirilmiş, web servisleri (API) ile haberleşebilen dinamik bir çeviri aracıdır. Modern yazılım mimarisine uygun olarak Asenkron (Async/Await) yapıda tasarlanmıştır.

## ⚡ Proje Özellikleri
* **Asenkron Mimari:** Çeviri işlemi sırasında arayüz donmaz, kullanıcı deneyimi ön planda tutulmuştur.
* **REST API Entegrasyonu:** MyMemory API servisi kullanılarak anlık veri çekilmektedir.
* **Hafif Veri İşleme:** Büyük JSON kütüphaneleri yerine, RegEx (Düzenli İfadeler) kullanılarak gelen veri en hızlı şekilde işlenmiştir.
* **Çoklu Dil Desteği:** Türkçe, İngilizce, Almanca, Fransızca ve İspanyolca dilleri arasında geçiş yapılabilir.

## 🛠 Kullanılan Teknolojiler
* **Dil:** C#
* **Ağ İletişimi:** `System.Net.Http.HttpClient`
* **Veri İşleme:** Regular Expressions (Regex)

## 📖 Kullanım
1.  Metin kutusuna çevrilecek cümleyi girin.
2.  Hedef dili listeden seçin.
3.  Çevir butonuna basarak sonucu anlık görüntüleyin.
