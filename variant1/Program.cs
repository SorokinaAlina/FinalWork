//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3м символам. 
//Первоначальный массив вводится с клавиатуры, либо задается на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
Console.WriteLine("Данная программа автоматически определяет количество символов в словах.");
Console.WriteLine("Будут отображены только те, где количество символов меньше или равно 3м.");
Console.WriteLine("Введите несколько слов с клавиатуры. Сколько слов у вас будет?:");
int n=Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[n];
int i=0;

while (i<n)
{
    Console.WriteLine($"Введите {i+1}-ое слово");
    array1[i]=Console.ReadLine();
    
    i++;
}

string[] array2 = new string[array1.Length];
void FindElementsLessThen3(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[index] = array1[i];
        index++;
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
FindElementsLessThen3(array1, array2);
Console.WriteLine("Введенные с клавиатуры слова: ");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Слова, у которых количество символов меньше или равно 3м:");
PrintArray(array2);
