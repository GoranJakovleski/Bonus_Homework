using System;
using System.Linq;

namespace Bonus_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            // 1.Write a C# Sharp program to find the sum of first 10 natural numbers
            //    *Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10

            int i, sum = 0;
            for (i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($" The first 10 natural number are:{sum}");
            #endregion

            #region Exercise 2
            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.


            int[] numbers = new int[10];


            int numberOfElements = 0;

            // for (int i = 0; i < numbers.Length; i++)
            {
                numberOfElements = i + 1;

                Console.WriteLine("enter the " + numberOfElements + " number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int average = 0;
            foreach (var num in numbers)
            {
                average += num;
            }
            Console.WriteLine($"The sum ovf this 10 number is =  {average}");
            #endregion

            #region Exercise 3
            //3.Declare and init array of 10 integers by your choise. 
            //   Find maximum and minimum element in that array and their indexes.

            int[] anArray = { 20, 21, 5, 36, 500, 6, 70, 14, 96, 107, };
            int maxValue = anArray.Max();
            int maxIndex = anArray.ToList().IndexOf(maxValue);
            int minValue = anArray.Min();
            int minIndex = anArray.ToList().IndexOf(minValue);
            Console.WriteLine($"maximum element is {maxValue} and their index is {maxIndex}");
            Console.WriteLine($"minimum element is {minValue} and their index is {minIndex}");
            #endregion

            #region Exercise 4
            //4.arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            //   Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            int[] arrayWithDuplicates = { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            int count = 0;

            // for (int i = 0; i < arrayWithDuplicates.Length; i++)
            {
                //int count = 0;
                for (int j = i + 1; j < arrayWithDuplicates.Length; j++)
                {

                    if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements found in array:" + count);


            #endregion

            #region Exercise 5
            //5.oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //   Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays

            int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            int[] oddArray = new int[10];
            int[] evenArray = new int[10];
            int m;
            int n = 0;
            int k = 0;

            for (m = 0; m < oddEvenArray.Length; m++)
            {
                if (oddEvenArray[m] % 2 == 0)
                {
                    evenArray[n] = oddEvenArray[m];
                    n++;
                }
                else
                {
                    oddArray[k] = oddEvenArray[m];
                    k++;
                }
            }

            for (m = 0; m < n; m++)
            {
                Console.WriteLine("EvenArray elements are: " + evenArray[m]);
            }
            Console.WriteLine("------------------------------");

            for (m = 0; m < k; m++)
            {
                Console.WriteLine("OddArray elements are:" + oddArray[m]);
            }

            #endregion

            #region Exercise 6
            //6.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //   the day with strings.Example: user enters 1, you should print Monday.

            Console.WriteLine("Please enter your exam score (number from 1 - 7):");

            int score = 0;
            bool validInput = int.TryParse(Console.ReadLine(), out score);

            if (score > 7 || score < 0 || validInput != true)
            {
                Console.WriteLine("You must enter a number from 1 to 7, PLEASE TRY AGAIN.");
            }

            else if (validInput == true)
            {
                switch (score)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
            #endregion

            #region Exercise 7
            //7.userNames = ["user1", "user2", "user3"]
            //   passwords = ["first", "second", "third"]
            //   Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //   Create a logic when user enters specific username to provide a correct password for that user, and when that
            //   happens you should print on the screen "You are logged in successfully".
            //   If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //   repeat the proccess from begining while he / she doesn't input correct username and password.


            //   Note: Every element in userNames corresponds with the element in passwords at same index.
            //   Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".




            string[] userNames = { "user1", "user2", "user3" };
            string[] passwords = { "first", "second", "third" };

            while (true)
            {
                Console.WriteLine("Enter a username");
                string userNameInput = (Console.ReadLine());
                Console.WriteLine("Enter a passwords");
                string userPassInput = (Console.ReadLine());

                if (userNameInput == userNames[0] && userPassInput == passwords[0])
                {
                    Console.WriteLine("You are logged in successfully");
                }
                else if (userNameInput == userNames[1] && userPassInput == passwords[1])
                {
                    Console.WriteLine("You are logged in successfully");
                }
                else if (userNameInput == userNames[2] && userPassInput == passwords[2])
                {
                    Console.WriteLine("You are logged in successfully");
                }
                else
                {
                    Console.WriteLine("Incorrect username or password");
                }
                #endregion

                Console.ReadLine();

            }
        }
    }
}
