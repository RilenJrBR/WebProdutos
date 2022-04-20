﻿using Microsoft.EntityFrameworkCore;

namespace WebProdutos.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options)
            : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }    
    }
}
