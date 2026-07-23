# C# OOP — Cinema Booking System (Assignment 5)

A C# console application developed for **Route IT Academy (C# OOP - Session 06)**. This project demonstrates core Object-Oriented Programming (OOP) concepts, including **Interfaces**, **Inheritance**, **Polymorphism**, **Enums**, and **Encapsulation**, through a cinema ticket reservation domain model.

---

## 📁 Project Structure

```text
Assignment-5/
├── Enums/
│   └── TicketType.cs
├── Interface/
│   ├── IBookable.cs
│   └── IPrintable.cs
├── Models/
│   ├── TicketsTypes/
│   │   ├── IMAXTicket.cs
│   │   ├── StandardTicket.cs
│   │   └── VIPTicket.cs
│   ├── BookingHelper.cs
│   ├── Cinema.cs
│   ├── Projector.cs
│   ├── SeatLocation.cs
│   └── Ticket.cs
├── Assignment5.csproj
└── Program.cs
```


---

## 💡 Key Features & Concepts Demonstrated

* **Interfaces (`IBookable`, `IPrintable`)**: Enforces modular contracts for printable items and entities that can be booked or canceled.
* **Inheritance & Polymorphism (`Ticket` hierarchy)**: Base `Ticket` class extended by specialized derived classes (`StandardTicket`, `VIPTicket`, `IMAXTicket`) with overridden methods for custom pricing and feature handling.
* **Enums (`TicketType`)**: Strongly typed representations for distinct ticket categories.
* **Separation of Concerns**: Clean directory architecture separating abstractions (interfaces/enums) from data structures and business logic (models/helpers).

---

## 🚀 Getting Started

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or higher
* Visual Studio 2022 / VS Code / Rider

### Running the Project

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/your-username/assignment-5.git](https://github.com/your-username/assignment-5.git)
   cd assignment-5
Build and run the application:


dotnet run --project Assignment5.csproj
🛠 Tech Stack
Language: C#

Framework: .NET Core / .NET Console Application

Concepts: Object-Oriented Programming (OOP), SOLID Principles Basics


### 💡 Quick Tip for GitHub:
If you are pasting this directly on GitHub's browser interface, click the **"Preview"** tab next to "Edit
