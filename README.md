# CLI-Library (CLIParser)

A lightweight command-line interface framework built in **C#**.  
This project provides the basic building blocks for parsing commands, handling options, and executing CLI logic with minimal boilerplate.

---

## 🧠 Overview

CLI-Library (CLIParser) is a minimal C# library designed to make writing command-line tools simple and structured.  
It helps developers define **commands**, **arguments**, and **options**, then invoke them dynamically at runtime.

---

## 📁 Project Structure
CLIParser.sln
CLIParser/
│
├── Program.cs # Entry point (demo / CLI setup)
├── CLIParser.csproj # Project file
└── Cmd/
├── CLIParser.cs # Core parser and command dispatcher
├── Command.cs # Base command structure
├── CommandInvoker.cs # Executes matched commands
├── Arguments.cs # Parses input arguments
├── Option.cs # Handles option flags and key-value pairs
└── Help.cs # Default help command implementation


---

## 🚀 Getting Started

### 1️⃣ Clone and build
```bash
git clone https://github.com/Xhyther/CLI-Library.git
cd CLI-Library/CLIParser
dotnet build
