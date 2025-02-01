
```markdown
# Desktop Calculator in C# (Windows Forms)

A simple desktop calculator application built using **C#** and **Windows Forms**. This application allows users to perform basic arithmetic operations like addition, subtraction, multiplication, and division, providing a simple and interactive graphical user interface.

## Table of Contents
- [Project Overview](#project-overview)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Code Structure](#code-structure)
- [Contributing](#contributing)
- [License](#license)

## Project Overview

This project is a **basic calculator** developed in C# using the **Windows Forms** framework. The app evaluates basic arithmetic expressions entered by the user and displays the result on the same window.

### Key Components:
- **Buttons for digits and operators**: These allow the user to input numbers and mathematical operations.
- **Display Area**: The results are displayed in a `TextBox` that is set to read-only to prevent user modifications directly.
- **Functionality**: The app evaluates the mathematical expression typed by the user and shows the output after pressing the "=" button.

The purpose of this project is to demonstrate the use of C# and Windows Forms for creating a functional desktop application.

## Features
- **Basic Arithmetic Operations**: 
    - Addition (`+`)
    - Subtraction (`-`)
    - Multiplication (`*`)
    - Division (`/`)
- **Clear Button**: Clears the display when clicked.
- **Fixed Window Size**: The window size is fixed to prevent resizing.
- **Non-editable Textbox**: The textbox used to display results is set to read-only.

## Installation

To run this project locally, follow the steps below:

### Clone the Repository:
First, clone the repository to your local machine using Git. Open a terminal and run the following command:

```bash
git clone https://github.com/Abdulraheem232/Desktop-calculator-app-in-C-.git
```

### Open the Project:
1. Open the project in **Visual Studio** or any compatible IDE for C# development.
2. Make sure you have **.NET Framework** installed (the project uses Windows Forms which requires .NET Framework).
3. Build and run the project.

### Dependencies:
- **.NET Framework**: Ensure that your environment has .NET Framework installed to run Windows Forms applications.

## Usage

Once the project is running, you can interact with the calculator by:

1. **Clicking the Number Buttons**: To input numbers into the display.
2. **Clicking the Operator Buttons**: To perform basic mathematical operations (`+`, `-`, `*`, `/`).
3. **Pressing the "=" Button**: To evaluate the expression and display the result in the TextBox.
4. **Pressing the "C" Button**: To clear the display and reset the calculator.

### Example:
- If you enter `3 + 5 * 2` and click `=`, the result `13` will be shown.
  
## Code Structure

### Main Components:
- **Form1**: The main form of the application that contains the calculator interface.
- **`equal_button`**: This method handles the logic for evaluating the mathematical expression using `DataTable.Compute()`.
- **`button_click`**: This method is responsible for handling the digit and operator button clicks, appending the button's text to the display.
- **`clear_button`**: This method clears the text box to allow a fresh calculation.

### Main Functions:
1. **Equal Button (`equal_button`)**: Evaluates the expression typed in the `TextBox` and displays the result.
2. **Button Clicks (`button_click`)**: Updates the `TextBox` with the clicked button’s value (either a number or an operator).
3. **Clear Button (`clear_button`)**: Resets the calculator’s display when clicked.

```csharp
private void equal_button(object sender, EventArgs e)
{
    var result = new DataTable();
    var evaluatedResult = result.Compute(textBox1.Text, "");

    // Ensure the result is a valid numeric value and set it as a string
    textBox1.Text = evaluatedResult.ToString();
}

private void button_click(object sender, EventArgs e)
{
    Button clickedButton = sender as Button;
    textBox1.Text += clickedButton.Text;
}

private void clear_button(object sender, EventArgs e)
{
    textBox1.Text = "";
}
```

## Contributing

If you'd like to contribute to this project, feel free to fork the repository and submit pull requests. Whether it's fixing bugs, adding features, or improving documentation, contributions are welcome!

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add feature'`).
5. Push to the branch (`git push origin feature-name`).
6. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

For more details, visit the GitHub repository: [Desktop Calculator in C#](https://github.com/Abdulraheem232/)
```
