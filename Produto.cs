using System;
using System.Collections.Generic;
using System.Linq;

namespace Joao_Ramos_DR2_TP2
{
    internal class Produto
    {
        public string nome { get; set; }

        private int _preco;
        public decimal preco { 
            get => (decimal)_preco / 100;
            set => _preco = (int)(value * 100);
        }


        public Produto( string nome, decimal preco)
        {
            this.preco = preco;
            this.nome = nome;
        }


    }
}
