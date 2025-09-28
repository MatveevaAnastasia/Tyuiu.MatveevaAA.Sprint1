using System;
using Tyuiu.MatveevaAA.Sprint1.Task6.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();
 
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (word.Length > 0)
                {

                    char firstLetter = word[0];

                    string restOfWord = word.Substring(1);

                    Console.Write(restOfWord + firstLetter + " ");

                    Console.ReadKey();
                }
            }
        }
    }
}