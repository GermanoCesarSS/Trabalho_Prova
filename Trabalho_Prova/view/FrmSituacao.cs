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
    public partial class FrmSituacao : Form
    {
        public FrmSituacao() {
            InitializeComponent();
        }

        private void sITUACAOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.sITUACAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmSituacao_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.SITUACAO'. Você pode movê-la ou removê-la conforme necessário.
            this.sITUACAOTableAdapter.Fill(this.dB_TrabalhoDataSet.SITUACAO);

        }
    }
}
