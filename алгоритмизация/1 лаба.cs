﻿// using System;
// using System.Data;

// // УСЛОВИЯ ЗАДАЧИ: поменять значение a и b между собой
// namespace project {
//     class Program 
//     {
//         static void Main()
//         {
//             Console.WriteLine("Введите два числа:");
//             int a = Convert.ToInt32(Console.ReadLine());
//             int b = Convert.ToInt32(Console.ReadLine());
//             a = a + b;
//             b = a - b;
//             a = a - b;
//             Console.WriteLine(a);
//             Console.WriteLine(b);
           
//         }
//     }
// }


// using System;
// using System.Data;

// //  УСЛОВИЕ ЗАДАЧИ: ВЫВЕСТИ НАИБОЛЬШЕЕ И НАИМЕНЬШЕЕ ИЗ ДВУХ ВОДИМЫХ ЧИСЕЛ
// namespace project {
//     class Program 
//     {
//         static void Main()
//         {
//             int a, b;

//             Console.WriteLine("Введите два числа:");
//             a = Convert.ToInt32(Console.ReadLine());
//             b = Convert.ToInt32(Console.ReadLine());

//             int min = (a + b - Math.Abs(a - b)) / 2;
//             int max = (a + b + Math.Abs(a - b)) / 2;

//             Console.WriteLine($"Наименьшее значение: {min}");
//             Console.WriteLine($"Наибольшее значение: {max}");  
//        }
//     }
// }
 



// ИСХОДНЫЕ ДАННЫЕ
// ЗАДАЧА 3 ИСХОДНЫЕ ДАННЫЕ: длина = ширина = 3, расстояние от колодца до грядки = 5
//  расстояние между грядками = 0
// для1 грядки ответ = 22 для 2 грядок отвте = 50 для трёх грядок = 84, для 10 =490
// using System;
// using System.Data;

// namespace project {
//     class Program 
//     {
//         static void Main()
//         {
//             Console.WriteLine("Введите длину грядки(она же как бы верхняя сторона):");
//             int len = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите ширину грядки:");
//             int wid = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите расстояние между грядками:");
//             int rast = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите расстояние от колодца до первой грядки:");
//             int p = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите количество грядок:");
//             int n = Convert.ToInt32(Console.ReadLine());
//             int raznica = len *2;
//             Console.WriteLine("Ответ");
//             int res = rast*2*(n-1)+((p*2+(len+wid)*2)+( p*2+(len+wid)*2)+raznica*(n-1))/2*n;
//             Console.WriteLine(res);
           
//         }
//     }
// }
