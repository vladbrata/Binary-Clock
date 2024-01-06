Console.Write("Introduceti ora curenta (HH:mm:ss): ");
string input = Console.ReadLine();

if (IsValidTimeFormat(input)) {
    string binaryClock = ConvertToBinaryClock(input);
    Console.WriteLine($"Ceasul binar corespunzator este: {binaryClock}");
}
else {
    Console.WriteLine("Formatul orei introduse nu este valid. Va rugam sa introduceti ora in formatul corect (HH:mm:ss).");
}

static bool IsValidTimeFormat(string input)
{
    return DateTime.TryParseExact(input, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out _);
}

static string ConvertToBinaryClock(string input)
{
    string[] timeComponents = input.Split(':');
    int hours = int.Parse(timeComponents[0]);
    int minutes = int.Parse(timeComponents[1]);
    int seconds = int.Parse(timeComponents[2]);
    string binaryHours = Convert.ToString(hours, 2).PadLeft(5, '0');
    string binaryMinutes = Convert.ToString(minutes, 2).PadLeft(6, '0');
    string binarySeconds = Convert.ToString(seconds, 2).PadLeft(6, '0');
    return $"{binaryHours}:{binaryMinutes}:{binarySeconds}";
}
