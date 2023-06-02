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
    public partial class FrmItensTelefoneLoja : Form
    {
        public FrmItensTelefoneLoja() {
            InitializeComponent();
        }

        private void iTENS_TEL_LOJABindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iTENS_TEL_LOJABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmItensTelefoneLoja_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.dB_TrabalhoDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.LOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.lOJATableAdapter.Fill(this.dB_TrabalhoDataSet.LOJA);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ITENS_TEL_LOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENS_TEL_LOJATableAdapter.Fill(this.dB_TrabalhoDataSet.ITENS_TEL_LOJA);

        }

        private void button2_Click(object sender, EventArgs e) {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmTelefone frm = new FrmTelefone();
            frm.ShowDialog();
        }
    }
}
