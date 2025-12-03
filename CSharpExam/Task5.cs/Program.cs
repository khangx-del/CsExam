using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Words = new Dictionary<string, string>
            {
                { "a", "apple" }              
            };
            while (true)
            {
                Console.WriteLine("1. Add Word and its definition");
                Console.WriteLine("2.Remove a Word");
                Console.WriteLine("3. Show all words and definitions");
                Console.WriteLine("4. Exit Program");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }
                
              
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the word: ");
                        string wordToAdd = Console.ReadLine();
                        if (Words.ContainsKey(wordToAdd))
                        {
                            Console.WriteLine("Word already exists. Do you want to overwrite it (yes/no)");
                            string response = Console.ReadLine();
                            if (response.ToLower() == "yes")
                            {
                                Console.Write("Enter the definition: ");
                                string definitionToAdd = Console.ReadLine();

                                Words[wordToAdd] = definitionToAdd;

                            }
                            else
                            {
                                Console.WriteLine("Word not added.");
                                break;
                            }
                        }
                        else if(!Words.ContainsKey(wordToAdd))
                        {
                            Console.Write("Enter the definition: ");
                            string definitionToAddNew = Console.ReadLine();
                            Words[wordToAdd] = definitionToAddNew;
                            Console.WriteLine("Word added successfully.");
                        }
                        break; 
                        
                                           
                    case 2:
                        Console.Write("Enter the word to remove: ");
                        string wordToRemove = Console.ReadLine();
                        if (Words.Remove(wordToRemove))
                        {
                            Console.WriteLine("Word removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Word not found.");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Words and Definitions:");
                        foreach (var kvp in Words)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
