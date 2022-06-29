using System;

namespace clase14_ejercicio01
{
    public class Carta
    {
        public string Palo
        {
            get;
            private set
            {
                Palo = value;
                PaloInt = NumeroDePalo(Palo);
            }
        }
        private int PaloInt;
        public int Numero {get;}

        Carta(string palo, int numero)
        {
            if(EsPaloCorrecto(palo))
            {
                Palo = palo;
            }
            else
            {
                Console.Writeline("Palo de carta incorrecto, se elige un palo correcto al azar");
                Palo = PaloAlAzar();
            }

            if(EsNumeroCorrecto(numero))
            {
                Numero = numero;
            }
            else
            {
                Console.Writeline("Numero de carta incorrecto, se elige numero correcto al azar");
                Numero = NumeroAlAzar;
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
            if(nombreDePalo != "espadas" && nombreDePalo != "bastos" && nombreDePalo != "oros" && nombreDePalo != "copas")
                return false;
            else
                return true;
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
            var random = new Random();
            var paloIntAlAzar = random.Next(4);
            return NombreDePalo(paloIntAlAzar);
        }
        
        static public int NumeroAlAzar()
        {
            var random = new Random();
            do
                var numeroAlAzar = random.Next(13);
            while(EsNumeroCorrecto(numeroAlAzar));
            return numeroAlAzar;
        }


    }
}
