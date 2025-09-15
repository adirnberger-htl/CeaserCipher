namespace ceasercypher;

public class Decipher
{
    public static string? MessageUnlocked { get; set; }

    private string? _messageUnlocked = MessageUnlocked;

    public string ShiftBy(int shift, string message)
    {
        var shiftedChars = new char[message!.Length];
        for (var i = 0; i < message.Length; i++)
        {
            if(message[i] == ' ') continue;
            
            var adjustedShift = shift;
            if ((char)(message[i] + shift) > 'Z') { adjustedShift = shift - 26; }

            shiftedChars[i] = (char)(message[i] + adjustedShift);
        }

        _messageUnlocked = new string(shiftedChars);
        return _messageUnlocked;
    }
}