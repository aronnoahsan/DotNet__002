// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;

int age = 18;
Console.WriteLine($"The age is {age}");
double height = 1.8, weight = 65, bmi;
bmi = weight / Math.Pow(height, 2);
Console.WriteLine($"The BMI is {bmi:0.###}");
bool result = 0.3 == 0.1 + 0.2;
Console.WriteLine(result);
bool result2 = "a" == "a";
Console.WriteLine(result2);
char c1 = 'a', c2 = 'b';
bool result3 = c1 < c2;
Console.WriteLine(result3);
string message = "Hello World";
Console.WriteLine(message);
Console.WriteLine(message.Length);
Console.WriteLine(message[4]);
class Person
{
   private  string firstName;
    private string lastName;
    private int age;
    private bool isValidName( string? name)
    {
        return !string.IsNullOrEmpty(name);
    }

    public string GetFullName()
    {
        return $"{this.firstName} {this.lastName}";
    }

    public Person SetFirstName(string? firstName)
    {
        if (isValidName(firstName))
        {
            this.firstName = firstName;
        }
        return this;
    }
    public Person SetLastName(string? lastName)
    {
        if (isValidName(lastName))
        {
            this.lastName = lastName;
        }
        return this;
    }
}
//Person p1 = new Person();
//Person p1 = new();

Person p1 = new();
