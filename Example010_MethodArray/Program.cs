﻿/*
    Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
    1. Установить счетчик index в позицию 0
    2. Если array [index] = find, алгоритм завершил работу успешно.
    3. Увеличить index на 1
    4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.
*/

int[] array = {1, 12, 31, 18, 4, 15, 16, 17, 18}; 

int n = array.Length;    // определяем длинну массива. (кол-во элементов)
int find = 18;            // число, которое ищем в массиве.

int index = 0;           // наш счетчик. 0 - означает начало массива.

while(index < n){
    if(array[index] == find){
        Console.WriteLine(index);
        break;                       // прерывает цикл. Будет искаться только первое совпадение.
    }  
    index++;
}

// Console.Write(n);