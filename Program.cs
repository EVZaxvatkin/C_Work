
string [] array = new string[5];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элементы массива");
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Вывод заданных элементов");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}

Console.WriteLine();
Console.WriteLine("Вывод элементов, состоящих из 3 символов");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
    Console.Write(array[i] + "\t");
}
