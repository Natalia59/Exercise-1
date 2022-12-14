// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)

Console.Clear();

static int GetNumberFromUser(string message, string errorMessage)
{
  while (true)
  {
    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber );
    if (isCorrect)
    return userNumber;
    Console.WriteLine(errorMessage);
  }
}

static double GetXCoefficients(int A, int B, int C, int D)
{
  double x = (double) (C - A) / (B - D);
  return x;
}

static double GetYCoefficients(int A, int B, double xCoefficients)
{
  double y = B * xCoefficients + A;
  return y;
}
int NumberB1 = GetNumberFromUser("Enter b1 : ", "Error. Try again.");
int NumberK1 = GetNumberFromUser("Enter k1 : ", "Error. Try again.");
int NumberB2 = GetNumberFromUser("Enter b2 : ", "Error. Try again.");
int NumberK2 = GetNumberFromUser("Enter k2 : ", "Error. Try again.");

double x = GetXCoefficients(NumberB1, NumberK1, NumberB2, NumberK2);
double y = GetYCoefficients(NumberB1, NumberK1, x);

Console.Write($"\nb1 = {NumberB1}, k1 = {NumberK1}, b2 = {NumberB2}, k2 = {NumberK2} ответ: -> ({x};{y})\n");


  











































