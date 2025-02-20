using System.ComponentModel;

Console.WriteLine("\nМассив 5*5");
int SizeArray = 5;
int[,] MyltiLineFilter = new int[SizeArray, SizeArray];
Random NumGegerationArray = new Random();
for (int k = 0; k < MyltiLineFilter.GetLength(0); k++)
{
    for (int l = 0; l < MyltiLineFilter.GetLength(0); l++)
    {
        int NewNumArray = NumGegerationArray.Next(-10, 101);
        MyltiLineFilter[k, l] = NewNumArray;
        Console.Write(MyltiLineFilter[k, l] + " ");
    }
    Console.WriteLine();

};
//Второе по величине значение
int max = int.MinValue;
int secondLargest = int.MinValue;
foreach (int num in MyltiLineFilter)
{
    if (num > max)
    {
        max = num;//вычесляем максимальное значение
    }
    else if (num > secondLargest && num < max)//вычисляем второе по величине
    {
        secondLargest = num;
    }
}
Console.WriteLine($"Второе по величине значение: {secondLargest}");
//Cортировка значений в массиве
Console.WriteLine("\nСортировка");
int[] SortArray = MyltiLineFilter.Cast<int>().ToArray();//Преобразовываем в одномерный
Array.Sort(SortArray);//сортируем
Console.WriteLine(string.Join(", ", SortArray));

//удалление из массива
Console.WriteLine("\nУдаление из массива");
int[,] ArrayDelNum = { { 7, 8, 9 }, { 4, 5, 6 }, { 1, 2, 3 } };
for (int i = 0; i < ArrayDelNum.GetLength(0); i++)
{
    for (int j = 0; j < ArrayDelNum.GetLength(0); j++)
    {
        Console.Write(ArrayDelNum[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите значение для его удаления: ");
int DelNum=(Convert.ToInt32(Console.ReadLine()));
int[] NewArrayDelNum = ArrayDelNum.Cast<int>().Where(x => x != DelNum).ToArray();
Console.WriteLine($"Новый массив:\n{string.Join(", ", NewArrayDelNum)}");

//Сумма элементов по диагонале
Console.Write("Сумма элементов по диагонале: ");
int SumNumDiagonal = 0;
for (int k = 0;k< ArrayDelNum.GetLength(0); k++)
{
    SumNumDiagonal += ArrayDelNum[k, k];
}
Console.WriteLine(SumNumDiagonal);


