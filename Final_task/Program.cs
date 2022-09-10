// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

Console.WriteLine();
Console.WriteLine("--> Итоговая задача <--");
string[] arr1 = new string[5] {"Hello", "World", "-1211", "Rusia", "999"};
string[] arr2 = new string[arr1.Length];
int count = 0;
Console.Write("Первоначальный массив: ");
Console.Write("[");
Console.Write("Hello, World, -1211, Rusia, 999");
Console.Write("]");

NewArray(arr1, arr2);
void NewArray(string[] arr1, string[] arr2){
    for (int i = 0; i < arr1.Length; i++){
        if(arr1[i].Length <= 3){
            arr2[count] = arr1[i];
            count++;}}}     
Console.WriteLine();

Console.Write("Полученный массив: ");
Console.Write("[");
PrintArray(arr2);
Console.Write("]");
void PrintArray(string[] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.Write(arr[i]);}}
Console.WriteLine();
Console.WriteLine();