﻿using System;
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
    }
}
