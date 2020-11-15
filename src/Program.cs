using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher caesarCipher = new CaesarCipher();
            string result = ""; // Empty assignment prevents compiler error at end of file 

            Console.Write("Encrypt [y] Decrypt [n]: ");
            char mode = Char.ToLower(Console.ReadKey().KeyChar);

            Console.Write("\nKey Char: ");
            char key = Char.ToLower(Console.ReadKey().KeyChar);

            if (key == 13 || key == 0)
            {
                Console.WriteLine("Please enter a correct key value!");
                return;
            }
            else { caesarCipher.key = key; }

            if (mode == 'y')
            {
                //Get the text to encrypt and encrypt it!
                Console.Write("\nPlain Text: ");
                string plainText = Console.ReadLine();

                result = caesarCipher.Encrypt(plainText);
            }
            else if (mode == 'n')
            {
                //Get the text to decrypt and then decrypt it!
                Console.Write("\nCipher Text: ");
                string cipherText = Console.ReadLine();

                result = caesarCipher.Decrypt(cipherText);
            }
            else { Console.WriteLine("[ERROR]: Please enter correct value"); }

            //Output the result
            Console.WriteLine($"Result:\n{result}");
        }
    }
}
