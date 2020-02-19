using System;
using BuilderComputer.Builder;
using BuilderComputer.Director;
using BuilderComputer.Models;

namespace BuilderComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store(new BuilderSuperComputer());
            Console.WriteLine(store.ObtenerComputer().ToString());

            store = new Store(new BuilderBasicComputer());
            Console.WriteLine(store.ObtenerComputer().ToString());

            var computer = ComputerFluentBuilder.Crear().RamTwo().StorageFour().ProcesadorThree().VideoOne().MonitorFour().AddExtras(Extras.Teclado).Armar();
            Console.WriteLine(computer.ToString());

            Console.ReadKey();
        }
    }
}
