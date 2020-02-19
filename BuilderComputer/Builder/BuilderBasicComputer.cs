using System;
using System.Collections.Generic;
using BuilderComputer.Models;

namespace BuilderComputer.Builder
{
    public class BuilderBasicComputer : ComputerBuilder
    {
        public BuilderBasicComputer()
        {
            _computer = new Computer();
            _computer.Nombre = "BasicComputer";
            _computer.Extras = new List<Extras>();
        }

        public override void AddRam()
        {
            _computer.Ram = Ram.one;
        }

        public override void AddStorage()
        {
            _computer.Storage = Storage.one;

        }

        public override void AddProcesador()
        {
            _computer.Procesador = Procesador.one;
        }

        public override void AddVideo()
        {
            _computer.Video = Video.one;
        }

    }
}
