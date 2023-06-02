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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios() {
            InitializeComponent();
        }

        private void fUNCIONARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.fUNCIONARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmFuncionarios_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.LOJA'. Você pode movê-la ou removê-la conforme necessário.
            this.lOJATableAdapter.Fill(this.dB_TrabalhoDataSet.LOJA);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FUNCAO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCAOTableAdapter.Fill(this.dB_TrabalhoDataSet.FUNCAO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.dB_TrabalhoDataSet.CIDADE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.dB_TrabalhoDataSet.CEP);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.dB_TrabalhoDataSet.BAIRRO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.dB_TrabalhoDataSet.RUA);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.dB_TrabalhoDataSet.FUNCIONARIOS);

        }

        private void button2_Click(object sender, EventArgs e) {
            FrmRua frm = new FrmRua();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmBairro frm = new FrmBairro();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            FrmCep frm = new FrmCep();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            FrmCidade frm = new FrmCidade();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) {
            FrmFuncao frm = new FrmFuncao();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e) {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void fUNCIONARIOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
