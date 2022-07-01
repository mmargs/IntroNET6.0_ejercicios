using System;

namespace clase14_ejercicio01.Modelos
{
    public class Baraja
    {
        private Stack<Carta>? CartasOcultas;
        private Stack<Carta>? CartasVistas;

        public Baraja()
        {
            CartasVistas = new Stack<Carta>();
            CartasOcultas = new Stack<Carta>();

            for (int i = 0; i < 40; i++)
            {
                CartasOcultas.Push(new Carta(i));
            }
        }
    }
}
