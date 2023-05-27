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
    public partial class FrmControle_LoginSistema : Form
    {
        public FrmControle_LoginSistema() {
            InitializeComponent();
        }

        private void cONTROLE_LOGSISTEMABindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.cONTROLE_LOGSISTEMABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmControle_LoginSistema_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.LOGINS'. Você pode movê-la ou removê-la conforme necessário.
            this.lOGINSTableAdapter.Fill(this.dB_TrabalhoDataSet.LOGINS);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CONTROLE_LOGSISTEMA'. Você pode movê-la ou removê-la conforme necessário.
            this.cONTROLE_LOGSISTEMATableAdapter.Fill(this.dB_TrabalhoDataSet.CONTROLE_LOGSISTEMA);

        }
    }
}
