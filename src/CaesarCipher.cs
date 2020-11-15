using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    class CaesarCipher
    {
        public char key { get; set; }
        
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

        public string Encrypt(string plainText)
        {
            throw new NotImplementedException();
        }

        public string Decrypt(string cipherText)
        {
            throw new NotImplementedException();
        }
    }
}
