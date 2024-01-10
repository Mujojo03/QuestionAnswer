//1 program to print hello and your name in a separate line

//string firstname = "Alexandra ";
//string lastname = "Abramov";
//string name = firstname + lastname;

//Console.WriteLine("Hello: ");
//Console.WriteLine(name);


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
//Console.WriteLine("Enter Your String");
//string userInput = Console.ReadLine();

//Lower lower = new Lower();
//string result = lower.toLower(userInput);
//Console.WriteLine(result);
//class Lower
//{
//    public string toLower(string input)
//    {
//        string? userInput = "";
//        if (string.IsNullOrEmpty(input))// or (input == null)
//        {
//            Console.WriteLine("Must Provide a Valid String");
//        }
//        return input.ToLower();
//    }
//}


//33 program to check if a given positive number is a multiple of 3 or 7

//Console.WriteLine("Enter a Digit");
//int num = Convert.ToInt32(Console.ReadLine());

//Check check = new Check();
//int results = Convert.ToInt32(check.checkMultiple(num));
//Console.WriteLine(results);
//class Check
//{
//    public bool checkMultiple(int num)
//    {
//        while (num > 0)
//        {
//            if (num % 3 == 0)
//            {
//                Console.WriteLine("Number Is Divisible By 3");
//                break;
//            }
//            else if (num % 7 == 0)
//            {
//                Console.WriteLine("Number Is Divisible By 7");
//                break;
//            }
//            else
//            {
//                Console.WriteLine("Number Not Divisible By Either 3 or 7");
//                break;
//            }

//        }
//        if (num <= 0)
//        {
//            Console.WriteLine("Input Must Be a Positive Integer");
//        }
//        return (num % 3 == 0 || num % 7 == 0);
//    }
//}


//54 program to find the century of a year
//Console.WriteLine("Enter A Year");
//int year = Convert.ToInt32(Console.ReadLine());

//Century century = new Century();
//double results = Convert.ToInt32(century.checkForCentury(century));
//Console.WriteLine(results);

//class Century
//{
//    public double checkForCentury(int year)
//    {
//        return (year / 100) + ((year % 100 == 0) ? 0 : 1);
//    }
//}


//using get set properties

//call the method person
//Person person = new Person();
//person.Name = "Jane Rose";

//Console.WriteLine(person.Name);

//create class person and method name
//class Person
//{
//    private string name;

//    public string Name
//    {
//        get {return name;}
//        set { name = value;}
//    }
//}


//program that sorts items in a list by ascending and descending order

//create a list of integers

//List<int> numbers = new List<int>();

//Console.WriteLine("Enter Integers One By One (or enter 'Q' to Quit) : ");


//while (true)
//{
//    string input = Console.ReadLine();

//    if (input == "Q")
//    { break; }

//attempts to convert the user input
//bool conversionSuccessful = int.TryParse(input, out int number);

//if (conversionSuccessful)
//{
//    numbers.Add(number);
//}
//else //conversion failed
//    {
//        Console.WriteLine("Invalid Input Please Enter a Valid Integer or Press Q to quit");
//    }
//}

//if (numbers.Count > 0)
//{
//    Console.WriteLine("\nChoose Sorting Order");
//    Console.WriteLine("1. Ascending Order");
//    Console.WriteLine("2. Descending Order");

//    string orderChoice = Console.ReadLine();

//    switch (orderChoice)
//    {
//        case "1":
//            numbers.Sort();
//            Console.WriteLine("\nSorted in Ascending Order");
//            PrintList(numbers);
//            break;

//            case "2":
//            numbers.OrderBy(n => n);
//            Console.WriteLine("\nSorted in Descending Order");
//            PrintList(numbers);
//            break;

//        default:
//            Console.WriteLine("Invalid Choice. Exit");
//            break;
//    }
//}
// a method that prints the list (PrintList)
//static void PrintList(List<int> list)
//{
//    foreach (var item in list)
//    {
//        Console.Write($"{item} ");
//    }
//    Console.WriteLine();
//}


//program that checks either a number is a multiple of 3, 5 or neither (fizz for 3, buzz for 5, fizzbuzz for both)
//using System;

//Console.WriteLine("Enter a digit");
//int numb = Convert.ToInt32(Console.ReadLine());

//Check check = new Check();
//int results = Convert.ToInt32(check.CheckMultiple(numb));

//Console.WriteLine(results);
//class Check
//{
//    public string CheckMultiple(int numb)
//    {
//        if (numb % 3 == 0 && numb % 5 == 0)
//        {
//            return "FizzBuzz";
//        }
//        else if (numb % 3 == 0)
//        {
//            return "Fizz";
//        }
//        else if (numb % 5 == 0)
//        {
//            return "Buzz";
//        }
//        else
//        {
//            return "Neither Fizz Nor Buzz";
//        }
//    }
//}

//Write a C# Sharp program to get the number of letters and digits in a given string.
//create two methods, count letters and count digits

//class StringAnalyzer
//{
//    public int CountLetters()
//    {
//        int letterCount = 0;
//        foreach (char c in input)
//        {
//            if (char.IsLetter(c))
//            {
//                letterCount++;
//            }
//        }
//        return letterCount;
//    }

//    public int CountDigits()
//    {
//        int digitCount = 0;
//        foreach (char c in input)
//        {
//            if (char.IsDigit(c))
//            {
//                digitCount++;
//            }
//        }
//        return digitCount;
//    }
//}
//class CallMethods
//{
//    public void calling()
//    {
//        Console.Write("Enter a String");
//        string input = Console.ReadLine();

//        StringAnalyzer stringAnalyzer = new StringAnalyzer();

//        stringAnalyzer.CountLetters();
//        stringAnalyzer.CountDigits();
//    }
//}


//program that converts minutes into seconds (using constructors)
//class MinutesConverter
//{
//    private int minutes;

//    public MinutesConverter(int minutes)
////    {
////        this.minutes = minutes;
////    }
////    public int ConvertToSeconds()
////    {
////        //1 min = 60 sec
////        return minutes * 60;
////    }
////}

////class Program
////{
////    static void Main()
////    {
////        Console.WriteLine("Enter Number of Minutes");
////        int minutes = Convert.ToInt32(Console.ReadLine());

////        MinutesConverter converter = new MinutesConverter(minutes);
////        int seconds = converter.ConvertToSeconds();

////        Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds");
////    }

////}


//program that convert age to days (using constructors)
//class AgeConverter
//{
//    private int years;

//    public AgeConverter(int years)
//    {
//        this.years = years;
//    }
//    public int ConvertToSeconds()
//    {
//        //1 years = 365 days
//        return years * 365;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter Number of Years");
//        int years = Convert.ToInt32(Console.ReadLine());

//        AgeConverter converter = new AgeConverter(years);
//        int days = converter.ConvertToSeconds();

//        Console.WriteLine($"{years} years is equal to {days} days");
//    }

//}


//program to check whether a word is plural of not plural
//class CheckPlural
//{
//    public bool IsPlural(string word)
//    {
//        //conditions; if the word is plural return true else false
//        if (word.EndsWith("s") || word.EndsWith("es"))
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a Word");
//        string inputWord = Console.ReadLine();

//        CheckPlural checkPlural = new CheckPlural();

//        if (checkPlural.IsPlural(inputWord))
//        {
//            Console.WriteLine($"{inputWord} Is Plural");
//        }
//        else 
//        { 
//            Console.WriteLine($"{inputWord} Is Not Plural");
//        }
//    }
//}

//using System;

//public class UserProfile
//{
//    private string email;
//    private string password;
//    private string languagePreference;

//    public void InputCredentials()
//    {
//        Console.Write("Enter your email: ");
//        email = Console.ReadLine();

//        Console.Write("Enter your password: ");
//        password = Console.ReadLine();

//        Console.Write("Enter your language preference: ");
//        languagePreference = Console.ReadLine();

//        Console.WriteLine("Credentials set successfully");
//    }

//    public void DisplayCredentials()
//    {
//        Console.WriteLine($"Your current email is: {email}");
//        Console.WriteLine($"Your current password is: {password}");
//        Console.WriteLine($"Your current language preference is: {languagePreference}");
//    }

//    public void ResetCredentials()
//    {
//        Console.Write("Enter a new email: ");
//        email = Console.ReadLine();

//        Console.Write("Enter a new password: ");
//        password = Console.ReadLine();

//        Console.Write("Enter a new language preference: ");
//        languagePreference = Console.ReadLine();

//        Console.WriteLine("Credentials reset successfully");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        UserProfile user = new UserProfile();

//        Console.WriteLine("Options:");
//        Console.WriteLine("1. Input Initial Credentials");
//        Console.WriteLine("2. View Credentials");
//        Console.WriteLine("3. Reset Credentials");

//        Console.Write("Select an option (1, 2, or 3): ");
//        string option = Console.ReadLine();

//        switch (option)
//        {
//            case "1":
//                user.InputCredentials();
//                break;
//            case "2":
//                user.DisplayCredentials();
//                break;
//            case "3":
//                user.ResetCredentials();
//                user.DisplayCredentials();
//                break;
//            default:
//                Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
//                break;
//        }
//    }
//}

//class Cart
//{
//    public void DisplayShopItems() //method that displays the items in the shop
//    {
//        Console.WriteLine("Shop Items:");
//        Console.WriteLine("1. Burger - 550");
//        Console.WriteLine("2. Fries - 300");
//        Console.WriteLine("3. Smoothie - 350");
//    }
//    public void AddToCart(List<string> shoppingCart, int itemNumber) //this adds the items chosen in the cart
//    {

//        Console.Write("Enter the item number to add to the cart (or 0 to go back): ");
//        string? itemChoice = Console.ReadLine();

//        if (int.TryParse(itemChoice, out itemNumber) && itemNumber >= 1 && itemNumber <= 3) //*to check
//        {
//            AddToCart(shoppingCart, itemNumber);
//            Console.WriteLine("Item added to the cart!");
//        }
//        else if (itemNumber != 0)
//        {
//            Console.WriteLine("Invalid item number. Please try again.");
//        }

//        switch (itemNumber)
//        {
//            case 1:
//                shoppingCart.Add("Burger - 550");
//                break;
//            case 2:
//                shoppingCart.Add("Fries - 300");
//                break;
//            case 3:
//                shoppingCart.Add("Smoothie - 350");
//                break;
//            case 4:
//                Console.WriteLine("Shop Page");
//                DisplayShopItems();
//                break;
//        }
//    }
//    public void DisplayShoppingCart(List<string> shoppingCart)
//    {
//        Console.WriteLine("Shopping Cart:");
//        if (shoppingCart.Count == 0)
//        {
//            Console.WriteLine("Your cart is empty.");
//        }
//        else
//        {
//            foreach (var item in shoppingCart)
//            {
//                Console.WriteLine($"- {item}");
//            }
//        }
//    }
/*    public void DisplayPaymentMethods()*/ //method to show user the payment otions
//    {
//        Console.WriteLine("Payment Methods:");
//        Console.WriteLine("1. Credit Card");
//        Console.WriteLine("2. PayPal");
//        Console.WriteLine("3. Mpesa");
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnOrderApp
//{
//    public class Shop
//    {
//        private List<string> shoppingItems;
//        public void shopItems()
//        {
//            List<string> shoppingItems = new List<string> { "Pizza", "Burger", "Fruit Smoothie" };
//        }

//        public void displayShopItems()
//        {
//            if (shoppingItems != null)
//            {
//                Console.WriteLine("Available Shop Items");

//                foreach (string item in shoppingItems)
//                {
//                    Console.WriteLine(item);
//                }
//            }
//            else { Console.WriteLine("Available Items is Empty"); }

//        }
//    }
//    class MethodCall
//    {
//        public MethodCall()
//        {
//            Shop shop = new Shop();

//            shop.displayShopItems();

//            shop.shopItems();
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AnOrderApp
//{
//    class Cart
//    {
//        private List<string> cartItems;
//        private List<string> paymentMethods;

//        public void DisplayCartItems()
//        {
//            MethodCall methodCall = new MethodCall();

//            List<string> cartItems = new List<string>(); 

//            if (cartItems.Count == 0)
//            {
//                Console.WriteLine("Your cart is empty.");
//            }
//            else
//            {
//                Console.WriteLine("Items in your cart:");
//                foreach (var item in cartItems)
//                {
//                    Console.WriteLine(item);
//                }
//            }
//        }
//        public void AddToCart(string item)
//        {
//            cartItems.Add(item);
//            Console.WriteLine($"{item} added to cart!");
//        }
//        public void DisplayPaymentMethods()
//        {
//            cartItems = new List<string>();
//            paymentMethods = new List<string>() { "visa", "Mpesa", "PayPal" };

//            foreach (var item in paymentMethods)
//            {
//                cartItems.Add(item);
//            }
//            Console.WriteLine("Choose a Payment Method");
//        }

//    }

//    class CallMethods
//    {
//        public CallMethods()
//        {
//            Cart cart = new Cart();

//            cart.DisplayCartItems();

//            cart.DisplayPaymentMethods();
//        }
//    }

//}


//public void DisplayPaymentMethods() //method to show user the payment otions
//{
//    Console.WriteLine("Payment Methods:");
//    Console.WriteLine("1. Credit Card");
//    Console.WriteLine("2. PayPal");
//    Console.WriteLine("3. Mpesa");
//}

//public class Logger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine(message);
//    }
//}
//public class Person
//{
//    public Person(string name) //constructor class
//    {
//        var logger = new Logger();
//        logger.Log($"{name} was created"); //person is dependent on the logger class
//    }
//}

//public class Person
//{
//    public Person(string name, Logger logger)
//    {
//        //now newing up [var logger = new Logger();]
//        logger.Log($"{name} was created");
//    }
//}


interface IAnimal //interface named IAnimal and declare abstract methods
{
    void MakeSound();
    void Eat();
}
class Dog : IAnimal
{
    public void MakeSound() //declare an implementation of the MakeSound method
    {
        Console.WriteLine("Woof");
    }
    public void Eat() //declare an implementation of the Eat method
    {
        Console.WriteLine("Pellets");
    }
}
class Cow : IAnimal // same thing
{
    public void MakeSound() 
    {
        Console.WriteLine("Moo");
    }
    public void Eat() 
    {
        Console.WriteLine("Grass");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog(); //instance of the dog class
        dog.MakeSound(); //call the methods form the Interface IAnimal
        dog.Eat();

        Cow cow = new Cow();
        cow.MakeSound();
        cow.Eat();
    }
}
