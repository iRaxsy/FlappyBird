# 🐦 Flappy Bird

Flappy Bird, klasik arcade mekaniklerini Unity 6 motorunun gücüyle birleştiren, akıcı ve bağımlılık yapıcı bir mobil/web oyun projesidir. Temiz kod yapısı ve optimize edilmiş 2D fiziği ile hem geliştiriciler hem de oyuncular için mükemmel bir deneyim sunar.

## ✨ Öne Çıkan Özellikler

### 🕹️ Oyun Mekanikleri
- **Hassas Fizik Kontrolü:** `Rigidbody2D` tabanlı dikey kuvvet yönetimi ile gerçekçi ve tatmin edici zıplama hissi.
- **Sonsuz Engel Sistemi:** `Coroutine` tabanlı dinamik boru oluşturma (spawning) ve otomatik temizleme (object cleanup).
- **Gerçek Zamanlı Skor Takibi:** Boruların arasından hatasız geçişleri algılayan tetikleyici (trigger) sistemi.
- **Aşamalı Akış:** Oyun başladığında devreye giren zaman ölçekleme (`Time.timeScale`) ve dinamik zorluk.

### 🎨 Görsel & Kullanıcı Deneyimi
- **Akıcı Arayüz (UI):** Unity **uGUI** ile tasarlanmış Başlangıç, Oyun ve Ölüm ekranları.
- **Ses Yönetimi:** Zıplama, skor ve çarpışma anları için özel SFX entegrasyonu.
- **Kalıcı Ayarlar:** Ses tercihlerinin cihazda saklanmasını sağlayan **PlayerPrefs** sistemi.
- **2D Animasyonlar:** Karakter hareketlerini destekleyen sprite tabanlı animasyon sistemi.

## 🛠️ Teknik Alt Yapı

- **Motor:** Unity 6
- **Dil:** C# (Modüler ve Event-driven yaklaşım)
- **Fizik:** Unity 2D Physics (BoxCollider2D, Rigidbody2D)
- **Input:** Unity **New Input System** (Fare Sol Tık & Klavye Boşluk tuşu desteği)
- **Veri Saklama:** PlayerPrefs (Ses ayarları ve skor için)

## 🚀 Kurulum Adımları

1. **Hazırlık:** Bilgisayarınızda **Unity Hub** ve **Unity 6** yüklü olduğundan emin olun.
2. **Projeyi Edinme:** Depoyu klonlayın veya `.zip` olarak indirin.
3. **Unity ile Aç:** Unity Hub üzerinden projeyi ekleyin ve seçin.
4. **Sahne Yükleme:** `Assets/Scenes/` altındaki oyun sahnesini açın.
5. **Çalıştır:** "Play" butonuna basarak oyuna başlayabilirsiniz.

## 🕹️ Kontroller

| Eylem | Klavye (Desktop) | Mouse (Desktop) |
| :--- | :--- | :--- |
| **Zıpla (Uç)** | Boşluk (Space) | Sol Tık |
| **Oyunu Başlat** | UI Butonu / Tıkla | UI Butonu / Tıkla |
| **Sesi Aç/Kapat** | UI Butonu | UI Butonu |

## 📂 Klasör Yapısı

```text
├── Assets/
│   ├── Scripts/            # Tüm C# Kodları (Bird, GameManager, Spawner vb.)
│   ├── Prefabs/            # Borular ve UI Panelleri
│   ├── Sprites/            # 2D Karakter ve Çevre Varlıkları
│   ├── Sounds/             # Ses Efektleri (SFX)
│   ├── Animations/         # Karakter Animasyonları
│   └── Fonts/              # UI Yazı Tipleri
└── ProjectSettings/        # Proje ve Paket Ayarları
```

## 📜 Lisans

Bu proje **MIT Lisansı** altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakabilirsiniz.

---
⭐ Bu projeyi geliştirmemize yardımcı olmak isterseniz yıldız atmayı ve geri bildirim vermeyi unutmayın!
