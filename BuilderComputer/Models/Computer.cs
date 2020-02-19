using System;
using System.Collections.Generic;

namespace BuilderComputer.Models
{
    public class Computer
    {
        public Ram Ram { set; get; }
        public Storage Storage { set; get; }
        public Procesador Procesador { set; get; }
        public Video Video { set; get; }
        public Monitor Monitor { set; get; }
        public List<Extras> Extras { set; get; }
        public string Nombre { set; get; }
        private float Cost { set; get; }

        public Computer()
        {
            this.Extras = new List<Extras>();
        }

        public Computer(string nombre, Ram ram, Storage storage, Procesador procesador, Video video, Monitor monitor, List<Extras> extras)
        {
            this.Nombre = nombre;
            this.Ram = ram;
            this.Storage = storage;
            this.Procesador = procesador;
            this.Video = video;
            this.Monitor = monitor;
            this.Extras = extras;

        }

        public float getCost()
        {

            switch((int)this.Ram)
            {
                case 8:
                    this.Cost += (float)CostoRam.one;
                    break;

                case 16:
                    this.Cost += (float)CostoRam.two;
                    break;

                case 32:
                    this.Cost += (float)CostoRam.three;
                    break;

                case 64:
                    this.Cost += (float)CostoRam.four;
                    break;
            }

            switch ((int)this.Storage)
            {
                case 256:
                    this.Cost += (float)CostoStorage.one;
                    break;

                case 512:
                    this.Cost += (float)CostoStorage.two;
                    break;

                case 1024:
                    this.Cost += (float)CostoStorage.three;
                    break;

                case 2048:
                    this.Cost += (float)CostoStorage.four;
                    break;
            }

            switch ((int)this.Procesador)
            {
                case 20:
                    this.Cost += (float)CostoProcesador.one;
                    break;

                case 25:
                    this.Cost += (float)CostoProcesador.two;
                    break;

                case 28:
                    this.Cost += (float)CostoProcesador.three;
                    break;

                case 29:
                    this.Cost += (float)CostoProcesador.four;
                    break;
            }

            switch ((int)this.Video)
            {
                case 64:
                    this.Cost += (float)CostoVideo.one;
                    break;

                case 128:
                    this.Cost += (float)CostoVideo.two;
                    break;

                case 256:
                    this.Cost += (float)CostoVideo.three;
                    break;

                case 512:
                    this.Cost += (float)CostoVideo.four;
                    break;
            }

            switch ((int)this.Monitor)
            {
                case 24:
                    this.Cost += (float)CostoMonitor.one;
                    break;

                case 25:
                    this.Cost += (float)CostoMonitor.two;
                    break;

                case 27:
                    this.Cost += (float)CostoMonitor.three;
                    break;

                case 32:
                    this.Cost += (float)CostoMonitor.four;
                    break;
            }

            foreach (Extras extra in this.Extras)
            {

                if ((int)extra == 0) this.Cost += (float)CostoExtras.Teclado;
                else if ((int)extra == 1) this.Cost += (float)CostoExtras.Mouse;

            }

            return this.Cost;
        }

        public override string ToString()
        {
            var cost = this.getCost();
            return $"Nombre {this.Nombre}, Ram: {(int)this.Ram} GB, Storage: {(int)this.Storage} GB, Procesador: {(float)((int)this.Procesador/10)} GHz, Video: {(int)this.Video} GB, Monitor: {(int)this.Monitor} in, Extras: {string.Join(separator: ',', this.Extras)}, Costo: $ { this.Cost }";
        }
    }
}
