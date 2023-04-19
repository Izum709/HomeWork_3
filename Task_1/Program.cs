Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
string revnumber = "";
for (int index = number.Length - 1; index >= 0; index--)
{
    revnumber =  revnumber + number[index];
}

if (number == revnumber)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
