namespace Trabalho_Prova.view
{
    partial class FrmItensCompraProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensCompraProduto));
            System.Windows.Forms.Label cOD_COMPRA_FKLabel;
            System.Windows.Forms.Label cOD_PRODUTO_FKLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.Windows.Forms.Label vALOCLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.iTENS_COMPRA_PRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENS_COMPRA_PRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.ITENS_COMPRA_PRODUTOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.iTENS_COMPRA_PRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iTENS_COMPRA_PRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_COMPRA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_PRODUTO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.vALOCTextBox = new System.Windows.Forms.TextBox();
            this.cOMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRAPRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.COMPRAPRODUTOTableAdapter();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            cOD_COMPRA_FKLabel = new System.Windows.Forms.Label();
            cOD_PRODUTO_FKLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            vALOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_COMPRA_PRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_COMPRA_PRODUTOBindingNavigator)).BeginInit();
            this.iTENS_COMPRA_PRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_COMPRA_PRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENS_COMPRA_PRODUTOBindingSource
            // 
            this.iTENS_COMPRA_PRODUTOBindingSource.DataMember = "ITENS_COMPRA_PRODUTO";
            this.iTENS_COMPRA_PRODUTOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // iTENS_COMPRA_PRODUTOTableAdapter
            // 
            this.iTENS_COMPRA_PRODUTOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FORNECEDORTableAdapter = null;
            this.tableAdapterManager.FUNCAOTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.IMAGENSTableAdapter = null;
            this.tableAdapterManager.ITENS_ACESSOLOGINTableAdapter = null;
            this.tableAdapterManager.ITENS_COMPRA_PRODUTOTableAdapter = this.iTENS_COMPRA_PRODUTOTableAdapter;
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
            this.tableAdapterManager.PRODUTOTableAdapter = this.pRODUTOTableAdapter;
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
            // iTENS_COMPRA_PRODUTOBindingNavigator
            // 
            this.iTENS_COMPRA_PRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.BindingSource = this.iTENS_COMPRA_PRODUTOBindingSource;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iTENS_COMPRA_PRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem});
            this.iTENS_COMPRA_PRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENS_COMPRA_PRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.Name = "iTENS_COMPRA_PRODUTOBindingNavigator";
            this.iTENS_COMPRA_PRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.Size = new System.Drawing.Size(557, 27);
            this.iTENS_COMPRA_PRODUTOBindingNavigator.TabIndex = 0;
            this.iTENS_COMPRA_PRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem
            // 
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem.Image")));
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem.Name = "iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem";
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem_Click);
            // 
            // iTENS_COMPRA_PRODUTODataGridView
            // 
            this.iTENS_COMPRA_PRODUTODataGridView.AutoGenerateColumns = false;
            this.iTENS_COMPRA_PRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENS_COMPRA_PRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.iTENS_COMPRA_PRODUTODataGridView.DataSource = this.iTENS_COMPRA_PRODUTOBindingSource;
            this.iTENS_COMPRA_PRODUTODataGridView.Location = new System.Drawing.Point(12, 283);
            this.iTENS_COMPRA_PRODUTODataGridView.Name = "iTENS_COMPRA_PRODUTODataGridView";
            this.iTENS_COMPRA_PRODUTODataGridView.RowHeadersWidth = 51;
            this.iTENS_COMPRA_PRODUTODataGridView.RowTemplate.Height = 24;
            this.iTENS_COMPRA_PRODUTODataGridView.Size = new System.Drawing.Size(524, 220);
            this.iTENS_COMPRA_PRODUTODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_COMPRA_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_COMPRA_FK";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_PRODUTO_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_PRODUTO_FK";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QUANTIDADE";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOC";
            this.dataGridViewTextBoxColumn4.HeaderText = "VALOC";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // cOD_COMPRA_FKLabel
            // 
            cOD_COMPRA_FKLabel.AutoSize = true;
            cOD_COMPRA_FKLabel.Location = new System.Drawing.Point(34, 100);
            cOD_COMPRA_FKLabel.Name = "cOD_COMPRA_FKLabel";
            cOD_COMPRA_FKLabel.Size = new System.Drawing.Size(119, 16);
            cOD_COMPRA_FKLabel.TabIndex = 2;
            cOD_COMPRA_FKLabel.Text = "COD COMPRA FK:";
            // 
            // cOD_COMPRA_FKComboBox
            // 
            this.cOD_COMPRA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_COMPRA_PRODUTOBindingSource, "COD_COMPRA_FK", true));
            this.cOD_COMPRA_FKComboBox.DataSource = this.cOMPRAPRODUTOBindingSource;
            this.cOD_COMPRA_FKComboBox.DisplayMember = "COD_COMPRA";
            this.cOD_COMPRA_FKComboBox.FormattingEnabled = true;
            this.cOD_COMPRA_FKComboBox.Location = new System.Drawing.Point(169, 97);
            this.cOD_COMPRA_FKComboBox.Name = "cOD_COMPRA_FKComboBox";
            this.cOD_COMPRA_FKComboBox.Size = new System.Drawing.Size(249, 24);
            this.cOD_COMPRA_FKComboBox.TabIndex = 3;
            this.cOD_COMPRA_FKComboBox.ValueMember = "COD_COMPRA";
            // 
            // cOD_PRODUTO_FKLabel
            // 
            cOD_PRODUTO_FKLabel.AutoSize = true;
            cOD_PRODUTO_FKLabel.Location = new System.Drawing.Point(34, 130);
            cOD_PRODUTO_FKLabel.Name = "cOD_PRODUTO_FKLabel";
            cOD_PRODUTO_FKLabel.Size = new System.Drawing.Size(129, 16);
            cOD_PRODUTO_FKLabel.TabIndex = 4;
            cOD_PRODUTO_FKLabel.Text = "COD PRODUTO FK:";
            // 
            // cOD_PRODUTO_FKComboBox
            // 
            this.cOD_PRODUTO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_COMPRA_PRODUTOBindingSource, "COD_PRODUTO_FK", true));
            this.cOD_PRODUTO_FKComboBox.DataSource = this.pRODUTOBindingSource;
            this.cOD_PRODUTO_FKComboBox.DisplayMember = "NOME_PRODUTO";
            this.cOD_PRODUTO_FKComboBox.FormattingEnabled = true;
            this.cOD_PRODUTO_FKComboBox.Location = new System.Drawing.Point(169, 127);
            this.cOD_PRODUTO_FKComboBox.Name = "cOD_PRODUTO_FKComboBox";
            this.cOD_PRODUTO_FKComboBox.Size = new System.Drawing.Size(249, 24);
            this.cOD_PRODUTO_FKComboBox.TabIndex = 5;
            this.cOD_PRODUTO_FKComboBox.ValueMember = "COD_PRODUTO";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(34, 160);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(99, 16);
            qUANTIDADELabel.TabIndex = 6;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENS_COMPRA_PRODUTOBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(169, 157);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(249, 22);
            this.qUANTIDADETextBox.TabIndex = 7;
            // 
            // vALOCLabel
            // 
            vALOCLabel.AutoSize = true;
            vALOCLabel.Location = new System.Drawing.Point(34, 188);
            vALOCLabel.Name = "vALOCLabel";
            vALOCLabel.Size = new System.Drawing.Size(54, 16);
            vALOCLabel.TabIndex = 8;
            vALOCLabel.Text = "VALOC:";
            // 
            // vALOCTextBox
            // 
            this.vALOCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENS_COMPRA_PRODUTOBindingSource, "VALOC", true));
            this.vALOCTextBox.Location = new System.Drawing.Point(169, 185);
            this.vALOCTextBox.Name = "vALOCTextBox";
            this.vALOCTextBox.Size = new System.Drawing.Size(249, 22);
            this.vALOCTextBox.TabIndex = 9;
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
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(439, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(439, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmItensCompraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 525);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(cOD_COMPRA_FKLabel);
            this.Controls.Add(this.cOD_COMPRA_FKComboBox);
            this.Controls.Add(cOD_PRODUTO_FKLabel);
            this.Controls.Add(this.cOD_PRODUTO_FKComboBox);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(vALOCLabel);
            this.Controls.Add(this.vALOCTextBox);
            this.Controls.Add(this.iTENS_COMPRA_PRODUTODataGridView);
            this.Controls.Add(this.iTENS_COMPRA_PRODUTOBindingNavigator);
            this.Name = "FrmItensCompraProduto";
            this.Text = "FrmItensCompraProduto";
            this.Load += new System.EventHandler(this.FrmItensCompraProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_COMPRA_PRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_COMPRA_PRODUTOBindingNavigator)).EndInit();
            this.iTENS_COMPRA_PRODUTOBindingNavigator.ResumeLayout(false);
            this.iTENS_COMPRA_PRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_COMPRA_PRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource iTENS_COMPRA_PRODUTOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.ITENS_COMPRA_PRODUTOTableAdapter iTENS_COMPRA_PRODUTOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENS_COMPRA_PRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENS_COMPRA_PRODUTOBindingNavigatorSaveItem;
        private DB_TrabalhoDataSetTableAdapters.COMPRAPRODUTOTableAdapter cOMPRAPRODUTOTableAdapter;
        private System.Windows.Forms.DataGridView iTENS_COMPRA_PRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cOD_COMPRA_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_PRODUTO_FKComboBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.TextBox vALOCTextBox;
        private System.Windows.Forms.BindingSource cOMPRAPRODUTOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}