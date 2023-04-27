
int numberB1 ()
{
    System.Console.Write("Введите b1 = ");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число, повторите ввод");
    }
    return i;
}

int numberB2 ()
{
    System.Console.Write("Введите b2 = ");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число, повторите ввод");
    }
    return i;
}

int numberK1 ()
{
    System.Console.Write("Введите k1 = ");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число, повторите ввод");
    }
    return i;
}

int numberK2 ()
{
    System.Console.Write("Введите k2 = ");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число, повторите ввод");
    }
    return i;
}

void numberX ()
{
    int b2 = numberB2();
    int b1 = numberB1();
    int k1 = numberK1();
    int k2 = numberK2();
    int x = (b2 - b1)/(k1 - k2);
    System.Console.WriteLine($"x = {x}");
    int y = k1 * x + b1;
    System.Console.WriteLine($"y = {y}");
    int y1 = y = k2 * x + b2;
    System.Console.WriteLine($"y1 = {y1}");
}

numberX();
