namespace CSharpTutorial.Helpers;

internal class DecisionMakingUtils
{
    public void IfStatement()
    {
        // Define a local variable
        int temperature = 30;

        // Check the condition using nested if statements
        if (temperature > 0)
        {
            if (temperature < 15)
            {
                Console.WriteLine("It's a cold day.");
            }
            else if (temperature <= 15 && temperature >= 25)
            {
                Console.WriteLine("The weather is pleasant.");
            }
            else
            {
                Console.WriteLine("It's a hot day.");
            }
        }
        else
        {
            Console.WriteLine("It's freezing outside!");
        }

        Console.WriteLine($"Current temperature: {temperature} degree C");
    }

    public void SwitchStatement()
    {
        int day = 3;

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number! Please enter a number between 1 and 7.");
                break;
        }
    }

    public void NestedSwitchStatement()
    {
        int a = 100;
        int b = 200;

        switch (a)
        {
            case 100:
                Console.WriteLine("This is part of outer switch ");

                switch (b)
                {
                    case 200:
                        Console.WriteLine("This is part of inner switch ");
                        break;
                }
                break;
        }
        Console.WriteLine("Exact value of a is : {0}", a);
        Console.WriteLine("Exact value of b is : {0}", b);
        Console.ReadLine();
    }
}
