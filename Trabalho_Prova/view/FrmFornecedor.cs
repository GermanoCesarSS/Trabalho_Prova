﻿using System;
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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor() {
            InitializeComponent();
        }

        private void fORNECEDORBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.fORNECEDORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_TrabalhoDataSet);

        }

        private void FrmFornecedor_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'dB_TrabalhoDataSet.FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORTableAdapter.Fill(this.dB_TrabalhoDataSet.FORNECEDOR);

        }

        private void button1_Click(object sender, EventArgs e) {
            FrmRua frm = new FrmRua();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            FrmBairro frm = new FrmBairro();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            FrmCep frm = new FrmCep();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) {
            FrmCidade frm = new FrmCidade();
            frm.ShowDialog();
        }
    }
}
