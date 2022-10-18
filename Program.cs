//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76


Console.WriteLine($"\nНайдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

  double[] GetNumberFromUser = new double[10];
  for (int i = 0; i < GetNumberFromUser.Length; i++ )
  {
    GetNumberFromUser[i] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble() * 10, 2);
    Console.Write(GetNumberFromUser[i] + " ");
  }

  double maxNumber = GetNumberFromUser[0];
  double minNumber = GetNumberFromUser[0];

  for (int i = 1; i < GetNumberFromUser.Length; i++)
  {
    if (maxNumber < GetNumberFromUser[i])
    {
      maxNumber = GetNumberFromUser[i];
    }
      if (minNumber > GetNumberFromUser[i])
    {
      minNumber = GetNumberFromUser[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}\n");















































