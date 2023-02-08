
string input;
string result;
do
{

    Console.Write("Enter a number: ");
    input = Console.ReadLine()!;


    if (input != "quit")
    {

        int number = int.Parse(input);

        Console.WriteLine($"DigitIntoLongText: {DigitIntoLongText(number)}{NumberIntoLongTextLevel1(number)}{NumberIntoLongTextLevel2(number)}{NumberIntoLongTextLevel3(number)}{NumberIntoLongTextLevel4(number)}{NumberIntoLongTextLevel5(number)}");
    }
}
while (input != "quit");

string DigitIntoLongText(int number)
{
    return number switch
    {
        case 0: System.Console.WriteLine("zero"); break;
        case 1: System.Console.WriteLine("one"); break;
        case 2: System.Console.WriteLine("two"); break;
        case 3: System.Console.WriteLine("three"); break;
        case 4: System.Console.WriteLine("four"); break;
        case 5: System.Console.WriteLine("five"); break;
        case 6: System.Console.WriteLine("six"); break;
        case 7: System.Console.WriteLine("seven"); break;
        case 8: System.Console.WriteLine("eight"); break;
        case 9: System.Console.WriteLine("nine"); break;
    }

}

string NumberIntoLongTextLevel1(int number)
{
    if (number < 10) { return DigitIntoLongText(number); }

    return switch (number)
    {
        case 10: System.Console.WriteLine("ten"); break;
        case 11: System.Console.WriteLine("eleven"); break;
        case 12: System.Console.WriteLine("twelve"); break;
        case 13: System.Console.WriteLine("thirteen "); break;
        case 15: System.Console.WriteLine("fifteen"); break;
        case 18: System.Console.WriteLine("eighteen"); break;
        default: System.Console.WriteLine($"{DigitIntoLongText(number % 10)}teen"); break;
    };
}

string NumberIntoLongTextLevel2(int number)
{
    if (number < 20) { return NumberIntoLongTextLevel1(number); }

    switch (number / 10)
    {
        case 2: System.Console.WriteLine("twenty"); break;
        case 3: System.Console.WriteLine("thirty"); break;
        case 4: System.Console.WriteLine("fourty"); break;
        case 5: System.Console.WriteLine("fifty"); break;
        case 8: System.Console.WriteLine("eighty"); break;
        default: System.Console.WriteLine($"{DigitIntoLongText(number / 10)}"); break;
    };

    if (number % 10 != 0)
    {
        result += DigitIntoLongText(number % 10);
    }

    return result;
}

string NumberIntoLongTextLevel3(int number)
{
    if (number < 100) { return NumberIntoLongTextLevel1(number); }
    if (number > 999) { return "not a valid number"; }

    result = $"{DigitIntoLongText(number / 100)}hundred";

    if (number % 100 != 0)
    {
        result += NumberIntoLongTextLevel2(number % 100);
    }

    return result;
}

string NumberIntoLongTextLevel4(int number)
{
    if (number < 1_000) { return NumberIntoLongTextLevel3(number); }
    if (number > 9_999) { return "not a valid number"; }

    string result = $"{DigitIntoLongText(number / 1000)}thousand";

    if (number % 1000 != 0)
    {
        result += NumberIntoLongTextLevel3(number % 1000);
    }

    return result;
}

string NumberIntoLongTextLevel5(int number)
{
    string result = "";
    if (number < 0)
    {
        result = "minus";
        number *= -1;
    }

    return $"{result}{NumberIntoLongTextLevel4(number)}";
}






