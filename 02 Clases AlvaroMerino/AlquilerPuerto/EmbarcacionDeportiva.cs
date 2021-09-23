using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Clases_AlvaroMerino.AlquilerPuerto
{
    class EmbarcacionDeportiva: Barco
    {
        private int potencia;

        public int Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }

        public EmbarcacionDeportiva(int potencia, string matricula, int fabricacion, int eslora) : base(matricula, eslora, fabricacion)
        {
            this.Matricula = matricula;
            this.Fabricacion = fabricacion;
            this.Eslora = eslora;
            this.potencia = potencia;
        }

        public override int alquiler()
        {
            return this.Eslora * 10 * 12 + potencia;
        }
    }
}
