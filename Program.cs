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
        switch (choice)
        {
            case '1':
                Console.Clear();
                Console.WriteLine("1. Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.\n");
                AssignmentMethods.LengthOfLastWord("Hello World");
                AssignmentMethods.LengthOfLastWord(" fly me to the moon ");

                break;
            case '2':
                break;
            case '3':
                break;
            case '4':
                break;
        }
        Console.WriteLine();
    } while (choice != 'q');
}