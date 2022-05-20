/*
Ejercicio - Clase 05
Curso Intro NET 6.0 - 2022
Polo Tecnologico Mina Clavero - Incluit
*/

//Declaramos variable de evaluacion [continuar] e igualamos a "S"
var continuar = "S";

//Evualamos si la variable [continuar] no es null y es igual a "S"
while(continuar != null && continuar.ToUpper() == "S")
{
    // 1) Borrar la pantalla
    Console.Clear();

    // 2) Pedir el nombre de una persona
    Console.Write("Ingrese su nombre: ");
    var nombre = Console.ReadLine();

    // 3) Saludarlo con un texto que diga:
    Console.WriteLine($"¡Hola {nombre}!");

    // 4) Preguntar si se quiere continuar.
    Console.Write("Si desea continuar ingrese 'S', de lo contrario ingrese 'N': ");
    continuar = Console.ReadLine();

    // 5) Si la respuesta es "S" repetir desde el punto 1.
}


if(continuar != null && continuar.ToUpper() == "N")
{
    // 6) Si la respuesta fue "N" finalizar el programa mostrando un mensaje que diga:
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    // 7) Si la respuesta no fue ni "S" ni "N" que tambien finalice el programa,
    //    pero mostrando un mensaje que diga:
    Console.WriteLine("Opcion no valida");
}

//Esperar a que el usario presione una tecla para finalizar
Console.ReadKey();