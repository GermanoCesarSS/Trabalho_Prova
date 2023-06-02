namespace Trabalho_Prova.view
{
    partial class FrmItensTelefoneFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensTelefoneFornecedor));
            System.Windows.Forms.Label cOD_FUNCIONARIO_FKLabel;
            System.Windows.Forms.Label cOD_TELEFONE_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.iTENS_TEL_FUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENS_TEL_FUNTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.ITENS_TEL_FUNTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.iTENS_TEL_FUNBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENS_TEL_FUNBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iTENS_TEL_FUNDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_FUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_TELEFONE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter();
            cOD_FUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            cOD_TELEFONE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_FUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_FUNBindingNavigator)).BeginInit();
            this.iTENS_TEL_FUNBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_FUNDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENS_TEL_FUNBindingSource
            // 
            this.iTENS_TEL_FUNBindingSource.DataMember = "ITENS_TEL_FUN";
            this.iTENS_TEL_FUNBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // iTENS_TEL_FUNTableAdapter
            // 
            this.iTENS_TEL_FUNTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = this.fUNCIONARIOSTableAdapter;
            this.tableAdapterManager.IMAGENSTableAdapter = null;
            this.tableAdapterManager.ITENS_ACESSOLOGINTableAdapter = null;
            this.tableAdapterManager.ITENS_COMPRA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_CLITableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_FORTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_FUNTableAdapter = this.iTENS_TEL_FUNTableAdapter;
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
            this.tableAdapterManager.TELEFONETableAdapter = this.tELEFONETableAdapter;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // iTENS_TEL_FUNBindingNavigator
            // 
            this.iTENS_TEL_FUNBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENS_TEL_FUNBindingNavigator.BindingSource = this.iTENS_TEL_FUNBindingSource;
            this.iTENS_TEL_FUNBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENS_TEL_FUNBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENS_TEL_FUNBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iTENS_TEL_FUNBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENS_TEL_FUNBindingNavigatorSaveItem});
            this.iTENS_TEL_FUNBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENS_TEL_FUNBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENS_TEL_FUNBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENS_TEL_FUNBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENS_TEL_FUNBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENS_TEL_FUNBindingNavigator.Name = "iTENS_TEL_FUNBindingNavigator";
            this.iTENS_TEL_FUNBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENS_TEL_FUNBindingNavigator.Size = new System.Drawing.Size(506, 27);
            this.iTENS_TEL_FUNBindingNavigator.TabIndex = 0;
            this.iTENS_TEL_FUNBindingNavigator.Text = "bindingNavigator1";
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
            // iTENS_TEL_FUNBindingNavigatorSaveItem
            // 
            this.iTENS_TEL_FUNBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENS_TEL_FUNBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENS_TEL_FUNBindingNavigatorSaveItem.Image")));
            this.iTENS_TEL_FUNBindingNavigatorSaveItem.Name = "iTENS_TEL_FUNBindingNavigatorSaveItem";
            this.iTENS_TEL_FUNBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iTENS_TEL_FUNBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENS_TEL_FUNBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENS_TEL_FUNBindingNavigatorSaveItem_Click);
            // 
            // iTENS_TEL_FUNDataGridView
            // 
            this.iTENS_TEL_FUNDataGridView.AutoGenerateColumns = false;
            this.iTENS_TEL_FUNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENS_TEL_FUNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENS_TEL_FUNDataGridView.DataSource = this.iTENS_TEL_FUNBindingSource;
            this.iTENS_TEL_FUNDataGridView.Location = new System.Drawing.Point(12, 261);
            this.iTENS_TEL_FUNDataGridView.Name = "iTENS_TEL_FUNDataGridView";
            this.iTENS_TEL_FUNDataGridView.RowHeadersWidth = 51;
            this.iTENS_TEL_FUNDataGridView.RowTemplate.Height = 24;
            this.iTENS_TEL_FUNDataGridView.Size = new System.Drawing.Size(480, 220);
            this.iTENS_TEL_FUNDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_FUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_FUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_TELEFONE_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_TELEFONE_FK";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_FUNCIONARIO_FKLabel
            // 
            cOD_FUNCIONARIO_FKLabel.AutoSize = true;
            cOD_FUNCIONARIO_FKLabel.Location = new System.Drawing.Point(14, 122);
            cOD_FUNCIONARIO_FKLabel.Name = "cOD_FUNCIONARIO_FKLabel";
            cOD_FUNCIONARIO_FKLabel.Size = new System.Drawing.Size(153, 16);
            cOD_FUNCIONARIO_FKLabel.TabIndex = 2;
            cOD_FUNCIONARIO_FKLabel.Text = "COD FUNCIONARIO FK:";
            // 
            // cOD_FUNCIONARIO_FKComboBox
            // 
            this.cOD_FUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_TEL_FUNBindingSource, "COD_FUNCIONARIO_FK", true));
            this.cOD_FUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource;
            this.cOD_FUNCIONARIO_FKComboBox.DisplayMember = "NOME_FUNCIONARIO";
            this.cOD_FUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cOD_FUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(173, 119);
            this.cOD_FUNCIONARIO_FKComboBox.Name = "cOD_FUNCIONARIO_FKComboBox";
            this.cOD_FUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(193, 24);
            this.cOD_FUNCIONARIO_FKComboBox.TabIndex = 3;
            this.cOD_FUNCIONARIO_FKComboBox.ValueMember = "COD_FUNCIONARIO";
            // 
            // cOD_TELEFONE_FKLabel
            // 
            cOD_TELEFONE_FKLabel.AutoSize = true;
            cOD_TELEFONE_FKLabel.Location = new System.Drawing.Point(14, 152);
            cOD_TELEFONE_FKLabel.Name = "cOD_TELEFONE_FKLabel";
            cOD_TELEFONE_FKLabel.Size = new System.Drawing.Size(132, 16);
            cOD_TELEFONE_FKLabel.TabIndex = 4;
            cOD_TELEFONE_FKLabel.Text = "COD TELEFONE FK:";
            // 
            // cOD_TELEFONE_FKComboBox
            // 
            this.cOD_TELEFONE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_TEL_FUNBindingSource, "COD_TELEFONE_FK", true));
            this.cOD_TELEFONE_FKComboBox.DataSource = this.tELEFONEBindingSource;
            this.cOD_TELEFONE_FKComboBox.DisplayMember = "NUMERO";
            this.cOD_TELEFONE_FKComboBox.FormattingEnabled = true;
            this.cOD_TELEFONE_FKComboBox.Location = new System.Drawing.Point(173, 149);
            this.cOD_TELEFONE_FKComboBox.Name = "cOD_TELEFONE_FKComboBox";
            this.cOD_TELEFONE_FKComboBox.Size = new System.Drawing.Size(193, 24);
            this.cOD_TELEFONE_FKComboBox.TabIndex = 5;
            this.cOD_TELEFONE_FKComboBox.ValueMember = "COD_TELEFONE";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(390, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tELEFONEBindingSource
            // 
            this.tELEFONEBindingSource.DataMember = "TELEFONE";
            this.tELEFONEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // tELEFONETableAdapter
            // 
            this.tELEFONETableAdapter.ClearBeforeFill = true;
            // 
            // FrmItensTelefoneFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 493);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(cOD_FUNCIONARIO_FKLabel);
            this.Controls.Add(this.cOD_FUNCIONARIO_FKComboBox);
            this.Controls.Add(cOD_TELEFONE_FKLabel);
            this.Controls.Add(this.cOD_TELEFONE_FKComboBox);
            this.Controls.Add(this.iTENS_TEL_FUNDataGridView);
            this.Controls.Add(this.iTENS_TEL_FUNBindingNavigator);
            this.Name = "FrmItensTelefoneFornecedor";
            this.Text = "FrmItensTelefoneFornecedor";
            this.Load += new System.EventHandler(this.FrmItensTelefoneFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_FUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_FUNBindingNavigator)).EndInit();
            this.iTENS_TEL_FUNBindingNavigator.ResumeLayout(false);
            this.iTENS_TEL_FUNBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_FUNDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource iTENS_TEL_FUNBindingSource;
        private DB_TrabalhoDataSetTableAdapters.ITENS_TEL_FUNTableAdapter iTENS_TEL_FUNTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENS_TEL_FUNBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENS_TEL_FUNBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iTENS_TEL_FUNDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cOD_FUNCIONARIO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_TELEFONE_FKComboBox;
        private DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
    }
}