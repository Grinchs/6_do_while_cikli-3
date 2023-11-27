using System;

int R;
double[] skaitluMasivs;
double reizinajums = 1;

Console.WriteLine("Ievadiet skaitli R: ");
while (!int.TryParse(Console.ReadLine(), out R) || R <= 0)
{
    Console.WriteLine("Nederīgs skaitlis");
}

skaitluMasivs = new double[R];

for (int i = 0; i < R; i++)
{
    Console.WriteLine($"Ievadiet {i + 1}. skaitli:");
    while (!double.TryParse(Console.ReadLine(), out skaitluMasivs[i]))
    {
        Console.WriteLine("Nederīgs skaitlis. Ievadiet skaitli vēlreiz:");
    }
}

for (int i = 0; i < R; i++)
{
    if (i == 0)
    {
        reizinajums = skaitluMasivs[i];
        Console.WriteLine($"Reiz[{i}] = {reizinajums}");
    }
    else
    {
        reizinajums *= skaitluMasivs[i];
        Console.WriteLine($"Reiz[{i}] = {skaitluMasivs[i - 1]}*{skaitluMasivs[i]}");
    }
}

Console.WriteLine($"Reizinājums ir: {reizinajums}");
