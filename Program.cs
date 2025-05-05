using Assignment_5._2;

mainMenu();


void mainMenu()
{
    char choice;
    do
    {
        Console.WriteLine("Select Assignment");
        Console.WriteLine("1: 5.2.1");
        Console.WriteLine("2: 5.2.2");
        Console.WriteLine("3: 5.2.3");
        Console.WriteLine("4: 5.2.4");
        Console.WriteLine("q: quit");
        choice = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Clear();
        switch (choice)
        {
            case '1':
                Console.WriteLine("1. Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.\n");
                AssignmentMethods.LengthOfLastWord("Hello World");
                AssignmentMethods.LengthOfLastWord(" fly me to the moon ");
                break;
            case '2':
                Console.WriteLine("2. Write a program in C# Sharp to print the first n natural number using recursion.");
                Console.Write("How many numbers to print: ");
                int value2;
                int.TryParse(Console.ReadLine(), out value2);
                AssignmentMethods.RecursivePrintNaturalNumbers(value2);
                break;
            case '3':
                Console.WriteLine("3. Write a program in C# Sharp to print numbers from n to 1 using recursion.");
                Console.Write("How many numbers to print: ");
                int value3;
                int.TryParse(Console.ReadLine(), out value3);
                AssignmentMethods.RecursivePrintNaturalNumbers(value3);
                break;
            case '4':
                Console.WriteLine("4. Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.");
                break;
            case 'q':
                Console.WriteLine("Quitting program...");
                return;
        }
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
        Console.Clear();
    } while (choice != 'q');
}