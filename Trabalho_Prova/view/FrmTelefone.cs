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
    public partial class FrmTelefone : Form
    {
        public FrmTelefone() {
            InitializeComponent();
        }

        private void tELEFONEBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.tELEFONEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);
            this.dadosTelefoneTableAdapter.Fill(this.dB_TrabalhoDataSet.DadosTelefone);

        }

        private void FrmTelefone_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.OPERADORA'. Você pode movê-la ou removê-la conforme necessário.
            this.oPERADORATableAdapter.Fill(this.dB_TrabalhoDataSet.OPERADORA);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.DadosTelefone'. Você pode movê-la ou removê-la conforme necessário.
            this.dadosTelefoneTableAdapter.Fill(this.dB_TrabalhoDataSet.DadosTelefone);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.dB_TrabalhoDataSet.TELEFONE);

        }

        private void dadosTelefoneDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
