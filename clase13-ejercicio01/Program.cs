using clase13_ejercicio01.modelo;

Billetera billetera1 = new Billetera() {
    BilletesDe10 = 1,
    BilletesDe20 = 2,
    BilletesDe50 = 3,
    BilletesDe100 = 4,
    BilletesDe200 = 5,
    BilletesDe500 = 6,
    BilletesDe1000 = 7
};

Billetera billetera2 = new Billetera() {
    BilletesDe10 = 7,
    BilletesDe20 = 6,
    BilletesDe50 = 5,
    BilletesDe100 = 4,
    BilletesDe200 = 3,
    BilletesDe500 = 2,
    BilletesDe1000 = 1
};

Billetera billetera3 = new Billetera();
billetera3 = billetera1.Combinar(billetera2);

Console.ReadKey();