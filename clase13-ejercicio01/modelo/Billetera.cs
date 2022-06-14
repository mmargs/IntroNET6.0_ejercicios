using System;

/*Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
*/

namespace clase13_ejercicio01.modelo
{
    internal class Billetera
    {
        public int BilletesDe10 {get; set;}
        public int BilletesDe20 {get; set;}
        public int BilletesDe50 {get; set;} 
        public int BilletesDe100 {get; set;}
        public int BilletesDe200 {get; set;}
        public int BilletesDe500 {get; set;}
        public int BilletesDe1000 {get; set;}

        public decimal Total()
        {
            decimal total = BilletesDe10*10M;
            total += BilletesDe20*20M;
            total += BilletesDe50*50M;
            total += BilletesDe100*100M;
            total += BilletesDe200*200M;
            total += BilletesDe500*500M;
            total += BilletesDe1000*1000M;
            return total;
        }

        public Billetera Combinar(Billetera billeteraACombinar)
        {
            Billetera billeteraCombinada = new Billetera();
            billeteraCombinada.BilletesDe10 = billeteraACombinar.BilletesDe10 + BilletesDe10;
            billeteraACombinar.BilletesDe10 = 0;
            BilletesDe10 = 0;
            billeteraCombinada.BilletesDe20 = billeteraACombinar.BilletesDe20 + BilletesDe20;
            billeteraACombinar.BilletesDe20 = 0;
            BilletesDe20 = 0;
            billeteraCombinada.BilletesDe50 = billeteraACombinar.BilletesDe50 + BilletesDe50;
            billeteraACombinar.BilletesDe50 = 0;
            BilletesDe50 = 0;
            billeteraCombinada.BilletesDe100 = billeteraACombinar.BilletesDe100 + BilletesDe100;
            billeteraACombinar.BilletesDe100 = 0;
            BilletesDe100 = 0;
            billeteraCombinada.BilletesDe200 = billeteraACombinar.BilletesDe200 + BilletesDe200;
            billeteraACombinar.BilletesDe200 = 0;
            BilletesDe200 = 0;
            billeteraCombinada.BilletesDe500 = billeteraACombinar.BilletesDe500 + BilletesDe500;
            billeteraACombinar.BilletesDe500 = 0;
            BilletesDe500 = 0;
            billeteraCombinada.BilletesDe1000 = billeteraACombinar.BilletesDe1000 + BilletesDe1000;
            billeteraACombinar.BilletesDe1000 = 0;
            BilletesDe1000 = 0;

            return billeteraCombinada;

        }

    }
}
