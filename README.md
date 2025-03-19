# Classic Calculator WPF app
A simple calculator application for Windows desktop giving a feel of using an old school physical calculator device.

## Table of Contents
- [Description](#description)
- [Features](#features)
- [Usage](#usage)
- [License](#license)

## Description
It's a Windows desktop application built using WPF. 

This project is just a frontend and for internal calculator logic it uses my ClassicCalculator Nuget package. Thanks to that it is focused solely on the presentation layer, not on the business logic.

## Features
The application provides the functionality of a simple calculator with a display showing just one number and the following buttons:
- Digits (0-9)
- Decimal point (.)
- Toggle sign (+/-)
- Add (+)
- Subtract (-)
- Multiply (*)
- Divide (/)
- Calculate/Equals (=)
- Percent (%)
- Sqaure root (√)
- Clear (C)

The behaviour follows quite closely my own physical calculator device.

## Usage
```bash
git clone https://github.com/r-dziewaltowski/ClassicCalculatorWpfApp.git
cd .\ClassicCalculatorWpfApp\
dotnet run --project .\src\ClassicCalculatorWpfApp\
```

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

