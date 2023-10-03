using System.Collections.Generic;

namespace Produto.Models
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        List<Produto> ObterTodos();
        Produto? ObterPorId(int id);
        void Atualizar(int id, Produto produto);
        void Remover(int id);
    }
}