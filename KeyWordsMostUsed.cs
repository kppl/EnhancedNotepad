using System;
using System.Collections.Generic;
using System.Text;

namespace EnhancedNotepad
{
    class KeyWordsMostUsed : IKeyWords 
    {
        private Dictionary<string, int> wordDict = new Dictionary<string, int>();

        public List<string> GetKeyWords(string input)
        {
            //TODO:
            // Count words
            string inputAphanumericOnly = input.ToLower().Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "");
            string[] words = input.Split(' ');
            foreach(string word in words)
            {
                if (wordDict.ContainsKey(word))
                {
                    wordDict[word] += 1;
                }
                else
                    wordDict.Add(word, 1);
            }
            return null;
        }
    }
         
}
