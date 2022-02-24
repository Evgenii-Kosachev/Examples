/*
int numberA = 3;
int numberB = 5;

// Console.WriteLine(numberA + numberB);

int result = numberA + numberB;
Console.Write(result);
*/

// Пример с генератором случайных чисел.
int numberA = new Random().Next(1, 10);  // 1234...9
Console.WriteLine(numberA);

int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);

int result = numberA + numberB;
Console.WriteLine(result);