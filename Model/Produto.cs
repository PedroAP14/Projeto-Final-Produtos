using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoFinal.Model.Enums;

namespace ProjetoFinal.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHora_Criacao { get; set; }
        public DateTime Ultima_Atualizacao { get; set; }
        public TipoCategoriaEnum TipoCategoria { get; set; }
    }
}