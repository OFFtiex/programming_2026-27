// using System.Diagnostics.CodeAnalysis;

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
//                 if (Array.IndexOf(operats, expression[0]) != -1)
//                 {
//                     Console.WriteLine("Некорретный первый символ арифметического выражения");
//                     return false;
//                 }
//                 if (expression[-1] != '=')
//                 {
//                     Console.WriteLine("Некорретный последний символ арифметического выражения");
//                     return false;                    
//                 }
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
//             return true;
//         }
//         static void Main(string[] args)
//         {   
//             Console.WriteLine("Введите арифметическое выражение:");
//             string arifExpression = Console.ReadLine();
//             if (arifExpression == null) return;
//             if (IsCorrectBrackets(arifExpression) && IsCorrectExpression(arifExpression))
//             {
//                 Console.WriteLine("Арифметическое выражение корректно");
//             }
//         }
//     }
// }

