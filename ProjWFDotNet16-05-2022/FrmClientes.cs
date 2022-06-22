using Models;
using Services;

namespace ProjWFDotNet16_05_2022
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frmClientes = new FrmConsultaClientes();
            frmClientes.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
            };

            ClientService clienteService = new ClientService();

            clienteService.Add(cliente);

            MessageBox.Show("Registro inserido com sucesso!");
        }
    }
}