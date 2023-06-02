namespace Trabalho_Prova.view
{
    partial class CompraProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraProduto));
            System.Windows.Forms.Label cOD_COMPRALabel;
            System.Windows.Forms.Label dATA_COMPRALabel;
            System.Windows.Forms.Label cOD_FORNECEDOR_FKLabel;
            System.Windows.Forms.Label cOD_FUNCIONARIO_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.cOMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRAPRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.COMPRAPRODUTOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.fORNECEDORTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FORNECEDORTableAdapter();
            this.fUNCIONARIOSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            this.cOMPRAPRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cOMPRAPRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cOMPRAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cOD_COMPRALabel1 = new System.Windows.Forms.Label();
            this.dATA_COMPRADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cOD_FORNECEDOR_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_FUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.fORNECEDORBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            cOD_COMPRALabel = new System.Windows.Forms.Label();
            dATA_COMPRALabel = new System.Windows.Forms.Label();
            cOD_FORNECEDOR_FKLabel = new System.Windows.Forms.Label();
            cOD_FUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingNavigator)).BeginInit();
            this.cOMPRAPRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRAPRODUTOBindingSource
            // 
            this.cOMPRAPRODUTOBindingSource.DataMember = "COMPRAPRODUTO";
            this.cOMPRAPRODUTOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOMPRAPRODUTOTableAdapter
            // 
            this.cOMPRAPRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.COMPRAPRODUTOTableAdapter = this.cOMPRAPRODUTOTableAdapter;
            this.tableAdapterManager.CONTROLE_LOGSISTEMATableAdapter = null;
            this.tableAdapterManager.FORNECEDORTableAdapter = this.fORNECEDORTableAdapter;
            this.tableAdapterManager.FUNCAOTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = this.fUNCIONARIOSTableAdapter;
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
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // fORNECEDORTableAdapter
            // 
            this.fORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPRAPRODUTOBindingNavigator
            // 
            this.cOMPRAPRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cOMPRAPRODUTOBindingNavigator.BindingSource = this.cOMPRAPRODUTOBindingSource;
            this.cOMPRAPRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cOMPRAPRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cOMPRAPRODUTOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cOMPRAPRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cOMPRAPRODUTOBindingNavigatorSaveItem});
            this.cOMPRAPRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cOMPRAPRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cOMPRAPRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cOMPRAPRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cOMPRAPRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cOMPRAPRODUTOBindingNavigator.Name = "cOMPRAPRODUTOBindingNavigator";
            this.cOMPRAPRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cOMPRAPRODUTOBindingNavigator.Size = new System.Drawing.Size(572, 27);
            this.cOMPRAPRODUTOBindingNavigator.TabIndex = 0;
            this.cOMPRAPRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cOMPRAPRODUTOBindingNavigatorSaveItem
            // 
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cOMPRAPRODUTOBindingNavigatorSaveItem.Image")));
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Name = "cOMPRAPRODUTOBindingNavigatorSaveItem";
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cOMPRAPRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.cOMPRAPRODUTOBindingNavigatorSaveItem_Click);
            // 
            // cOMPRAPRODUTODataGridView
            // 
            this.cOMPRAPRODUTODataGridView.AutoGenerateColumns = false;
            this.cOMPRAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cOMPRAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cOMPRAPRODUTODataGridView.DataSource = this.cOMPRAPRODUTOBindingSource;
            this.cOMPRAPRODUTODataGridView.Location = new System.Drawing.Point(12, 235);
            this.cOMPRAPRODUTODataGridView.Name = "cOMPRAPRODUTODataGridView";
            this.cOMPRAPRODUTODataGridView.RowHeadersWidth = 51;
            this.cOMPRAPRODUTODataGridView.RowTemplate.Height = 24;
            this.cOMPRAPRODUTODataGridView.Size = new System.Drawing.Size(540, 220);
            this.cOMPRAPRODUTODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_COMPRA";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_COMPRA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATA_COMPRA";
            this.dataGridViewTextBoxColumn2.HeaderText = "DATA_COMPRA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COD_FORNECEDOR_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "COD_FORNECEDOR_FK";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COD_FUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "COD_FUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // fORNECEDORBindingSource
            // 
            this.fORNECEDORBindingSource.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(461, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(461, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cOD_COMPRALabel
            // 
            cOD_COMPRALabel.AutoSize = true;
            cOD_COMPRALabel.Location = new System.Drawing.Point(22, 83);
            cOD_COMPRALabel.Name = "cOD_COMPRALabel";
            cOD_COMPRALabel.Size = new System.Drawing.Size(100, 16);
            cOD_COMPRALabel.TabIndex = 34;
            cOD_COMPRALabel.Text = "COD COMPRA:";
            // 
            // cOD_COMPRALabel1
            // 
            this.cOD_COMPRALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOMPRAPRODUTOBindingSource, "COD_COMPRA", true));
            this.cOD_COMPRALabel1.Location = new System.Drawing.Point(184, 83);
            this.cOD_COMPRALabel1.Name = "cOD_COMPRALabel1";
            this.cOD_COMPRALabel1.Size = new System.Drawing.Size(253, 23);
            this.cOD_COMPRALabel1.TabIndex = 35;
            this.cOD_COMPRALabel1.Text = "label1";
            // 
            // dATA_COMPRALabel
            // 
            dATA_COMPRALabel.AutoSize = true;
            dATA_COMPRALabel.Location = new System.Drawing.Point(22, 113);
            dATA_COMPRALabel.Name = "dATA_COMPRALabel";
            dATA_COMPRALabel.Size = new System.Drawing.Size(108, 16);
            dATA_COMPRALabel.TabIndex = 36;
            dATA_COMPRALabel.Text = "DATA COMPRA:";
            // 
            // dATA_COMPRADateTimePicker
            // 
            this.dATA_COMPRADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cOMPRAPRODUTOBindingSource, "DATA_COMPRA", true));
            this.dATA_COMPRADateTimePicker.Location = new System.Drawing.Point(184, 109);
            this.dATA_COMPRADateTimePicker.Name = "dATA_COMPRADateTimePicker";
            this.dATA_COMPRADateTimePicker.Size = new System.Drawing.Size(253, 22);
            this.dATA_COMPRADateTimePicker.TabIndex = 37;
            // 
            // cOD_FORNECEDOR_FKLabel
            // 
            cOD_FORNECEDOR_FKLabel.AutoSize = true;
            cOD_FORNECEDOR_FKLabel.Location = new System.Drawing.Point(22, 140);
            cOD_FORNECEDOR_FKLabel.Name = "cOD_FORNECEDOR_FKLabel";
            cOD_FORNECEDOR_FKLabel.Size = new System.Drawing.Size(156, 16);
            cOD_FORNECEDOR_FKLabel.TabIndex = 38;
            cOD_FORNECEDOR_FKLabel.Text = "COD FORNECEDOR FK:";
            // 
            // cOD_FORNECEDOR_FKComboBox
            // 
            this.cOD_FORNECEDOR_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cOMPRAPRODUTOBindingSource, "COD_FORNECEDOR_FK", true));
            this.cOD_FORNECEDOR_FKComboBox.DataSource = this.fORNECEDORBindingSource1;
            this.cOD_FORNECEDOR_FKComboBox.DisplayMember = "NOME_FORNECEDOR";
            this.cOD_FORNECEDOR_FKComboBox.FormattingEnabled = true;
            this.cOD_FORNECEDOR_FKComboBox.Location = new System.Drawing.Point(184, 137);
            this.cOD_FORNECEDOR_FKComboBox.Name = "cOD_FORNECEDOR_FKComboBox";
            this.cOD_FORNECEDOR_FKComboBox.Size = new System.Drawing.Size(253, 24);
            this.cOD_FORNECEDOR_FKComboBox.TabIndex = 39;
            this.cOD_FORNECEDOR_FKComboBox.ValueMember = "COD_FORNECEDOR";
            // 
            // cOD_FUNCIONARIO_FKLabel
            // 
            cOD_FUNCIONARIO_FKLabel.AutoSize = true;
            cOD_FUNCIONARIO_FKLabel.Location = new System.Drawing.Point(22, 170);
            cOD_FUNCIONARIO_FKLabel.Name = "cOD_FUNCIONARIO_FKLabel";
            cOD_FUNCIONARIO_FKLabel.Size = new System.Drawing.Size(153, 16);
            cOD_FUNCIONARIO_FKLabel.TabIndex = 40;
            cOD_FUNCIONARIO_FKLabel.Text = "COD FUNCIONARIO FK:";
            // 
            // cOD_FUNCIONARIO_FKComboBox
            // 
            this.cOD_FUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cOMPRAPRODUTOBindingSource, "COD_FUNCIONARIO_FK", true));
            this.cOD_FUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource1;
            this.cOD_FUNCIONARIO_FKComboBox.DisplayMember = "NOME_FUNCIONARIO";
            this.cOD_FUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cOD_FUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(184, 167);
            this.cOD_FUNCIONARIO_FKComboBox.Name = "cOD_FUNCIONARIO_FKComboBox";
            this.cOD_FUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(253, 24);
            this.cOD_FUNCIONARIO_FKComboBox.TabIndex = 41;
            this.cOD_FUNCIONARIO_FKComboBox.ValueMember = "COD_FUNCIONARIO";
            // 
            // fORNECEDORBindingSource1
            // 
            this.fORNECEDORBindingSource1.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource1.DataSource = this.dB_TrabalhoDataSet;
            // 
            // fUNCIONARIOSBindingSource1
            // 
            this.fUNCIONARIOSBindingSource1.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource1.DataSource = this.dB_TrabalhoDataSet;
            // 
            // CompraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 475);
            this.Controls.Add(cOD_COMPRALabel);
            this.Controls.Add(this.cOD_COMPRALabel1);
            this.Controls.Add(dATA_COMPRALabel);
            this.Controls.Add(this.dATA_COMPRADateTimePicker);
            this.Controls.Add(cOD_FORNECEDOR_FKLabel);
            this.Controls.Add(this.cOD_FORNECEDOR_FKComboBox);
            this.Controls.Add(cOD_FUNCIONARIO_FKLabel);
            this.Controls.Add(this.cOD_FUNCIONARIO_FKComboBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cOMPRAPRODUTODataGridView);
            this.Controls.Add(this.cOMPRAPRODUTOBindingNavigator);
            this.Name = "CompraProduto";
            this.Text = "CompraProduto";
            this.Load += new System.EventHandler(this.CompraProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingNavigator)).EndInit();
            this.cOMPRAPRODUTOBindingNavigator.ResumeLayout(false);
            this.cOMPRAPRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource cOMPRAPRODUTOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.COMPRAPRODUTOTableAdapter cOMPRAPRODUTOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cOMPRAPRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cOMPRAPRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cOMPRAPRODUTODataGridView;
        private DB_TrabalhoDataSetTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label cOD_COMPRALabel1;
        private System.Windows.Forms.DateTimePicker dATA_COMPRADateTimePicker;
        private System.Windows.Forms.ComboBox cOD_FORNECEDOR_FKComboBox;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource1;
        private System.Windows.Forms.ComboBox cOD_FUNCIONARIO_FKComboBox;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource1;
    }
}