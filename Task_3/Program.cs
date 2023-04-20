// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int EnterData(string text)
{
    Console.WriteLine(text);
    return(int.Parse(Console.ReadLine()));
}

int number = EnterData("Введи число: ");
int cub = 1;
Console.Write($" {number} -> ");
while (cub < number)
{
    
    Console.Write($" {cub * cub * cub}, " );
    cub = cub + 1;
}
Console.Write($" {number *number*number}. ");