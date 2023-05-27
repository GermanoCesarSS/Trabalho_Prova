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
    public partial class FrmFuncao : Form
    {
        public FrmFuncao() {
            InitializeComponent();
        }

        private void fUNCAOBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.fUNCAOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmFuncao_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FUNCAO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCAOTableAdapter.Fill(this.dB_TrabalhoDataSet.FUNCAO);

        }
    }
}
