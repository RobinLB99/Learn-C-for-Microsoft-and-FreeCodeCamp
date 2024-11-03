// See https://aka.ms/new-console-template for more information

string[] nombres = {"Maria", "Joel", "Elizabeth", "Eugenia"};
foreach (var nombre in nombres)
{
    Console.WriteLine(nombre);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (var item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

Console.WriteLine($"La suma total de 'inventory' es {sum}");