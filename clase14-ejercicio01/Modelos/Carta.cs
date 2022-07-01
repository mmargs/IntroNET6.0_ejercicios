using System;

namespace clase14_ejercicio01.Modelos
{
    public class Carta
    {
        public string? Palo{get; private set;}
        private int PaloInt;
        public int Numero {get; private set;}

        public Carta()
        {
            PaloInt = NumeroDePaloAlAzar();
            Palo = NombreDePalo(PaloInt);
            Numero = NumeroAlAzar();
        }

        public Carta(int numeroDePalo, int numero)
        {
            CrearCarta(numeroDePalo, numero);
        }

        public Carta(string nombreDePalo, int numero)
        {
            CrearCarta(NumeroDePalo(nombreDePalo), numero);
        }

        public Carta(int indiceDeCarta)
        {
            var numeroDePalo = NumeroDePaloDesdeIndice(indiceDeCarta);
            var numeroDeCarta = NumeroDeCartaDesdeIndice(indiceDeCarta);
            CrearCarta(numeroDePalo, numeroDeCarta);
        }

        public void CrearCarta(int palo, int numero)
        {
            if(EsPaloCorrecto(palo))
            {
                PaloInt = palo;
            }
            else
            {
                Console.WriteLine("Palo de carta incorrecto, se elige un palo correcto al azar");
                PaloInt = NumeroDePaloAlAzar();
            }
            Palo = NombreDePalo(PaloInt);

            if(EsNumeroCorrecto(numero))
            {
                Numero = numero;
            }
            else
            {
                Console.WriteLine("Numero de carta incorrecto, se elige numero correcto al azar");
                Numero = NumeroAlAzar();
            }
        }

        static public string NombreDePalo(int numeroDePalo)
        {
            if(numeroDePalo == 0)
                return "espadas";
            else if (numeroDePalo == 1)
                return "bastos";
            else if (numeroDePalo == 2)
                return "oros";
            else if (numeroDePalo == 3)
                return "copas";
            else
                return "";
        }

        static public int NumeroDePalo(string nombreDePalo)
        {
            if(nombreDePalo == "espadas")
                return 0;
            else if(nombreDePalo == "bastos")
                return 1;
            else if(nombreDePalo == "oros")
                return 2;
            else if(nombreDePalo == "copas")
                return 3;
            else
                return -1;
        }
        static public bool EsPaloCorrecto(string nombreDePalo)
        {
            return EsPaloCorrecto(NumeroDePalo(nombreDePalo));
        }
        static public bool EsPaloCorrecto(int numeroDePalo)
        {
            if(numeroDePalo > -1 && numeroDePalo < 4)
                return true;
            else
                return false;
        }
        static public bool EsNumeroCorrecto(int numeroDeCarta)
        {
            if((numeroDeCarta > 0 && numeroDeCarta < 8) || (numeroDeCarta > 9 && numeroDeCarta < 13))
                return true;
            else
                return false;
        }
        static public string PaloAlAzar()
        {
            return NombreDePalo(NumeroDePaloAlAzar());
        }
        static public int NumeroDePaloAlAzar()
        {
            var random = new Random();
            return random.Next(4);
        }
        static public int NumeroAlAzar()
        {
            var random = new Random();
            int numeroAlAzar;
            do
                numeroAlAzar = random.Next(13);
            while(!EsNumeroCorrecto(numeroAlAzar));
            return numeroAlAzar;
        }
        static public string NombreDePaloDesdeIndice(int indiceDeCarta)
        {
            return NombreDePalo(NumeroDePaloDesdeIndice(indiceDeCarta));
        }
        static public int NumeroDePaloDesdeIndice(int indiceDeCarta)
        {
            if(indiceDeCarta > -1 && indiceDeCarta < 40)
                return indiceDeCarta / 10;
            else
                return -1;
        }
        static public int NumeroDeCartaDesdeIndice(int indiceDeCarta)
        {
            int numeroDeCarta;
            if(indiceDeCarta > -1 && indiceDeCarta < 40)
                numeroDeCarta = indiceDeCarta % 10;
            else
                return -1;

            if(numeroDeCarta < 7q)
                return numeroDeCarta + 1;
            else
                return numeroDeCarta + 3;
        }
        static public int IndiceDeCartaDesdePaloYNumero(string nombreDePalo, int numeroDeCarta)
        {
            return IndiceDeCartaDesdePaloYNumero(NumeroDePalo(nombreDePalo), numeroDeCarta);
        }
        static public int IndiceDeCartaDesdePaloYNumero(int numeroDePalo, int numeroDeCarta)
        {
            int indiceDeCarta;
            if(EsPaloCorrecto(numeroDePalo))
                indiceDeCarta = numeroDePalo * 10;
            else
                return -1;

            if(EsNumeroCorrecto(numeroDeCarta))
            {
                if(numeroDeCarta < 8)
                    indiceDeCarta += numeroDeCarta - 1;
                else
                    indiceDeCarta += numeroDeCarta - 3;

                return indiceDeCarta;
            }
            else
            {
                return -1;
            }

        }

    }
}
