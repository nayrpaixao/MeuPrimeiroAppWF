namespace MeuPrimeiroAppWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Obter o texto do TextBox

            var nome = txtNome.Text;

            //Exibir mensagem para o usuário
            var mensagem = $"Cliente {nome} salvo com sucesso!";

            MessageBox.Show(mensagem);
        }
    }
}
