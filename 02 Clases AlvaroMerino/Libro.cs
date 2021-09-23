using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Clases_AlvaroMerino
{
    public class Libro
    {
        public Libro(String titulo, String autor, String Estilo, String editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Estilo = estilo;
        }
        public Libro()
        {

        }
        private String titulo;

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private String autor;

        public String Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private String estilo;

        public String Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }
        private String editorial;

        public String Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        public override string ToString()
        {
            return string.Format("Titulo: " + this.titulo +  "\t Autor: " + this.autor +"\t Estilo: " + this.estilo + "\t Editorial: " + this.editorial);
        }
    }
}
      


