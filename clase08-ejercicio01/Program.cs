﻿/*
Ejercicio - Clase 08
Curso Intro NET 6.0 - 2022
Polo Tecnologico Mina Clavero - Incluit
*/

// Comunicar al usuario el objetivo del programa
Console.WriteLine("Ingresar una matriz de números enteros y calcular el promedio de cada columna");

// Pedir al usuario que ingrese la cantidad de filas y columnas de la matriz
Console.Write("Ingrese cantidad de filas: ");
int cantidadDeFilasIngresadas = int.Parse(Console.ReadLine());
Console.Write("Ingrese cantidad de columnas: ");
int cantidadDeColumnasIngresadas = int.Parse(Console.ReadLine());

// 1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
int[,] numeros = new int[cantidadDeFilasIngresadas, cantidadDeColumnasIngresadas];

// 2) Determinar el tamaño de cada dimension (fila, columnas) mediante valores ingresados por pantalla
int cantidadDeFilas = numeros.GetUpperBound(0) + 1;
int cantidadDeColumnas = numeros.GetUpperBound(1) + 1;

// 3) Declarar un vector de tipo double llamado promedios
double[] promedios = new double[cantidadDeColumnas];

// 4) Recorrer la matriz para su carga con elementos de tipo int
for (int columna = 0; columna < cantidadDeColumnas; columna++)
{
    for (int fila = 0; fila < cantidadDeFilas; fila++)
    {
        Console.Write($"Ingrese valor de la columna {columna+1}, fila {fila+1}: ");
        numeros[fila,columna] = int.Parse(Console.ReadLine());
    }
}

// 5) Recorrer la matriz para mostrar cada valor de la matriz
for (int columna = 0; columna < cantidadDeColumnas; columna++)
{
    for (int fila = 0; fila < cantidadDeFilas; fila++)
    {
        Console.WriteLine($"El valor de la columna {columna+1}, fila {fila+1} es: {numeros[fila,columna]}");
        // 6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
        promedios[columna] += numeros[fila,columna] / Convert.ToDouble(cantidadDeFilas);
    }
}

// 7) Mostrar los promedios recorriendo el vector promedios
for (int columna = 0; columna < cantidadDeColumnas; columna++)
{
    Console.WriteLine($"El promedio de la columna {columna+1} es: {promedios[columna]}");
}

Console.ReadKey();