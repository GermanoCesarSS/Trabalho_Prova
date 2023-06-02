namespace Trabalho_Prova.view
{
    partial class FrmItensVendaProduto
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
            System.Windows.Forms.Label cOD_VENDA_FKLabel;
            System.Windows.Forms.Label cOD_PRODUTO_FKLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.Windows.Forms.Label vALORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensVendaProduto));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.iTENS_VENDAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENS_VENDAPRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.ITENS_VENDAPRODUTOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.pRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter();
            this.iTENS_VENDAPRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iTENS_VENDAPRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_VENDA_FKLabel1 = new System.Windows.Forms.Label();
            this.cOD_PRODUTO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            cOD_VENDA_FKLabel = new System.Windows.Forms.Label();
            cOD_PRODUTO_FKLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_VENDAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_VENDAPRODUTOBindingNavigator)).BeginInit();
            this.iTENS_VENDAPRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_VENDAPRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_VENDA_FKLabel
            // 
            cOD_VENDA_FKLabel.AutoSize = true;
            cOD_VENDA_FKLabel.Location = new System.Drawing.Point(12, 103);
            cOD_VENDA_FKLabel.Name = "cOD_VENDA_FKLabel";
            cOD_VENDA_FKLabel.Size = new System.Drawing.Size(108, 16);
            cOD_VENDA_FKLabel.TabIndex = 2;
            cOD_VENDA_FKLabel.Text = "COD VENDA FK:";
            // 
            // cOD_PRODUTO_FKLabel
            // 
            cOD_PRODUTO_FKLabel.AutoSize = true;
            cOD_PRODUTO_FKLabel.Location = new System.Drawing.Point(12, 132);
            cOD_PRODUTO_FKLabel.Name = "cOD_PRODUTO_FKLabel";
            cOD_PRODUTO_FKLabel.Size = new System.Drawing.Size(129, 16);
            cOD_PRODUTO_FKLabel.TabIndex = 4;
            cOD_PRODUTO_FKLabel.Text = "COD PRODUTO FK:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(12, 162);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(99, 16);
            qUANTIDADELabel.TabIndex = 6;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(12, 190);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(55, 16);
            vALORLabel.TabIndex = 8;
            vALORLabel.Text = "VALOR:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENS_VENDAPRODUTOBindingSource
            // 
            this.iTENS_VENDAPRODUTOBindingSource.DataMember = "ITENS_VENDAPRODUTO";
            this.iTENS_VENDAPRODUTOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // iTENS_VENDAPRODUTOTableAdapter
            // 
            this.iTENS_VENDAPRODUTOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENS_VENDAPRODUTOTableAdapter = this.iTENS_VENDAPRODUTOTableAdapter;
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
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // iTENS_VENDAPRODUTOBindingNavigator
            // 
            this.iTENS_VENDAPRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.BindingSource = this.iTENS_VENDAPRODUTOBindingSource;
            this.iTENS_VENDAPRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iTENS_VENDAPRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem});
            this.iTENS_VENDAPRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENS_VENDAPRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.Name = "iTENS_VENDAPRODUTOBindingNavigator";
            this.iTENS_VENDAPRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENS_VENDAPRODUTOBindingNavigator.Size = new System.Drawing.Size(588, 31);
            this.iTENS_VENDAPRODUTOBindingNavigator.TabIndex = 0;
            this.iTENS_VENDAPRODUTOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // iTENS_VENDAPRODUTOBindingNavigatorSaveItem
            // 
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENS_VENDAPRODUTOBindingNavigatorSaveItem.Image")));
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem.Name = "iTENS_VENDAPRODUTOBindingNavigatorSaveItem";
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENS_VENDAPRODUTOBindingNavigatorSaveItem_Click);
            // 
            // iTENS_VENDAPRODUTODataGridView
            // 
            this.iTENS_VENDAPRODUTODataGridView.AutoGenerateColumns = false;
            this.iTENS_VENDAPRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENS_VENDAPRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.iTENS_VENDAPRODUTODataGridView.DataSource = this.iTENS_VENDAPRODUTOBindingSource;
            this.iTENS_VENDAPRODUTODataGridView.Location = new System.Drawing.Point(12, 249);
            this.iTENS_VENDAPRODUTODataGridView.Name = "iTENS_VENDAPRODUTODataGridView";
            this.iTENS_VENDAPRODUTODataGridView.RowHeadersWidth = 51;
            this.iTENS_VENDAPRODUTODataGridView.RowTemplate.Height = 24;
            this.iTENS_VENDAPRODUTODataGridView.Size = new System.Drawing.Size(556, 220);
            this.iTENS_VENDAPRODUTODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_VENDA_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_VENDA_FK";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOR";
            this.dataGridViewTextBoxColumn4.HeaderText = "VALOR";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // cOD_VENDA_FKLabel1
            // 
            this.cOD_VENDA_FKLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENS_VENDAPRODUTOBindingSource, "COD_VENDA_FK", true));
            this.cOD_VENDA_FKLabel1.Location = new System.Drawing.Point(147, 103);
            this.cOD_VENDA_FKLabel1.Name = "cOD_VENDA_FKLabel1";
            this.cOD_VENDA_FKLabel1.Size = new System.Drawing.Size(305, 23);
            this.cOD_VENDA_FKLabel1.TabIndex = 3;
            this.cOD_VENDA_FKLabel1.Text = "label1";
            // 
            // cOD_PRODUTO_FKComboBox
            // 
            this.cOD_PRODUTO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_VENDAPRODUTOBindingSource, "COD_PRODUTO_FK", true));
            this.cOD_PRODUTO_FKComboBox.DataSource = this.pRODUTOBindingSource;
            this.cOD_PRODUTO_FKComboBox.DisplayMember = "NOME_PRODUTO";
            this.cOD_PRODUTO_FKComboBox.FormattingEnabled = true;
            this.cOD_PRODUTO_FKComboBox.Location = new System.Drawing.Point(147, 129);
            this.cOD_PRODUTO_FKComboBox.Name = "cOD_PRODUTO_FKComboBox";
            this.cOD_PRODUTO_FKComboBox.Size = new System.Drawing.Size(305, 24);
            this.cOD_PRODUTO_FKComboBox.TabIndex = 5;
            this.cOD_PRODUTO_FKComboBox.ValueMember = "COD_PRODUTO";
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENS_VENDAPRODUTOBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(147, 159);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(305, 22);
            this.qUANTIDADETextBox.TabIndex = 7;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENS_VENDAPRODUTOBindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(147, 187);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(305, 22);
            this.vALORTextBox.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(470, 129);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(368, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // FrmItensVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 489);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(cOD_VENDA_FKLabel);
            this.Controls.Add(this.cOD_VENDA_FKLabel1);
            this.Controls.Add(cOD_PRODUTO_FKLabel);
            this.Controls.Add(this.cOD_PRODUTO_FKComboBox);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(this.iTENS_VENDAPRODUTODataGridView);
            this.Controls.Add(this.iTENS_VENDAPRODUTOBindingNavigator);
            this.Name = "FrmItensVendaProduto";
            this.Text = "FrmItensVendaProduto";
            this.Load += new System.EventHandler(this.FrmItensVendaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_VENDAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_VENDAPRODUTOBindingNavigator)).EndInit();
            this.iTENS_VENDAPRODUTOBindingNavigator.ResumeLayout(false);
            this.iTENS_VENDAPRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_VENDAPRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource iTENS_VENDAPRODUTOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.ITENS_VENDAPRODUTOTableAdapter iTENS_VENDAPRODUTOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENS_VENDAPRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENS_VENDAPRODUTOBindingNavigatorSaveItem;
        private DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.DataGridView iTENS_VENDAPRODUTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label cOD_VENDA_FKLabel1;
        private System.Windows.Forms.ComboBox cOD_PRODUTO_FKComboBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}