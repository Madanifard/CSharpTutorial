using System;

namespace CSharpTutorial.Helpers
{
    internal class OperatorsUtils
    {
        public void ArithmeticOperation()
        {
            // Arithmetic Operators
            int x= 10, y= 20;
            Console.WriteLine("Addition: " + (x + y)); // Addition: 14
            Console.WriteLine("Multiplication: " + (x * y)); // Multiplication: 40
            Console.WriteLine("Modulo: " + (x % y)); // Modulo: 2


            // +   Adds two operands   A + B = 30
            // -   Subtracts second operand from the first  A - B = -10
            // *   Multiplies both operands  A * B = 200
            // /   Divides numerator by de - numerator  B / A = 2
            // %   Modulus Operator and remainder of after an integer division  B % A = 0
            // ++  Increment operator increases integer value by one  A++ = 11
            // --  Decrement operator decreases integer value by one A-- = 9

        }

        public void RelationalOperators()
        {
            // Relational Operators
            int a = 20, b = 15;
            Console.WriteLine("Is a > b? " + (a > b)); // Is a > b? True
            Console.WriteLine("Is a == b? " + (a == b)); // Is a == b? False

            // == Checks if the values of two operands are equal or not, if yes then condition becomes true.   (A == B) is not true.
            // != Checks if the values of two operands are equal or not, if values are not equal then condition becomes true.    (A != B) is true.
            // >  Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true.   (A > B) is not true.
            // <  Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true.  (A < B) is true.
            // >= Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true. (A >= B) is not true.
            // <= Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true.  (A <= B) is true.

        }

        public void LogicalOperators()
        {
            // Logical Operators
            bool x = true, y = false;
            Console.WriteLine("AND (&&) : " + (x && y)); // AND (&&) : False
            Console.WriteLine("OR (||)  : " + (x || y)); // OR (||)  : True
            Console.WriteLine("NOT (!)  : " + (!x)); // NOT (!)  : False

            // &&  Called Logical AND operator. If both the operands are non zero then condition becomes true.   (A && B) is false.
            // ||  Called Logical OR Operator.If any of the two operands is non zero then condition becomes true.  (A || B) is true.
            // !   Called Logical NOT Operator. Use to reverses the logical state of its operand.If a condition is true then Logical NOT operator will make false. !(A && B) is true.
        }

        public void BitwiseOperator()
        {
            int a = 5, b = 3;
            Console.WriteLine("Bitwise AND: " + (a & b)); // Bitwise AND: 1
            Console.WriteLine("Bitwise OR: " + (a | b)); // Bitwise OR: 7

            // &  Binary AND Operator copies a bit to the result if it exists in both operands.	(A & B) = 12, which is 0000 1100
            // |  Binary OR Operator copies a bit if it exists in either operand.	(A | B) = 61, which is 0011 1101
            // ^  Binary XOR Operator copies the bit if it is set in one operand but not both.    (A ^ B) = 49, which is 0011 0001
            // ~  Binary Ones Complement Operator is unary and has the effect of 'flipping' bits. (~A) = -61, which is 1100 0011 in 2's complement due to a signed binary number.
            // << Binary Left Shift Operator.The left operands value is moved left by the number of bits specified by the right operand.	A << 2 = 240, which is 1111 0000
            // >> Binary Right Shift Operator.The left operands value is moved right by the number of bits specified by the right operand.	A >> 2 = 15, which is 0000 1111
        }

        public void AssignmentOperators()
        {
            int num = 10;
            num += 5;  // Equivalent to num = num + 5
            Console.WriteLine(num); // 15

            // =   Simple assignment operator, Assigns values from right side operands to left side operand    C = A + B assigns value of A +B into C
            // +=  Add AND assignment operator, It adds right operand to the left operand and assign the result to left operand    C += A is equivalent to C = C + A
            // -=  Subtract AND assignment operator, It subtracts right operand from the left operand and assign the result to left operand    C -= A is equivalent to C = C - A
            // *=  Multiply AND assignment operator, It multiplies right operand with the left operand and assign the result to left operand   C *= A is equivalent to C = C * A
            // /=  Divide AND assignment operator, It divides left operand with the right operand and assign the result to left operand    C /= A is equivalent to C = C / A
            // %=  Modulus AND assignment operator, It takes modulus using two operands and assign the result to left operand C %= A is equivalent to C = C % A
            // <<= Left shift AND assignment operator	C <<= 2 is same as C = C << 2
            // >>= Right shift AND assignment operator	C >>= 2 is same as C = C >> 2
            // &=  Bitwise AND assignment operator	C &= 2 is same as C = C & 2
            // ^=  bitwise exclusive OR and assignment operator	C ^= 2 is same as C = C ^ 2
            // |=  bitwise inclusive OR and assignment operator	C |= 2 is same as C = C | 2
        }

        public void TernaryOperator()
        {
            int age = 18;
            string result = (age >= 18) ? "Eligible to vote" : "Not eligible";
            Console.WriteLine(result); // Eligible to vote
        }

        public void MiscellaneousOperators()
        {
            // operators are basically used for type checking
            // typeof operator
            Console.WriteLine("Type of int: " + typeof(int)); // Type of int: System.Int32

            // sizeof operator
            Console.WriteLine("Size of int: " + sizeof(int)); // Size of int: 4

            // is operator
            object obj = "Hello";
            Console.WriteLine("Is obj a string? " + (obj is string)); // Is obj a string? True

            // as operator
            object number = 42;
            string str = number as string;
            Console.WriteLine("Using 'as' operator: " + (str ?? "Conversion failed")); // Using 'as' operator: Conversion failed

            // nameof operator
            string variableName = nameof(number);
            Console.WriteLine("Variable name: " + variableName); // Variable name: number


            // sizeof()    Returns the size of a data type.    sizeof(int), returns 4.
            // typeof()    Returns the type of a class.	typeof(StreamReader);
            // &	       Returns the address of an variable. &a; returns actual address of the variable.
            // *	       Pointer to a variable.	*a; creates pointer named 'a' to a variable.
            // ? :	       Conditional Expression  If Condition is true ? Then value X : Otherwise value Y
            // is          Determines whether an object is of a certain type.If(Ford is Car) // checks if Ford is an object of the Car class.
            // as	       Cast without raising an exception if the cast fails.Object obj = new StringReader("Hello");
            //             StringReader r = obj as StringReader;
    }
    }
}
