using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _02_Clases_AlvaroMerino.AlquilerPuerto
{
    class Alquiler
    {
        private String nombreCliente;

        public String NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        private String dniCliente;

        public String DniCliente
        {
            get { return dniCliente; }
            set { dniCliente = value; }
        }
        private DateTime fechaInicial;

        public DateTime FechaInicial
        {
            get { return fechaInicial; }
            set { fechaInicial = value; }
        }
        private DateTime fechaFinal;

        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }
        private Barco barco;

        public Barco Barco
        {
            get { return barco; }
            set { barco = value; }
        }

        private int alquilerBarco;

        public int  AlquilerBarco
        {
            get { return alquilerBarco; }
            set { alquilerBarco = value; }
        }

        public Alquiler(String nombreCliente, String dniCliente, DateTime fechaInicial, DateTime fechaFinal, Barco barco)
        {
            this.nombreCliente = nombreCliente;
            this.dniCliente = dniCliente;
            this.fechaInicial = fechaInicial;
            this.fechaFinal = fechaFinal;
            this.barco = barco;
            this.alquilerBarco = alquiler();
        }

        public int alquiler()
        {
            return this.barco.alquiler() * ((int)(FechaFinal - fechaInicial).TotalDays);
        }

        public override string ToString()
        {
            return "Nombre del cliente: " + this.nombreCliente + "\n" +
                "Dni del cliente: " + this.dniCliente + "\n" +
                "Fecha de Inicio: " + this.fechaInicial.ToString("d",CultureInfo.CreateSpecificCulture("en-NZ")) + "\n" +
                "Fecha Final: " + this.fechaFinal.ToString("d", CultureInfo.CreateSpecificCulture("en-NZ")) + "\n" +
                "Matricula del barco alquilado: " +
                "" + this.barco.Matricula + "\n" +
                "Tipo de barco: " + this.barco.GetType().Name + " \n" +
                "Precio del alquiler: " + this.alquilerBarco + " euros" +
                "";
        }
    }
}
