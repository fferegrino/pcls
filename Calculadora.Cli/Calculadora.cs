using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclCalculadora.Cli
{
    public class Calculadora
    {
        private int _primerNumero;
        private int _segundoNumero;

        public void SetPrimerNumero(int numero)
        {
            _primerNumero = numero;
        }

        public void SetSegundoNumero(int numero)
        {
            _segundoNumero = numero;
        }

        public int Calcula()
        {
            return _primerNumero + _segundoNumero;
        }
    }
}
