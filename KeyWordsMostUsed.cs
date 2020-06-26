using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnhancedNotepad
{
    class KeyWordsMostUsed : IKeyWords 
    {
        private Dictionary<string, int> WordDict = new Dictionary<string, int>();

        public List<string> GetKeyWords(string input, int topResults = 10)
        {
            List<string> result = new List<string>();

            string inputAphanumericOnly = input.ToLower().Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "");
            string[] words = input.Split(' ');
            foreach(string word in words)
            {
                if (WordDict.ContainsKey(word))
                {
                    WordDict[word] += 1;
                }
                else
                    WordDict.Add(word, 1);
            }
            PrintWords();
            WordDict.OrderByDescending(s => s.Value);
            PrintWords();
            for (int i = 0; i < WordDict.Count && i < topResults; i++)
            {
                result.Add(WordDict.ElementAt<KeyValuePair<string,int>>(i).Key);
            }

            return result;
        }

        public void PrintWords()
        {
            foreach (KeyValuePair<string, int> word in WordDict)
            {
                Console.WriteLine(word.Key + ": " + word.Value);
            }
        }
    }
         
}
