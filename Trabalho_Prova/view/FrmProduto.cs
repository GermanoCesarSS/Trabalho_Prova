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
    public partial class FrmProduto : Form
    {
        public FrmProduto() {
            InitializeComponent();
        }

        private void pRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.pRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmProduto_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TIPO'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPOTableAdapter.Fill(this.dB_TrabalhoDataSet.TIPO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.MARCA'. Você pode movê-la ou removê-la conforme necessário.
            this.mARCATableAdapter.Fill(this.dB_TrabalhoDataSet.MARCA);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.PRODUTO);

        }

        private void pRODUTODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            FrmMarca frm = new FrmMarca();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            FrmTipo frm = new FrmTipo();
            frm.ShowDialog();
        }
    }
}
