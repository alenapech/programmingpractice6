// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Задача 041");
Console.WriteLine("Сколько чисел Вы хотите ввести?");
int number = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[number];
for (int i = 0; i < number; i++)
    {
       Console.WriteLine("Введите число");
       Array[i] =  Convert.ToInt32(Console.ReadLine());
     }

    int count = 0; 
    for (int i =0; i < Array.Length; i++)
    {
        
        if(Array[i] > 0) count = count + 1;
        Console.Write(Array[i] + "\t"); 
    }

    Console.WriteLine("_____________________");
    Console.WriteLine($"Вы ввели {count} положительных(ое) чисел(ла)");
 



