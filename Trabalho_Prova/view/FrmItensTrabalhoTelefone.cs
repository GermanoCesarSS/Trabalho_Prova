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
    public partial class FrmItensTrabalhoTelefone : Form
    {
        public FrmItensTrabalhoTelefone() {
            InitializeComponent();
        }

        private void iTENS_TEL_TRABindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iTENS_TEL_TRABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmItensTrabalhoTelefone_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.dB_TrabalhoDataSet.TRABALHO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TELEFONE'. Você pode movê-la ou removê-la conforme necessário.
            this.tELEFONETableAdapter.Fill(this.dB_TrabalhoDataSet.TELEFONE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ITENS_TEL_TRA'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENS_TEL_TRATableAdapter.Fill(this.dB_TrabalhoDataSet.ITENS_TEL_TRA);

        }
    }
}
