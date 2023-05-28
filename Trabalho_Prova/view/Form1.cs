using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Prova.view;

namespace Trabalho_Prova
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmSexo frm = new FrmSexo();
            frm.ShowDialog();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void rUAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmRua frm = new FrmRua();
            frm.ShowDialog();
        }

        private void tabelasToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void bAIRROToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmBairro frm = new FrmBairro();
            frm.ShowDialog(); 
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmCep frm = new FrmCep();
            frm.ShowDialog();
        }

        private void cIDADEToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmCidade frm = new FrmCidade();
            frm.ShowDialog();
        }

        private void uFToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmUF frm = new FrmUF();
            frm.ShowDialog();
        }

        private void tRABALHOSToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmTrabalho frm = new FrmTrabalho();   
            frm.ShowDialog();
        }

        private void oPERADORAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmOperadora frm = new FrmOperadora();
            frm.ShowDialog();
        }

        private void tELEFONEToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmTelefone frm = new FrmTelefone();
            frm.ShowDialog();
        }

        private void fUNCAOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmFuncao frm = new FrmFuncao();
            frm.ShowDialog();
        }

        private void lOJAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmLoja frm = new FrmLoja();
            frm.ShowDialog();
        }

        private void fUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmFuncionarios frm = new FrmFuncionarios();
            frm.ShowDialog();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void cONTROLELOGINSToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmControle_LoginSistema frm = new FrmControle_LoginSistema();
            frm.ShowDialog();
        }

        private void aCESSOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmAcesso frm = new FrmAcesso();
            frm.ShowDialog();
        }

        private void aCESSOLOGINToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmItensAcessoLogin frm = new FrmItensAcessoLogin();
            frm.ShowDialog();
        }
    }
}
