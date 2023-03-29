using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConcreteCreator
{
    public class TitaniumFactory : CartaoFactory
    {
        private decimal _limiteCredito;
        private decimal _cobrancaAnual;

        public TitaniumFactory(decimal limiteCredito, decimal cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }



        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoTitanium(_limiteCredito, _cobrancaAnual);
        }
    }
}
