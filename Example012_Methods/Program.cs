// Вид 1. Ничего не принимают, ничего не возвращают.

void Method1(){                             // () - пустые скобки, ничего не принимаем. void - ничего не возвращаем.
    Console.WriteLine("Автор ... ");        // Тело метода может что-то выводить на экран.
}

// Method1();                               // Так вызывается этот метод.


// Вид 2. Что-то принимают, ничего не возвращают.

void Method2(string msg){                  // string msg - принимаем строчную переменную. void - ничего не возвращаем.
    Console.WriteLine(msg);    
}

// Method2("Текст сообщения");             // Так вызывается этот метод и передаются в него какие-то данные.

void Method21(string msg, int count){      // (string msg, int count) - принимаем две переменных. void - ничего не возвращаем.
    int i = 0;                             // Ctrl + C прерывает выполнение программы.  
    while(i < count){
        Console.WriteLine(msg);
        i++;
    }    
}

// Method21(count: 4, msg: "Текст");          // Явное указание какому аргументу присваиваем какое значение. Порядок указания соблюдать не обязательно. 
// Method21("Текст", 4);                      // Не явное указание какому аргументу присваиваем какое значение. Порядок указания соблюдать обязательно. 


// Вид 3. Ничего не принимают, что-то возвращают.

int Method3(){                                // () - пустые скобки, ничего не принимаем. int - возвращаем число.
    return DateTime.Now.Year;                 // return - обязательно использовать.
}

int year = Method3();                         // Возвращаемое число помещаем в переменную year.
// Console.WriteLine(year);                   // И выводим на экран.
// Console.WriteLine(Method3());              // Или так, без переменной.


// Вид 4. Что-то принимают, что-то возвращают.

// string Method4(int count, string text){       // (int count, string text) - принимаем числовую и строчную переменные. string - возвращаем строку.
//     int i = 0;
//     string result = String.Empty;             // string result = " "; - вместо пустой строки запишем String.Empty - это более понятная запись.

//     while(i < count){
//         result = result + text;               // Переименование переменной - выделяем и нажимаем F2 (rename symbol), вводим новое имя. 
//         i++;
//     }
//     return result;                            // return - обязательно использовать.
// }

// string res = Method4(10, "Z");
// Console.WriteLine(res);

// Тоже самое только за место while будет цикл for.
string Method4(int count, string text){
    string result = String.Empty;
    for(int i = 0; i < count; i++){
        result = result + text;    
    }
    return result;    
}

string res = Method4(10, "Z");
// Console.WriteLine(res);

// Цикл в цикле. Вывод таблицы умножения на экран.
// for(int i = 2; i <= 10; i++){
//     for(int j = 2; j <= 10; j++){
//         Console.WriteLine($"{i} X {j} = {i*j}");   // Интерполяция строк. 
//     }
//     Console.WriteLine();                           // Отступы между работой внутреннего цикла..
// }


// ----------------------------------(Работа с текстом) ---------------------------------
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// Ясна ли задача?

string text = "- Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милогоВинценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Выдадите мне чаю?";

// string s = "qwerty";    строка как массив.
//             012345
// s[3]  // r              обращаемся к элементу.

string Replace(string text, char oldValue, char newValue){   // 4 тип. string text - принимаем строку, которую будем менять. char oldValue - старый символ меняем на новый символ - char newValue. 
    string result = String.Empty;         // Переменная, в которой старые символы меняем на новые. 
    int length = text.Length;             // Узнаем кол-во символов в строке/"массиве". 

    for(int i = 0; i < length; i++){
        if(text[i] == oldValue) result = result + $"{newValue}";   // $"{newValue}" это значение присваиваем в переменную которая вернет это значение за место старого. 
        else result = result + $"{text[i]}";                       // $"{text[i]}" это значение присваиваем в случае если совпадение не найдено т.е оставляем как было. 
    }
    return result;   
}

string newText = Replace(text, ' ', '|'); 
//Console.WriteLine(newText);                    // Выполнили только часть задания. Заменили пробелы вертикальными черточками

//Console.WriteLine();
newText = Replace(newText, 'к', 'К');             // Доделываем полученный текст. 
//Console.WriteLine(newText);

// Сортировка массива. Алгоритм сортировки методом "выбора, минимакса". 
// Суть: массив = {6, 8, 3, 2, 1, 4, 5, 7}; Выбрать первый элемент: 6. В оставшейся части найти минимальный: 1. Поменять их местами.
// Далее выбираем второй элемент: 8. Первый элемент уже не трогаем. Снова в оставшейся части находим минимальный: 2. Меняем их местами и т.д.
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; 

void PrintArray(int[] array){       // Метод, который выводит массив на экран.
    int count = array.Length;
    for(int i = 0; i < count; i++){
        Console.Write($"{array[i]} ");    
    }
    Console.WriteLine();
}
/*
void SelectionSort(int[] array){
    for(int i = 0; i < array.Length - 1; i++){
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++){
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];           // Временная переменная, в которой лежит минимальное число.
        array[i] = array[minPosition];      // Меняем местами. Swap.
        array[minPosition] = temporary;     // Меняем местами. Swap.
    }
}
*/


// Задача. Подумать, как отсортировать массив от больших чисел к маленьким.
void SelectionSort(int[] array){
    for (int i = 0; i < array.Length - 1; i++){
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++){
            if (array[j] > array[minPosition]) minPosition = j;  
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);