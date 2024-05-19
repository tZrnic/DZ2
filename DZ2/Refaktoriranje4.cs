﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Refaktoriranje4
    {
        public static List<char> ExtractUnique(string text)
        {
            List<char> chars = new List<char>();
            for (int index = 0; index < text.Length; index++)
            {
                if (IsUnique(text, text[index]))
                {
                    chars.Add(text[index]);
                }
            }
            return chars;
        }
        public static bool IsUnique(string text, char character)
        {
            int occurrenceCount = 0;
            for (int index = 0; index < text.Length; index++)
            {
                if (character == text[index])
                {
                    occurrenceCount++;
                }
            }
            if (occurrenceCount != 1) return false;
            return true;
        }
    }
}
