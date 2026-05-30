# MVC-Image-Upload-App

## About Project

This project is a simple ASP.NET Core MVC application developed for image upload and gallery management operations.

The application allows users to:

- Upload images
- Display uploaded images in gallery view
- Store image files inside `wwwroot/images`
- Save image metadata without database
- Run application inside Docker container
- Use Docker Volume for persistent storage

---

# Technologies

- ASP.NET Core MVC
- .NET 8
- Bootstrap 5
- Docker
- Docker Volume

---

# Project Structure

Controllers/
Models/
Services/
Views/
wwwroot/images/
Data/
Dockerfile
docker-compose.yml
Program.cs

---

# Features

## IActionResult Index()

This action returns all uploaded images to the main gallery page.

