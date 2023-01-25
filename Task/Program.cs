//Написать программу, которая из имеющегося массива строк формирует
//массив из строк, длина которых меньше либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = {"12hj", "123456", "12v", "2U", "Frd458j", "8="};
var result = new string[array.Length];
void Array3symb(string[] array, string[] result)
{
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        result[i] = array[i];
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Array3symb(array, result);
PrintArray(result);
