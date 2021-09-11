using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrenteAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, [AllowNull] ContaCorrente y)
        {
            if (x == y)
            {
                return 0;
            }
            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
