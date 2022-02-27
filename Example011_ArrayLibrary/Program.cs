// void - ничего не возвращать.
// Используя в методе void, нам не надо писать return в конце.

int[] array = new int[10];            // Создаем массив array на 10 ячеек. По умолчанию заполнен нулями.

void FillArray(int[] collection){     // Метод заполняющий массив случайными числами.                 
    int length = collection.Length;
    int index = 0;

    while(index < length){
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col){           // Метод который будет печатать массив. 
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.WriteLine(col[position]);
        position++;
    }   
}

int IndexOf(int[] collection, int find){  // Метод который будет находить нужное число. (где, что)
    int count = collection.Length;
    int index = 0;
    int position = -1;                    // Значение которое будет показано в случае отсутствия совпадений. 

    while(index < count){                 // Цикл сравнения с искомым числом.
        if(collection[index] == find){
            position = index;             
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);       // Методу FillArray передаем данные массива array.
PrintArray(array);      // Методу PrintArray передаем данные массива array.
Console.WriteLine();

int pos = IndexOf(array, 4);  
Console.WriteLine(pos);