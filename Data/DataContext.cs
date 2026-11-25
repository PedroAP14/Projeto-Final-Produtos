using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Model;
using ProjetoFinal.Model.Enums;

namespace ProjetoFinal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        
        public DbSet<Produto> TB_PRODUTOS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData
            (
                new Produto() {Id = 1, Nome = "Banana-Prata (Kg)", Descricao = "Banana-prata fresca in natura, polpa firme e sabor suave. Vendida por quilo", Preco = 9.87, Quantidade = 0, DataHora_Criacao = new DateTime(2026, 11, 25, 0, 0, 0), Ultima_Atualizacao = new DateTime(2026, 11, 25, 0, 0, 0), TipoCategoria = TipoCategoriaEnum.Alimento}
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(500);
        }
    }
}