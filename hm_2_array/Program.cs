using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_2_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("task 1:\r\n");

                int size = 6;
                int[] arr = new int[size];

                while (true)
                {
                    Console.Write("Enter six-digit number: ");
                    int temp = int.Parse(Console.ReadLine());

                    if (temp > 99999 && temp < 10000000)
                    {
                        for (int i = 0; i < size; ++i)
                        {
                            arr[i] = temp % 10;
                            temp /= 10;
                        }

                        Array.Reverse(arr);

                        Console.WriteLine("enter digit's first position to swap: ");
                        int firstPosition = int.Parse(Console.ReadLine());

                        if (firstPosition >= 1 && firstPosition <= size)
                        {
                            Console.WriteLine("enter digit's second position to swap: ");
                            int secondPosition = int.Parse(Console.ReadLine());

                            if (secondPosition >= 1 && secondPosition <= size || firstPosition != secondPosition)
                            {
                                --firstPosition;
                                --secondPosition;

                                int swap = arr[firstPosition];
                                arr[firstPosition] = arr[secondPosition];
                                arr[secondPosition] = swap;

                                Console.Write("\r\nyour number is ");

                                for (int i = 0; i < size; ++i)
                                {
                                    Console.Write(arr[i]);
                                }
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\r\nYou entered invalid value. Value must be from '1' to '6' and not equal to first number entry. Try again.\r\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\r\nYou entered invalid value. Value must be from '1' to '6'. Try again.\r\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\r\nYou entered invalid value. Value must be a six-digit number. Try again.\r\n");
                    }
                }

                Console.WriteLine("\r\n\t ***");
            }

            {
                Console.WriteLine("task 2:\r\n");

                while (true)
                {
                    Console.Write("Enter date in format of dd.mm.yyyy: ");

                    DateTime date = DateTime.Parse(Console.ReadLine());

                    int month = date.Month;

                    if (month == 12 || month == 1 || month == 2)
                    {
                        string season = "Winter";
                        string dayOfWeek = date.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"));
                        Console.WriteLine($"{season} {dayOfWeek}");
                        break;
                    }
                    else if (month == 3 || month == 4 || month == 5)
                    {
                        string season = "Весна";
                        string dayOfWeek = date.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"));
                        Console.WriteLine($"{season} {dayOfWeek}");
                        break;
                    }
                    else if (month == 6 || month == 7 || month == 8)
                    {
                        string season = "Літо";
                        string dayOfWeek = date.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"));
                        Console.WriteLine($"{season} {dayOfWeek}");
                        break;
                    }
                    else if (month == 9 || month == 10 || month == 11)
                    {
                        string season = "Autumn";
                        string dayOfWeek = date.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"));
                        Console.WriteLine($"{season} {dayOfWeek}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong date format.");
                    }
                }
                Console.WriteLine("\r\n\t ***");
            }

            {
                Console.WriteLine("task 2:\r\n");

                while (true)
                {
                    Console.Write("Enter first number: ");

                    int firstNumber = int.Parse(Console.ReadLine());

                    if (firstNumber >= 0)
                    {
                        Console.Write("Enter second number: ");

                        int secondNumber = int.Parse(Console.ReadLine());

                        if (secondNumber >= 0 && secondNumber != firstNumber)
                        {
                            int start = Math.Min(firstNumber, secondNumber);
                            int end = Math.Max(firstNumber, secondNumber);

                            if (start % 2 == 1)
                            {
                                start++;
                            }

                            Console.WriteLine($"Even numbers in the section from {start} to {end}:");

                            for (int i = start; i <= end; i += 2)
                            {
                                Console.WriteLine(i);
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong second input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong first input.");
                    }
                }
                Console.WriteLine("\r\n\t ***");
            }
        }
    }
}
