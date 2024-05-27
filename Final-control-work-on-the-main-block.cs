/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. */
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int CountingElementsUpToThreeCharacters(string[] arr)   //Считаем количество элементов подходящих под условие задачи 
{
    int iter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            iter++;
        }
    }
    return iter;   //количество элементов подходящих под условие задачи == количество элементов итогового массива
}

string[] RemovingMoreThanThreeCharactersFromAnArrayOfStrings(string[] arr)   //Создаем новый массив и заполняем элесентами подходящими под условия задачи
{
    string[] FinalArray = new string[CountingElementsUpToThreeCharacters(arr)];   //Тут у нас создается массив строк количество элемнтов которого берется из функии с подсчетом
    int IterForFinalArray = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            FinalArray[IterForFinalArray] = arr[i];
            IterForFinalArray++;   //Этот счетчик двигает нас по элементам нового массива 
        }
    }
    return FinalArray;   //Итоговый массив
}

void WriteArray(string[] arr)   //Вывод массива
{
    Console.WriteLine("Итоговый массив:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  ");
    }
}

Console.WriteLine("Введите количество элементов массива"); // Первичные переменные и ввод массива 
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    j = i + 1;
    Console.WriteLine($"Введите элемент массива №{j}");
    array[i] = Console.ReadLine();
}

WriteArray(RemovingMoreThanThreeCharactersFromAnArrayOfStrings(array));