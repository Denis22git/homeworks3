//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5ти значное число: ");
string number = Console.ReadLine();
    bool A = true;
    for (int i = 0; i < (number.Length - 1) / 2; i++)
    {
        if (number[i] != number[number.Length - i - 1])
        {
            A = false;
        }
    }        
    if (A)
    {
        Console.WriteLine("Палиндром");
    }
    else 
    {
        Console.WriteLine("Не палиндром");
    }
    Console.ReadKey();