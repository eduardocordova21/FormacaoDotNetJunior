﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models
{
    public class Pedido : BaseModel
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }

        [Required]
        public virtual Cadastro Cadastro { get; private set; }

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
    }
}