/*
Ejercicio 01 - Clase 09
Curso Intro NET 6.0 - 2022
Polo Tecnologico Mina Clavero - Incluit
*/

// Comunicar al usuario el objectivo del programa
Console.WriteLine("Crear vector con datos aleatorios e invertir.");

// 1) Pedir al usuario la longitud de un vector
Console.Write("Ingrese longitud de vector: ");
var longitud = int.Parse(Console.ReadLine());

// 2) Crear el vector del tamaño ingresado.
int[] vector = new int[longitud];

Random aleatorio = new Random();

Console.WriteLine("Vector: ");
for (int i = 0; i < vector.Length; i++)
{
    // 3) Llenar el mismo con datos aleatorios
    vector[i] = aleatorio.Next(100);
    // 4) Mostrar el vector por pantalla
    Console.Write(vector[i]+" ");
}

// 5) Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero.
for (int i = 0; i < vector.Length/2; i++)
{
    var tmp = vector[i];
    vector[i] = vector[vector.GetUpperBound(0)-i];
    vector[vector.GetUpperBound(0)-i] = tmp;
}

// 6) Mostrar el vector nuevamente.
Console.WriteLine();
Console.WriteLine("Vector invertido: ");
foreach(int i in vector)
{
    Console.Write(i+" ");
}

Console.ReadKey();