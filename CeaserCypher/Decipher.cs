namespace ceasercypher;

public class Decipher
{
    public static string? MessageUnlocked { get; set; }

    private string? _messageUnlocked = MessageUnlocked;

    public string ShiftBy(int shift, string message)
    {
        var shiftedChars = new char[message.Length];
        
        for (var i = 0; i < message.Length; i++)
        {
            char c = message[i];
            
            //if space -> go to next
            if(message[i] == ' ')
            {
                shiftedChars[i] = message[i];
                continue;
            }
            
            //shift curChar
            // Shift the character
            char shiftedChar = (char)(((c - 'A' + shift + 26) % 26) + 'A');

            shiftedChars[i] = shiftedChar;
        }

        _messageUnlocked = new string(shiftedChars);
        return _messageUnlocked;
    }
}