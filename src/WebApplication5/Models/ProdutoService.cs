using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class ProdutoService
    {
        public Task<List<Produto>> LoadAsync()
        {
            return Task.Factory.StartNew(
                () =>
                {
                    Task.Delay(3000).Wait();
                    return new List<Produto>() {
                        new Produto() { Id=1,Titulo="Livro ASP.NET"} ,
                        new Produto() { Id=2,Titulo= "Livro C#" }
                    };
                });
        }
        public Task<List<Produto>> LoadUltimosProdutosAsync()
        {
            return Task.Factory.StartNew(
                () =>
                {
                    Task.Delay(4000).Wait();
                    return new List<Produto>() {
                        new Produto() { Id=1,Titulo="Ultimo Produto 1"} ,
                        new Produto() { Id=2,Titulo= "Ultimo Produto 2" }
                    };
                });
        }
    }
}