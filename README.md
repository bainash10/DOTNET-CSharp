# **VB.NET, C# Lab Reports by Nischal Baidar**

## **Branches Overview**
| Branch | Description |
| --- | --- |
| `main` | Contains lab reports. |
| `testing` | Contains a simple `nis.txt` file. |
| `check` | Contains Python files with `.py` extensions. |
| `master` | Merged with `testing` and `check` branches. |

## **Inside `main` Branch**

### **Lab 1: Git and GitHub Familiarity**
This lab focuses on understanding Git and GitHub workflow, including:
- Repository creation
- Branching and merging
- Basic Git commands and commits

---

### **Lab 2: C# Programming Exercises**
This lab consists of several fundamental C# programs:

1. **Print "Hello" and your name on separate lines.**
2. **Swap two numbers.**
3. **Find the largest of three numbers.**
4. **Check if a given number is even or odd.**
5. **Calculate the sum of first `n` natural numbers.**
6. **Check whether a given year is a leap year or not.**
7. **Create an integer array and print the sum of array elements.**
8. **Calculate the factorial of a given number.**
9. **Check if an input number is a prime number.**

#### **Project Structure**
- The **`Program.cs`** file contains the object creation and main program logic.
- Each question’s solution is written in separate **`file.cs`** files for better organization.
- **Question 1** is implemented inside `Program.cs` using different functions.

#### **Practice Project at College**
- Files located inside **`Lab 2\!Practice_PROJECT_Folder_AT_College\ConsoleApp1`** is developed under the guidance of the instructor.

---

### **Lab 3: Inheritance, Overloading, and Overriding**

This lab demonstrates important **Object-Oriented Programming (OOP)** concepts in C#:

#### Concepts Covered
- **Method Overloading**
  - Same method names `Add` and `Multiply` are defined with different parameter types (`int`, `double`).
  - Demonstrates **compile-time polymorphism** (static binding).

- **Inheritance**
  - A base class provides basic math operations like addition, subtraction, multiplication, and division.
  - A derived class inherits these functionalities and enhances them.

- **Palindrome Checking**
  - A class is implemented to check whether a given string is a **palindrome** (reads the same forward and backward).

- **Method Overriding**
  - The base class `Operation` defines a virtual `Calculate` method.
  - Derived classes `Addition`, `Subtraction`, `Multiplication`, and `Division` override the `Calculate` method to perform specific arithmetic operations.
  - Demonstrates **runtime polymorphism** (dynamic binding) based on user input.

#### Project Structure
| File | Description |
| --- | --- |
| `Program.cs` | Main program where object creation, method calls, and menu logic are handled. |
| `Overloading.cs` | Contains method overloading implementations. |
| `Inheritance.cs` | Contains inheritance examples. |
| `Palindrome.cs` | Implements logic for checking if a string is a palindrome. |
| `Overriding.cs` | Contains base and derived classes for overriding (`Operation`, `Addition`, `Subtraction`, `Multiplication`, `Division`). |

#### Summary
This lab builds strong foundations on how **overloading**, **inheritance**, **palindrome checking**, and **overriding** work together to implement real-world scenarios using **C#**.

---

### **Lab 4: WinForm**

This lab focuses on developing a **Windows Form Application** that includes multiple UI components and functionalities:

#### Components Implemented

1. **Calculator**
   - Supports arithmetic operations: **Addition**, **Subtraction**, **Multiplication**, and **Division**.
   - Includes input fields for numbers and buttons for each operation.
   - A **Clear** button resets all inputs.

2. **Login Form**
   - Fields: Username and password (with password masked as `*`).
   - A **Login** button initiates the login process.

3. **Registration Form**
   - Features:
     - **ComboBox 1**: Main category.
     - **ComboBox 2**: Dependent on ComboBox 1's selection.
     - **Radio Buttons**: For selecting options (e.g., Gender).
     - **Checkboxes**: For selecting additional features or preferences.
     - **Numeric Up Down**: For numerical input such as age or quantity.
   - **Validation** is implemented to ensure all fields are correctly filled before submission.

4. **Timer Feature**
   - A **Timer** is added to sync with the current local time.
   - It can be **enabled or disabled** via the **MenuStrip** under the `File` menu.

---

## **How to Use**
1. Clone the repository:
   ```sh
   git clone https://github.com/bainash10/DOTNET-CSharp.git
