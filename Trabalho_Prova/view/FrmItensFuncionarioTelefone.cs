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
    public partial class FrmItensFuncionarioTelefone : Form
    {
        public FrmItensFuncionarioTelefone() {
            InitializeComponent();
        }

        private void iTENS_TEL_FUNBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iTENS_TEL_FUNBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmItensFuncionarioTelefone_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.dB_TrabalhoDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.dB_TrabalhoDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ITENS_TEL_FUN'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENS_TEL_FUNTableAdapter.Fill(this.dB_TrabalhoDataSet.ITENS_TEL_FUN);

        }
    }
}
