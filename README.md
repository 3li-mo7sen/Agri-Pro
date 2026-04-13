# Agri-Pro

A comprehensive agricultural management and marketplace platform designed to empower farmers and agribusinesses with modern digital solutions.

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Modules](#modules)
- [Architecture](#architecture)
- [Getting Started](#getting-started)
- [Contribution Guidelines](#contribution-guidelines)
- [Team](#team)
- [License](#license)

## 🎯 Project Overview

Agri-Pro is an integrated platform that combines farm management, marketplace operations, and investment management in a single ecosystem. The platform is designed to streamline agricultural operations, facilitate direct market connections, and enable transparent investment opportunities in the agricultural sector.

### Mission
To digitally transform the agricultural industry by providing farmers and agribusinesses with comprehensive tools for farm management, market access, and investment opportunities.

### Vision
To create a sustainable and connected agricultural community where technology enables efficiency, transparency, and growth.

## ✨ Features

### Core Features
- **Farm Management**: Comprehensive tools for tracking crops, livestock, and resources
- **Marketplace Integration**: Direct connection between producers and buyers
- **Investment Platform**: Transparent investment opportunities in agricultural projects
- **Real-time Analytics**: Data-driven insights for better decision-making
- **User-Friendly Interface**: Intuitive design for farmers of all technical levels
- **Mobile-First Design**: Responsive and accessible on all devices

### Advanced Features
- Inventory tracking and management
- Financial reporting and analysis
- Automated notifications and alerts
- Weather forecasting integration
- Supply chain transparency
- Community marketplace with rating systems

## 📦 Modules

### 1. Management Module
Handles core farm and resource management operations.

**Team Members:**
- Abo Elfadl Ramadan
- Mohamed Salah

**Key Responsibilities:**
- Farm operations management
- Resource allocation and tracking
- Crop and livestock management
- Performance monitoring and reporting

### 2. Marketplace Module
Manages buying, selling, and trading of agricultural products.

**Team Members:**
- Ali Mohsen
- Mayar Mohamed

**Key Responsibilities:**
- Product listing and catalog management
- Order processing and fulfillment
- Buyer-seller matching
- Rating and review systems
- Payment integration

### 3. Investment Module
Oversees investment opportunities and capital management.

**Team Members:**
- Maram Mahmoud
- Fatma Hassan

**Key Responsibilities:**
- Investment opportunity creation and management
- Fund management and tracking
- Investor verification and KYC processes
- Returns calculation and distribution
- Investment portfolio management

## 🧱 Architecture

- **Backend:** ASP.NET Core MVC Web API (`backend/AgriPro.Api`)
- **Frontend:** React + Vite (`frontend`)
- **Database:** SQL Server (configured via `appsettings.json`)

## 🚀 Getting Started

### Prerequisites
- .NET 8 SDK
- Node.js (v18 or higher)
- SQL Server (local or containerized)

### Backend Setup

```bash
cd backend/AgriPro.Api

dotnet restore

dotnet run
```

Update the SQL Server connection string in `backend/AgriPro.Api/appsettings.json` as needed.

### Frontend Setup

```bash
cd frontend

npm install

npm run dev
```

### API Overview

- `/api/users` - User registration and administration
- `/api/projects` - Investment project tracking
- `/api/projects/{projectId}/tasks` - Farm task management
- `/api/projects/{projectId}/expenses` - Expense tracking
- `/api/investments` - Investor funding records
- `/api/products` - Marketplace listings
- `/api/products/{productId}/reports` - Product moderation workflow

## 🤝 Contribution Guidelines

We welcome contributions from the community! Please follow these guidelines to contribute to Agri-Pro.

### How to Contribute

1. **Fork the Repository**
   - Click the "Fork" button on the GitHub repository page
2. **Create a Feature Branch**
   - `git checkout -b feature/amazing-feature`
3. **Commit Your Changes**
   - `git commit -m 'Add some amazing feature'`
4. **Push to the Branch**
   - `git push origin feature/amazing-feature`
5. **Open a Pull Request**

## 👥 Team

Agri-Pro was crafted by a passionate team dedicated to transforming the agricultural landscape.

## 📄 License

This project is licensed under the MIT License.
