namespace Trabalho_Prova.view
{
    partial class FrmUF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUF));
            System.Windows.Forms.Label cOD_UFLabel;
            System.Windows.Forms.Label nOME_UFLabel;
            System.Windows.Forms.Label sIGLALabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.uFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uFTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.UFTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.uFBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uFBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uFDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_UFLabel1 = new System.Windows.Forms.Label();
            this.nOME_UFTextBox = new System.Windows.Forms.TextBox();
            this.sIGLATextBox = new System.Windows.Forms.TextBox();
            cOD_UFLabel = new System.Windows.Forms.Label();
            nOME_UFLabel = new System.Windows.Forms.Label();
            sIGLALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingNavigator)).BeginInit();
            this.uFBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uFDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uFBindingSource
            // 
            this.uFBindingSource.DataMember = "UF";
            this.uFBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // uFTableAdapter
            // 
            this.uFTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRAPRODUTOTableAdapter = null;
            this.tableAdapterManager.CONTROLE_LOGSISTEMATableAdapter = null;
            this.tableAdapterManager.FORNECEDORTableAdapter = null;
            this.tableAdapterManager.FUNCAOTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.IMAGENSTableAdapter = null;
            this.tableAdapterManager.ITENS_ACESSOLOGINTableAdapter = null;
            this.tableAdapterManager.ITENS_COMPRA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_CLITableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_FORTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_FUNTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_LOJATableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_TRATableAdapter = null;
            this.tableAdapterManager.ITENS_VENDAPRODUTOTableAdapter = null;
            this.tableAdapterManager.LOGINSTableAdapter = null;
            this.tableAdapterManager.LOJATableAdapter = null;
            this.tableAdapterManager.MARCATableAdapter = null;
            this.tableAdapterManager.OPERADORATableAdapter = null;
            this.tableAdapterManager.PARCELACOMPRATableAdapter = null;
            this.tableAdapterManager.PARCELAVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = this.uFTableAdapter;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // uFBindingNavigator
            // 
            this.uFBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uFBindingNavigator.BindingSource = this.uFBindingSource;
            this.uFBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uFBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uFBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uFBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uFBindingNavigatorSaveItem});
            this.uFBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uFBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uFBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uFBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uFBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uFBindingNavigator.Name = "uFBindingNavigator";
            this.uFBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uFBindingNavigator.Size = new System.Drawing.Size(459, 27);
            this.uFBindingNavigator.TabIndex = 0;
            this.uFBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // uFBindingNavigatorSaveItem
            // 
            this.uFBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uFBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uFBindingNavigatorSaveItem.Image")));
            this.uFBindingNavigatorSaveItem.Name = "uFBindingNavigatorSaveItem";
            this.uFBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.uFBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.uFBindingNavigatorSaveItem.Click += new System.EventHandler(this.uFBindingNavigatorSaveItem_Click);
            // 
            // uFDataGridView
            // 
            this.uFDataGridView.AutoGenerateColumns = false;
            this.uFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uFDataGridView.DataSource = this.uFBindingSource;
            this.uFDataGridView.Location = new System.Drawing.Point(0, 280);
            this.uFDataGridView.Name = "uFDataGridView";
            this.uFDataGridView.RowHeadersWidth = 51;
            this.uFDataGridView.RowTemplate.Height = 24;
            this.uFDataGridView.Size = new System.Drawing.Size(459, 220);
            this.uFDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_UF";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_UF";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_UF";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_UF";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SIGLA";
            this.dataGridViewTextBoxColumn3.HeaderText = "SIGLA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // cOD_UFLabel
            // 
            cOD_UFLabel.AutoSize = true;
            cOD_UFLabel.Location = new System.Drawing.Point(24, 84);
            cOD_UFLabel.Name = "cOD_UFLabel";
            cOD_UFLabel.Size = new System.Drawing.Size(60, 16);
            cOD_UFLabel.TabIndex = 2;
            cOD_UFLabel.Text = "COD UF:";
            // 
            // cOD_UFLabel1
            // 
            this.cOD_UFLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uFBindingSource, "COD_UF", true));
            this.cOD_UFLabel1.Location = new System.Drawing.Point(114, 84);
            this.cOD_UFLabel1.Name = "cOD_UFLabel1";
            this.cOD_UFLabel1.Size = new System.Drawing.Size(100, 23);
            this.cOD_UFLabel1.TabIndex = 3;
            this.cOD_UFLabel1.Text = "label1";
            // 
            // nOME_UFLabel
            // 
            nOME_UFLabel.AutoSize = true;
            nOME_UFLabel.Location = new System.Drawing.Point(24, 113);
            nOME_UFLabel.Name = "nOME_UFLabel";
            nOME_UFLabel.Size = new System.Drawing.Size(71, 16);
            nOME_UFLabel.TabIndex = 4;
            nOME_UFLabel.Text = "NOME UF:";
            // 
            // nOME_UFTextBox
            // 
            this.nOME_UFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uFBindingSource, "NOME_UF", true));
            this.nOME_UFTextBox.Location = new System.Drawing.Point(114, 110);
            this.nOME_UFTextBox.Name = "nOME_UFTextBox";
            this.nOME_UFTextBox.Size = new System.Drawing.Size(290, 22);
            this.nOME_UFTextBox.TabIndex = 5;
            // 
            // sIGLALabel
            // 
            sIGLALabel.AutoSize = true;
            sIGLALabel.Location = new System.Drawing.Point(24, 141);
            sIGLALabel.Name = "sIGLALabel";
            sIGLALabel.Size = new System.Drawing.Size(48, 16);
            sIGLALabel.TabIndex = 6;
            sIGLALabel.Text = "SIGLA:";
            // 
            // sIGLATextBox
            // 
            this.sIGLATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uFBindingSource, "SIGLA", true));
            this.sIGLATextBox.Location = new System.Drawing.Point(114, 138);
            this.sIGLATextBox.Name = "sIGLATextBox";
            this.sIGLATextBox.Size = new System.Drawing.Size(290, 22);
            this.sIGLATextBox.TabIndex = 7;
            // 
            // FrmUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 503);
            this.Controls.Add(cOD_UFLabel);
            this.Controls.Add(this.cOD_UFLabel1);
            this.Controls.Add(nOME_UFLabel);
            this.Controls.Add(this.nOME_UFTextBox);
            this.Controls.Add(sIGLALabel);
            this.Controls.Add(this.sIGLATextBox);
            this.Controls.Add(this.uFDataGridView);
            this.Controls.Add(this.uFBindingNavigator);
            this.Name = "FrmUF";
            this.Text = "FrmUF";
            this.Load += new System.EventHandler(this.FrmUF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingNavigator)).EndInit();
            this.uFBindingNavigator.ResumeLayout(false);
            this.uFBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uFDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource uFBindingSource;
        private DB_TrabalhoDataSetTableAdapters.UFTableAdapter uFTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uFBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uFBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uFDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label cOD_UFLabel1;
        private System.Windows.Forms.TextBox nOME_UFTextBox;
        private System.Windows.Forms.TextBox sIGLATextBox;
    }
}