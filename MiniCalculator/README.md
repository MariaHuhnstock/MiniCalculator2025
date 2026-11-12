# MiniCalculator

A small console-based calculator developed in C# using Visual Studio.

## Project Overview

MiniCalculator is a simple command-line application that allows users to perform basic arithmetic operations on two integer values. Users select an operation and enter the two numbers through the console.

## Project Background

This project was developed as a small practical exercise in C# application development using Visual Studio during my internship at Buss-IT-Labs.

## Features

- Addition (`add`)
- Subtraction (`sub`)
- Multiplication (`mul`)
- Console-based user input
- Feedback for an invalid operation selection

## Technologies

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio
- **Application type:** Console application

## How to Run

1. Install the .NET 8 SDK.
2. Clone or download this repository.
3. Open `MiniCalculator.sln` in Visual Studio.
4. Build and run the project.

Alternatively, run it from a terminal:

```bash
dotnet run --project MiniCalculator/MiniCalculator.csproj
```

## Learning Objectives

This exercise provided practice with:

- Reading input from the console
- Converting user input into integer values
- Using `switch` statements to select program logic
- Performing basic arithmetic operations
- Displaying results and error messages

## Limitations and Future Improvements

The current version is intentionally minimal. Possible improvements for a future version include:

- Input validation to handle non-numeric values
- Support for division and decimal numbers
- Case-insensitive operation selection
- Repeating calculations without restarting the application
- Separating input handling and calculation logic

---

*This repository preserves an early version of the project and can serve as a reference point for future improvements.*
