using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaCorrienteBanco2011
{
    class Banco
    {
        private DateTime _fechaInicio;
        private List<CuentaCorriente> _listaCuentasCorrientes;
        private string _razonSocial;

        public Banco(string razonSocial, DateTime fechaInicio)
        {
            this._razonSocial = razonSocial;
            this._fechaInicio = fechaInicio;
            this._listaCuentasCorrientes = new List<CuentaCorriente>();
        }

        public void MostrarBanco()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razon Social: " + this._razonSocial);
            sb.AppendLine("Fecha Inicio Actividades: " + this._fechaInicio);
            
            foreach (var item in _listaCuentasCorrientes)
            {
                sb.AppendLine("" + Usuario.Mostrar(item.Dueño));
                sb.AppendLine("Saldo: " + item.Saldo.ToString());
                
            }

            Console.WriteLine("" + sb.ToString());
        }



        public static Banco operator +(Banco unBanco, CuentaCorriente unaCuenta)
        {
            bool encontro = false;

            if (unBanco._listaCuentasCorrientes.Count == 0)
            {
                unBanco._listaCuentasCorrientes.Add(unaCuenta);
                Console.WriteLine("Se ha agregado una cuenta corriente");
            }
            else
            {
                foreach (var item in unBanco._listaCuentasCorrientes)
                {
                    if (item == unaCuenta)
                    {
                        encontro = true;
                        break;          //Hago un break, para que no siga buscando.
                    }
                }

                // En caso de que encontro que el usuario ya tenga una cuentacorriente.
                if (encontro)
                {
                    Console.WriteLine("Ya existe una  cuenta corriente para el usuario");
                }
                else
                {
                    unBanco._listaCuentasCorrientes.Add(unaCuenta); // Agrego la cuenta, si no se encuentra en la lista.
                    Console.WriteLine("Se ha agregado una cuenta corriente");
                }
            }
            

            return unBanco;
        }


        public static Banco operator -(Banco unBanco, CuentaCorriente unaCuenta)
        {
            foreach (var item in unBanco._listaCuentasCorrientes)
            {
                if (item == unaCuenta)
                {
                    unBanco._listaCuentasCorrientes.Remove(item);
                    Console.WriteLine("Elimino una cuenta del banco");
                    break;
                }
            }

            return unBanco;
        }




    }
}
