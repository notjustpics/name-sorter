# 🧠 Name Sorter

A clean, simple C# console application that sorts a list of full names by **last name**, then **given names**, and outputs the sorted list to both the console and a file.

---

## 📋 Features

- ✅ Reads names from a provided `.txt` file
- ✅ Sorts names by **last name**, then by **given names**
- ✅ Prints sorted names to the screen
- ✅ Saves sorted names to `sorted-names-list.txt`
- ✅ Includes unit tests for sorting logic
- ✅ GitHub Actions CI pipeline runs build and tests automatically
- ✅ Minimal, practical documentation (this file!)

---

## 🧾 Input Example

The input file should contain one full name per line, like so:

Janet Parsons
Vaughn Lewis
Adonis Julius Archer
Shelby Nathan Yoder
Marin Alvarez


---

## 🧮 Sorting Rules

Names are sorted:
1. By **last name**
2. If last names match, by **all given names**

Example:

Adonis Julius Archer
Marin Alvarez
Vaughn Lewis
Janet Parsons
Shelby Nathan Yoder


---

## 🏁 How to Run the Application

### ✅ Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download) installed
- An input file (e.g., `unsorted-names-list.txt`)

### ▶️ Run from Terminal or Command Line

```bash
dotnet run --project NameSorter "unsorted-names-list.txt"

Run from Visual Studio
Right-click the NameSorter project > Properties

Go to the Debug tab

In Application arguments, add:

unsorted-names-list.txt

Press F5 to run

Output
Printed to the terminal (console)

Written to sorted-names-list.txt (overwrites every run)

## Running Unit Tests
This solution includes a test project called NameSorter.Tests.

To run the tests:

dotnet test

### Run
```
dotnet run --project NameSorter ./unsorted-names-list.txt

## Tests cover:

Sorting logic

Multiple given names

Same last names

File handling (mocked if applicable)

## Continuous Integration (CI)
GitHub Actions pipeline is configured to:

Build the project

Restore dependencies

Run unit tests on every push to main

name: .NET Build and Test

on:
  push:
    branches: [ main ]
  pull_request:
    branches: [ main ]

jobs:
  build:
    runs-on: ubuntu-latest
    steps:
    - uses: actions/checkout@v3
    - uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '8.0.x'
    - run: dotnet restore
    - run: dotnet build --no-restore
    - run: dotnet test --no-build --verbosity normal

## Project Structure

/NameSorter
  Program.cs
  Models/
  Services/
  sorted-names-list.txt (output)

NameSorter.Tests/
  NameSorterTests.cs

.github/
  workflows/
    dotnet.yml

ReadMe.md

## Author
Liz Smit
