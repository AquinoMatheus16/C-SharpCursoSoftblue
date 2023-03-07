using System;

namespace PartialClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            QuartoHotel q = new QuartoHotel();
            q.Numero = 321;
            q.Andar = 7;
            q.Fumante = false;
            q.Reservar();
            q.CancelarReserva();
        }
    }
}