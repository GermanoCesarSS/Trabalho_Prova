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
    public partial class FrmItensClienteTelefone : Form
    {
        public FrmItensClienteTelefone() {
            InitializeComponent();
        }

        private void iTENS_TEL_CLIBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iTENS_TEL_CLIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmItensClienteTelefone_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.dB_TrabalhoDataSet.CLIENTE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.dB_TrabalhoDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ITENS_TEL_CLI'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENS_TEL_CLITableAdapter.Fill(this.dB_TrabalhoDataSet.ITENS_TEL_CLI);

        }

        private void button1_Click(object sender, EventArgs e) {
            FrmTelefone frm = new FrmTelefone();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }
    }
}
