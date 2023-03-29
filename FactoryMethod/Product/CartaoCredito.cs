using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get;}
        public abstract decimal LimiteCredito { get; set; }
        public abstract decimal CobrancaAnual { get; set; }

    }
}
