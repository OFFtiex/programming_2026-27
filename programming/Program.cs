namespace FirstLab
{
    class Program
    {   
        static void IsCorrect(string strBracket)
        {
            Stack<char> Brackets = new Stack<char>();
            if (strBracket == null) return;
            foreach (char symbol in strBracket)
            {
                if (symbol == '(' || symbol == '[' || symbol == '{') 
                    Brackets.Push(symbol);
                else
                {
                    if (Brackets.Count == 0)
                    {
                        Console.WriteLine("Строка не корректна");
                        return;
                    }
                    char lastOpenedBracket = Brackets.Pop();
                    if ((symbol == ')' && lastOpenedBracket != '(') ||
                        (symbol == ']' && lastOpenedBracket != '[') ||
                        (symbol == '}' && lastOpenedBracket != '{')
                        )
                    {
                        Console.WriteLine("Строка не корректна");
                        return;
                    }
                }
            }
            if (Brackets.Count == 0) 
                Console.WriteLine("Строка корректна");
            else 
                Console.WriteLine("Строка не корректна");
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите строку:");
            string strBracket = Console.ReadLine();
            if (strBracket == null) return;
            IsCorrect(strBracket);
        }
    }
}

