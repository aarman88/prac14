using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится " +
                      "В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует " +
                      "пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

        // Очищаем текст от знаков препинания и разбиваем его на слова
        string[] words = Regex.Split(text, @"\W+");

        // Создаем словарь для подсчета слов
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        // Подсчитываем количество каждого слова
        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                string lowercaseWord = word.ToLower(); // Приводим к нижнему регистру для учета
                if (wordCount.ContainsKey(lowercaseWord))
                {
                    wordCount[lowercaseWord]++;
                }
                else
                {
                    wordCount[lowercaseWord] = 1;
                }
            }
        }

        // Выводим статистику
        Console.WriteLine("Слово\t\t\tКоличество");
        Console.WriteLine("-----------------------------");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key,-20}\t{pair.Value}");
        }
    }
}
