# Restaurant Management System (C# WinForms)

A comprehensive desktop application designed to streamline restaurant operations, including inventory management, order processing, and user administration. This project was developed as a **Group Project (Group J)** for the **Database Systems and Programming** module.

## Project Overview
This system provides a multi-role interface for Administrators and Cashiers to manage a restaurant's day-to-day activities efficiently. It uses a local SQL database for persistent data storage.

## Key Features
* **User Authentication:** Secure Login and Registration systems for different user roles.
* **Admin Dashboard:** Comprehensive tools to manage products (add/edit/delete), manage users, and view system statistics.
* **Cashier Interface:** Streamlined interface for managing customer orders and processing transactions in real-time.
* **Database Integration:** Utilizes SQL Server (LocalDB) to manage inventory, user data, and order history.

## Tech Stack
* **Language:** C#
* **Framework:** .NET WinForms
* **Database:** SQL Server (LocalDB)
* **IDE:** Visual Studio

## Repository Structure
* `/AdminAddProducts.cs`: Logic for managing the restaurant's menu items.
* `/AdminDashboardForm.cs`: The central hub for administrative tasks.
* `/CashierOrderForm.cs`: The main interface for handling customer sales.
* `/LoginForm.cs` & `/RegisterForm.cs`: Modules for secure system access.
* `Database_Setup.sql`: The SQL script required to set up the database schema and initial data.

## Setup Instructions
1. Clone this repository to your local machine.
2. Open the solution file `RestaurentManagementSystem.sln` in **Visual Studio**.
3. Open **SQL Server Management Studio (SSMS)** and run the `Database_Setup.sql` script to create the necessary tables and data.
4. Update the connection string in `App.config` or the relevant code files to match your local SQL instance if necessary.
5. Build and run the project (Press `F5`).

---
*Developed with ❤️ by Thilina Sandakelum Wijesinghe - University of Vocational Technology (UoVT) - Department of Software Technology*
