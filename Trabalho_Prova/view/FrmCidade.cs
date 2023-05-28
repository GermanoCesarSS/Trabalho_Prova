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
    public partial class FrmCidade : Form
    {
        public FrmCidade() {
            InitializeComponent();
        }

        private void cIDADEBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.cIDADEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmCidade_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.UF'. Você pode movê-la ou removê-la conforme necessário.
            this.uFTableAdapter.Fill(this.dB_TrabalhoDataSet.UF);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.dB_TrabalhoDataSet.CIDADE);

        }

        private void button1_Click(object sender, EventArgs e) {
            FrmUF frm = new FrmUF();
            frm.ShowDialog();
        }
    }
}
