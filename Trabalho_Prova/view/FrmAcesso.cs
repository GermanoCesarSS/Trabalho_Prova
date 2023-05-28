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
    public partial class FrmAcesso : Form
    {
        public FrmAcesso() {
            InitializeComponent();
        }

        private void aCESSOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.aCESSOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmAcesso_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ACESSO'. Você pode movê-la ou removê-la conforme necessário.
            this.aCESSOTableAdapter.Fill(this.dB_TrabalhoDataSet.ACESSO);

        }
    }
}
