# 📝 To-Do List - Yapılacaklar Listesi Uygulaması

Basit ve kullanışlı bir yapılacaklar listesi uygulaması. C# Windows Forms ile geliştirildi, veriler MySQL veritabanında tutulur. Görevlerinizi ekleyin, düzenleyin, tamamlayın veya silin. Hepsi tek bir ekranda, kolay kullanım için tasarlandı.

## 🚀 Neler Yapabilirsiniz?

- ✅ Yeni görev ekleyin
- 🧠 Görevlerinizi düzenleyin
- ⛔ Gereksiz görevleri silin
- 📌 Tamamlanmış görevleri işaretleyin
- 📅 Tarihe göre görevleri filtreleyin
- 📊 İstatistiklerle genel durumu görün

## 🛠️ Teknolojiler

- C# (Windows Forms)
- MySQL
- MySql.Data kütüphanesi (NuGet)

## 🗃️ Veritabanı Bilgisi

**Veritabanı Adı:** `todo_app`

### `tasks` tablosu:

| Kolon | Tip | Açıklama |
|-------|-----|----------|
| `id` | INT | Otomatik artan görev ID’si |
| `description` | TEXT | Görev açıklaması |
| `date_created` | DATETIME | Eklenme zamanı |
| `is_done` | BOOLEAN | Tamamlanma durumu (0: Hayır, 1: Evet) |

### SQL Kurulumu:
```sql
CREATE DATABASE todo_app;

USE todo_app;

CREATE TABLE tasks (
    id INT AUTO_INCREMENT PRIMARY KEY,
    description TEXT NOT NULL,
    date_created DATETIME NOT NULL,
    is_done BOOLEAN DEFAULT 0
);
