﻿using System;

namespace serverTCC.Models
{
    public class Investimento : IConta
    {
        public int Id { get; set; }

        public Usuario Usuario { get; set; }
        public string UsuarioId { get; set; }

        public TipoInvestimento TipoInvestimento { get; set; }
        public int TipoInvestimentoId { get; set; }

        public Moeda Moeda { get; set; }
        public int MoedaId { get; set; }

        public string Descricao { get; set; }
        public decimal ValorAtual { get; set; }
        public decimal ValorInvestido { get; set; }
        public int QtdTempo { get; set; }
        public DateTime DataInicio { get; set; }

        public EscalaTempo EscalaTempo { get; set; }
    }
}
