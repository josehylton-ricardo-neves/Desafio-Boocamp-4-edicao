using System;
using System.Windows.Forms;
using Produto.Models;

namespace Produto
{
    public partial class Form1 : Form
    {
        private IProdutoRepository _produtoRepository;

        public Form1()
        {
            InitializeComponent();
            _produtoRepository = new ProdutoRepository();
            AtualizarListaProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                Models.Produto produto = new Models.Produto(txtNome.Text);
                _produtoRepository.Adicionar(produto);
                AtualizarListaProdutos();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Nome do produto em branco.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdEditar.Text, out int id) && !string.IsNullOrEmpty(txtNovoNome.Text))
            {
                Models.Produto produto = new Models.Produto(txtNovoNome.Text);
                _produtoRepository.Atualizar(id, produto);
                AtualizarListaProdutos();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("ID inválido ou novo nome do produto em branco.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdRemover.Text, out int id))
            {
                _produtoRepository.Remover(id);
                AtualizarListaProdutos();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("ID inválido.");
            }
        }

        private void AtualizarListaProdutos()
        {
            lstProdutos.Items.Clear();
            foreach (Models.Produto produto in _produtoRepository.ObterTodos())
            {
                lstProdutos.Items.Add($"ID: {produto.Id}, Nome: {produto.Nome}");
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdEditar.Text = string.Empty;
            txtNovoNome.Text = string.Empty;
            txtIdRemover.Text = string.Empty;
        }
    }
}