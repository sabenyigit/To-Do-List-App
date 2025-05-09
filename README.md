# 📝 To-Do List - Yapılacaklar Listesi Uygulaması

Basit ve kullanışlı bir yapılacaklar listesi uygulaması. C# Windows Forms ile geliştirildi, veriler MySQL veritabanında tutulur. Görevlerinizi ekleyin, düzenleyin, tamamlayın veya silin. Hepsi tek bir ekranda, kolay kullanım için tasarlandı.

A simple and useful to-do list application. Developed with C# Windows Forms, data is stored in MySQL database. Add, edit, complete or delete your tasks. All on a single screen, designed for ease of use.

## 🚀 Neler Yapabilirsiniz? / What Can You Do?

- ✅ Yeni görev ekleyin / Add new task
- 🧠 Görevlerinizi düzenleyin / Organize your tasks
- ⛔ Gereksiz görevleri silin / Delete unnecessary tasks
- 📌 Tamamlanmış görevleri işaretleyin / Mark completed tasks
- 📅 Tarihe göre görevleri filtreleyin / Filter tasks by date
- 📊 İstatistiklerle genel durumu görün / See the overall situation with statistics

## 🛠️ Teknolojiler / Technologies

- C# (Windows Forms)
- MySQL
- MySql.Data kütüphanesi (NuGet) / MySql.Data library (NuGet)

## 🗃️ Veritabanı Bilgisi / Database Information

**Veritabanı Adı:** `todo_app` / **Database Name:** `todo_app`

### `tasks` tablosu / `tasks` table:

| Kolon / Column | Tip / Type | Açıklama / Description |
|----------------|------------|-----------------------|
| `id` | INT | Otomatik artan görev ID’si / Automatically incrementing task ID |
| `description` | TEXT | Görev açıklaması / Task description |
| `date_created` | DATETIME | Eklenme zamanı / Added time |
| `is_done` | BOOLEAN | Tamamlanma durumu (0: Hayır, 1: Evet) / Completion status (0: No, 1: Yes) |

### SQL Kurulumu / SQL Installation:
```sql
CREATE DATABASE todo_app;

USE todo_app;

CREATE TABLE tasks (
    id INT AUTO_INCREMENT PRIMARY KEY,
    description TEXT NOT NULL,
    date_created DATETIME NOT NULL,
    is_done BOOLEAN DEFAULT 0
);
