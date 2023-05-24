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
    public partial class FrmBairro : Form
    {
        public FrmBairro() {
            InitializeComponent();
        }

        private void bAIRROBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.bAIRROBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmBairro_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.dB_TrabalhoDataSet.BAIRRO);

        }
    }
}
