using System;

class CaesarCipher
{
    static string Encrypt(string message, int shift)
    {
        char[] result = new char[message.Length];

        for (int i = 0; i < message.Length; i++)
        {
            char ch = message[i];

            if (char.IsLetter(ch))
            {
                char offset = char.IsUpper(ch) ? 'A' : 'a';
                result[i] = (char)(((ch + shift - offset) % 26 + 26) % 26 + offset);
            }
            else
            {
                result[i] = ch;
            }
        }

        return new string(result);
    }

    static string Decrypt(string encryptedMessage, int shift)
    {

        return Encrypt(encryptedMessage, -shift);
    }

    static void Main()
    {
        Console.WriteLine("Enter the message to encrypt:");
        string messageToEncrypt = Console.ReadLine();

        Console.WriteLine("Enter the shift value (an integer):");
        int shiftValue;
        while (!int.TryParse(Console.ReadLine(), out shiftValue))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the shift value:");
        }

        string encryptedMessage = Encrypt(messageToEncrypt, shiftValue);
        Console.WriteLine("Encrypted Message: " + encryptedMessage);

        string decryptedMessage = Decrypt(encryptedMessage, shiftValue);
        Console.WriteLine("Decrypted Message: " + decryptedMessage);
    }
}