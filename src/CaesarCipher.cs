using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    class CaesarCipher
    {
        private char _key;
        
        private static Dictionary<char, byte> alphabetPositions = new Dictionary<char, byte>
        {
            {'a', 0 },  {'b', 1 },  {'c', 2 },
            {'d', 3 },  {'e', 4 },  {'f', 5 },
            {'g', 6 },  {'h', 7 },  {'i', 8 },
            {'j', 9 },  {'k', 10 }, {'l', 11 },
            {'m', 12 }, {'n', 13 }, {'o', 14 },
            {'p', 15 }, {'q', 16 }, {'r', 17 },
            {'s', 18 }, {'t', 19 }, {'u', 20 },
            {'v', 21 }, {'w', 22 }, {'x', 23 },
            {'y', 24 }, {'z', 25 }
        };

        public bool setKey(char key)
        {
            if (!alphabetPositions.ContainsKey(key)) { return false; }
            
            _key = key;
            return true;
        }

        private char getKeyFromValue(sbyte value)
        {
            foreach (KeyValuePair<char, byte> entry in alphabetPositions)
            {
                if (entry.Value == value)
                {
                    return entry.Key;
                }
            }

            return ' ';
        }

        public string Encrypt(string plainText)
        {
            string cipherText = "";
            byte keyRange = alphabetPositions[_key];

            foreach (char letter in plainText)
            {
                bool isUpper = false;
                if (Char.IsUpper(letter)) { isUpper = true; }

                // Detect the character position and update it based on the key
                sbyte charValue;
                try
                {
                    charValue = (sbyte)(alphabetPositions[Char.ToLower(letter)] + keyRange);
                }
                catch (KeyNotFoundException e)
                {
                    cipherText += letter;
                    continue;
                }

                if (charValue > 25) { charValue -= 26; };

                char cipherLetter = getKeyFromValue(charValue);
                cipherText += isUpper ? Char.ToUpper(cipherLetter) : cipherLetter;
            }

            return cipherText;
        }

        public string Decrypt(string cipherText)
        {
            string plainText = "";
            byte keyRange = alphabetPositions[_key];

            foreach (char letter in cipherText)
            {
                bool isUpper = false;
                if (Char.IsUpper(letter)) { isUpper = true; }

                sbyte charValue;
                try
                {
                    charValue = (sbyte)(alphabetPositions[Char.ToLower(letter)] - keyRange);
                }
                catch (KeyNotFoundException e)
                {
                    plainText += letter;
                    continue;
                }

                if (charValue < 0) { charValue += 26; };

                char plainLetter = getKeyFromValue(charValue);
                plainText += isUpper ? Char.ToUpper(plainLetter) : plainLetter;
            }

            return plainText;
        }
    }
}
