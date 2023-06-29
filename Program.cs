// -------------------------------------------ВСЕ РЕШАТЬ ЧЕРЕЗ МЕТОДЫ---------------------------------------------------

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// Console.Write("Введите число 1: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число 2: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{GetMultiply(B)}");


// int GetMultiply(int limit){

//   int result = 1;
//   for (int i = 1; i <= limit; i++)
//   {
//     result = result * A;
//   }
//   return result;
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{GetSum(num)}");

// int GetSum(int number)
// {
//   int sum = 0;
//   while (number > 0)
//   {
//     sum = sum + number % 10;
//     number /= 10;
//   }
//   return sum;
// }



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] array = GetArray(8,0,100);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetArray(int size, int minValue, int maxValue){
  int[] result = new int[size];
  for(int i = 0; i < size; i++){
    result[i] = new Random().Next(minValue, maxValue);
  }
  return result;
}