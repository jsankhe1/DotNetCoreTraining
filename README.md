# .NetCoreTraining

This repository contains multiple assignments unified under a shared dashboard and menu system. Each assignment is organized into folders with corresponding dashboards, enums, and helper classes to streamline navigation and enhance mine own understanding of .NET Core and C# concepts.

## Disclaimer
This README may be updated periodically as the repository evolves and more assignments solutions are added by me. The general structure of the base will remain the same, so future instructions and usage guidelines can be generalized accordingly. Happy learning!

## Table of Contents
- [Overview](#overview)
- [Project Structure](#project-structure)
- [How to Run](#how-to-run)
- [Assignments](#assignments)
- [Disclaimer](#disclaimer)

## Overview
This repository explores various .NET Core and C# concepts through multiple assignments. The application uses a unified static menu system, defined in `MenuHandler.cs`, to navigate between different assignments. Each assignment has a dedicated dashboard (e.g., `AssignmentOneDashboard.cs`, `AssignmentTwoDashboard.cs`) to handle user input and guide you through its respective tasks.

## Project Structure
The project is organized as follows:

```
.idea/
  IDE-specific settings and configuration files.

Assignment/
  Assignment.csproj         - .NET Core project file for building the solution.
  Program.cs                - Main entry point that launches the unified menu.
  Helpers/                  - Contains shared resources like dashboards, enums, and menu handlers.
    Dashboards/             - Dedicated dashboards for each assignment (e.g., AssignmentOneDashboard.cs, AssignmentTwoDashboard.cs).
    Enums/                  - Enum definitions for menu options and tasks.
    Menus/                  - Static menu system to navigate between assignments.
  AssignmentOne/            - Contains theory solutions and mini-projects for Assignment One.
  AssignmentTwo/            - Contains theory solutions and mini-projects for Assignment Two.
  AssignmentThree/          - Contains theory solutions and mini-projects for Assignment Three.
  bin/                      - Build output files.
  obj/                      - Intermediate build files.

DotNetCoreTraining.sln      - .NET Core solution file.
README.md                   - This README file.
```

## How to Run
1. **Clone this repository:**
   ```sh
   git clone https://github.com/yourusername/NetCoreTraining.git
   cd NetCoreTraining
   ```

2. **Open the solution:**
   Open `DotNetCoreTraining.sln` in your preferred IDE or editor (e.g., Visual Studio, Rider, or Visual Studio Code).

3. **Build the project:**
   ```sh
   dotnet build
   ```

4. **Run the project:**
   ```sh
   dotnet run --project Assignment
   ```

5. **Use the menu system:**
   Follow the prompts on the console to select and run a specific assignment or task.

## Assignments
### Assignment One
- **Focus Areas:** Introduction, data types, and flow control.
- **Components:**
    - Theory solutions in `AssignmentOne/Assignment One Theory Solution.md`.
    - Mini-projects in `AssignmentOne/MiniAssignment1`.

### Assignment Two
- **Focus Areas:** Arrays, strings, and advanced flow.
- **Components:**
    - Theory solutions in `AssignmentTwo/Assignment Two Theory Solution.md`.
    - Mini-projects in `AssignmentTwo/MiniAssignment2`.

### Assignment Three
- **Focus Areas:** Object-oriented programming (classes, inheritance, and interfaces).
- **Components:**
    - Theory solutions in `AssignmentThree/Assignment Three Theory Solution.md`.
    - Mini-projects in `AssignmentThree/MiniAssignment3`.

Each assignment folder contains a "Theory" subfolder for written Q&A and a "Tasks" subfolder for the code-based exercises. The dashboards in `Assignment/Helpers/Dashboards` make it easy to select and run each set of tasks.

## Disclaimer
This README may be updated periodically as the repository evolves and more assignments are added. The general structure of the base will remain the same, so future instructions and usage guidelines can be generalized accordingly.
