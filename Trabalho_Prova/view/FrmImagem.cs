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
    public partial class FrmImagem : Form
    {
        public FrmImagem() {
            InitializeComponent();
        }

        private void iMAGENSBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iMAGENSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmImagem_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.PRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.PRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.IMAGENS'. Você pode movê-la ou removê-la conforme necessário.
            this.iMAGENSTableAdapter.Fill(this.dB_TrabalhoDataSet.IMAGENS);

        }

        private void button6_Click(object sender, EventArgs e) {
            FrmProduto frm = new FrmProduto();
            frm.ShowDialog();
        }
    }
}
