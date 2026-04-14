using System;
using System.Collections.Generic;

Cuadrado miCuadrado = new Cuadrado("Cuadradito", "Rojo", 5);
Circulo miCirculo = new Circulo("Circulito", "Azul", 3);
Triangulo miTriangulo = new Triangulo("Triangulo", "Verde", 4, 6, 4,5, 4);

List<Figura> misFiguras = new List<Figura>();
misFiguras.Add(miCuadrado);
misFiguras.Add(miCirculo);
misFiguras.Add(miTriangulo);

Console.WriteLine("--- ANALIZANDO FIGURAS ---");

foreach (Figura figuraActual in misFiguras)
{
    Console.WriteLine($"Nombre: {figuraActual.Nombre}");
    Console.WriteLine($"Color: {figuraActual.Color}");
    Console.WriteLine($"Área: {figuraActual.CalcularArea()}");
    Console.WriteLine($"Perímetro: {figuraActual.CalcularPerimetro()}");
    Console.WriteLine("------------------------");
}
