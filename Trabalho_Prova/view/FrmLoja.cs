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
    public partial class FrmLoja : Form
    {
        public FrmLoja() {
            InitializeComponent();
        }

        private void lOJABindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.lOJABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmLoja_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.LOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.lOJATableAdapter.Fill(this.dB_TrabalhoDataSet.LOJA);

        }
    }
}
