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
                Console.Write("Input a string: ");
                string value1 = Console.ReadLine();
                AssignmentMethods.LengthOfLastWord(value1);
                break;
            case '2':
                Console.WriteLine("2. Write a program in C# Sharp to print the first n natural number using recursion.");
                Console.Write("How many numbers to print: ");
                bool flag2 = false;
                while (!flag2)
                {
                    flag2 = int.TryParse(Console.ReadLine(), out int value2);
                    if (flag2)
                    {
                        AssignmentMethods.RecursivePrintNaturalNumbers(value2);
                        break;
                    }
                    else
                    {
                        Console.Write("Input is not an integer. How many numbers to print: ");
                    }
                }
                break;
            case '3':
                Console.WriteLine("3. Write a program in C# Sharp to print numbers from n to 1 using recursion.");
                Console.Write("How many numbers to print: ");
                bool flag3 = false;
                while (!flag3)
                {
                    flag3 = int.TryParse(Console.ReadLine(), out int value3);
                    if (flag3)
                    {
                        AssignmentMethods.RecursivePrintNaturalNumbersReverse(value3);
                        break;
                    }
                    else
                    {
                        Console.Write("Input is not an integer. How many numbers to print: ");
                    }
                }
                break;
            case '4':
                Console.WriteLine("4. Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.");
                Console.Write("Input a string: ");
                string value4 = Console.ReadLine();
                Console.WriteLine($"Is '{value4}' a palindrome: {AssignmentMethods.IsPalindromeRecursion(value4)}");
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