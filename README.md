# C# .Net7 Website / SQL server / Microsoft Azure

## Overview

This project is a website built using C# .NET 7, utilizing Microsoft SQL Server for data storage, and deployed on Microsoft Azure.
https://shaomvc.azurewebsites.net/

## Technologies Used

- C# .NET 7
- Microsoft SQL Server
- Microsoft Azure
- Stripe API
- Facebook OAuth

## Features

### User Authentication and Security
The project incorporates the ASP.NET Core Identity framework, which provides built-in support for user authentication and security. The features related to user authentication and security include:

- User registration and login: Users can create new accounts and log in to the website using their credentials.
- Password hashing and storage: User passwords are securely hashed and stored in the database.
- Account management: Users can update their profile information, change passwords, and manage account settings.
- Role-based authorization: The application includes role-based access control, allowing administrators to define different roles and assign permissions accordingly.
- Secure password reset: Users can request a password reset if they forget their password, and a secure password reset mechanism is implemented.

### MVC Structure
The project follows the Model-View-Controller (MVC) architectural pattern, which promotes a separation of concerns and provides a structured way to develop web applications. The key features of the MVC structure used in this project include:

- Models: Define the data entities and business logic of the application.
- Views: Render the user interface and display data to the user.
- Controllers: Handle user requests, interact with models, and coordinate the flow of data between models and views.
- Routing: The routing mechanism maps URLs to specific controllers and actions to handle user requests.

### Payment Integration with Stripe API
The project integrates with the Stripe API for payment processing. The features related to payment processing include:

- Online payment acceptance: Users can securely make payments for products or services using various payment methods supported by Stripe.
- Payment gateway integration: The application integrates with the Stripe payment gateway to handle payment transactions securely.
- Seamless checkout experience: Users can easily complete the payment process with a smooth and user-friendly checkout flow.
- Payment status tracking: The application tracks and manages the status of payment transactions, allowing users and administrators to view and monitor the payment history.

## Deployment
Using Microsoft Azure for depolyment.

- Create sql database and copy the connection string
- create web application service and deploy it with github CI/CD
