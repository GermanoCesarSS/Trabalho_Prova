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
    public partial class FrmParcelaCompra: Form
    {
        public FrmParcelaCompra()
        {
            InitializeComponent();
        }

        private void pARCELACOMPRABindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.pARCELACOMPRABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmParcelaCompra_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.COMPRAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.cOMPRAPRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.COMPRAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.SITUACAO'. Você pode movê-la ou removê-la conforme necessário.
            this.sITUACAOTableAdapter.Fill(this.dB_TrabalhoDataSet.SITUACAO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.PARCELACOMPRA'. Você pode movê-la ou removê-la conforme necessário.
            this.pARCELACOMPRATableAdapter.Fill(this.dB_TrabalhoDataSet.PARCELACOMPRA);

        }

        private void button5_Click(object sender, EventArgs e) {
            FrmSituacao frm = new FrmSituacao();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e) {
            CompraProduto frm = new CompraProduto();
            frm.ShowDialog();
        }
    }
}
