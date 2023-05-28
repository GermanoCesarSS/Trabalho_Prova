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
    public partial class FrmLogin : Form
    {
        public FrmLogin() {
            InitializeComponent();
        }

        private void lOGINSBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.lOGINSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmLogin_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.dB_TrabalhoDataSet.FUNCIONARIOS);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.LOGINS'. Você pode movê-la ou removê-la conforme necessário.
            this.lOGINSTableAdapter.Fill(this.dB_TrabalhoDataSet.LOGINS);

        }

        private void button2_Click(object sender, EventArgs e) {
            FrmFuncionarios frm = new FrmFuncionarios();
            frm.ShowDialog();
        }
    }
}
