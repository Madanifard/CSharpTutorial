namespace CSharpTutorial.Helpers;

internal class VariableUtils
{
    public void varibales()
    {
        int age = 21;
        Console.WriteLine(age); // 21

        int? number2 = null;
        Console.WriteLine(number2); // noting 

        string name = string.Empty;
        Console.WriteLine(name); // noting

        string? nameOptional = null;
        Console.WriteLine(nameOptional);

        string family = "MD";
        Console.WriteLine(family); // MD

        bool isActive = false;
        Console.WriteLine(isActive); // False

        double pi = 3.14;

        Console.WriteLine(pi); // 3.14

        int[] numbers = new int[] { 1, 2, 3, 5 };
        Console.WriteLine(numbers); // System.Int32[]

        string firstName = "Sudhir";
        string lastName = "Sharma";
        int userAge = 28;
        Console.WriteLine("User: " + firstName + " " + lastName + " Age: " + userAge); // User: Sudhir Sharma Age: 28
        Console.WriteLine("Age: " + userAge); // Age: 28


        bool isMember = true;
        if (isMember)
        {
            Console.WriteLine("Welcome, valued member!"); // Welcome, valued member!
        }
        else
        {
            Console.WriteLine("Please sign up for a membership.");
        }


        // The constants refer to fixed values that the program may not alter during its execution.
        // These fixed values are also called literals.
        // const <data_type> <constant_name> = value;
        const double PI_NUMBER = 3.14;
        Console.WriteLine(PI_NUMBER);
        //PI_NUMBER = 10; get error

        // You can define a class constant by using the following syntax:
        // like this
        //class ClassName
        //{
        //    public const datatype ConstantName = value;
        //}

    }
}
