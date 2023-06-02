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
    public partial class FrmParcelaVenda : Form
    {
        public FrmParcelaVenda() {
            InitializeComponent();
        }

        private void pARCELAVENDABindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.pARCELAVENDABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmParcelaVenda_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.SITUACAO'. Você pode movê-la ou removê-la conforme necessário.
            this.sITUACAOTableAdapter.Fill(this.dB_TrabalhoDataSet.SITUACAO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.VENDAPRODUTO'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDAPRODUTOTableAdapter.Fill(this.dB_TrabalhoDataSet.VENDAPRODUTO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.PARCELAVENDA'. Você pode movê-la ou removê-la conforme necessário.
            this.pARCELAVENDATableAdapter.Fill(this.dB_TrabalhoDataSet.PARCELAVENDA);

        }

        private void button5_Click(object sender, EventArgs e) {
            FrmSituacao frm = new FrmSituacao();
            frm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e) {
            FrmVendaProduto frm = new FrmVendaProduto();
            frm.ShowDialog();
        }
    }
}
