using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade._10._11
{
    class Venda
    {
        private int qtde;
        private double valor;

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Venda(int qtde, double valor)
        {
            this.qtde = qtde;
            this.valor = valor;
        }

        public Venda() : this(0, 0.0)
        {
        }

        public double valorMedio()
        {
            return valor / qtde;
        }
    }
}
