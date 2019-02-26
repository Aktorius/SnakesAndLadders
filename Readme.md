# Snakes And Ladders

This repository contains the solutions for the Snake and Ladders kata

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

The application is developed using .NET Core 2.1 so please make sure you have it installed on your machine

### Installing

Clone the repository on your local machine

## Running the tests

Within visual studio use the test runner explorer or use the command "dotnet test" from the CLI


## Breaking down the solution

The application is broken down into five projects in which two are unit tests projects

- SnakesAndLadders.Models: contains the definition of the domain of the application
- SnakesAndLadders.Core: contains the implementation of the core busiess logic
- SnakesAndLadders.Application: contains the presentation layer to use the application and actually play (not implemented in the scope of this exercise)
- Tests.SnakesAndLadders.Models: test projects to validate the domain
- Tests.SnakesAndLadders.Core: test project to valide the code features

## Assumptions

For the purpose of this exercise I have assumed that the value of the parameters for the different methods was correct. In a real life example I would have added more check and custom exceptions.


## Author

* *Tarik Miri*