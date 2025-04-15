using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalTextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentences = new List<string>
            {
                "Functional programming is powerful and elegant.",
                "C# supports functional programming via LINQ and delegates.",
                "Pure functions and immutability lead to safer code.",
                "Declarative code is easier to reason about."
            };

            Console.WriteLine("--- ANALIZA ZDAŃ ---\n");

            Analyze(sentences);
        }

        static void Analyze(List<string> sentences)
        {
            var words = sentences
                .SelectMany(s => s.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
                .Select(w => w.ToLowerInvariant());

            var totalWords = words.Count();
            var uniqueWords = words.Distinct().Count();

            var wordFrequency = words
                .GroupBy(w => w)
                .Select(g => new { Word = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.Count)
                .Take(5);

            var sentenceLengths = sentences.Select(s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);

            var wordsStartingWithF = words.Where(w => w.StartsWith("f")).Distinct();

            Console.WriteLine($"Liczba wszystkich słów: {totalWords}");
            Console.WriteLine($"Liczba unikalnych słów: {uniqueWords}\n");

            Console.WriteLine("Top 5 najczęstszych słów:");
            foreach (var item in wordFrequency)
                Console.WriteLine($"{item.Word} - {item.Count}");

            Console.WriteLine("\nDługości zdań (w słowach):");
            foreach (var len in sentenceLengths)
                Console.WriteLine(len);

            Console.WriteLine("\nSłowa zaczynające się na literę 'f':");
            foreach (var word in wordsStartingWithF)
                Console.WriteLine(word);
        }
    }
}
