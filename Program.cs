using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("🎯 Object-Oriented Programming Demos");
            Console.WriteLine("1. Inheritance and Method Overriding (Animal Sounds)");
            Console.WriteLine("2. Abstract Classes and Methods (Shape Areas)");
            Console.WriteLine("3. Interfaces (IMovable)");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter your choice (1-4): ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DemoInheritance();
                    break;
                case "2":
                    DemoAbstractClasses();
                    break;
                case "3":
                    DemoInterfaces();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void DemoInheritance()
    {
        Console.WriteLine("\n--- Inheritance & Method Overriding ---");
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        animal.MakeSound();  // Some generic sound
        dog.MakeSound();     // Bark
        cat.MakeSound();     // Meow
    }

    static void DemoAbstractClasses()
    {
        Console.WriteLine("\n--- Abstract Classes & GetArea() ---");

        // Input for Circle
        double radius = ReadDouble("Enter the radius of the circle: ");
        Shape circle = new Circle(radius);

        // Input for Rectangle
        double width = ReadDouble("Enter the width of the rectangle: ");
        double height = ReadDouble("Enter the height of the rectangle: ");
        Shape rectangle = new Rectangle(width, height);

        // Output areas
        Console.WriteLine($"\nCircle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
    }

    static void DemoInterfaces()
    {
        Console.WriteLine("\n--- Interfaces (IMovable) ---");

        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();      // Car is moving
        bicycle.Move();  // Bicycle is moving
    }

    // Helper method to safely read double from user
    static double ReadDouble(string prompt)
    {
        double result;
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out result) && result >= 0)
            {
                return result;
            }
            Console.WriteLine("Please enter a valid non-negative number.");
        } while (true);
    }
}