using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}
