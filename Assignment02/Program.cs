using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //1.Write a program that allows the user to enter a number then print it.

            //Console.WriteLine(value: "Enter Your Number : ");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Number : " + Number);

            #endregion

            #region Q2

            //2.Write C# program that converts a string to an integer, but the string contains non-numeric characters.
            //And mention what will happen

            //string Numeric = "Menna";
            //int numeric = Convert.ToInt32(Numeric);
            //Console.WriteLine(Numeric);
            // System.FormatException: The input string 'Menna' was not in a correct format.

            #endregion

            #region Q3

            //3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float num1 = 14.5F;
            //float num2 = 10.3F;
            //float sum = num1 + num2;
            //Console.WriteLine(sum); //24.8

            #endregion

            #region Q4

            //4.Write C# program that Extract a substring from a given string.

            //Console.Write("Enter a string: ");
            //string OriginalString = Console.ReadLine();

            //Console.Write("Enter the starting index: ");
            //int StartIndex = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the length of the substring: ");
            //int Length = Convert.ToInt32(Console.ReadLine());

            #endregion

            #region Q5

            // 5. Write C# program that Assigning one value type variable to another and modifying the value of one variable
            // and mention what will happen

            //int X = 6;
            //int Y = X;
            //X = 8;

            //Console.WriteLine("value of X :" + X);  //8
            // Console.WriteLine("value of y :" + Y); // 6 

            #endregion


            #region Q6

            // 6. Write C# program that Assigning one reference type variable to another and modifying the object through
            // one variable and mention what will happen

            //Child Child01 = new Child("M", 21);
            //Child Child02 = Child01;

            //Child01.Name = "Youssef";
            //Child01.Age = 24;
            //Console.WriteLine("Child01 :" + Child01.Name +',' + Child01.Age);
            //Console.WriteLine("Child02 :" + Child02.Name + ',' + Child02.Age); 

            #endregion

            #region Q7

            //7.Write C# program that take two string variables and print them as one variable 

                    //string variable1 = "Hello ";
                    //string variable2= "World";

                    //string variable0= variable1 + variable2;

                    //Console.WriteLine(variable0);  //Hello World

            #endregion

            #region Q8

            //8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time.
            //The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.Write("Enter the principal amount: ");
            //double principal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the rate of interest (in %): ");
            //double rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the time (in years): ");
            //double time = Convert.ToDouble(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine("The simple interest is: " + interest.ToString("F2"));

            //Enter the principal amount: 5000
            //Enter the rate of interest(in %): 20
            //Enter the time(in years): 3
            //The simple interest is: 3000.00

            #endregion

            #region Q9

            //Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters.
            //The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.Write("Enter Your Weight In Kilograms: ");
            //double Weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Your Height In Meters: ");
            //double Height = Convert.ToDouble(Console.ReadLine());

            //double Bmi = Weight / (Height * Height);

            //Console.WriteLine("Your Body Mass Index (BMI) is: " + Bmi.ToString("F2"));

            #endregion

            #region Q10

            //10. Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            //Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold",
            //above 30 degrees is "Just Hot", and anything else is "Just Good".

            //Console.Write("Enter the Temperature in Degrees: ");
            //int Temperature = Convert.ToInt32(Console.ReadLine());
            //string Result = Temperature < 10 ? "Just Cold"
            //               : (Temperature > 30 ? "Just Hot"
            //               : "Just Good");

            //Console.WriteLine("The Temperature is: " + Result);

            //Enter the temperature in degrees: 40
            // The Temperature is: Just Hot

            //Enter the temperature in degrees: 30
            //The temperature is: Just Good

            //Enter the temperature in degrees: 5
            //The temperature is: Just Cold

            #endregion

            #region Q11

            //11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //    Today’s date : 20 , 11 , 2001
            //    Today's date : 20 / 11 / 2001
            //    Today's date : 20 – 11 – 2001

            //DateTime date = new DateTime(2001, 11, 20); Console.WriteLine($"The event is on {date:dd,MM,yyyy}"); //The event is on 20,11,2001
            //DateTime date02 = new DateTime(2001/ 11/ 20); Console.WriteLine($"The event is on {date:dd/MM/yyyy}");//The event is on 20/11/2001
            //DateTime date03 = new DateTime(2001- 11- 20); Console.WriteLine($"The event is on {date:dd-MM-yyyy}");//The event is on 20-11-2001

            #endregion

            #region Q12

            //DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");//The event is on 06/14/2024


            #endregion

            #region Q13

            //int d;
            //d = Convert.ToInt32(!(30 < 20)); //A value 1 will be assigned to d.

            #endregion

            #region Q14

            //Console.WriteLine(13 / 2 + " " + 13 % 2); // 6 1 

            #endregion

            #region Q15

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z); //7 7

            #endregion


        }
    }
}
