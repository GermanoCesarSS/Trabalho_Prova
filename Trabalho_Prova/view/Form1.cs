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
    }
}
