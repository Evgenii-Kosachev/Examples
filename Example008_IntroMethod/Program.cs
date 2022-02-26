// Нахождение максимального числа. (задача с гирями)

/*  "стихийным способом"
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max = a1;              // Переменная в которую помещаем найденные максимальные числа.
if(b1 > max)  max = b1;
if(c1 > max)  max = c1;

if(a2 > max)  max = a2;
if(b2 > max)  max = b2;
if(c2 > max)  max = c2;

if(a3 > max)  max = a3;
if(b3 > max)  max = b3;
if(c3 > max)  max = c3;

Console.WriteLine(max);
*/

// Будем брать по 3 числа и находить максимальное. А затем "финалистов" сравним между собой.
// Преимущество подхода в том, что ошибка может быть только в одном месте: функция Max().
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int Max(int arg1, int arg2, int arg3){    // Отработав функция выдаст result.
    int result = arg1;                    // По умолчанию первое число считаем максимальным.  
    if(arg2 > result)  result = arg2;     // Сравниваем его с остальными двумя.
    if(arg3 > result)  result = arg3;
    return result;     
}

// вариант 1.
//int max1 = Max(a1, b1, c1);               // Сравнение. Первая тройка.
//int max2 = Max(a2, b2, c2);               // Сравнение. Вторая тройка.
//int max3 = Max(a3, b3, c3);               // Сравнение. Третья тройка.
//int max = Max(max1, max2, max3);          // Сравнение "финалистов."

// вариант 2.
//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); 

// вариант 2.1
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);