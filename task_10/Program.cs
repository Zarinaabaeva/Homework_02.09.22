int a = new Random().Next(100, 1000);

int x = a % 100 / 10;

Console.WriteLine($"{a} -> {x}");
