<<<<<<< HEAD
# 📝 Final Exam – Fullstack Student Attendance System

## 👨‍💻 Student: Gustavo Reis  
GitHub Repo: [tt4-final-exam-1280_2025050212001600](https://github.com/lgustavoreis/tt4-final-exam-1280_2025050212001600)  
Docker Hub: [lgustavoreis](https://hub.docker.com/repositories/lgustavoreis)  

---

## ✍️ Part I – Multiple Choice Questions

Each question is worth 0.5 points.

### 🐳 Docker

1. Which file is used to define how a Docker image is built?  
   - **B) Dockerfile**

2. What does `docker images` command show?  
   - **C) Downloaded images**

3. How do you remove a Docker container?  
   - **D) docker rm**

4. What port does Docker map to when using `EXPOSE 80`?  
   - **B) Container’s internal port 80**

---

### 🌿 Git / GitHub

5. Which command initializes a new Git repository?  
   - **C) git init**

6. What is a Git branch?  
   - **C) A version of your repository history**

7. What does `git pull` do?  
   - **C) Fetch and merge from remote**

8. How do you stage all modified files?  
   - **D) git add .**

---

### ⚙️ .NET Core

9. What is Entity Framework Core used for?  
   - **C) Mapping C# classes to database tables**

10. What’s the purpose of `appsettings.json`?  
   - **B) Configure app settings like DB connection strings**

11. Which command runs a .NET Core project?  
   - **C) dotnet run**

12. What does `[HttpPost]` represent in a controller?  
   - **C) An endpoint for POST requests**

---

### ⚛️ Frontend Frameworks

13. What command creates a new Angular project?  
   - **C) ng new**

14. In React, what is a component?  
   - **B) A function or class that renders UI**

15. How do you bind data in VueJS templates?  
   - **B) v-bind:value or :value**

16. What is the default file extension for Svelte components?  
   - **A) .svelte**

---

### 💡 General Concepts

17. What does REST stand for?  
   - **C) Representational State Transfer**

18. What is JSON used for?  
   - **C) Structuring and exchanging data**

19. What is the role of `Tailwind CSS`?  
   - **C) A utility-first CSS framework**

20. What does `docker-compose down` do?  
   - **B) Stops and removes containers, networks, volumes**

---

## 💻 Part II – Final Project

### 🔧 Project: Student Attendance System

A fullstack application to manage student attendance records. Built with:

- **Backend:** ASP.NET Core Web API with Entity Framework Core (SQLite)
- **Frontend:** Vue.js + Tailwind CSS + Axios
- **Containerization:** Docker & Docker Compose

---

### ✅ Features

- 📌 **CRUD operations** for `StudentAttendance`:
  - `ID`, `StudentName`, `Date`, `Present`, `Remarks`
- 🌐 RESTful API with Swagger
- 🖥️ Vue frontend integrated via Axios
- 💅 Styled with Tailwind CSS
- 🐳 Docker Compose to run both frontend and backend

---

### 📁 Project Structure

```
tt4-final-exam-1280_2025050212001600/
├── backend/
│   └── StudentAttendanceApi/
│       ├── Controllers/
│       ├── Data/
│       ├── Models/
│       ├── Program.cs
│       ├── Dockerfile
├── frontend/
│   └── student-attendance-frontend/
│       ├── src/
│       ├── Dockerfile
├── docker-compose.yml
├── README.md
```

---

### 🚀 How to Run

```bash
# 1. Clone the repo
git clone https://github.com/lgustavoreis/tt4-final-exam-1280_2025050212001600.git
cd tt4-final-exam-1280_2025050212001600

# 2. Run the app with Docker Compose
docker-compose up --build
```

- 📦 Backend API: `http://localhost:5000/swagger`
- 🖥️ Frontend App: `http://localhost:8080`

---

### 📅 Submission Date

2025-05-06 19:13:49

---
=======
# student-attendance-frontend

This template should help get you started developing with Vue 3 in Vite.

## Recommended IDE Setup

[VSCode](https://code.visualstudio.com/) + [Volar](https://marketplace.visualstudio.com/items?itemName=Vue.volar) (and disable Vetur).

## Customize configuration

See [Vite Configuration Reference](https://vite.dev/config/).

## Project Setup

```sh
npm install
```

### Compile and Hot-Reload for Development

```sh
npm run dev
```

### Compile and Minify for Production

```sh
npm run build
```
>>>>>>> 43b073c038b3b15e11436d7a9f5f2ac061ab36f9
