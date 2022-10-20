//Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1
//y = k2 * x + b2
//значения b1, k1, b2, k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


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

static double GetXKoordinate(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
{
    double x = (double) (thirdNumber - firstNumber) / (secondNumber- fourthNumber);
    return x;
}

static double GetYKoordinate(int firstNumber, int secondNumber, double xKoordinate)
{
    double y = secondNumber * xKoordinate + firstNumber;
    return y;
}


Console.Clear();
int NumberB1 = GetNumberFromUser("Enter b1 : ", "Error. Try again.");
int NumberK1 = GetNumberFromUser("Enter k1 : ", "Error. Try again.");
int NumberB2 = GetNumberFromUser("Enter b2 : ", "Error. Try again.");
int NumberK2 = GetNumberFromUser("Enter k2 : ", "Error. Try again.");

double x = GetXKoordinate(NumberB1, NumberK1, NumberB2, NumberK2);
double y = GetYKoordinate(NumberB1, NumberK1, x);

Console.Clear();
Console.Write($"\nb1 = {NumberB1}, k1 = {NumberK1}, b2 = {NumberB2}, k2 = {NumberK2} -> ({x};{y})\n");

  















































