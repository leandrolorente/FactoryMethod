using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConcreteProduct
{
    public class CartaoTitanium : CartaoCredito
    {
        public string _tipoCartao { get; set; }
        public decimal _limiteCredito { get; set; }
        public decimal _cobrancaAnual { get; set; }
        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }

        public override decimal LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }
        public override decimal CobrancaAnual
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }

        public CartaoTitanium(decimal limite, decimal cobranca)
        {
            _limiteCredito = limite;
            _cobrancaAnual = cobranca;
            _tipoCartao = "Titanium";

        }
    }
}
