using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Labs
{
//     class Program
//     {   
//         static void IsCorrect(string strBracket)
//         {
//             Stack<char> Brackets = new Stack<char>();
//             if (strBracket == null) return;
//             foreach (char symbol in strBracket)
//             {
//                 if (symbol == '(' || symbol == '[' || symbol == '{') 
//                     Brackets.Push(symbol);
//                 else
//                 {
//                     if (Brackets.Count == 0)
//                     {
//                         Console.WriteLine("Строка не корректна");
//                         return;
//                     }
//                     char lastOpenedBracket = Brackets.Pop();
//                     if ((symbol == ')' && lastOpenedBracket != '(') ||
//                         (symbol == ']' && lastOpenedBracket != '[') ||
//                         (symbol == '}' && lastOpenedBracket != '{')
//                         )
//                     {
//                         Console.WriteLine("Строка не корректна");
//                         return;
//                     }
//                 }
//             }
//             if (Brackets.Count == 0) 
//                 Console.WriteLine("Строка корректна");
//             else 
//                 Console.WriteLine("Строка не корректна");
//         }
//         static void Main(string[] args)
//         {   
//             Console.WriteLine("Введите строку:");
//             string strBracket = Console.ReadLine();
//             if (strBracket == null) return;
//             IsCorrect(strBracket);
//         }
//     }
// }


// namespace FirstLab
// {
//     class Lab2
//     {   
//         static bool IsCorrectBrackets(string strBracket)
//         {
//             Stack<char> Brackets = new Stack<char>();
//             foreach (char symbol in strBracket)
//             {
//                 if (symbol == '(' || symbol == '[' || symbol == '{') 
//                     Brackets.Push(symbol);
//                 else if (symbol == ')' || symbol == ']' || symbol == '}')
//                 {
//                     if (Brackets.Count == 0)
//                     {
//                         Console.WriteLine("Скобки в арифметическом выражении не корректны");
//                         return false;
//                     }
//                     char lastOpenedBracket = Brackets.Pop();
//                     if ((symbol == ')' && lastOpenedBracket != '(') ||
//                         (symbol == ']' && lastOpenedBracket != '[') ||
//                         (symbol == '}' && lastOpenedBracket != '{')
//                         )
//                     {
//                         Console.WriteLine("Скобки в арифметическом выражении не корректны");
//                         return false;
//                     }
//                 }
//             }
//             if (Brackets.Count == 0) 
//                 return true;
//             else 
//                 Console.WriteLine("Скобки в арифметическом выражении не корректны");
//                 return false;
//         }
//         static bool IsCorrectExpression(string expression)
//         {   
//             char [] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
//             char [] operats = {'+', '-', '*', '/'};
//             for (int i = 1; i < expression.Length; i++)
//             {
//                 if (expression[i-1] == expression[i] 
//                     && Array.IndexOf(operats, expression[i-1]) != -1 && Array.IndexOf(operats, expression[i]) != -1)
//                 {
//                     Console.WriteLine("Две подряд операции");
//                     return false;
//                 }
//                 if (expression[i-1] == '/' && expression[i] == '0')
//                 {
//                     Console.WriteLine("Ошибка деления на 0");
//                     return false;
//                 }
//             }
//             if (Array.IndexOf(operats, expression[0]) != -1)
//                 {
//                     Console.WriteLine("Некорретный первый символ арифметического выражения");
//                     return false;
//                 }
//             if (expression[expression.Length - 1] != '=' || expression.Count(x => x == '=') != 1)
//                 {
//                     Console.WriteLine("Некорректный последний символ арифметического выражения");
//                     return false;                    
//                 }
//             return true;
//         }
//         static void Main(string[] args)
//         {   
//             Console.WriteLine("Введите арифметическое выражение:");
//             string arifExpression = Console.ReadLine();
//             arifExpression = arifExpression.Replace(" ", "");
//             if (arifExpression == null) return;
//             if (IsCorrectBrackets(arifExpression) && IsCorrectExpression(arifExpression))
//             {
//                 Console.WriteLine("Арифметическое выражение корректно");
//             }
//             return;
//         }
//     }
// }

    // class Lab4
    // {   

    //     static string Sort(string str)
    //     {   
    //         char[] numbersArr = new char[str.Length];
    //         for (int i = 0; i < str.Length; i++) numbersArr[i] = str[i];
    //         int gap = numbersArr.Length;
    //         double shrink = 1.234;
    //         while (gap > 1)
    //         {
    //             gap = (int)(gap / shrink);
    //             if (gap < 1) gap = 1;
    //             for (int i = 0; i < numbersArr.Length - gap; i++)
    //             {
    //                 if (numbersArr[i] > numbersArr[i + gap])
    //                 {
    //                     char temp = numbersArr[i];
    //                     numbersArr[i] = numbersArr[i + gap];
    //                     numbersArr[i + gap] = temp;
    //                 }
    //             }
    //         }
    //     str = new string(numbersArr);
    //     return str;
    //     }
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Введите строку: ");
    //         string str = Console.ReadLine();
    //         if (str == null) return;
    //         Console.WriteLine(Sort(str));
    //     }
    // }
    // 
    // class Lab5
    // {
    //     static string InsertionSort(string numbers)
    //     {   
    //         char[] numberArray = numbers.ToCharArray();
    //         for (int i = 1; i < numberArray.Length; i++)
    //         {
    //             char key = numberArray[i];
    //             int j = i - 1;
    //             while ((j >= 0) && (numberArray[j] > key))
    //             {
    //                 numberArray[j + 1] = numberArray[j];
    //                 j--;
    //             }
    //             numberArray[j + 1] = key;
    //         }
    //         return new string(numberArray);
    //     }
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Введите последовательность чисел:" );
    //         string numbers = Console.ReadLine();
    //         if (numbers == null) return;
    //         Console.WriteLine(InsertionSort(numbers));
    //     }
    // }
}