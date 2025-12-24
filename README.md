# SWE201_235060002-Final-
# LibraryManagementApp – SWE203 Term Project

## 1. Introduction
This project was developed as part of the SWE203 course to demonstrate the practical application of object-oriented programming principles. The system models a simplified library management application focusing on books, members, and borrowing operations.

The primary objective of the project is to design a clear and maintainable class structure that reflects real-world entities and their relationships while adhering to fundamental object-oriented design principles.

---

## 2. System Overview
The application represents a basic library environment where members can borrow books for a specified period. The system does not focus on user interfaces or database integration; instead, it emphasizes object modeling and class responsibility separation.

---

## 3. Class Design and Responsibilities

### 3.1 Book Class
The `Book` class represents books available in the library. It encapsulates book-related attributes such as title, author, and availability status. The availability of a book is managed internally through methods, ensuring controlled access to the book’s state.

This design choice supports the principle of encapsulation and allows future extensions, such as adding different book types or tracking additional book attributes.

### 3.2 Member Class
The `Member` class represents individuals who are registered in the library system. It stores essential member information and is intentionally kept independent of borrowing logic. This separation ensures that member data management remains isolated from other system responsibilities.

### 3.3 Borrow Class
The `Borrow` class establishes a relationship between the `Book` and `Member` classes. It models the borrowing process by linking a specific book to a specific member for a defined duration. Additionally, it updates the availability status of the borrowed book.

This class demonstrates the use of composition to model real-world relationships and improves system modularity.

---

## 4. Object-Oriented Design Principles Applied
The following object-oriented programming principles were applied during the development of this project:

- **Encapsulation:** Class attributes are accessed and modified through properties and methods.
- **Single Responsibility Principle:** Each class has a clearly defined responsibility.
- **Composition:** Real-world relationships are modeled using object references.
- **Constructor Usage:** Constructors are used to ensure valid and controlled object initialization.

---

## 5. Design Rationale
The class structure was intentionally kept simple and modular to improve readability and maintainability. Each class corresponds to a real-world concept, which makes the system intuitive and extensible. The design allows future enhancements such as inheritance, polymorphism, or integration with persistent storage.

---

## 6. Technologies Used
- C#
- .NET Console Application
