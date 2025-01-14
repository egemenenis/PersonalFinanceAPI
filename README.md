# API Documentation

This project provides a RESTful API for financial management, including features like budgeting, saving, transaction management, and user management. The architecture is designed for scalability, maintainability, and modularity, using DTO structures and AutoMapper for optimized data transfer.

## Project Structure

- **Controller**: Handles incoming HTTP requests and returns appropriate responses.
- **Profiles**: Contains AutoMapper profile classes for mapping between DTOs and Entities.
- **Repositories**: Interface with the database and perform CRUD operations.
- **Services**: Contains business logic, working with Repositories and DTOs.
- **Core**: Contains two main sub-folders:
  - **DTOs**: Data Transfer Objects used for optimized data communication.
  - **Entities**: The core data structures that represent the database schema.

## API Endpoints

### Budgets

#### GET `/api/Budgets`
- Retrieve all budgets.

#### POST `/api/Budgets`
- Create a new budget.

#### GET `/api/Budgets/{id}`
- Retrieve a specific budget by its ID.

#### PUT `/api/Budgets/{id}`
- Update an existing budget by its ID.

#### DELETE `/api/Budgets/{id}`
- Delete a specific budget by its ID.

---

### Category

#### GET `/api/Category`
- Retrieve all categories.

#### POST `/api/Category`
- Create a new category.

#### GET `/api/Category/{id}`
- Retrieve a specific category by its ID.

#### PUT `/api/Category/{id}`
- Update an existing category by its ID.

#### DELETE `/api/Category/{id}`
- Delete a specific category by its ID.

---

### Saving

#### GET `/api/Saving`
- Retrieve all savings.

#### POST `/api/Saving`
- Create a new saving.

#### GET `/api/Saving/{id}`
- Retrieve a specific saving by its ID.

#### PUT `/api/Saving/{id}`
- Update an existing saving by its ID.

#### DELETE `/api/Saving/{id}`
- Delete a specific saving by its ID.

---

### TransactionCategory

#### GET `/api/TransactionCategory`
- Retrieve all transaction categories.

#### POST `/api/TransactionCategory`
- Create a new transaction category.

#### GET `/api/TransactionCategory/{id}`
- Retrieve a specific transaction category by its ID.

#### PUT `/api/TransactionCategory/{id}`
- Update an existing transaction category by its ID.

#### DELETE `/api/TransactionCategory/{id}`
- Delete a specific transaction category by its ID.

---

### Transactions

#### GET `/api/Transactions`
- Retrieve all transactions.

#### POST `/api/Transactions`
- Create a new transaction.

#### GET `/api/Transactions/{id}`
- Retrieve a specific transaction by its ID.

#### PUT `/api/Transactions/{id}`
- Update an existing transaction by its ID.

#### DELETE `/api/Transactions/{id}`
- Delete a specific transaction by its ID.

---

### User

#### POST `/api/User/register`
- Register a new user.

#### POST `/api/User/login`
- Login an existing user.

#### GET `/api/User/{id}`
- Retrieve a specific user by their ID.

#### PUT `/api/User/{id}`
 - Update an existing user by their ID.

#### DELETE `/api/User/{id}`
- Delete a specific user by their ID.

#### GET `/api/User`
- Retrieve all users.

---

## Architecture Overview

Data transfer is optimized using **DTO structures** and **AutoMapper**, providing efficient data handling and separation of concerns. The API also supports secure financial management features such as user registration, login, and profile management.

This architecture enhances **scalability**, **maintainability**, and **modularity**, making it suitable for both personal finance management and further expansion.

## Authentication and Security

The API ensures secure user management with endpoints for user registration, login, and profile updates. Authorization and authentication mechanisms are built to protect sensitive financial data.

## Error Handling

The API provides standardized error responses, including relevant HTTP status codes and error messages to help with debugging and client-side handling.

---

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/egemenenis/PersonalFinanceAPI.git
2. Navigate to the project directory:
     ```bash
   cd PersonalFinanceAPI
-  `dotnet restore `
-   `dotnet run`
3. Configuration
- Open the `appsettings.json` file in project.
- Locate the `ConnectionStrings` section.
- Update the `PerFinString` connection string with your database details.

## **Contact**

For questions, suggestions, or any problems, feel free to contact me:

- **Email**: [enis.egemen25@gmail.com](mailto:enis.egemen25@gmail.com)

---

Thank you for discovering **PersonalFinanceAPI**!
