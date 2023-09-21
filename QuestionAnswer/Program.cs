//1 program to print hello and your name in a separate line
string firstname = "Alexandra ";
string lastname = "Abramov";
string name = firstname + lastname;

Console.WriteLine("Hello: ");
Console.WriteLine(name);


//2 program to print sum of two numbers
//declare variables
//double num1 = 0;
//double num2 = 0;
//double results = 0;

//string? firstNumber = "";
//string? secondNumber = "";

//ask user for numbers
//Console.WriteLine("Enter Your First Number");
//firstNumber = Console.ReadLine();

//Console.WriteLine("Enter Your Second Number");
//secondNumber = Console.ReadLine();

//convert userinput to double
//num1 = Convert.ToDouble(firstNumber);
//num2 = Convert.ToDouble(secondNumber);

//double sum = num1 + num2;
//Console.WriteLine($"Sum is: {sum}");

//3 print result of dividing two numbers
//declare variables
//double num3 = 0;
//double num4 = 0;
//double Result = 0;

//string? firstdiv = "";
//string? seconddiv = "";

//ask user for numbers
//Console.WriteLine("Enter Your Number");
//firstdiv = Console.ReadLine();

//Console.WriteLine("Enter Your Second Number");
//seconddiv = Console.ReadLine();

//convert userinput to double
//num3 = Convert.ToDouble(firstdiv);
//num4 = Convert.ToDouble(seconddiv);

//double div = num3 / num4;
//Console.WriteLine($"Result is: {div}");


//5 a program to swap two numbers
//double x = 0;
//double y = 0;

//string? firstmyNum = "";
//string? secondmyNum = "";

//ask user for numbers
//Console.WriteLine("Enter Your Number");
//firstmyNum = Console.ReadLine();

//Console.WriteLine("Enter Your Second");
//secondmyNum = Console.ReadLine();

//convert userinput to double
//x = Convert.ToDouble(firstmyNum);
//y = Convert.ToDouble(secondmyNum);

//Console.WriteLine($"{y} {x}");


//6 program to multiply three numbers
//double a = 0;
//double b = 0;
//double c = 0;
//double mult = a * b * c;

//string multipleOne = "";
//string multipleTwo = "";
//string multipleThree = "";

//ask user for numbers
//Console.WriteLine("Enter Your Number");
//multipleOne = Console.ReadLine();

//Console.WriteLine("Enter Your Second");
//multipleTwo = Console.ReadLine();

//Console.WriteLine("Enter Your Number");
//multipleThree = Console.ReadLine();

//convert user input to double
//a = Convert.ToDouble(multipleOne);
//b = Convert.ToDouble(multipleTwo);
//c = Convert.ToDouble(multipleThree);

//Console.WriteLine($"{mult}");


//7 program that output adding, subtracting, multiplying and dividing two numbers
//string? firstUserInput = "";
//string? secondUserInput = "";
//string? operationChosen = "";

//double num5 = 0;
//double num6 = 0;
//double result = 0;

//ask for first number
//Console.WriteLine("Enter your first number:");
//firstUserInput = Console.ReadLine();

////ask for second number
//Console.WriteLine("Enter your second number:");
//secondUserInput = Console.ReadLine();


//Console.WriteLine("Select one operation you wish to perform");
//Console.WriteLine("0 Addition\n1 Subtraction\n2 Multiplication\n3 Division");
//operationChosen = Console.ReadLine();

//Convert user input to double
//num5 = Convert.ToDouble(firstUserInput);
//num6 = Convert.ToDouble(secondUserInput);


//switch (operationChosen)
//{

//case "0":
//add numbers
//2 Add the converted numbers
//result = num5 + num6;

//break;
//case "1":
//result = num5 - num6;
//break;
//case "2":
//result = num5 * num6;
//break;          
//case "3":
//result = num5 / num6;
//break;
//default:
//Console.WriteLine("No such operation");
//break;
//}
//Console.WriteLine($"Result is: {result}");

//public enum Operations
//{
//    Addition = 0,
//    Subtraction = 1,
//    Multiplication = 2,
//    Division = 3,
//}


//8 program that prints multiplication table of a number
//int j = 0;
//int results;

//Console.WriteLine("Enter A Number");
//j = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    int result = j * i;
//    Console.WriteLine($"{result}");
//}
//damn!


//9.program that prints the average of 4 numbers
//double k = 0;
//double l = 0;
//double m = 0;
//double n = 0;
//double result = 0;

//ask user for numbers and convert them to double
//Console.WriteLine("Enter The First Number");
//k = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter The Second Number");
//l = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter The Third Number");
//m = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter The Fourth Number");
//n = Convert.ToDouble(Console.ReadLine());

//double Average = (k + l + m + n) / 4;
//Console.WriteLine($"Average is: {Average}");

//10.print program that asks three number then: (x+y).z and x.y + y.z
//double s = 0;
//double t = 0;
//double u = 0;

//ask user for digits and convert them to double
//Console.WriteLine("Enter Your First Number");
//s= Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter Your Second Number");
//t = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter Your Third Number");
//u = Convert.ToDouble(Console.ReadLine());

//operation to be performed
//double result1 = (s + t) * u;
//double result2 = (s * t ) + (t * u);

//output
//Console.WriteLine($"Answer 1: {result1}");
//Console.WriteLine($"Answer 2: {result2}");

//11. program that takes age then outputs a message
//int age = 0;
//int result = 0;

//ask user for age and convert it to int
//Console.WriteLine("Enter Your Age");
//age = Convert.ToInt32(Console.ReadLine());

//message to be output
//Console.WriteLine($"You Look Older Than {age}");


//14.
// program to convert temperature in celsius to kelvin and fahrenheit

//while (true)
//{
//call the methods
//to welcome the user
//Conversions conversions = new Conversions();
//conversions.WelcomeUser();

//to prompt the user to enter a digit
//    string? userInput = conversions.PromptUserForTemperatureCelsius();

//    if (string.IsNullOrEmpty(userInput) == false)
//    {
//        var conversionResult = conversions.ConvertUserInputToDouble(userInput);

//        if (conversionResult.Success == true)
//        {
//            double convertedAmount = conversionResult.Result;

//            var kelvin = conversions.CelsiusToKelvin(convertedAmount);

//            if (kelvin.Success == false)
//            {
//                Console.WriteLine(kelvin.Remarks);
//                break;
//            }

//            var fahrenheit = conversions.CelsiusToFahrenheit(convertedAmount);

//            if (fahrenheit.Success == false)
//            {
//                Console.WriteLine(fahrenheit.Remarks);
//                break;
//            }

//            conversions.PrintResult(
//                kelvin.Result,
//                fahrenheit.Result);
//        }
//        else
//        {
//            Console.WriteLine(conversionResult.Remarks);
//            break;
//        }
//    }
//    break;
//}



//class Conversions
//{
//method to convert celsius to kelvin
//public ConversionResponse CelsiusToKelvin(double celcuis)
//{
//    try //code that might throw an exeption
//{
// declare variable called result which is ,1c = 273K
//    double result = celcuis + 273;
//    return new ConversionResponse
//    {
//        Success = true,
//        Result = result,
//        Remarks = "Success"
//    };
//}
//catch (Exception ex) //exception/where wrong code is handled
//    {
//        return new ConversionResponse
//        {
//            Success = false,
//            Result = 0,
//            Remarks = ex.Message
//        };
//    }
//}

//method to convert celsius to fahrenheit
//public ConversionResponse CelsiusToFahrenheit(double celcuis)
//{
//    try //code that might throw an exception
//{
// 1c = 33.8 F
//    double result = (celcuis / 2) + 30;
//    return new ConversionResponse
//    {
//        Success = true,
//        Result = result,
//        Remarks = "Success"
//    };
//}
//catch (Exception ex) //exception/where wrong code is handled
//    {
//        return new ConversionResponse
//        {
//            Success = false,
//            Result = 0,
//            Remarks = ex.Message
//        };
//    }
//}

//method to welcome the user
//public void WelcomeUser()
//{
//    Console.WriteLine("::: Welcome to Conversions :::");
//}

//method to prompt the user to enter the digits
//public string? PromptUserForTemperatureCelsius()
//{
//    Console.WriteLine("::: Enter temperature in Degrees Celsius :::\n");
//    string? userInput = Console.ReadLine();
//    return userInput;
//}

//method to convert user input to double
//public ConversionResponse ConvertUserInputToDouble(string userInput)
//{
//    try
//    {
//        double celsius = Convert.ToDouble(userInput);
//        return new ConversionResponse // response converted in double from user input
//        {
//            Remarks = "Success",
//            Success = true,
//            Result = celsius
//        };
//    }
//    catch (Exception ex)
//    {
//        return new ConversionResponse
//        {
//            Success = false,
//            Result = 0,
//            Remarks = ex.Message
//        };
//    }
//}

//method to print the result in kelvin and F
//public void PrintResult(double kelvin, double fahrenheit)
//{
//    Console.WriteLine($"The Kelvin conversion result is {kelvin}");
//    Console.WriteLine($"The Fahrenheit conversion result is {fahrenheit}");
//}

//method for the response to determine if code will run correctly or not
//    public class ConversionResponse
//    {
//        public bool? Success { get; set; }
//        public string? Remarks { get; set; }
//        public double Result { get; set; }
//    }
//}


//15
//program that removes a specified character using the index of a character
//string? character = "";



//18
// program to check a pair of integers and return true if one is negative and one  is positive
//int numb1 = 0;
//int numb2 = 0;
//string result = "True";

//while (true)
//{
//    //ask user for the numbers and convert them
//    Console.WriteLine("Enter The First Number");
//    numb1 = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter The Second Number");
//    numb2 = Convert.ToInt32(Console.ReadLine());

//    if (numb1 > 0 && numb2 < 0 || numb1 < 0 && numb2 > 0)
//    {
//        Console.WriteLine($"Result is: {result}");
//        break;
//    }
//display message for an invalid number
//Console.WriteLine("Invalid Integers");
//}

//25 program to print odd number from 1 to 99 per line
//int num = 0;

//while (true)
//{
//    //display odd numbers
//    for (int i = 1; num < (99 + 1); num++)
//    {
//        if (num % 2 != 0)
//        {
//            Console.WriteLine(num);
//        }
//    }

//}


//23 converts a given string to lowercase
Console.WriteLine("Enter Your String");
string userInput = Console.ReadLine();

Lower lower = new Lower();
string result = lower.toLower(userInput);
Console.WriteLine(result);
    class Lower
{
    public string toLower(string input)
    {
        string? userInput = "";
        if (string.IsNullOrEmpty(input))// or (input == null)
        {
            Console.WriteLine("Must Provide a Valid String");
        }
        return input.ToLower();
    }
}


//33 program to check if a given positive number is a multiple of 3 or 7
Console.WriteLine("Enter a Digit");
int num = Console.ReadLine();

Check check = new Check();
int results = check.checkMultiple(num);
Console.WriteLine(results);
class Check
{
    public bool checkMultiple()
    {
        int num = 0;
        if (num <= 0)
        {
            Console.WriteLine("Input Must Be a Positive Integer");
        }
        return (num % 3 == 0 || num % 7 == 0);
    }
}