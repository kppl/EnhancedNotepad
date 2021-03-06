﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnhancedNotepad
{
    public static class KeyWordFactory
    {
        static List<string> KeyWords; 

        public static List<string> GetKeyWordList(string input, string category)
        {
            switch (category)
            {
                // TODO: enumeration here
                case "most used":
                    KeyWordsMostUsed result = new KeyWordsMostUsed();
                    return result.GetKeyWords(input);
                case "context related":
                    return null;
                case "positive":
                    return null;
                case "negative":
                    return null;
                default:
                    return null;
            }
        }
    }
}
