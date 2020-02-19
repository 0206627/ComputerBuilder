using System;
using BuilderComputer.Builder;
using BuilderComputer.Models;

namespace BuilderComputer.Director
{
    public class Store
    {
        private ComputerBuilder _computerBuilder;

        public Store(ComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public Computer ObtenerComputer()
        {
            _computerBuilder.AddRam();
            _computerBuilder.AddStorage();
            _computerBuilder.AddProcesador();
            _computerBuilder.AddVideo();
            _computerBuilder.AddMonitor();
            _computerBuilder.AddExtras();

            return _computerBuilder.ObtenerComputer;
        }
    }
}
