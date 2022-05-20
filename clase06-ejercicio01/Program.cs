/*
Ejercicio - Clase 06
Curso Intro NET 6.0 - 2022
Polo Tecnologico Mina Clavero - Incluit
*/

//Declarar e inicializar en 0 la variable [intentos], el acumulador de intentos
int intentos = 0;

//Declarar la variable [numeroIngresado]
//Variable donde se almacena el último numero ingresado por el usuario
int numeroIngresado;

// 1) Generar un número secreto aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

// Comunicar al usuario el objetivo del programa.
Console.WriteLine("Adivinar el número entero entre 1 y 20 que eligió la computadora.");

do
{
    // 2) Pedir al usuario que ingrese un número y que
    // intente adivinar el número que eligió la computadora.
    Console.Write("Adivine un número: ");
    numeroIngresado = int.Parse(Console.ReadLine());
    //Incrementar por 1 los intentos
    intentos++;

    if(numeroIngresado > numeroSecreto)
    {
        // 3) Si el numero ingresado por el usuario es mayor
        // al número secreto, avisarle que es muy grande y que intente de nuevo y que
        // vuelva al paso 2.
        Console.WriteLine("El número ingresaso es muy grande, intente de nuevo.");
    }
    else if (numeroIngresado < numeroSecreto)
    {
        // 4) Si el numero ingresado es menor al número
        // secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.
        Console.WriteLine("El número ingresaso es muy chico, intente de nuevo.");
    }

} while(numeroIngresado != numeroSecreto);

// 5) Si el número ingresado coincide con el número
// secreto, sacar el siguiente mensaje:
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
Console.WriteLine($"Lo has logrado en {intentos} intentos!!");

// Y finalizar el programa.
Console.ReadKey();