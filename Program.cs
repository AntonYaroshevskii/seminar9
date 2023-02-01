// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(N,0));
// // ------Метод------------------------
// string PrintNumbers(int start, int end){
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start - 1, end));
// }

// //Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма натуральных эелементов в промежутке от M до N равна  = {SumNaturNumbers(M,N)} ");
// //------метод-----------------
// int SumNaturNumbers(int start, int end){
//     if(start == end) return end;
//     return (start + SumNaturNumbers(start + 1, end));
// }

//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.Write("Введите неотрицательное число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите неотрицательное число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(AkkermanFunc(M,N));
// //-----------метод---------------
// int AkkermanFunc(int m, int n){
// 	if(m == 0){
// 		return n + 1;
// 	}
// 	if(m > 0 && n == 0){
// 		return AkkermanFunc(m - 1, 1);
// 	}
// 		return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// }
		
