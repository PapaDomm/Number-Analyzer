//Declaring bool for program loop
bool runProgram = true;

//Main Program loop
while (runProgram)
{
    //Getting the Users name
    Console.Write("Hello User! Welcome to the Number Analyzer! What is your name? ");
    string userName = Console.ReadLine();
    Console.WriteLine();

    //Starting the Analyzer
    Console.Write($"Hello {userName}, please enter a number from 1 to 100 ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine();

    //Checking for a correct input from user
    if (number < 1 || number > 100)
    {
        //Setting up loop to keep asking user for correct input
        bool invalidInput = true;
        while (invalidInput)
        {
            Console.WriteLine($"Sorry {userName}, but that isn't a number from 1 to 100");
            Console.Write("Try again, enter a number from 1 to 100 ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Breaking loop if input is finally correct
            if (number >= 1 && number <= 100)
            {
                invalidInput = false;
            }
        }
    }

    Console.WriteLine($"Great job {userName}, that's a number we can analyze! Let's take a look at that for you.");

    if(number < 60 && number % 2 == 1)
    {
        Console.WriteLine($"Your number is odd and less than 60, {userName}");
    }
    else if (number % 2 == 0 && number >= 2 && number <= 24)
    {
        Console.WriteLine($"Your number is even and less than 25, {userName}");
    }
    else if (number % 2 == 0 && number >=26 && number <= 60)
    {
        Console.WriteLine($"Your number is even and between 26 and 60 inclusive, {userName}");
    }
    else if (number % 2 == 0 && number > 60)
    {
        Console.WriteLine($"Your number is even and greater than 60, {userName}");
    }
    else
    {
        Console.WriteLine($"Your number is odd and greater than 60, {userName}");
    }

    Console.WriteLine();
    Console.Write("Would you like to restart the number analyzer?(Y/N) ");
    string answer = Console.ReadLine();
    
    while (answer.ToUpper() != "Y" && answer.ToUpper() != "N")
    {
        Console.WriteLine($"Please enter a valid answer {userName}, you're testing my paitience");
        Console.WriteLine();
        Console.Write("Would you like to restart the number analyzer?(Y/N) ");
        answer = Console.ReadLine();
    }

    if(answer.ToUpper() == "N")
    {
        runProgram = false;
    }
    Console.WriteLine();
}