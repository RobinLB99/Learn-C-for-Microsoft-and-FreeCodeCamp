// Desafío de código: Notificar los identificadores de pedido que necesitan
// una investigación más detallada

string[] orderIDs = { "B123", "C234", "A345", "B177", "G3003", "C235", "B179" };
foreach (var orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}