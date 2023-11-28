// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.X86;
using System;



namespace Application
{
    public class Person
    {
        private  string? firstName;
        private string? lastName;
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


    public class Execute
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executing");
            Person p1 = new();
            p1.SetFirstName("Aronno");
            p1.SetLastName("Ahsan");
            string name = p1.GetFullName();
            Console.WriteLine(name);
        }

    }
}




