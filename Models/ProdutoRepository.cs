using System;
using System.Collections.Generic;

namespace Produto.Models
{
    public class ProdutoRepository : IProdutoRepository
    {
        private List<Produto> _produtos;

        public ProdutoRepository()
        {
            _produtos = new List<Produto>();
        }

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public List<Produto> ObterTodos()
        {
            return _produtos;
        }

        public Produto ObterPorId(int id)
        {
            return _produtos.FirstOrDefault(produto => produto.Id == id);
        }

        public void Atualizar(int id, Produto produtoAtualizado)
        {
            var produtoExistente = _produtos.Find(produto => produto.Id == id);
            if (produtoExistente != null)
            {
                produtoExistente.Nome = produtoAtualizado.Nome;
            }
        }

        public void Remover(int id)
        {
            _produtos.RemoveAll(produto => produto.Id == id);
        }
    }
}