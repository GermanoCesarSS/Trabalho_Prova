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
    public partial class FrmUF : Form
    {
        public FrmUF() {
            InitializeComponent();
        }

        private void uFBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.uFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmUF_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.UF'. Você pode movê-la ou removê-la conforme necessário.
            this.uFTableAdapter.Fill(this.dB_TrabalhoDataSet.UF);

        }
    }
}
