﻿using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models
{
    public class Produto : BaseModel
    {
        public Produto()
        {
        }

        public Produto(string codigo, string nome, decimal preco, Categoria categoria)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
            this.Categoria = categoria;
        }

        [Required]
        public Categoria Categoria { get; private set; }

        [Required]
        public string Codigo { get; private set; }

        [Required]
        public string Nome { get; private set; }

        [Required]
        public decimal Preco { get; private set; }
    }
}