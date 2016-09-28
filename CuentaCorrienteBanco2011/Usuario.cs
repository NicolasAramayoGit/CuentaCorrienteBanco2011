using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaCorrienteBanco2011
{
    class Usuario
    {

        private string _apellido;
        private double _dni;
        private string _nombre;


        // Tengo que hacer visible la propiedad DNI, para usarlo en 
        // la sobrecarga del operador == de la clase 'CuentaCorriente'.
        public double DNI
        {
            get
            {
                return this._dni;
            }
        }


        public Usuario(string apellido, string nombre, double dni)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._dni = dni;
        }

        private string DevolverDatosFormatosString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Apellido: " + this._apellido);
            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Dni.: " + this._dni.ToString());

            return sb.ToString();
        }


        public static string Mostrar(Usuario unUsuario)
        {
            return unUsuario.DevolverDatosFormatosString();
        }




    }
}
