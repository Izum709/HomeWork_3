// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



int EnterData(string text)
{
    Console.WriteLine(text);
    return(int.Parse(Console.ReadLine()));
}

int Ax = EnterData("Введите координаты Ax ");
int Ay = EnterData("Введите координаты Ay ");
int Az = EnterData("Введите координаты Az ");

int Bx = EnterData("Введите координаты Bx ");
int By = EnterData("Введите координаты By ");
int Bz = EnterData("Введите координаты Bz ");

double line = Math.Sqrt((Bx-Ax)*(Bx-Ax) + (By-Ay)*(By-Ay) + (Bz-Az)*(Bz-Az));
Console.WriteLine($"A ({Ax},{Ay},{Az}); B ({Bx}, {By}, {Bz}), -> {line}");