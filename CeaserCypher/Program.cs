namespace ceasercypher;

public static class Program
{
    public static void Main(string[] args)
    {
        var encryptedMsg = AskEncryptedMessage();
        
        var decipher =  new Decipher();

        while (true)
        {
            var unlockedMsg = decipher.ShiftBy(AskShift(), encryptedMsg);
            Console.WriteLine(unlockedMsg);
            
            //-- try again --
            
            Console.WriteLine("Do you want to try again? (Y/n)");
            var answer = Console.ReadKey();
            if (answer.Key is ConsoleKey.N) break;
        }
    }

    private static string AskEncryptedMessage()
    {
        while (true)
        {
            Console.Write("Enter encrypted message:");
            var res = Console.ReadLine()!;
            if (!string.IsNullOrEmpty(res) && !res.Any(c => !char.IsLetter(c) && c != ' ')) return res;
        }
    }

    private static int AskShift()
    {
        while (true)
        {
            Console.Write("Enter shift:");
            var res = Console.ReadLine()!;
            if (!string.IsNullOrEmpty(res) && res.Any(char.IsNumber)) return Convert.ToInt32(res);
        }
    }
}