/*
    Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input. The program should:

    Prompt the user to enter two numbers.

    Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).

    Use conditional statements to perform the selected operation.

    Print the result of the operation to the console.

    Handle division by zero with a specific message.
*/


int firstNumber, secondNumber;
char operation;
float result = 0f;

Console.WriteLine("Enter the first number:");
while (!int.TryParse(Console.ReadLine(), out firstNumber))
    Console.WriteLine("Please enter a valid integer.");

Console.WriteLine("Enter the second number:");
while (!int.TryParse(Console.ReadLine(), out secondNumber))
    Console.WriteLine("Please enter a valid integer.");

do
{
    Console.WriteLine("Enter an operator (+, -, *, /):");
} while (!char.TryParse(Console.ReadLine(), out operation) ||
         (operation != '+' && operation != '-' && operation != '*' && operation != '/'));

switch (operation)
{
    case '+':
        result = firstNumber + secondNumber;
        break;
    case '-':
        result = firstNumber - secondNumber;
        break;
    case '*':
        result = firstNumber * secondNumber;
        break;
    case '/':
        if (secondNumber == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        result = (float)firstNumber / secondNumber;
        result = (float)Math.Round(result, 2);
        break;
}

Console.WriteLine($"\nResult: {result}");
Console.ReadKey();