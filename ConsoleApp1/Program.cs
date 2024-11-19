using System;

namespace Exercises
{
    class VariableRenaming
    {
        static void Main(string[] args)
        {
            // Definisanje varijabli
            string firstUserName;
            int birthDate;
            float firstOperand;

            // Unos imena korisnika
            Console.Write("Enter your name: ");
            firstUserName = Console.ReadLine();

            // Unos datuma rođenja s provjerom ispravnosti
            Console.Write("Enter your birth year (e.g., 1990): ");
            while (!int.TryParse(Console.ReadLine(), out birthDate) || birthDate < 1900 || birthDate > DateTime.Now.Year)
            {
                Console.Write("Invalid input. Please enter a valid birth year: ");
            }

            // Unos operanda s provjerom ispravnosti
            Console.Write("Enter a decimal number (e.g., 12.34): ");
            while (!float.TryParse(Console.ReadLine(), out firstOperand))
            {
                Console.Write("Invalid input. Please enter a valid decimal number: ");
            }

            // Prikaz unesenih podataka
            Console.WriteLine("\nVariables renamed and data captured successfully!");
            Console.WriteLine($"Name: {firstUserName}");
            Console.WriteLine($"Birth Year: {birthDate}");
            Console.WriteLine($"Operand: {firstOperand}");
        }
    }
}
