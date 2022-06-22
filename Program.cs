namespace morse 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            bool working = true;
            while (working)
            {
                Console.WriteLine("1. зашифровать сообщение 2. расшифровать сообщение 3. выход");
                var input = Console.ReadLine()!;
                switch (input)
                {
                    case "1":
                        Console.WriteLine();
                        Encode();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine();
                        Decode();
                        Console.WriteLine();
                        break;
                    case "3":
                        working = false;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }

        public static void Encode()
        {
            Console.Write("Сообщение для шифровки: ");
            var message = Console.ReadLine()!.ToLower();
            var encodedMessage = "";
            foreach(var c in message)
            {
                var morseChar = alphabet[c.ToString()];
                encodedMessage += morseChar + " ";
            }
            Console.WriteLine("Зашифрованное сообщение: " + encodedMessage);
        }

        public static void Decode()
        {
            Console.Write("Сообщение для дешифровки: ");
            var message = Console.ReadLine()!.ToLower().Split(' ');
            var decodedMessage = "";
            foreach (var c in message)
            {
                var latinChar = alphabet.Where(x => x.Value == c.ToString()).FirstOrDefault().Key;
                decodedMessage += latinChar;
            }
            Console.WriteLine("Дешифрованное сообщение: " + decodedMessage);
        }

        static Dictionary<string, string> alphabet = new Dictionary<string, string>()
        {
            { "a", ".-" },
            { "b", "-..." },
            { "c", "-.-." },
            { "d", "-.." },
            { "e", "." },
            { "f", "..-." },
            { "g", "--." },
            { "h", "...." },
            { "i", ".." },
            { "j", ".---" },
            { "k", "-.-" },
            { "l", ".-.." },
            { "m", "--" },
            { "n", "-." },
            { "o", "---" },
            { "p", ".--." },
            { "q", "--.-" },
            { "r", ".-." },
            { "s", "..." },
            { "t", "-" },
            { "u", "..-" },
            { "v", "...-" },
            { "w", ".--" },
            { "x", "-..-" },
            { "y", "-.--" },
            { "z", "--.." },
        };
    }
}



