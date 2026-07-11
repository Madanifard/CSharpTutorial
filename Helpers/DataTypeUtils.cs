namespace CSharpTutorial.Helpers
{
    // int	4 bytes (Stores whole numbers from -2,147,483,648 to 2,147,483,647)
    // long	8 bytes (Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
    // float 4 bytes (Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits)
    // double 8 bytes (Stores fractional numbers. Sufficient for storing 15 decimal digits)
    // bool	1 byte	(Stores true or false values)
    // char	2 bytes	(Stores a single character/letter, surrounded by single quotes)
    // string 2 bytes (per character	Stores a sequence of characters, surrounded by double quotes)

    public class DataTypeUtils
    {
        public void SampleDataType()
        {

            int myNum_int = 100000;
            Console.WriteLine(myNum_int); // 100000

            long myNum_long = 15000000000L;
            Console.WriteLine(myNum_long); // 15000000000

            float myNum_float = 5.75F;
            Console.WriteLine(myNum_float); // 5.75

            double myNum_double = 19.99D;
            Console.WriteLine(myNum_double); // 19.99

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            char myGrade = 'B';
            Console.WriteLine(myGrade);

            string greeting = "Hello World";
            Console.WriteLine(greeting);
        }

        public void SampleTypeCasting()
        {
            //Type casting is when you assign a value of one data type to another type.
            // In C#, there are two types of casting:

            // Implicit Casting (automatically) - converting a smaller type to a larger type size
            // char -> int -> long -> float -> double

            // Explicit Casting (manually) - converting a larger type to a smaller size type
            // double -> float -> long -> int -> char


            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9


            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9
        }

        public void SampleConverting()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}