using System;
//Personal Info
class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Please enter your name:");
    var name = Console.ReadLine();
    Console.WriteLine("Please enter your birthdate (MM/DD/YYYY):");
    var birthdate = Console.ReadLine();
    Console.WriteLine("Please enter your work phone number");
    var workphone = Console.ReadLine();
    Console.WriteLine("Please enter cellphone number");
    var cellphone = Console.ReadLine();
     // Display the entered information
  Console.WriteLine(name);
  Console.WriteLine(birthdate);
  Console.WriteLine($"work {workphone}");
  Console.WriteLine($"cell {cellphone}");
        }
    }