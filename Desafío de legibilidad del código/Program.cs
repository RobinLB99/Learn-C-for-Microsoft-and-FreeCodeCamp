// Ejercicio: Completar una actividad de desafío para mejorar la legibilidad del código

/*
   This code reverses a message, counts the number of times
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int count = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        count++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");