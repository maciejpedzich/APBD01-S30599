﻿// See https://aka.ms/new-console-template for more information
// Modyfikacja 1
// Modyfikacja 2
// Modyfikacja 3

static double Srednia(int[] liczby)
{
    return liczby.Average();
}

static int ObliczMaks(int[] liczby)
{
    return liczby.Max();
}

int[] liczby = new[] { 7, 3, 1, 2 };

Console.WriteLine(Srednia(liczby));
Console.WriteLine(ObliczMaks(liczby));
