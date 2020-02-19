using System;
using System.Collections.Generic;
using BuilderComputer.Models;

namespace BuilderComputer.Builder
{
    public class BuilderSuperComputer : ComputerBuilder
    {
        public BuilderSuperComputer()
        {
            _computer = new Computer();
            _computer.Nombre = "SuperComputer";
            _computer.Extras = new List<Extras>();
        }

        public override void AddRam()
        {
            _computer.Ram = Ram.four;
        }

        public override void AddStorage()
        {
            _computer.Storage = Storage.four;

        }

        public override void AddProcesador()
        {
            _computer.Procesador = Procesador.four;
        }

        public override void AddVideo()
        {
            _computer.Video = Video.four;
        }

        public override void AddMonitor()
        {
            _computer.Monitor = Monitor.four;
        }

        public override void AddExtras()
        {
            _computer.Extras.Add(Extras.Mouse);
            _computer.Extras.Add(Extras.Teclado);

        }


    }
}
