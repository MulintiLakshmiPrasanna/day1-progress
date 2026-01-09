// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your age:");

string ageInput = Console.ReadLine();
int age;

bool isValidAge = int.TryParse(ageInput, out age);

if (isValidAge)
{
    if (age >= 18)
    {
        Console.WriteLine("You are eligible to vote.");
    }
    else
    {
        Console.WriteLine("You are not eligible to vote.");
    }
}
else
{
    Console.WriteLine("Please enter a valid number.");
}

