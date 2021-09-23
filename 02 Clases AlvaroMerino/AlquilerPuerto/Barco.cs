using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Clases_AlvaroMerino.AlquilerPuerto
{
    abstract class Barco
    {
        private String matricula;

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private int eslora;

        public int Eslora
        {
            get { return eslora; }
            set { eslora = value; }
        }

        private int fabricacion;

        public int Fabricacion
        {
            get { return fabricacion; }
            set { fabricacion = value; }
        }
        public Barco(String matricula,int eslora, int fabricacion)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.fabricacion = fabricacion;
        }
        public abstract int alquiler();
    }
}
