using System;
using System.Collections.Generic;
using System.Text;

namespace EnhancedNotepad
{
    class KeyWordsMostUsed : IKeyWords 
    {
        private Dictionary<string, int> wordDict = new Dictionary<string, int>();

        public List<string> GetKeyWords()
        {
            //TODO:
            // Count words
            return null;
        }
    }
         
}
