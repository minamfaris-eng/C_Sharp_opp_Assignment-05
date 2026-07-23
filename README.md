C# OOP — Cinema Booking System (Assignment 5)
A C# console application developed for Route IT Academy (C# OOP - Session 06). This project demonstrates core Object-Oriented Programming (OOP) concepts, including Interfaces, Inheritance, Polymorphism, Enums, and Encapsulation, through a cinema ticket reservation domain model.

📁 Project Structure
Plaintext
Assignment-5/
│
├── Enums/
│   └── TicketType.cs          # Enumeration for ticket classification (Standard, VIP, IMAX)
│
├── Interface/
│   ├── IBookable.cs           # Interface contract for booking/cancellation logic
│   └── IPrintable.cs          # Interface contract for formatted object printing
│
├── Models/
│   ├── Cinema.cs              # Aggregates cinema operations, screens, and seating
│   ├── Ticket.cs              # Base abstract/virtual class for cinema tickets
│   ├── Projector.cs           # Hardware model for theater projector management
│   ├── SeatLocation.cs        # Struct/Model defining row and column seating
│   ├── BookingHelper.cs       # Utility/service class managing booking workflows
│   │
│   └── TicketsTypes/          # Derived ticket implementations (Inheritance)
│       ├── StandardTicket.cs  # Standard seat booking logic
│       ├── VIPTicket.cs       # VIP booking with premium features/lounge access
│       └── IMAXTicket.cs      # IMAX experience ticket implementation
│
├── Program.cs                 # Main entry point and demo execution
└── Assignment5.csproj         # Project configuration file
💡 Key Features & Concepts Demonstrated
Interfaces (IBookable, IPrintable): Enforces modular contracts for printable items and entities that can be booked or canceled.

Inheritance & Polymorphism (Ticket hierarchy): Base Ticket class extended by specialized derived classes (StandardTicket, VIPTicket, IMAXTicket) with overridden methods for custom pricing and feature handling.

Enums (TicketType): Strongly typed representations for distinct ticket categories.

Separation of Concerns: Clean directory architecture separating abstractions (interfaces/enums) from data structures and business logic (models/helpers).

🚀 Getting Started
Prerequisites
.NET 8.0 SDK or higher

Visual Studio 2022 / VS Code / Rider

Running the Project
Clone the repository:

Bash
git clone https://github.com/your-username/assignment-5.git
cd assignment-5
Build and run the application:

Bash
dotnet run --project Assignment5.csproj
🛠 Tech Stack
Language: C#

Framework: .NET Core / .NET Console Application

Concepts: Object-Oriented Programming (OOP), SOLID Principles Basics
