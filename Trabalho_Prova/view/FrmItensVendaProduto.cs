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
    public partial class FrmItensVendaProduto : Form
    {
        public FrmItensVendaProduto() {
            InitializeComponent();
        }

        private void iTENS_VENDAPRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iTENS_VENDAPRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmItensVendaProduto_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.PRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ITENS_VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENS_VENDAPRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.ITENS_VENDAPRODUTO);

        }

        private void button6_Click(object sender, EventArgs e) {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
        }
    }
}
