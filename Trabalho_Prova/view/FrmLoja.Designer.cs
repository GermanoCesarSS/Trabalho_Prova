namespace Trabalho_Prova.view
{
    partial class FrmLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoja));
            System.Windows.Forms.Label cOD_LOJALabel;
            System.Windows.Forms.Label nOME_LOJALabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label nOME_FANTASIALabel;
            System.Windows.Forms.Label rAZAOSOCIALLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.lOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOJATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.LOJATableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.lOJABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lOJABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lOJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_LOJALabel1 = new System.Windows.Forms.Label();
            this.nOME_LOJATextBox = new System.Windows.Forms.TextBox();
            this.cNPJTextBox = new System.Windows.Forms.TextBox();
            this.nOME_FANTASIATextBox = new System.Windows.Forms.TextBox();
            this.rAZAOSOCIALTextBox = new System.Windows.Forms.TextBox();
            cOD_LOJALabel = new System.Windows.Forms.Label();
            nOME_LOJALabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            nOME_FANTASIALabel = new System.Windows.Forms.Label();
            rAZAOSOCIALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingNavigator)).BeginInit();
            this.lOJABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOJADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOJABindingSource
            // 
            this.lOJABindingSource.DataMember = "LOJA";
            this.lOJABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // lOJATableAdapter
            // 
            this.lOJATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOJATableAdapter = this.lOJATableAdapter;
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
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // lOJABindingNavigator
            // 
            this.lOJABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOJABindingNavigator.BindingSource = this.lOJABindingSource;
            this.lOJABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOJABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOJABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lOJABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOJABindingNavigatorSaveItem});
            this.lOJABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lOJABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOJABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOJABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOJABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOJABindingNavigator.Name = "lOJABindingNavigator";
            this.lOJABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOJABindingNavigator.Size = new System.Drawing.Size(697, 27);
            this.lOJABindingNavigator.TabIndex = 0;
            this.lOJABindingNavigator.Text = "bindingNavigator1";
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
            // lOJABindingNavigatorSaveItem
            // 
            this.lOJABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOJABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOJABindingNavigatorSaveItem.Image")));
            this.lOJABindingNavigatorSaveItem.Name = "lOJABindingNavigatorSaveItem";
            this.lOJABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lOJABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lOJABindingNavigatorSaveItem.Click += new System.EventHandler(this.lOJABindingNavigatorSaveItem_Click);
            // 
            // lOJADataGridView
            // 
            this.lOJADataGridView.AutoGenerateColumns = false;
            this.lOJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lOJADataGridView.DataSource = this.lOJABindingSource;
            this.lOJADataGridView.Location = new System.Drawing.Point(0, 257);
            this.lOJADataGridView.Name = "lOJADataGridView";
            this.lOJADataGridView.RowHeadersWidth = 51;
            this.lOJADataGridView.RowTemplate.Height = 24;
            this.lOJADataGridView.Size = new System.Drawing.Size(693, 220);
            this.lOJADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_LOJA";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_LOJA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_LOJA";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_LOJA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOME_FANTASIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "NOME_FANTASIA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RAZAOSOCIAL";
            this.dataGridViewTextBoxColumn5.HeaderText = "RAZAOSOCIAL";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // cOD_LOJALabel
            // 
            cOD_LOJALabel.AutoSize = true;
            cOD_LOJALabel.Location = new System.Drawing.Point(12, 71);
            cOD_LOJALabel.Name = "cOD_LOJALabel";
            cOD_LOJALabel.Size = new System.Drawing.Size(75, 16);
            cOD_LOJALabel.TabIndex = 2;
            cOD_LOJALabel.Text = "COD LOJA:";
            // 
            // cOD_LOJALabel1
            // 
            this.cOD_LOJALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "COD_LOJA", true));
            this.cOD_LOJALabel1.Location = new System.Drawing.Point(137, 71);
            this.cOD_LOJALabel1.Name = "cOD_LOJALabel1";
            this.cOD_LOJALabel1.Size = new System.Drawing.Size(100, 23);
            this.cOD_LOJALabel1.TabIndex = 3;
            this.cOD_LOJALabel1.Text = "label1";
            // 
            // nOME_LOJALabel
            // 
            nOME_LOJALabel.AutoSize = true;
            nOME_LOJALabel.Location = new System.Drawing.Point(12, 100);
            nOME_LOJALabel.Name = "nOME_LOJALabel";
            nOME_LOJALabel.Size = new System.Drawing.Size(86, 16);
            nOME_LOJALabel.TabIndex = 4;
            nOME_LOJALabel.Text = "NOME LOJA:";
            // 
            // nOME_LOJATextBox
            // 
            this.nOME_LOJATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "NOME_LOJA", true));
            this.nOME_LOJATextBox.Location = new System.Drawing.Point(153, 100);
            this.nOME_LOJATextBox.Name = "nOME_LOJATextBox";
            this.nOME_LOJATextBox.Size = new System.Drawing.Size(499, 22);
            this.nOME_LOJATextBox.TabIndex = 5;
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(12, 128);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(45, 16);
            cNPJLabel.TabIndex = 6;
            cNPJLabel.Text = "CNPJ:";
            // 
            // cNPJTextBox
            // 
            this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "CNPJ", true));
            this.cNPJTextBox.Location = new System.Drawing.Point(153, 128);
            this.cNPJTextBox.Name = "cNPJTextBox";
            this.cNPJTextBox.Size = new System.Drawing.Size(499, 22);
            this.cNPJTextBox.TabIndex = 7;
            // 
            // nOME_FANTASIALabel
            // 
            nOME_FANTASIALabel.AutoSize = true;
            nOME_FANTASIALabel.Location = new System.Drawing.Point(12, 156);
            nOME_FANTASIALabel.Name = "nOME_FANTASIALabel";
            nOME_FANTASIALabel.Size = new System.Drawing.Size(119, 16);
            nOME_FANTASIALabel.TabIndex = 8;
            nOME_FANTASIALabel.Text = "NOME FANTASIA:";
            // 
            // nOME_FANTASIATextBox
            // 
            this.nOME_FANTASIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "NOME_FANTASIA", true));
            this.nOME_FANTASIATextBox.Location = new System.Drawing.Point(153, 156);
            this.nOME_FANTASIATextBox.Name = "nOME_FANTASIATextBox";
            this.nOME_FANTASIATextBox.Size = new System.Drawing.Size(499, 22);
            this.nOME_FANTASIATextBox.TabIndex = 9;
            // 
            // rAZAOSOCIALLabel
            // 
            rAZAOSOCIALLabel.AutoSize = true;
            rAZAOSOCIALLabel.Location = new System.Drawing.Point(12, 184);
            rAZAOSOCIALLabel.Name = "rAZAOSOCIALLabel";
            rAZAOSOCIALLabel.Size = new System.Drawing.Size(103, 16);
            rAZAOSOCIALLabel.TabIndex = 10;
            rAZAOSOCIALLabel.Text = "RAZAOSOCIAL:";
            // 
            // rAZAOSOCIALTextBox
            // 
            this.rAZAOSOCIALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOJABindingSource, "RAZAOSOCIAL", true));
            this.rAZAOSOCIALTextBox.Location = new System.Drawing.Point(153, 184);
            this.rAZAOSOCIALTextBox.Name = "rAZAOSOCIALTextBox";
            this.rAZAOSOCIALTextBox.Size = new System.Drawing.Size(499, 22);
            this.rAZAOSOCIALTextBox.TabIndex = 11;
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 479);
            this.Controls.Add(cOD_LOJALabel);
            this.Controls.Add(this.cOD_LOJALabel1);
            this.Controls.Add(nOME_LOJALabel);
            this.Controls.Add(this.nOME_LOJATextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJTextBox);
            this.Controls.Add(nOME_FANTASIALabel);
            this.Controls.Add(this.nOME_FANTASIATextBox);
            this.Controls.Add(rAZAOSOCIALLabel);
            this.Controls.Add(this.rAZAOSOCIALTextBox);
            this.Controls.Add(this.lOJADataGridView);
            this.Controls.Add(this.lOJABindingNavigator);
            this.Name = "FrmLoja";
            this.Text = "FrmLoja";
            this.Load += new System.EventHandler(this.FrmLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingNavigator)).EndInit();
            this.lOJABindingNavigator.ResumeLayout(false);
            this.lOJABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOJADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource lOJABindingSource;
        private DB_TrabalhoDataSetTableAdapters.LOJATableAdapter lOJATableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOJABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lOJABindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lOJADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label cOD_LOJALabel1;
        private System.Windows.Forms.TextBox nOME_LOJATextBox;
        private System.Windows.Forms.TextBox cNPJTextBox;
        private System.Windows.Forms.TextBox nOME_FANTASIATextBox;
        private System.Windows.Forms.TextBox rAZAOSOCIALTextBox;
    }
}