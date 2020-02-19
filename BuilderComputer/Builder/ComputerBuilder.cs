using System;
using BuilderComputer.Models;

namespace BuilderComputer.Builder
{
    public abstract class ComputerBuilder
    {

        public Computer _computer;

        public Computer ObtenerComputer
        {
            get { return this._computer; }
        }

        public virtual void AddRam() { }

        public virtual void AddStorage() { }

        public virtual void AddProcesador() { }

        public virtual void AddVideo() { }

        public virtual void AddMonitor() { }

        public virtual void AddExtras() { }

    }
}
