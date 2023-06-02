namespace Trabalho_Prova.view
{
    partial class FrmVendaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendaProduto));
            System.Windows.Forms.Label cOD_VENDALabel;
            System.Windows.Forms.Label dATAVENDALabel;
            System.Windows.Forms.Label cOD_CLIENTE_FKLabel;
            System.Windows.Forms.Label cOD_FUNCIONARIO_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.vENDAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDAPRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.VENDAPRODUTOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.vENDAPRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vENDAPRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vENDAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_VENDALabel1 = new System.Windows.Forms.Label();
            this.dATAVENDADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cOD_CLIENTE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_FUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CLIENTETableAdapter();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            cOD_VENDALabel = new System.Windows.Forms.Label();
            dATAVENDALabel = new System.Windows.Forms.Label();
            cOD_CLIENTE_FKLabel = new System.Windows.Forms.Label();
            cOD_FUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingNavigator)).BeginInit();
            this.vENDAPRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENDAPRODUTOBindingSource
            // 
            this.vENDAPRODUTOBindingSource.DataMember = "VENDAPRODUTO";
            this.vENDAPRODUTOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // vENDAPRODUTOTableAdapter
            // 
            this.vENDAPRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = this.cLIENTETableAdapter;
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
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = this.vENDAPRODUTOTableAdapter;
            // 
            // vENDAPRODUTOBindingNavigator
            // 
            this.vENDAPRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vENDAPRODUTOBindingNavigator.BindingSource = this.vENDAPRODUTOBindingSource;
            this.vENDAPRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vENDAPRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vENDAPRODUTOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vENDAPRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vENDAPRODUTOBindingNavigatorSaveItem});
            this.vENDAPRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vENDAPRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vENDAPRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vENDAPRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vENDAPRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vENDAPRODUTOBindingNavigator.Name = "vENDAPRODUTOBindingNavigator";
            this.vENDAPRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vENDAPRODUTOBindingNavigator.Size = new System.Drawing.Size(558, 27);
            this.vENDAPRODUTOBindingNavigator.TabIndex = 0;
            this.vENDAPRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // vENDAPRODUTOBindingNavigatorSaveItem
            // 
            this.vENDAPRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vENDAPRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vENDAPRODUTOBindingNavigatorSaveItem.Image")));
            this.vENDAPRODUTOBindingNavigatorSaveItem.Name = "vENDAPRODUTOBindingNavigatorSaveItem";
            this.vENDAPRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.vENDAPRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.vENDAPRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.vENDAPRODUTOBindingNavigatorSaveItem_Click);
            // 
            // vENDAPRODUTODataGridView
            // 
            this.vENDAPRODUTODataGridView.AutoGenerateColumns = false;
            this.vENDAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vENDAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vENDAPRODUTODataGridView.DataSource = this.vENDAPRODUTOBindingSource;
            this.vENDAPRODUTODataGridView.Location = new System.Drawing.Point(12, 218);
            this.vENDAPRODUTODataGridView.Name = "vENDAPRODUTODataGridView";
            this.vENDAPRODUTODataGridView.RowHeadersWidth = 51;
            this.vENDAPRODUTODataGridView.RowTemplate.Height = 24;
            this.vENDAPRODUTODataGridView.Size = new System.Drawing.Size(526, 220);
            this.vENDAPRODUTODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_VENDA";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_VENDA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATAVENDA";
            this.dataGridViewTextBoxColumn2.HeaderText = "DATAVENDA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COD_CLIENTE_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "COD_CLIENTE_FK";
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
            // cOD_VENDALabel
            // 
            cOD_VENDALabel.AutoSize = true;
            cOD_VENDALabel.Location = new System.Drawing.Point(12, 74);
            cOD_VENDALabel.Name = "cOD_VENDALabel";
            cOD_VENDALabel.Size = new System.Drawing.Size(89, 16);
            cOD_VENDALabel.TabIndex = 2;
            cOD_VENDALabel.Text = "COD VENDA:";
            // 
            // cOD_VENDALabel1
            // 
            this.cOD_VENDALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDAPRODUTOBindingSource, "COD_VENDA", true));
            this.cOD_VENDALabel1.Location = new System.Drawing.Point(171, 74);
            this.cOD_VENDALabel1.Name = "cOD_VENDALabel1";
            this.cOD_VENDALabel1.Size = new System.Drawing.Size(258, 23);
            this.cOD_VENDALabel1.TabIndex = 3;
            this.cOD_VENDALabel1.Text = "label1";
            // 
            // dATAVENDALabel
            // 
            dATAVENDALabel.AutoSize = true;
            dATAVENDALabel.Location = new System.Drawing.Point(12, 104);
            dATAVENDALabel.Name = "dATAVENDALabel";
            dATAVENDALabel.Size = new System.Drawing.Size(94, 16);
            dATAVENDALabel.TabIndex = 4;
            dATAVENDALabel.Text = "DATAVENDA:";
            // 
            // dATAVENDADateTimePicker
            // 
            this.dATAVENDADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vENDAPRODUTOBindingSource, "DATAVENDA", true));
            this.dATAVENDADateTimePicker.Location = new System.Drawing.Point(171, 100);
            this.dATAVENDADateTimePicker.Name = "dATAVENDADateTimePicker";
            this.dATAVENDADateTimePicker.Size = new System.Drawing.Size(258, 22);
            this.dATAVENDADateTimePicker.TabIndex = 5;
            // 
            // cOD_CLIENTE_FKLabel
            // 
            cOD_CLIENTE_FKLabel.AutoSize = true;
            cOD_CLIENTE_FKLabel.Location = new System.Drawing.Point(12, 131);
            cOD_CLIENTE_FKLabel.Name = "cOD_CLIENTE_FKLabel";
            cOD_CLIENTE_FKLabel.Size = new System.Drawing.Size(117, 16);
            cOD_CLIENTE_FKLabel.TabIndex = 6;
            cOD_CLIENTE_FKLabel.Text = "COD CLIENTE FK:";
            // 
            // cOD_CLIENTE_FKComboBox
            // 
            this.cOD_CLIENTE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vENDAPRODUTOBindingSource, "COD_CLIENTE_FK", true));
            this.cOD_CLIENTE_FKComboBox.DataSource = this.cLIENTEBindingSource;
            this.cOD_CLIENTE_FKComboBox.DisplayMember = "NOME_CLIENTE";
            this.cOD_CLIENTE_FKComboBox.FormattingEnabled = true;
            this.cOD_CLIENTE_FKComboBox.Location = new System.Drawing.Point(171, 128);
            this.cOD_CLIENTE_FKComboBox.Name = "cOD_CLIENTE_FKComboBox";
            this.cOD_CLIENTE_FKComboBox.Size = new System.Drawing.Size(258, 24);
            this.cOD_CLIENTE_FKComboBox.TabIndex = 7;
            this.cOD_CLIENTE_FKComboBox.ValueMember = "COD_CLIENTE";
            // 
            // cOD_FUNCIONARIO_FKLabel
            // 
            cOD_FUNCIONARIO_FKLabel.AutoSize = true;
            cOD_FUNCIONARIO_FKLabel.Location = new System.Drawing.Point(12, 161);
            cOD_FUNCIONARIO_FKLabel.Name = "cOD_FUNCIONARIO_FKLabel";
            cOD_FUNCIONARIO_FKLabel.Size = new System.Drawing.Size(153, 16);
            cOD_FUNCIONARIO_FKLabel.TabIndex = 8;
            cOD_FUNCIONARIO_FKLabel.Text = "COD FUNCIONARIO FK:";
            // 
            // cOD_FUNCIONARIO_FKComboBox
            // 
            this.cOD_FUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vENDAPRODUTOBindingSource, "COD_FUNCIONARIO_FK", true));
            this.cOD_FUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource;
            this.cOD_FUNCIONARIO_FKComboBox.DisplayMember = "NOME_FUNCIONARIO";
            this.cOD_FUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cOD_FUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(171, 158);
            this.cOD_FUNCIONARIO_FKComboBox.Name = "cOD_FUNCIONARIO_FKComboBox";
            this.cOD_FUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(258, 24);
            this.cOD_FUNCIONARIO_FKComboBox.TabIndex = 9;
            this.cOD_FUNCIONARIO_FKComboBox.ValueMember = "COD_FUNCIONARIO";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(447, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 458);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(cOD_VENDALabel);
            this.Controls.Add(this.cOD_VENDALabel1);
            this.Controls.Add(dATAVENDALabel);
            this.Controls.Add(this.dATAVENDADateTimePicker);
            this.Controls.Add(cOD_CLIENTE_FKLabel);
            this.Controls.Add(this.cOD_CLIENTE_FKComboBox);
            this.Controls.Add(cOD_FUNCIONARIO_FKLabel);
            this.Controls.Add(this.cOD_FUNCIONARIO_FKComboBox);
            this.Controls.Add(this.vENDAPRODUTODataGridView);
            this.Controls.Add(this.vENDAPRODUTOBindingNavigator);
            this.Name = "FrmVendaProduto";
            this.Text = "FrmVendaProduto";
            this.Load += new System.EventHandler(this.FrmVendaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingNavigator)).EndInit();
            this.vENDAPRODUTOBindingNavigator.ResumeLayout(false);
            this.vENDAPRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource vENDAPRODUTOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.VENDAPRODUTOTableAdapter vENDAPRODUTOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vENDAPRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vENDAPRODUTOBindingNavigatorSaveItem;
        private DB_TrabalhoDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridView vENDAPRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label cOD_VENDALabel1;
        private System.Windows.Forms.DateTimePicker dATAVENDADateTimePicker;
        private System.Windows.Forms.ComboBox cOD_CLIENTE_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_FUNCIONARIO_FKComboBox;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}