using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Prova.view
{
    public partial class FrmVendaProduto : Form
    {
        public FrmVendaProduto() {
            InitializeComponent();
        }

        private void vENDAPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.vENDAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmVendaProduto_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.dB_TrabalhoDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.dB_TrabalhoDataSet.CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.VENDAPRODUTO);

        }

        private void button5_Click(object sender, EventArgs e) {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e) {
            FrmFuncionarios frm = new FrmFuncionarios();
            frm.ShowDialog();
        }
    }
}
