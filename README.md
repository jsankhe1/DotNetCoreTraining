# .NetCoreTraining

This repository is a personal space to explore and practice various concepts of the .NET Core framework by working through assignments and mini-projects.

## Table of Contents
- [Purpose](#purpose)
- [Project Structure](#project-structure)
- [How to Run](#how-to-run)
- [Assignments Overview](#assignments-overview)

## Purpose
The goal of this repo is to deepen understanding of .NET Core by trying out different coding exercises, creating console applications, and learning best practices. The projects showcase fundamental topics like data types, control flow, enums, class design, and more.

## Project Structure
The main folders and files are outlined below:

- [`.idea`](.idea )  
  IDE-specific settings and cache files.

- [`Assignment`](Assignment )  
  - **Assignment.csproj** – Project file defining build settings and dependencies.  
  - **Program.cs** – Main entry point, runs an assignment dashboard.  
  - **AssignmentOne/** – Contains theory solutions and mini-projects for Assignment One.  
    - **Assignment One Theory Solution.md** – Written answers to textual questions.  
    - **MiniAssignment1/** – Code for the first set of mini tasks.  
    - **MiniAssignment2/** – Code for the second set of mini tasks.  
  - **Helpers/** – Utility classes used throughout the project.  
    - **AssignmentTasks.cs** – Enum defining menu options.  
    - **MenuHandler.cs** – Handles menu logic and calls the corresponding mini assignment code.  
    - **AssignmentOneDashboard.cs** – Runs a loop to handle user input and show a simplified menu.  
    - **ConsolePrintingPretty.cs** – Helper for printing centered text in the console.  
  - **bin/** and **obj/** – Build outputs and intermediate files.



## How to Run
1. **Clone this repository**:
   
    - ```git clone https://github.com/jsankhe1/DotNetCoreTraining.git ```

2. **Open the solution:** 
    - Open DotNetCoreTraining.sln in your preferred editor or IDE (e.g., Visual Studio Code, Rider, or Visual Studio).

3. **Compile and run:**
    - Using your IDE’s build and run commands, or
    - Via terminal:
    > `` dotnet build``
    >
    >  ``dotnet run --project Assignment ``
4. **Follow the on-screen menu** to choose different tasks.

## Assignments Overview
- A theory solution file (Assignment One Theory Solution.md) with written Q&A.
- One or more mini assignments (in the MiniAssignment1/ and MiniAssignment2/ folders), each demonstrating specific C# concepts such as data types, loop constructs, or console input/output.

