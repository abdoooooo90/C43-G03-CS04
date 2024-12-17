using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace se04
{
    #region Function (Q2 : EX)
    //class Person
    //{
    //    public string Name { get; set; }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line
            //Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            //double.TryParse(Console.ReadLine(), out double x1);
            //double.TryParse(Console.ReadLine(), out double y1);

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //double.TryParse(Console.ReadLine(), out double x2);
            //double.TryParse(Console.ReadLine(), out double y2);

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //double.TryParse(Console.ReadLine(),out double x3);
            //double.TryParse(Console.ReadLine(), out double y3);

            //comments
            // (y2 - y1) / (x2 - x1) == (y3 - y1) / (x3 - x1)
            // To avoid division by zero, cross-multiply:
            // (y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1)

            //if ((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
            //    Console.WriteLine("The points lie on a single straight line.");

            //else
            //    Console.WriteLine("The points do not lie on a single straight line.");

            #endregion

            #region 2
            //Console.Write("What The Time Taken For The Task In Hours: ");
            //double.TryParse(Console.ReadLine(), out double time);
            //if (time >= 2 && time < 3)
            //    Console.WriteLine("The worker is highly efficient");
            //else if (time >= 3 && time < 4)
            //    Console.WriteLine("The worker needs to improve speed.");
            //else if (time >= 4 && time <= 5)
            //    Console.WriteLine("The worker requires training to improve speed.");
            //else if (time > 5)
            //    Console.WriteLine("The worker needs to leave the company");
            //else
            //    Console.WriteLine("Invalid input. Please enter a time greater than or equal to 2 hours");

            #endregion

            #region 3- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n
            //Console.Write("Enter Size The Matrix(n * n): ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[,] matrix = new int[size, size];
            //if (size <= 0)
            //    Console.WriteLine("Invalid Input");
            //else
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = 0; j < size; j++)
            //        {
            //            Console.Write($"{j + 1} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            #endregion

            #region 20- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if(size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{

            //    int[] arr = new int[size];
            //    int sum = 0;
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for(int i = 0 ; i < arr.Length; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        arr[i] = int.Parse(Console.ReadLine());

            //        sum += arr[i];

            //    }
            //    Console.WriteLine($"The Sum Of All Element In The Array Is --> {sum}");
            //}
            #endregion

            #region 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr01 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The 1st Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        arr01[i] = int.Parse(Console.ReadLine());

            //    }
            //    int[] arr02 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The 2nd Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        arr02[i] = int.Parse(Console.ReadLine());

            //    }

            //    int index1 = 0, index2 = 0, indexmer = 0;
            //    int[] merge = new int[size * 2];

            //    while (index1 < size && index2 < size)
            //    {
            //        if (arr01[index1] < arr02[index2])
            //        {
            //            merge[indexmer++] = arr01[index1++];
            //        }
            //        else
            //        {
            //            merge[indexmer++] = arr02[index2++];
            //        }

            //    }
            //    // Add remaining elements from array01
            //    while (index1 < size)
            //    {
            //        merge[indexmer++] = arr01[index1++];
            //    }

            //    // Add remaining elements from array02
            //    while (index2 < size)
            //    {
            //        merge[indexmer++] = arr02[index2++];
            //    }
            //    Console.WriteLine("The merged array in ascending order is:");
            //    foreach (int i in merge)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region 22- Write a program in C# Sharp to count the frequency of each element of an array
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr03 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr03[i])))
            //            Console.WriteLine("Please Enter An Integer");   
            //    }
            //    bool[] visited = new bool[size]; // Array to keep track of visited elements

            //    Console.WriteLine("\nFrequency of Each Element:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (visited[i]) 
            //            continue;

            //        int count = 1; 
            //        for (int j = i + 1; j < size; j++)
            //        {
            //            if (arr03[i] == arr03[j])
            //            {
            //                count++;
            //                visited[j] = true;
            //            }
            //        }

            //        Console.WriteLine($"Element {arr03[i]} occurs {count} time(s).");
            //    }
            //}

            #endregion

            #region 23- Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size <= 0)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr04 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr04[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    Console.WriteLine($"Maximum Number In Array --> {arr04.Max()}");
            //    Console.WriteLine($"Minimum Number In Array --> {arr04.Min()}");

            //}
            #endregion

            #region 24- Write a program in C# Sharp to find the second largest element in an array
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 2)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr05 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr05[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    int[] ndLargest = new int[size - 1];
            //    for (int i = 0;i < size - 1;i++)
            //    {
            //        if (arr05[i] == arr05.Max())
            //            continue;
            //        else
            //            ndLargest[i] = arr05[i];
            //    }
            //    Console.WriteLine($"The Second Largest Element In An Array --> {ndLargest.Max()}");
            //}
            #endregion

            #region 25-. Consider an Array of Integer values with size N, having values as this Example
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 1)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr06 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1} ==> ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr06[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    int MaxDistance = 0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        for (int j = size - 1; j > 0; j--)
            //        {
            //            if (arr06[i] == arr06[j])
            //            {
            //                int distance = j - i;
            //                if (distance > MaxDistance) 
            //                {
            //                    MaxDistance = distance;
            //                }
            //            }

            //        }

            //    }
            //    Console.WriteLine($"The Longest Distance Between Two Equal Elements Is: {MaxDistance}");
            //}

            #endregion

            #region 26- Given a list of space separated words, reverse the order of the words
            //Console.Write("Enter The Words: ");
            //string word = Console.ReadLine();
            //string[] text = word.Split();
            //text = text.Reverse().ToArray();
            //string reverse = string.Join(" ", text);  //// Join(string separator, params obj[] array)
            //Console.WriteLine($"Reversed Words: {reverse}");
            #endregion

            #region 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //Console.Write("Enter Size Of Row: ");
            //bool r = int.TryParse(Console.ReadLine(), out int row);
            //Console.Write("Enter Size Of Column: ");
            //bool c = int.TryParse(Console.ReadLine(), out int column);

            //if(!c && !r || row <= 0 || column <= 0)
            //    Console.WriteLine("Please Enter Valid Positive Integers For Rows And Columns");
            //else
            //{
            //    int[,] multidimensional = new int[row, column];
            //    for(int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < column; j++)
            //        {
            //            Console.Write($"\nEnter element [{i + 1}, {j + 1}]: ");
            //            multidimensional[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //    int[,]code = new int[row, column];
            //    for (int i = 0; i < row; i++)
            //    {
            //        for (int j = 0; j < column; j++)
            //        {
            //            code[i, j] = multidimensional[i, j];
            //        }
            //    }
            //    Console.WriteLine("=======================Output================================");

            //    for (int i = 0;i < row; i++)
            //    {
            //        for(int j = 0;j < column; j++)
            //            Console.WriteLine($"The Element [{i + 1}, {j + 1}]: = {code[i,j]}");
            //    }
            //}
            #endregion

            #region 28- Write a Program to Print One Dimensional Array in Reverse Order
            //Console.Write("Enter Size Of The Array: ");
            //bool sizeCon = int.TryParse(Console.ReadLine(), out int size);
            //if(! sizeCon || size <= 0)
            //    Console.WriteLine("Please Enter Valid Positive Integers For Rows And Columns");
            //else
            //{
            //    int[] arr07 = new int[size];
            //    int[] Reverse00 = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < arr07.Length; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1}: ");
            //        arr07[i] = int.Parse(Console.ReadLine());
            //    }
            //    for (int i = 0; i < Reverse00.Length; i++)
            //    {
            //        Reverse00[i] = arr07[arr07.Length - 1 - i];
            //    }
            //    Console.WriteLine("Array in Reverse Order: ");
            //    foreach (int i in Reverse00)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion

            #region Functions 

            #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
            //// 1- Passing by Value:
            ////copy of the argument's value is passed to the method. The method works with this copy,
            ////and any changes made to the parameter inside the method do not affect the original
            ////variable outside the method
            //int num = 10;
            //update(num);
            //Console.WriteLine(num);  //Not Changes (num = 5)

            //// 2- Passing by Reference:
            ////the memory address of the original variable is passed to the method.
            ////This means that any changes made to the parameter inside the method will
            ////affect the original variable outside the method.

            //updatere(ref num);
            //Console.WriteLine(num); // output(num = 20)

            #endregion

            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example
            ////1- Passing Reference Type by Value
            //// a copy of the reference (i.e., memory address) is passed to the method.
            //// However, the method still works with the same object in memory.

            ////any changes made to the object's fields/properties inside the method will
            ////affect the original object. However, reassigning the reference to a new object
            ////inside the method does not affect the original reference outside the method
            ////EX:
            //Person person = new Person { Name = "John" };
            //update(person); // Passing by value
            //Console.WriteLine("Person's Name after method call: " + person.Name);

            ////2- Passing Reference Type by Reference:
            //// the method receives the memory address of the original object.
            //// This means the method can modify the original reference itself,
            //// not just the object it points to.
            //// and will affect the original variable in the calling method
            //Person person00 = new Person { Name = "John" };
            //updatere(ref person00); // Passing by reference using 'ref'
            //Console.WriteLine("Person's Name after method call: " + person.Name); // Output: "Mohamed"

            #endregion

            #region 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.Write("Enter The 1st Number: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter The 2nd Number: ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //calculator(num1, num2, out int sum, out int sub);
            //Console.WriteLine($"{num1} + {num2} = {sum}\n{num1} - {num2} = {sub}");
            #endregion

            #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given numbe
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int sum);
            //Console.WriteLine($"The Sum Of The Digits Of The Number {sum}: {sumDigits(sum)}");
            #endregion

            #region 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //Console.Write("Enter Size Of The Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //if (size < 2)
            //    Console.WriteLine("Invaild Input ");
            //else
            //{
            //    int[] arr = new int[size];
            //    Console.WriteLine("Enter The Elements Of The Array: ");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"Enter Element {i + 1}: ");
            //        while (!(int.TryParse(Console.ReadLine(), out arr[i])))
            //            Console.WriteLine("Please Enter An Integer");
            //    }
            //    MinMaxArray(arr, out int max, out int min);
            //    Console.WriteLine($"The Maximum Number: {max}\nThe Minimum Number: {min}");
            //}
            #endregion

            #region 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //bool flag;
            //int num;
            //do
            //{
            //    Console.Write("Enter The Number: ");
            //    flag = int.TryParse(Console.ReadLine(), out  num);
            //} while (!flag || num == 0);
            //Console.WriteLine($"Factorial of {num} is: { Factorial(num)}");
            #endregion

            #region 8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.Write("Enter The Text: ");
            //string str = Console.ReadLine();
            //Console.Write("Enter The Position: ");
            //int.TryParse(Console.ReadLine(), out int pos);
            //Console.Write("Enter The New Char: ");
            //char.TryParse(Console.ReadLine(), out char c);

            //string newStr = ChangeChar(str, pos, c);
            //Console.WriteLine($"Original string: {str}");
            //Console.WriteLine($"Modified string: {newStr}");
            #endregion

            #endregion

        }
        #region (Function) Q1: example(Passing by Value, Passing by Reference)
        //// 1- Passing by Value
        //static void update(int x)
        //{
        //    x = 20;
        //}
        //// 1- Passing by Referenc
        //static void updatere(ref int x)
        //{
        //    x = 20; // Modifies the original variable directly
        //}
        #endregion

        #region (Function) Q2: example(Passing by Value, Passing by Reference)
        ////1- Passing by Value
        //static void update(Person p)
        //{
        //    p.Name = "Saad"; //Modifying the object
        //    p = new Person { Name = "Mohamed" }; // not affect the original reference
        //}
        //// 1- Passing by Referenc
        //static void updatere(ref Person p)
        //{
        //    p.Name = "Saad"; // Modifying the object
        //    p = new Person { Name = "Mohamed" };  // Reassigning the reference to a new object
        //}
        #endregion

        #region (Function) Q3: 
        //static void calculator(int num1, int num2, out int sum, out int sub)
        //{
        //    sum = num1 + num2;
        //    sub = num1 - num2;
        //}
        #endregion

        #region (Function) Q4:
        //static int sumDigits(int n)
        //{
        //    int sum = 0;
        //    while (n != 0)
        //    {
        //        sum += n % 10; // sum = 0 + 25 % 10 --> (sum = 5)first digit  , sum = 5 + 2 % 10 = 5 + 2 = 7
        //        n /= 10;       // n = 2      ,  n = 2 / 10 = 0.2  (n = 0)
        //    }
        //    return sum;
        //}
        #endregion

        #region (Function) Q5:
        //static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //            return false; 
        //    }

        //    return true;
        //}
        #endregion

        #region (Function) Q6:
        //static void MinMaxArray(int[]arr, out int max, out int min)
        //{
        //    max = arr.Max();
        //    min = arr.Min();
        //}
        #endregion

        #region (Function) Q7:
        //static long Factorial(int num)
        //{
        //    int result = 1; 
        //    for (int i = 1; i < num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion

        #region (Function) Q8:
        //static string ChangeChar(string input, int position, char newChar)
        //{
        //    if (position < 0 || position >= input.Length)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(position), "Position must be within the string's bounds.");
        //    }

        //    // Replace character at specified position
        //    char[] charArray = input.ToCharArray();
        //    charArray[position] = newChar;

        //    return new string(charArray);
        //}
        #endregion


    }
}
