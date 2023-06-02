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

        private void tELEFONECLIENTEToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmItensClienteTelefone frm = new FrmItensClienteTelefone();
            frm.ShowDialog();
        }

        private void tELEFONETRABALHOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmItensTrabalhoTelefone frm = new FrmItensTrabalhoTelefone();  
            frm.ShowDialog();
        }

        private void tELEFONEFUNCIONARIOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmItensFuncionarioTelefone frm = new FrmItensFuncionarioTelefone();    
            frm.ShowDialog();
        }

        private void tELEFONELOJAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmItensTelefoneLoja frm = new FrmItensTelefoneLoja();
            frm.ShowDialog();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmProduto frm = new FrmProduto();
            frm.ShowDialog();
        }

        private void pRODUTOToolStripMenuItem_Click_1(object sender, EventArgs e) {
            FrmProduto frm = new FrmProduto();
            frm.ShowDialog();   
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmMarca frm = new FrmMarca();
            frm.ShowDialog();
        }

        private void tIPOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmTipo frm = new FrmTipo();
            frm.ShowDialog();
        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmFornecedor frm = new FrmFornecedor();
            frm.ShowDialog();
        }

        private void pARCELACOMPRAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmParcelaCompra frm = new FrmParcelaCompra();
            frm.ShowDialog();
        }

        private void sITUACAOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmSituacao frm = new FrmSituacao();
            frm.ShowDialog();
        }

        private void tELEFONEFORNECEDORToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmItensTelefoneFornecedor frm = new FrmItensTelefoneFornecedor();
            frm.ShowDialog();
        }

        private void cOMPRAPRODUTOToolStripMenuItem_Click(object sender, EventArgs e) {
            CompraProduto frm = new CompraProduto();
            frm.ShowDialog();
        }

        private void cOMPRAPRODUTOToolStripMenuItem1_Click(object sender, EventArgs e) {
            CompraProduto frm = new CompraProduto();
            frm.ShowDialog();
        }

        private void vENDAPRODUTOToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmVendaProduto frm = new FrmVendaProduto();
            frm.ShowDialog();
        }

        private void pARCELAVENDAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmParcelaCompra frm = new FrmParcelaCompra();
            frm.ShowDialog();
        }

        private void iMAGENSToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmImagens frm = new FrmImagens();
            frm.ShowDialog();
        }

        private void vENDAPRODUTOToolStripMenuItem1_Click(object sender, EventArgs e) {
           FrmVendaProduto frm =new FrmVendaProduto();
            frm.ShowDialog();
        }

        private void cLIENTEToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void fUNCIONARIOToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmFuncionarios frm = new FrmFuncionarios();
            frm.ShowDialog();
        }

        private void lOGINToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }

        private void cONTROLELOGINToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmControle_LoginSistema frm = new FrmControle_LoginSistema();
            frm.ShowDialog();
        }

        private void fORNECEDORToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmFornecedor frm = new FrmFornecedor();
            frm.ShowDialog();
        }

        private void iTENSACESSOLOGINToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmItensAcessoLogin frm = new FrmItensAcessoLogin();
            frm.ShowDialog();
        }

        private void rUAToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmRua frm = new FrmRua();
            frm.ShowDialog();
        }

        private void bAIRROToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmBairro frm = new FrmBairro();
            frm.ShowDialog();
        }

        private void cEPToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmCep frm = new FrmCep();
            frm.ShowDialog();
        }

        private void uFToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmUF frm = new FrmUF();
            frm.ShowDialog();
        }

        private void cIDADEToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmCidade frm = new FrmCidade();
            frm.ShowDialog();
        }

        private void tELEFONEToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmTelefone frm = new FrmTelefone();
            frm.ShowDialog();
        }

        private void oPERADORAToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmOperadora frm = new FrmOperadora();
            frm.ShowDialog();
        }

        private void lOJAToolStripMenuItem2_Click(object sender, EventArgs e) {
            FrmLoja frm = new FrmLoja();
            frm.ShowDialog();
        }

        private void pRODUTOToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmProduto frm = new FrmProduto();
            frm.ShowDialog();
        }

        private void mARCAToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmMarca frm = new FrmMarca();
            frm.ShowDialog();
        }

        private void tIPOToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmTipo frm = new FrmTipo();
            frm.ShowDialog();
        }

        private void lOJAToolStripMenuItem1_Click(object sender, EventArgs e) {

        }

        private void pARCELAToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmParcelaCompra frm = new FrmParcelaCompra();
            frm.ShowDialog();
        }

        private void sITUACAOToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmSituacao frm = new FrmSituacao();
            frm.ShowDialog();
        }

        private void cOMPRAPRODUTOToolStripMenuItem1_Click_1(object sender, EventArgs e) {
            CompraProduto frm = new CompraProduto();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void vENDAPRODUTOToolStripMenuItem1_Click_1(object sender, EventArgs e) {
            FrmVendaProduto frm = new FrmVendaProduto();
            frm.ShowDialog();
        }

        private void pARCELAVENDAToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmParcelaCompra frm = new FrmParcelaCompra();
            frm.ShowDialog();
        }

        private void iMAGENSToolStripMenuItem1_Click(object sender, EventArgs e) {
            FrmImagens frm = new FrmImagens();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }
    }
}
