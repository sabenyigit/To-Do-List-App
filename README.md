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

#### English explanation:
# 📝 To-Do List - Yapılacaklar Listesi Uygulaması

A simple and useful to-do list application. Developed with C# Windows Forms, data is stored in MySQL database. Add, edit, complete or delete your tasks. All on a single screen, designed for ease of use.

## 🚀 What Can You Do?

- ✅ Add new task
- 🧠 Organize your tasks
- ⛔ Delete unnecessary tasks
- 📌 Mark completed tasks
- 📅 Filter tasks by date
- 📊 See the overall situation with statistics

## 🛠️ Teknolojiler

- C# (Windows Forms)
- MySQL
- MySql.Data library (NuGet)

## 🗃️Database Information

**Database Name:** `todo_app`

### `tasks` table:

| Colon | Medicine | Explanation |
|-------|-----|----------|
| `id` | INT | Automatically incrementing task ID |
| `description` | TEXT | Task description |
| `date_created` | DATETIME | Added time |
| `is_done` | BOOLEAN | Completion status (0: No, 1: Yes) |

### SQL Installation:
```sql
CREATE DATABASE todo_app;

USE todo_app;

CREATE TABLE tasks (
    id INT AUTO_INCREMENT PRIMARY KEY,
    description TEXT NOT NULL,
    date_created DATETIME NOT NULL,
    is_done BOOLEAN DEFAULT 0
);

