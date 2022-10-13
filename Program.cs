//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

class Program
{
public static void Main(string[] args)
{
    Console.WriteLine("Введите число A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Pow(numberA, numberB));

    int result = 1;
    for(int i=1; i <= numberB; i++)
    result = result * numberA;
  
    Console.WriteLine("Ответ: " + result);
}
}

