namespace gigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonAdcionar_Click(object sender, EventArgs e)
        {
            criar_produto fcp = new criar_produto();
            var resultado = fcp.ShowDialog();

            {
                string textoProduto = $"{fcp.Nome_do_Produto}({fcp.Nome_do_Fabricante})preco de compra[R$ {fcp.precoCompra}] preco venda[R${fcp.precoVenda}]";
                listBox1.Items.Add(textoProduto);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
