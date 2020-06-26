using System;
using System.Collections.Generic;
using System.Text;

namespace EnhancedNotepad
{
    interface IKeyWords
    {
        List<string> GetKeyWords(string input, int topResults);
    }
}
