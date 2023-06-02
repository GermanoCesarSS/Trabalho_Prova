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
    public partial class FrmItensCompraProduto: Form
    {
        public FrmItensCompraProduto()
        {
            InitializeComponent();
        }

        private void iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iTENS_COMPRA_PRODUTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmItensCompraProduto_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.PRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.COMPRAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ITENS_COMPRA_PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENS_COMPRA_PRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.ITENS_COMPRA_PRODUTO);

        }

        private void button5_Click(object sender, EventArgs e) {
            CompraProduto compraProduto = new CompraProduto();  
            compraProduto.ShowDialog();          

        }

        private void button6_Click(object sender, EventArgs e) {
            FrmProduto frm = new FrmProduto();
            frm.ShowDialog();
        }
    }
}
