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
    public partial class FrmCliente : Form
    {
        public FrmCliente() {
            InitializeComponent();
        }

        private void cLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmCliente_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.TRABALHO'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHOTableAdapter.Fill(this.dB_TrabalhoDataSet.TRABALHO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CIDADE'. Você pode movê-la ou removê-la conforme necessário.
            this.cIDADETableAdapter.Fill(this.dB_TrabalhoDataSet.CIDADE);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CEP'. Você pode movê-la ou removê-la conforme necessário.
            this.cEPTableAdapter.Fill(this.dB_TrabalhoDataSet.CEP);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.BAIRRO'. Você pode movê-la ou removê-la conforme necessário.
            this.bAIRROTableAdapter.Fill(this.dB_TrabalhoDataSet.BAIRRO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.RUA'. Você pode movê-la ou removê-la conforme necessário.
            this.rUATableAdapter.Fill(this.dB_TrabalhoDataSet.RUA);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.SEXO'. Você pode movê-la ou removê-la conforme necessário.
            this.sEXOTableAdapter.Fill(this.dB_TrabalhoDataSet.SEXO);
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTETableAdapter.Fill(this.dB_TrabalhoDataSet.CLIENTE);

        }
    }
}
