using System;
namespace ExceptionHandlingExample
{


    class Expection
    {
        //static void Main()
        //{
            //    try
            //    {
            //        Console.Write("Enter first number: ");
            //        int a = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Enter second number: ");
            //        int b = Convert.ToInt32(Console.ReadLine());
            //        int c = a / b;
            //        Console.WriteLine("Quotient is " + c);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Finished");
            //    }
            //    Console.ReadKey();
            //}

            //            try
            //            {
            //                int[] myNumbers = { 1, 2, 3 };
            //                Console.WriteLine(myNumbers[10]);
            //            }
            //            catch (Exception e)
            //            {
            //                Console.WriteLine("Something went wrong.");
            //            }
            //            finally
            //            {
            //                Console.WriteLine("Finished");
            //            }
            //            Console.ReadKey();
            //        }
            //        }
            //}
            static void checkAge(int age)
            {
                if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                }
            }

            static void Main(string[] args)
            {
                checkAge(15);
            }
        }
    }