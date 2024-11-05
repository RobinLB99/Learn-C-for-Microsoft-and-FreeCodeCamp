// Ejercicio: Creación de comentarios de código efectivos

string firstName = "John";
int widgetsPurchased = 7;
/*
Testing a charge to the message
int widgetsSold = 7;
*/
//Console.WriteLine($"{firstName} sold {widgetSold} widgets");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets");

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}

foreach (var orderId in orderIDs)
{
    Console.WriteLine(orderId);
}