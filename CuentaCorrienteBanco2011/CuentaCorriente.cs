using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaCorrienteBanco2011
{
    class CuentaCorriente
    {

        private Usuario _dueño;
        private int _numeroCuenta;
        private double _saldo;


        public Usuario Dueño
        {
            get
            {
                return this._dueño;
            }
        }


        public double Saldo
        {
            get
            {
                return this._saldo;
            }

            set
            {
                this._saldo += value;
            }
        }


        public CuentaCorriente(string apellido, string nombre, double dni, int numero, double saldo)
        {
            this._saldo = saldo;
            this._numeroCuenta = numero;
            this._dueño = new Usuario(apellido, nombre, dni);
        }

        public CuentaCorriente(Usuario miDueño, int numero, double saldo)
        {
            this._dueño = miDueño;
            this._numeroCuenta = numero;
            this._saldo = saldo;
        }


        public static bool operator ==(CuentaCorriente cuentaUno, CuentaCorriente cuentaDos)
        {
            return cuentaUno.Dueño.DNI.CompareTo(cuentaDos.Dueño.DNI) == 0;
        }

        public static bool operator !=(CuentaCorriente cuentaUno, CuentaCorriente cuentaDos)
        {
            return !(cuentaUno == cuentaDos);
        }


        public static explicit operator double(CuentaCorriente unaCuenta)
        {
            return unaCuenta._saldo;
        }

        public static implicit operator CuentaCorriente(Usuario unUsuario)
        {
            return new CuentaCorriente(unUsuario, 0, 0);
        }
    }
}
