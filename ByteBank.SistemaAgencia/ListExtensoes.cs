using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(List<int> listaDeInteiros, params int[] itens)
        {
            foreach (var item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}
