// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int InputNumber(string numbers)
{
    System.Console.Write($"Введите {numbers}");
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число, повторите ввод");
    }
    return i;
}

int MinusNumber(int argument)
{
    int x = argument;
    if(x < 0)
    {
        System.Console.WriteLine("Размер массива не может быть меньше 0");
    }
    
    return argument;
}

int[] FillArray(int numbers)
{
    int[] Array = new int[numbers];
    for(int i = 0; i < numbers; i++)
    {
        Array[i] = InputNumber("значение ");
    }
    return Array;
}


void PrintArray (int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]} ");
    }
    System.Console.WriteLine();
}

int CountNumbers (int[] numbers)
{
    int summ = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > 0)
        {
            summ++;
        }
    }
    return summ;
}

void Print()
{
    int Massive = InputNumber("размер массива ");
    MinusNumber(Massive);
    int[] Mas = FillArray(Massive);
    PrintArray(Mas);
    CountNumbers(Mas);
    System.Console.WriteLine($"Кол-во положительных чисел = {CountNumbers(Mas)}");
}

Print();
