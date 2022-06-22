using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWFDotNet16_05_2022
{
    public partial class FrmConsultaClientes : Form
    {
        public FrmConsultaClientes()
        {
            InitializeComponent();
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = new ClientService().findAll();
        }
    }
}
