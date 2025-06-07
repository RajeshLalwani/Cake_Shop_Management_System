# Cake Shop Management System

![VB.NET](https://img.shields.io/badge/VB.NET-5C2D91?logo=.net)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-5C2D91?logo=windows)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?logo=microsoft-sql-server)

A comprehensive desktop application for bakery shops built with VB.NET and SQL Server, designed to streamline inventory, sales, and customer management.

## Table of Contents
- [Features](#features)
- [Technology Stack](#technology-stack)
- [Installation](#installation)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Troubleshooting](#troubleshooting)
- [Contributing](#contributing)
- [License](#license)

## Features

### 🛒 Inventory Management
- Add/edit/delete cake products
- Track ingredients and stock levels
- Barcode support (optional)

### 💵 Sales Processing
- Order creation with item selection
- Invoice generation
- Discount and tax calculation

### 👥 Customer Management
- Customer database
- Purchase history
- Loyalty programs

### 📊 Reporting
- Daily sales summaries
- Inventory alerts
- Financial reports

### 🔐 User Management
- Role-based access (Admin/Staff)
- Secure login system
- Password recovery

## Technology Stack

- **Frontend**: VB.NET Windows Forms
- **Database**: SQL Server LocalDB (.mdf)
- **Development**: Visual Studio 2019+
- **Dependencies**: 
  - .NET Framework 4.5+
  - Microsoft Reporting Services (for reports)

## Installation

### Prerequisites
- Visual Studio 2017/2019
- SQL Server Express LocalDB
- .NET Framework 4.5+

### Setup Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/RajeshLalwani/Cake_Shop_Management_System.git
2. Open the solution in Visual Studio:

File → Open → Project/Solution → Select CakeShop.sln

3. Database setup:

Attach App_Data/CakeShopDB.mdf to LocalDB

OR run Database/Scripts/FullSetup.sql in SSMS

Configure connection string in App.config:
