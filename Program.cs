using System.Transactions;

int first_number;
int second_number;

Console.WriteLine("Welcome to my basic calculator!");
Console.Write("Enter the first number:" );
first_number = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the second number:" );
second_number = int.Parse(Console.ReadLine());

string option;
Console.WriteLine("Enter +, -, *, or /");
option = Console.ReadLine();

if (option == "+")
{
    Console.WriteLine("The solution is {0}", first_number + second_number);
} else if (option == "-")
{
    Console.WriteLine("The solution is {0}", first_number - second_number);
} else if (option == "*")
{
    Console.WriteLine("The solution is {0}", first_number - second_number);
} else if (option == "/")
{
    Console.WriteLine("The solution is {0}", first_number / second_number);
}
