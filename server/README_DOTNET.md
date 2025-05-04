# 🧩 Task Manager API (.NET 7+ Backend)

This is a lightweight .NET Web API backend for the Angular Task Manager app.

It provides a simple in-memory task list with full CRUD support.

---

## 📦 Features

- ✅ ASP.NET Core Web API (.NET 7+)
- ✅ In-memory storage (no DB required)
- ✅ RESTful endpoints
- ✅ CORS enabled for Angular frontend

---

## 🚀 Run Instructions

### 1. Clone this repository

```bash
git clone https://github.com/NaveiShelly/ServerShaam.git
cd server
```

### 2. Run the backend

```bash
dotnet run
```

> Ensure you have **.NET 7 SDK or later** installed: https://dotnet.microsoft.com/download

---

## 🔗 API Base URL

By default:

```
http://localhost:5089/api/tasks
```

You can change this in the launch settings or by modifying your CORS and URL bindings in `Program.cs`.

---

## 🔁 API Endpoints

| Method | Endpoint          | Description     |
| ------ | ----------------- | --------------- |
| GET    | `/api/tasks`      | Get all tasks   |
| GET    | `/api/tasks/{id}` | Get task by ID  |
| POST   | `/api/tasks`      | Create new task |
| PUT    | `/api/tasks/{id}` | Update task     |
| DELETE | `/api/tasks/{id}` | Delete task     |

---

## 🧪 Technologies

- ASP.NET Core 7+
- C#
- CORS for frontend connection

---
