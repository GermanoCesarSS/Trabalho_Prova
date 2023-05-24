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
    public partial class FrmTrabalho : Form
    {
        public FrmTrabalho() {
            InitializeComponent();
        }

        private void tRABALHOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.tRABALHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmTrabalho_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.dB_TrabalhoDataSet.TRABALHO);

        }
    }
}
