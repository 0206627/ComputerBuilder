using System;
using System.Collections.Generic;
using BuilderComputer.Models;

namespace BuilderComputer.Builder
{
    public class ComputerFluentBuilder
    {
        private Computer _computer;

        private ComputerFluentBuilder()
        {
            _computer = new Computer();
            _computer.Extras = new List<Extras>();
            _computer.Nombre = "Custom";
        }

        public static ComputerFluentBuilder Crear()
        {
            return new ComputerFluentBuilder();
        }

        public ComputerFluentBuilder RamOne()
        {
            _computer.Ram = Ram.one;
            return this;
        }

        public ComputerFluentBuilder RamTwo()
        {
            _computer.Ram = Ram.two;
            return this;
        }

        public ComputerFluentBuilder RamThree()
        {
            _computer.Ram = Ram.three;
            return this;
        }

        public ComputerFluentBuilder RamFour()
        {
            _computer.Ram = Ram.four;
            return this;
        }

        public ComputerFluentBuilder StorageOne()
        {
            _computer.Storage = Storage.one;
            return this;
        }

        public ComputerFluentBuilder StorageTwo()
        {
            _computer.Storage = Storage.two;
            return this;
        }

        public ComputerFluentBuilder StorageThree()
        {
            _computer.Storage = Storage.three;
            return this;
        }

        public ComputerFluentBuilder StorageFour()
        {
            _computer.Storage = Storage.four;
            return this;
        }

        public ComputerFluentBuilder ProcesadorOne()
        {
            _computer.Procesador = Procesador.one;
            return this;
        }

        public ComputerFluentBuilder ProcesadorTwo()
        {
            _computer.Procesador = Procesador.two;
            return this;
        }

        public ComputerFluentBuilder ProcesadorThree()
        {
            _computer.Procesador = Procesador.three;
            return this;
        }

        public ComputerFluentBuilder ProcesadorFour()
        {
            _computer.Procesador = Procesador.four;
            return this;
        }

        public ComputerFluentBuilder VideoOne()
        {
            _computer.Video = Video.one;
            return this;
        }

        public ComputerFluentBuilder VideoTwo()
        {
            _computer.Video = Video.two;
            return this;
        }

        public ComputerFluentBuilder VideoThree()
        {
            _computer.Video = Video.three;
            return this;
        }

        public ComputerFluentBuilder VideoFour()
        {
            _computer.Video = Video.four;
            return this;
        }

        public ComputerFluentBuilder MonitorOne()
        {
            _computer.Monitor = Monitor.one;
            return this;
        }

        public ComputerFluentBuilder MonitorTwo()
        {
            _computer.Monitor = Monitor.two;
            return this;
        }

        public ComputerFluentBuilder MonitorThree()
        {
            _computer.Monitor = Monitor.three;
            return this;
        }

        public ComputerFluentBuilder MonitorFour()
        {
            _computer.Monitor = Monitor.four;
            return this;
        }

        public ComputerFluentBuilder AddExtras(Extras extra)
        {
            _computer.Extras.Add(extra);
            return this;
        }

        public Computer Armar()
        {
            return this._computer;
        }

    }
}
