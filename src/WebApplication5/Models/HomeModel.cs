using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class HomeModel
    {
        public Task<List<Produto>> Produtos { get; set; }
        public Task<List<Produto>> UltimosProdutos { get; set; }
    }
}