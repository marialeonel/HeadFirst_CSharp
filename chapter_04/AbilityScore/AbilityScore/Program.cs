using AbilityScore;


AbilityScoreCalculator calculator = new AbilityScoreCalculator();
while (true)
{
    calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
    calculator.DividedBy = ReadDouble(calculator.DividedBy, "Divided by");
    calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
    calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
    calculator.CalculateAbilityScore();
    Console.WriteLine($"Calculated ability score: {calculator.Score}");
    Console.WriteLine("Press Q to quit, any other key to continue.");
    char keyChar = Console.ReadKey(true).KeyChar;
    0if ((keyChar == 'Q') || (keyChar == 'q')) return;
}

static int ReadInt(int lastUsedValue, string prompt)
{
    Console.WriteLine($"{prompt} [{lastUsedValue}]:");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int result))
    {
        Console.WriteLine($"using value {result}");
        return result;
    }

    Console.WriteLine($"using default value {lastUsedValue}");
    return lastUsedValue;
}

static double ReadDouble(double lastUsedValue, string prompt)
{
    Console.WriteLine($"{prompt} [{lastUsedValue}]:");
    string input = Console.ReadLine();
    if (double.TryParse(input, out double result))
    {
        Console.WriteLine($"using value {result}");
        return result;
    }

    Console.WriteLine($"using default value {lastUsedValue}");
    return lastUsedValue;
}