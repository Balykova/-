#домашнеезадание1
#задача1
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число (a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число (b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int max = Math.Max(a, b);
        int min = Math.Min(a, b);
        Console.WriteLine($"max = {max}");
        Console.WriteLine($"min = {min}");


# задача2
        Console.WriteLine("Введите три числа, разделенные пробелами:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int num1 = int.Parse(numbers[0]);
        int num2 = int.Parse(numbers[1]);
        int num3 = int.Parse(numbers[2]);

        int max = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine($"Максимальное число: {max}");



        Console.WriteLine("Введите число:");

# задача3
        string input = Console.ReadLine();
        int number;
        if (int.TryParse(input, out number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} -> Чётное");
            }
            else
            {
                Console.WriteLine($"{number} -> Не чётное");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное целое число.");
        }

# задача4
        Console.WriteLine("Введите число N:");
        string input = Console.ReadLine();
        int N;
        if (int.TryParse(input, out N) && N > 0)
        {
            Console.WriteLine($"Четные числа от 1 до {N}:");

            for (int i = 2; i <= N; i += 2)
            {
                Console.Write(i);

                if (i + 2 <= N)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное положительное целое число.");
        }


# задача5
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();
        int number;
        if (int.TryParse(input, out number))
        {
            if (number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine($"{number} -> Число кратно 7 и 23");
            }
            else
            {
                Console.WriteLine($"{number} -> Число не кратно 7 и 23");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное целое число.");
        }

""#задача6""
        Console.WriteLine("Введите координаты точки (X и Y), где X не равен 0 и Y не равен 0:");
        Console.Write("Введите X: ");
        string inputX = Console.ReadLine();
        double x;
        Console.Write("Введите Y: ");
        string inputY = Console.ReadLine();
        double y;
        if (double.TryParse(inputX, out x) && double.TryParse(inputY, out y) && x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в 1-й четверти.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во 2-й четверти.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в 3-й четверти.");
            }
            else
            {
                Console.WriteLine("Точка находится в 4-й четверти.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректные координаты, где X ≠ 0 и Y ≠ 0.");
        }


""# задача7""
        Console.WriteLine("Введите целое число из отрезка [10, 99]:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 10 && number <= 99)
        {
            int tens = number / 10;
            int units = number % 10;

            int maxDigit = Math.Max(tens, units);

            Console.WriteLine($"Наибольшая цифра числа {number} -> {maxDigit}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное целое число из отрезка [10, 99].");
        }

        ""#задача8"""
Console.WriteLine("Введите натуральное число:");
string input = Console.ReadLine();
if (ulong.TryParse(input, out ulong number) && number > 0)
{
    string numberString = number.ToString();
    string result = string.Join(", ", numberString.ToCharArray());
    Console.WriteLine($"Цифры числа {number} через запятую: {result}");
}
else
{
    Console.WriteLine("Ошибка: введите корректное натуральное число.");
}

"""#домашнеезадание2"""
"""#задача1"""

int[] numbers = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int count = 0;
foreach (int number in numbers)
    if (number >= 20 && number <= 90)
        count++;
Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке от 20 до 90: " + count);


"""#задача2"""
int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int evenCount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) // Проверка на четность
    {
        evenCount++;
    }
}
Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
Console.WriteLine("Количество четных чисел в массиве: " + evenCount);


"""#задача3"""
int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double difference = max - min;
Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);


"""#задача4"""
Console.Write("Введите натуральное число от 1 до 100000: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100000)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 100000.");
}
string numberString = number.ToString();
int length = numberString.Length;
int[] digits = new int[length];
for (int i = 0; i < length; i++)
{
    digits[i] = (int)char.GetNumericValue(numberString[length - 1 - i]);
}
Console.WriteLine("Массив цифр числа: " + string.Join(", ", digits));


"""#домашнеезадание3"""
using System;
    {
        
        int size = 10; 
        int[] numbers = new int[size];

       
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000); 
        }

      
        Console.WriteLine("Сгенерированный массив трехзначных чисел:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

     
        int evenCount = CountEvenNumbers(numbers);

        
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

  
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var number in array)
        {
            if (number % 2 == 0) 
            {
                count++;
            }
        }
        return count;
    }
}








";"}
}