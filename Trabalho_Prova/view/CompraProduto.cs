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
    public partial class CompraProduto : Form
    {
        public CompraProduto() {
            InitializeComponent();
        }

        private void cOMPRAPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.cOMPRAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void CompraProduto_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.dB_TrabalhoDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORTableAdapter.Fill(this.dB_TrabalhoDataSet.FORNECEDOR);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.COMPRAPRODUTO);

        }

        private void button5_Click(object sender, EventArgs e) {
            FrmFornecedor frm = new FrmFornecedor();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e) {
            FrmFuncionarios frm = new FrmFuncionarios();
            frm.ShowDialog();
        }
    }
}
