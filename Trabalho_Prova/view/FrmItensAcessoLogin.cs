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
    public partial class FrmItensAcessoLogin : Form
    {
        public FrmItensAcessoLogin() {
            InitializeComponent();
        }

        private void iTENS_ACESSOLOGINBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.iTENS_ACESSOLOGINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmItensAcessoLogin_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.LOGINS'. Você pode movê-la ou removê-la conforme necessário.
            this.lOGINSTableAdapter.Fill(this.dB_TrabalhoDataSet.LOGINS);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ACESSO'. Você pode movê-la ou removê-la conforme necessário.
            this.aCESSOTableAdapter.Fill(this.dB_TrabalhoDataSet.ACESSO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.ITENS_ACESSOLOGIN'. Você pode movê-la ou removê-la conforme necessário.
            this.iTENS_ACESSOLOGINTableAdapter.Fill(this.dB_TrabalhoDataSet.ITENS_ACESSOLOGIN);

        }
    }
}
