//              0   1   2   3   4   5   6   7   8
int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
array[0] = 12;                            // 0 элементу массива array присвоить значение 12.
Console.WriteLine(array[0]);              // Так можно получить значение по указанному индексу.

int Max(int arg1, int arg2, int arg3){    // Отработав функция выдаст result.
    int result = arg1;                    // По умолчанию первое число считаем максимальным.  
    if(arg2 > result)  result = arg2;     // Сравниваем его с остальными двумя.
    if(arg3 > result)  result = arg3;
    return result;     
}

int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);