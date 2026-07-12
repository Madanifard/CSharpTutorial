namespace CSharpTutorial.Helpers;

internal class LoopsUtils
{
    public void ForLoop()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        // 1
        // 2
        // 3
        // 5
        // 6
    }

    public void WileLoop()
    {
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine("Numbers: " + i);
            i++;
        }
        // Number: 1
        // Number: 2
        // Number: 3
        // Number: 4
        // Number: 5
    }

    public void ForLoop2()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
        }
        // Number: 1
        // Number: 2
        // Number: 3
        // Number: 4
        // Number: 5
    }

    public void DoWhileLoop()
    {
        int i = 1;
        do
        {
            Console.WriteLine("Number: " + (i));
            i++;
        } while (i <= 5);
        // Number: 1
        // Number: 2
        // Number: 3
        // Number: 4
        // Number: 5
    }

    public void BreakStatement()
    {
        int count = 0;
        for (int i = 0; i <= count; i++)
        {
            if (i == 3)
            {
                break;
            }
            Console.WriteLine(i);
        }
        // 1
        // 2
    }

    public void ContinueStatement()
    {
        /* local variable definition */
        int a = 10;

        /* do loop execution */
        do
        {
            if (a == 15)
            {
                /* skip the iteration */
                a = a + 1;
                continue;
            }
            Console.WriteLine("value of a: {0}", a);
            a++;
        }
        while (a < 20);
        Console.ReadLine();

        // value of a: 10
        // value of a: 11
        // value of a: 12
        // value of a: 13
        // value of a: 14
        // value of a: 16
        // value of a: 17
        // value of a: 18
        // value of a: 19

    }

    public void ContinueStatementInForLoop()
    {
        for (int i = 1; i <= 10; i++)
        {
            // Skip even numbers
            if (i % 2 == 0)
            {
                // Jump to the next iteration
                continue;
            }
            Console.WriteLine("Odd number: " + i);
        }
        Console.WriteLine("Loop completed.");

        // Odd number: 1
        // Odd number: 3
        // Odd number: 5
        // Odd number: 7
        // Odd number: 9
        // Loop completed.
    }

    public void InfiniteLoop()
    {
        for (; ; )
        {
            Console.WriteLine("Hey! I am Trapped");
        }
    }

    public void NestedForLoop()
    {
        int i, j;

        for (i = 2; i < 100; i++)
        {
            for (j = 2; j <= (i / j); j++)
                if ((i % j) == 0) break; // if factor found, not prime
            if (j > (i / j)) Console.WriteLine("{0} is prime", i);
        }
        Console.ReadLine();

        // 2 is prime
        // 3 is prime
        // 5 is prime
        // 7 is prime
        // 11 is prime
        // 13 is prime
        // 17 is prime
        // 19 is prime
        // 23 is prime
        // 29 is prime
        // 31 is prime
        // 37 is prime
        // 41 is prime
        // 43 is prime
        // 47 is prime
        // 53 is prime
        // 59 is prime
        // 61 is prime
        // 67 is prime
        // 71 is prime
        // 73 is prime
        // 79 is prime
        // 83 is prime
        // 89 is prime
        // 97 is prime
    }

    public void NestedWhileLoops()
    {
        int i = 2, j;

        // Outer loop
        while (i < 100)
        {
            j = 2;
            // Inner loop
            while (j <= (i / j))
            {
                if ((i % j) == 0)
                    // If factor found, not prime
                    break;
                j++;
            }
            if (j > (i / j))
                Console.WriteLine("{0} is prime", i);
            i++;
        }
        Console.ReadLine();

        // 2 is prime
        // 3 is prime
        // 5 is prime
        // 7 is prime
        // 11 is prime
        // 13 is prime
        // 17 is prime
        // 19 is prime
        // 23 is prime
        // 29 is prime
        // 31 is prime
        // 37 is prime
        // 41 is prime
        // 43 is prime
        // 47 is prime
        // 53 is prime
        // 59 is prime
        // 61 is prime
        // 67 is prime
        // 71 is prime
        // 73 is prime
        // 79 is prime
        // 83 is prime
        // 89 is prime
        // 97 is prime
    }

    public void NestedDoWhileLoops()
    {
        int i = 2, j;

        // Outer loop
        do
        {
            j = 2;

            // Inner loop
            do
            {
                if ((i % j) == 0)
                    break; // If factor found, not prime
                j++;
            } while (j <= (i / j));

            if (j > (i / j))
                Console.WriteLine("{0} is prime", i);

            i++;
        } while (i < 100);

        Console.ReadLine();

        // 2 is prime
        // 3 is prime
        // 5 is prime
        // 7 is prime
        // 11 is prime
        // 13 is prime
        // 17 is prime
        // 19 is prime
        // 23 is prime
        // 29 is prime
        // 31 is prime
        // 37 is prime
        // 41 is prime
        // 43 is prime
        // 47 is prime
        // 53 is prime
        // 59 is prime
        // 61 is prime
        // 67 is prime
        // 71 is prime
        // 73 is prime
        // 79 is prime
        // 83 is prime
        // 89 is prime
        // 97 is prime
    }

    public void FoorEachLoop()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int num in numbers)
        {
            Console.WriteLine($"Number: {num}");
        }
        // Number: 10
        // Number: 20
        // Number: 30
        // Number: 40
        // Number: 50
    }

    public void ForeachWithArrays()
    {
        // Define an array of numbers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Loop through each number and print it
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        // 1
        // 2
        // 3
        // 4
        // 5
    }

    public void NestedForeachLoops()
    {
        // Define array of arrays
        int[][] matrix = new int[][]{
         new int[] {1, 2},
         new int[] {3, 4},
         new int[] {5, 6}
      };

        // Loop through each row and print its elements
        foreach (int[] row in matrix)
        {
            foreach (int item in row)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); // Move to the next line after each row
        }

        // 1 2
        // 3 4
        // 5 6
    }

    public void ForeachWithLists()
    {
        // Create a list containing fruit names
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };

        // Display all fruits from the list
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Apple
        // Banana
        // Orange
    }

    public void ForeachWithDictionaries()
    {
        // Create a dictionary with student IDs and names
        Dictionary<int, string> students = new Dictionary<int, string> {
         { 1, "John" },
         { 2, "Sarah" },
         { 3, "Mike" }
      };

        foreach (KeyValuePair<int, string> student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }

        // ID: 1, Name: John
        // ID: 2, Name: Sarah
        // ID: 3, Name: Mike
    }

    // Limitations and Common Errors
    //
    // Loop Variable is Read-Only
    // foreach (int num in numbers){
    //     num = num* 2; //  Error: cannot reassign loop variable
    //     Console.WriteLine(num); // Allowed: reading value
    // }
    //
    // Cannot Modify the Collection While Iterating
    // foreach (int num in numbers){
    //     if (num == 3)
    //     numbers.Remove(num);  // InvalidOperationException
    //  }
    // 

    class Person
    {
        public required string Name { get; set; }
        public int Age { get; set; }
    }

    public void ForeachWithObjects()
    {
        // Create a list of people
        List<Person> people = new List<Person> {
         new Person { Name = "John", Age = 30 },
         new Person { Name = "Sarah", Age = 25 }
      };

        // Update age of each person by 1
        foreach (Person person in people)
        {
            person.Age += 1;  // Modifying object property is allowed
        }

        // Print updated ages
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name}: {person.Age}");
        }

        // John: 31
        // Sarah: 26
    }

    public void IndexAccessForeach()
    {
        string[] names = { "Alice", "Bob", "Charlie" };
        int index = 0;

        foreach (string name in names)
        {
            Console.WriteLine($"Index: {index}, Name: {name}");
            index++;
        }
        // Index: 0, Name: Alice
        // Index: 1, Name: Bob
        // Index: 2, Name: Charlie
    }
}
