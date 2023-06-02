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
    public partial class FrmTipo : Form
    {
        public FrmTipo() {
            InitializeComponent();
        }

        private void tIPOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.tIPOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmTipo_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TIPO'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPOTableAdapter.Fill(this.dB_TrabalhoDataSet.TIPO);

        }
    }
}
