Random random = new Random();
double GetRandomDouble(int max) => max * random.NextDouble();

void PrintValue(double d) => Console.WriteLine(d);

var value = GetRandomDouble(100);
PrintValue(value);

