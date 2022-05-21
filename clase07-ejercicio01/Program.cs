/*
Ejercicio - Clase 07
Curso Intro NET 6.0 - 2022
Polo Tecnologico Mina Clavero - Incluit
*/

double[] numeros = new double[10];

// Escribe un programa que:
// 1) Pida 10 números al usuario.
Console.WriteLine("Ingrese 10 números");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Ingrese el número {i+1}: ");
    numeros[i] = double.Parse(Console.ReadLine());
}

double suma = 0, promedio = 0;
double maximo = numeros[0], minimo = numeros[0];

for (int i = 0; i < numeros.Length; i++)
{
    // 2) Obtener la suma de todos los números ingresados.
    suma += numeros[i];

    // 3) Obtener cual es el mayor de todos los números.
    if (numeros[i] > maximo)
        maximo = numeros[i];

    // 4) Obtener cual es el menor de todos los números.
    if (numeros[i]< minimo)
        minimo = numeros[i];

    // 5) Obtener el promedio de todos los números.
    promedio += numeros[i]/numeros.Length;

    // 6) Mostrar todos los números ingresados por pantalla.
    Console.WriteLine($"El número {i+1} ingresado es: {numeros[i]}");
}

// 7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
Console.WriteLine($"La suma de los números es: {suma}");
Console.WriteLine($"El máximo de los números es: {maximo}");
Console.WriteLine($"El mínimo de los números es: {minimo}");
Console.WriteLine($"El promedio de los números es: {promedio}");

Console.ReadKey();