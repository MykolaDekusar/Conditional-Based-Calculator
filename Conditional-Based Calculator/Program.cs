/*
    Create a simple C# calculator program that performs basic arithmetic operations (+, -, *, /) based on user input. The program should:

    Prompt the user to enter two numbers.

    Prompt the user to choose an arithmetic operation (Addition, Subtraction, Multiplication, Division).

    Use conditional statements to perform the selected operation.

    Print the result of the operation to the console.

    Handle division by zero with a specific message.
*/


int firstNumber;
int secondNumber;
char aOperator;
float result = 0f;

Console.WriteLine("Enter the first number\n");
while(!int.TryParse(Console.ReadLine(), out firstNumber))
    Console.WriteLine("\nEnter a valid first number\n");

Console.WriteLine("\nEnter the second number\n");
while (!int.TryParse(Console.ReadLine(), out secondNumber))
    Console.WriteLine("Enter a valid second number");

Console.WriteLine("\nEnter an operator between +, -, *, / \n");

while (!char.TryParse(Console.ReadLine(), out aOperator))
        Console.WriteLine("\nEnter a valid char\n");

if (aOperator != '*' && aOperator != '+' && aOperator != '/' && aOperator != '-')
{
    Console.WriteLine("\nEnter a valid operator\n");
}
else
{
    switch (aOperator)
    {
        case '*':
            result = firstNumber * secondNumber;
            Console.WriteLine("\n" + result);
            break;
        case '-':
            result = firstNumber - secondNumber;
            Console.WriteLine("\n" + result);
            break;
        case '+':
            result = firstNumber + secondNumber;
            Console.WriteLine("\n" + result);
            break;
        case '/':
            if(secondNumber == 0)
            {
                Console.WriteLine("\nError: Division by zero is not allowed.");
                break;
            }
            result = firstNumber / secondNumber;
            Console.WriteLine("\n" + Math.Round(result, 2));
            break;
    }
}
Console.ReadKey();