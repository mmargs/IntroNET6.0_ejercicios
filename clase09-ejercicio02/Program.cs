/*
Ejercicio 02 - Clase 09
Curso Intro NET 6.0 - 2022
Polo Tecnologico Mina Clavero - Incluit
*/

/*
Requerimientos del ejericicio:

Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla
*/

//Matriz de 3 filas por 9 colunas donde se almacena el carton generado
int[,] carton = new int[9,3];

//Generador de numeros aleatorios
Random aleatorio = new Random();

//Contador de numeros por columna
//para evaluar si por columna hay una cantidad correcta de numeros
int numerosPorColumna;

//Vector de contadores de numeros por fila
// para evaluar si por fila hay una cantidad correcta de numeros
int[] numerosPorFila = new int[3];

do
{
    //Borrar pantalla
    Console.Clear();
    Console.WriteLine();

    //Variable booleana que determina si el carton es incorrecto
    bool cartonIncorrecto;

    //Se intenta generar un carton correcto
    do
    {
        //Se asume que el carton generado será correcto
        cartonIncorrecto = false;

        //Se inicializan en 0 los contadores de numeros por fila
        numerosPorFila[0] = 0;
        numerosPorFila[1] = 0;
        numerosPorFila[2] = 0;

        //Bucle para avanzar por columas del carton
        for (int columna = 0; columna < 9; columna++)
        {
            //Variable booleana que determina si la columna es incorrecta
            bool columnaIncorrecta;

            //Se intenta generar una columna correcta
            do
            {
                //Se asume que la columna generada será correcta
                columnaIncorrecta = false;

                //Se inicializa en 0 el contador de numeros por columna
                numerosPorColumna = 0;

                //Bucle para avanzar por filas del carton
                for (int fila = 0; fila < 3; fila++)
                {
                    //Se genera un numero aleatorio de 0 a 26, si es menor a 15 la celda se completa con un numero
                    //De lo contrario se completa con un 0. El valor 0 indica celda en blanco.
                    if(aleatorio.Next(27)<15)
                    {
                        //Si es la primera columna, se completa la celda con un numero aleatorio del 1 al 9
                        if(columna == 0)
                            carton[columna,fila] = aleatorio.Next(1,10);
                        //Si es la última columna, se completa la celda con un numero aleatorio del 80 al 90
                        else if(columna == 8)
                            carton[columna,fila] = aleatorio.Next(80,91);
                        //De lo contrario, se completa la celda con un numero aleatorio entre columna*10 y columna*10+9, ej. columna=4 -> 40 a 49
                        else
                            carton[columna,fila] = aleatorio.Next(columna*10,columna*10+10);

                        //Si la celda se completó con un numero, incrementa el contador de numeros por columnas
                        numerosPorColumna++;
                    }
                    else
                        carton[columna,fila] = 0;
                }

                //Si la cantidad de numeros por columna es menor a 1 o mayor a 2, la columna es incorrecta
                if(numerosPorColumna < 1 || numerosPorColumna > 2)
                    columnaIncorrecta = true;

                //Si la primera y segunda celda de la columna no son celdas en blanco y
                //la primera celda es mayor o igual a la segunda celda, la columna es incorrecta
                if(carton[columna,0] != 0 && carton[columna,1] != 0 && carton[columna,0] >= carton[columna,1])
                    columnaIncorrecta = true;

                //Si la segunda y tercera celda de la columna no son celdas en blanco y
                //la segunda celda es mayor o igual a la tercera celda, la columna es incorrecta
                if(carton[columna,1] != 0 && carton[columna,2] != 0 && carton[columna,1] >= carton[columna,2])
                    columnaIncorrecta = true;

                //Si la primera y tercera celda de la columna no son celdas en blanco y
                //la primera celda es mayor o igual a la tercera celda, la columna es incorrecta
                if(carton[columna,0] != 0 && carton[columna,2] != 0 && carton[columna,0] >= carton[columna,2])
                    columnaIncorrecta = true;

            //Si la columna es incorrecta, se vuelve a intentar generar una correcta
            } while(columnaIncorrecta);

            //Bucle para avanzar por celdas de la columna generada correctamente
            for (int i = 0; i < 3; i++)
            {
                //Si la celda de la fila i no es una celda en blanco, entonces contine un numero
                if(carton[columna,i] != 0)
                    //Se incrementa el contador de numeros por fila de la fila i
                    numerosPorFila[i]++;

                //Si contador de numeros por fila de la fila i es mayor a 5, entonces el carton es incorrecto
                if(numerosPorFila[i] > 5)
                    cartonIncorrecto = true;
            }

            //Si ya se determinó que el carton es incorrecto, entonces no se continua intentando generar columnas
            if(cartonIncorrecto)
                //Se interrumpe el bucle que avanza por columnas
                break;

        }

        //Bucle para avanzar por contadores de numeros por fila
        foreach(int cantidadDeNumerosPorFila in numerosPorFila)
        {
            //Si cantidad de numeros por fila alguna de las filas es menor a 5, el carton es incorrecto
            if(cantidadDeNumerosPorFila < 5)
                cartonIncorrecto = true;
        }

    //Si el carton es incorrecto, se vuelve a intentar generar uno correcto
    } while (cartonIncorrecto);


    // Si el carton generado es correcto, mostrar en pantalla.
    Console.WriteLine("----------------------------");
    for (int fila = 0; fila < 3; fila++)
    {
        Console.Write("|");
        for (int columna = 0; columna < 9; columna++)
        {
            if(carton[columna, fila] != 0)
            {
                if(columna == 0)
                    Console.Write(" ");
                Console.Write(carton[columna, fila]);
            }
            else
            {
                Console.Write("  ");
            }
            Console.Write("|");
        }
        Console.WriteLine();
    }
    Console.WriteLine("----------------------------");
    Console.WriteLine();

    // Preguntar al usuario si quiere generar otro carton
    Console.Write("Generar otro carton? (S)/N: ");
} while(Console.ReadLine().ToLower() != "n");


