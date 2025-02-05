namespace _02_PZ5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // Пример использования FilterNumbers
            List<int> numbers = new List<int> { 10, 15, 20, 25, 30, 35, 40, 45 };
            int divisor = 5;
            List<int> filteredNumbers = FilterNumbers(numbers, divisor);
            Console.WriteLine("Отфильтрованные числа: " + string.Join(", ", filteredNumbers));

            // Пример использования FindLongestString
            List<string> strings = new List<string> { "apple", "banana", "strawberry", "kiwi" };
            string longestString = FindLongestString(strings);
            Console.WriteLine("Самая длинная строка: " + longestString);

            // Пример использования IsPalindrome
            string input = "Madam";
            bool isPalindrome = IsPalindrome(input);
            Console.WriteLine($"Строка \"{input}\" является палиндромом: {isPalindrome}");
        }

        static List<int> FilterNumbers(List<int> numbers, int divisor)
        {
            return numbers.Where(n => n % divisor != 0).ToList();
        }

        static string FindLongestString(List<string> strings)
        {
            return strings.OrderByDescending(s => s.Length).FirstOrDefault() ?? string.Empty;
        }

        static bool IsPalindrome(string input)
        {
            string upper = input.ToUpper();
            return upper.SequenceEqual(upper.Reverse());
        }
    }
}
