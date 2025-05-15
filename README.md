# Rechnerverwaltung

A C# (CSharp) Console App exercise project developed during my retraining as an IT Specialist in Application Development at Lutz + Grub Academy.

This project focuses on managing different types of computers within a company’s IT environment. The program uses a class hierarchy with inheritance and polymorphism to represent various hardware types, such as:

- **Servers** with processor count, RAM size, disk count, and network performance
- **Office Workstations** with performance specs
- **Graphics Workstations** with monitor size and GPU details
- **Terminals** linked to servers
- All of them inherit from a base `Rechner` (Computer) class

The logic and structure are based on a class diagram provided in  
`18Rechnerverwaltung Klassenhierarchie.png`.

### Features

- Inheritance-based structure from a unified `Rechner` base class
- Custom `ITVerwaltung` class to manage all devices
- Method to display all system details
- Object-oriented design with encapsulation and class-specific output logic

### How to Run

This is an educational exercise project and does not contain a direct executable.  
You can open and run the solution by loading  
`Rechnerverwaltung.sln` in Visual Studio.

> **Note**: German language used.

---

The code was written independently by me. The class only provided a general idea of what the project should do.
