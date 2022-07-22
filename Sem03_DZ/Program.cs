void Zadacha19()
{
    //Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.WriteLine("Введите пятизначное число");
    Random random = new Random();
    string number = Console.ReadLine();
    if (number.Length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine("Введенное число - палиндром");
        }
        else 
        {
            Console.WriteLine("Введенное число не является палиндромом");
        }
    }
    else 
    {
        Console.WriteLine("Введенное некорректное число");
    }    
}

//Zadacha19();

void Zadacha21()
{
    //Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Введите координаты x,y,z первой точки через Enter");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты x,y,z второй точки через Enter");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());
    /*
    Random random = new Random();
    int x1 = random.Next(0, 100);
    int y1 = random.Next(0, 100);
    int z1 = random.Next(0, 100);
    int x2 = random.Next(0, 100);
    int y2 = random.Next(0, 100);
    int z2 = random.Next(0, 100);
    */
    double dist = 0;
    Console.WriteLine($"Координаты точки 1 ({x1}, {y1}, {z1}) и точки 2 ({x2} , {y2}, {z2})");
    dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние ({Math.Round(dist, 2)})");
}

//Zadacha21();

void Zadacha23()
{
    //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Random random = new Random();
    int n = random.Next(0, 10);
    double num = 1;
    double res;
    Console.WriteLine($"Число {n}");
    while (num <= n)
    {
        res = Math.Pow(num, 3);
        Console.WriteLine($"{num}^3={res}");
        num++;
    }

}

Zadacha23();