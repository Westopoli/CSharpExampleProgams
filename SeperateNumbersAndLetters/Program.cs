string [] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal number = 0; 
decimal sum = 0; 
string message = ""; 

foreach (string value in values)
{
    if (decimal.TryParse(value, out number))
    {
        sum += number;
    }
    else 
    {
        message += value;
    }
}

Console.WriteLine("Message: {0}", message);
Console.WriteLine("Number: {0}", sum);