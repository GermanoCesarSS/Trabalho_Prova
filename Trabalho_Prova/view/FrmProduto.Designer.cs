namespace Trabalho_Prova.view
{
    partial class FrmProduto
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
            System.Windows.Forms.Label cOD_PRODUTOLabel;
            System.Windows.Forms.Label nOME_PRODUTOLabel;
            System.Windows.Forms.Label qUANTIDADELabel;
            System.Windows.Forms.Label vALORLabel;
            System.Windows.Forms.Label cOD_MARCA_FKLabel;
            System.Windows.Forms.Label cOD_TIPO_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.mARCATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.MARCATableAdapter();
            this.tIPOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TIPOTableAdapter();
            this.pRODUTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pRODUTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.nOME_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.qUANTIDADETextBox = new System.Windows.Forms.TextBox();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.cOD_MARCA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.mARCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_TIPO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.tIPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mARCABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            cOD_PRODUTOLabel = new System.Windows.Forms.Label();
            nOME_PRODUTOLabel = new System.Windows.Forms.Label();
            qUANTIDADELabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            cOD_MARCA_FKLabel = new System.Windows.Forms.Label();
            cOD_TIPO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingNavigator)).BeginInit();
            this.pRODUTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_PRODUTOLabel
            // 
            cOD_PRODUTOLabel.AutoSize = true;
            cOD_PRODUTOLabel.Location = new System.Drawing.Point(12, 47);
            cOD_PRODUTOLabel.Name = "cOD_PRODUTOLabel";
            cOD_PRODUTOLabel.Size = new System.Drawing.Size(110, 16);
            cOD_PRODUTOLabel.TabIndex = 2;
            cOD_PRODUTOLabel.Text = "COD PRODUTO:";
            // 
            // nOME_PRODUTOLabel
            // 
            nOME_PRODUTOLabel.AutoSize = true;
            nOME_PRODUTOLabel.Location = new System.Drawing.Point(12, 75);
            nOME_PRODUTOLabel.Name = "nOME_PRODUTOLabel";
            nOME_PRODUTOLabel.Size = new System.Drawing.Size(121, 16);
            nOME_PRODUTOLabel.TabIndex = 4;
            nOME_PRODUTOLabel.Text = "NOME PRODUTO:";
            // 
            // qUANTIDADELabel
            // 
            qUANTIDADELabel.AutoSize = true;
            qUANTIDADELabel.Location = new System.Drawing.Point(12, 103);
            qUANTIDADELabel.Name = "qUANTIDADELabel";
            qUANTIDADELabel.Size = new System.Drawing.Size(99, 16);
            qUANTIDADELabel.TabIndex = 6;
            qUANTIDADELabel.Text = "QUANTIDADE:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(12, 131);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(55, 16);
            vALORLabel.TabIndex = 8;
            vALORLabel.Text = "VALOR:";
            // 
            // cOD_MARCA_FKLabel
            // 
            cOD_MARCA_FKLabel.AutoSize = true;
            cOD_MARCA_FKLabel.Location = new System.Drawing.Point(12, 159);
            cOD_MARCA_FKLabel.Name = "cOD_MARCA_FKLabel";
            cOD_MARCA_FKLabel.Size = new System.Drawing.Size(109, 16);
            cOD_MARCA_FKLabel.TabIndex = 10;
            cOD_MARCA_FKLabel.Text = "COD MARCA FK:";
            // 
            // cOD_TIPO_FKLabel
            // 
            cOD_TIPO_FKLabel.AutoSize = true;
            cOD_TIPO_FKLabel.Location = new System.Drawing.Point(12, 189);
            cOD_TIPO_FKLabel.Name = "cOD_TIPO_FKLabel";
            cOD_TIPO_FKLabel.Size = new System.Drawing.Size(92, 16);
            cOD_TIPO_FKLabel.TabIndex = 12;
            cOD_TIPO_FKLabel.Text = "COD TIPO FK:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.MARCATableAdapter = this.mARCATableAdapter;
            this.tableAdapterManager.OPERADORATableAdapter = null;
            this.tableAdapterManager.PARCELACOMPRATableAdapter = null;
            this.tableAdapterManager.PARCELAVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = this.pRODUTOTableAdapter;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = this.tIPOTableAdapter;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // mARCATableAdapter
            // 
            this.mARCATableAdapter.ClearBeforeFill = true;
            // 
            // tIPOTableAdapter
            // 
            this.tIPOTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUTOBindingNavigator
            // 
            this.pRODUTOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pRODUTOBindingNavigator.BindingSource = this.pRODUTOBindingSource;
            this.pRODUTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pRODUTOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pRODUTOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pRODUTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pRODUTOBindingNavigatorSaveItem});
            this.pRODUTOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pRODUTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pRODUTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pRODUTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pRODUTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pRODUTOBindingNavigator.Name = "pRODUTOBindingNavigator";
            this.pRODUTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pRODUTOBindingNavigator.Size = new System.Drawing.Size(571, 27);
            this.pRODUTOBindingNavigator.TabIndex = 0;
            this.pRODUTOBindingNavigator.Text = "bindingNavigator1";
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
            // pRODUTOBindingNavigatorSaveItem
            // 
            this.pRODUTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pRODUTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRODUTOBindingNavigatorSaveItem.Image")));
            this.pRODUTOBindingNavigatorSaveItem.Name = "pRODUTOBindingNavigatorSaveItem";
            this.pRODUTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pRODUTOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pRODUTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.pRODUTOBindingNavigatorSaveItem_Click);
            // 
            // pRODUTODataGridView
            // 
            this.pRODUTODataGridView.AutoGenerateColumns = false;
            this.pRODUTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pRODUTODataGridView.DataSource = this.pRODUTOBindingSource;
            this.pRODUTODataGridView.Location = new System.Drawing.Point(0, 251);
            this.pRODUTODataGridView.Name = "pRODUTODataGridView";
            this.pRODUTODataGridView.RowHeadersWidth = 51;
            this.pRODUTODataGridView.RowTemplate.Height = 24;
            this.pRODUTODataGridView.Size = new System.Drawing.Size(551, 271);
            this.pRODUTODataGridView.TabIndex = 1;
            this.pRODUTODataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pRODUTODataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_PRODUTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_PRODUTO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PRODUTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_PRODUTO";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COD_MARCA_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "COD_MARCA_FK";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "COD_TIPO_FK";
            this.dataGridViewTextBoxColumn6.HeaderText = "COD_TIPO_FK";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // cOD_PRODUTOTextBox
            // 
            this.cOD_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "COD_PRODUTO", true));
            this.cOD_PRODUTOTextBox.Location = new System.Drawing.Point(139, 44);
            this.cOD_PRODUTOTextBox.Name = "cOD_PRODUTOTextBox";
            this.cOD_PRODUTOTextBox.Size = new System.Drawing.Size(202, 22);
            this.cOD_PRODUTOTextBox.TabIndex = 3;
            // 
            // nOME_PRODUTOTextBox
            // 
            this.nOME_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "NOME_PRODUTO", true));
            this.nOME_PRODUTOTextBox.Location = new System.Drawing.Point(139, 72);
            this.nOME_PRODUTOTextBox.Name = "nOME_PRODUTOTextBox";
            this.nOME_PRODUTOTextBox.Size = new System.Drawing.Size(202, 22);
            this.nOME_PRODUTOTextBox.TabIndex = 5;
            // 
            // qUANTIDADETextBox
            // 
            this.qUANTIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "QUANTIDADE", true));
            this.qUANTIDADETextBox.Location = new System.Drawing.Point(139, 100);
            this.qUANTIDADETextBox.Name = "qUANTIDADETextBox";
            this.qUANTIDADETextBox.Size = new System.Drawing.Size(202, 22);
            this.qUANTIDADETextBox.TabIndex = 7;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUTOBindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(139, 128);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(202, 22);
            this.vALORTextBox.TabIndex = 9;
            // 
            // cOD_MARCA_FKComboBox
            // 
            this.cOD_MARCA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUTOBindingSource, "COD_MARCA_FK", true));
            this.cOD_MARCA_FKComboBox.DataSource = this.mARCABindingSource1;
            this.cOD_MARCA_FKComboBox.DisplayMember = "NOME_MARCA";
            this.cOD_MARCA_FKComboBox.FormattingEnabled = true;
            this.cOD_MARCA_FKComboBox.Location = new System.Drawing.Point(139, 156);
            this.cOD_MARCA_FKComboBox.Name = "cOD_MARCA_FKComboBox";
            this.cOD_MARCA_FKComboBox.Size = new System.Drawing.Size(202, 24);
            this.cOD_MARCA_FKComboBox.TabIndex = 11;
            this.cOD_MARCA_FKComboBox.ValueMember = "COD_MARCA";
            // 
            // mARCABindingSource
            // 
            this.mARCABindingSource.DataMember = "MARCA";
            this.mARCABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_TIPO_FKComboBox
            // 
            this.cOD_TIPO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUTOBindingSource, "COD_TIPO_FK", true));
            this.cOD_TIPO_FKComboBox.DataSource = this.tIPOBindingSource1;
            this.cOD_TIPO_FKComboBox.DisplayMember = "NOME_TIPO";
            this.cOD_TIPO_FKComboBox.FormattingEnabled = true;
            this.cOD_TIPO_FKComboBox.Location = new System.Drawing.Point(139, 186);
            this.cOD_TIPO_FKComboBox.Name = "cOD_TIPO_FKComboBox";
            this.cOD_TIPO_FKComboBox.Size = new System.Drawing.Size(202, 24);
            this.cOD_TIPO_FKComboBox.TabIndex = 13;
            this.cOD_TIPO_FKComboBox.ValueMember = "COD_TIPO";
            // 
            // tIPOBindingSource
            // 
            this.tIPOBindingSource.DataMember = "TIPO";
            this.tIPOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mARCABindingSource1
            // 
            this.mARCABindingSource1.DataMember = "MARCA";
            this.mARCABindingSource1.DataSource = this.dB_TrabalhoDataSet;
            // 
            // tIPOBindingSource1
            // 
            this.tIPOBindingSource1.DataMember = "TIPO";
            this.tIPOBindingSource1.DataSource = this.dB_TrabalhoDataSet;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 542);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cOD_PRODUTOLabel);
            this.Controls.Add(this.cOD_PRODUTOTextBox);
            this.Controls.Add(nOME_PRODUTOLabel);
            this.Controls.Add(this.nOME_PRODUTOTextBox);
            this.Controls.Add(qUANTIDADELabel);
            this.Controls.Add(this.qUANTIDADETextBox);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(cOD_MARCA_FKLabel);
            this.Controls.Add(this.cOD_MARCA_FKComboBox);
            this.Controls.Add(cOD_TIPO_FKLabel);
            this.Controls.Add(this.cOD_TIPO_FKComboBox);
            this.Controls.Add(this.pRODUTODataGridView);
            this.Controls.Add(this.pRODUTOBindingNavigator);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingNavigator)).EndInit();
            this.pRODUTOBindingNavigator.ResumeLayout(false);
            this.pRODUTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pRODUTOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pRODUTOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pRODUTODataGridView;
        private DB_TrabalhoDataSetTableAdapters.MARCATableAdapter mARCATableAdapter;
        private System.Windows.Forms.TextBox cOD_PRODUTOTextBox;
        private System.Windows.Forms.TextBox nOME_PRODUTOTextBox;
        private System.Windows.Forms.TextBox qUANTIDADETextBox;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.ComboBox cOD_MARCA_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_TIPO_FKComboBox;
        private System.Windows.Forms.BindingSource mARCABindingSource;
        private DB_TrabalhoDataSetTableAdapters.TIPOTableAdapter tIPOTableAdapter;
        private System.Windows.Forms.BindingSource tIPOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mARCABindingSource1;
        private System.Windows.Forms.BindingSource tIPOBindingSource1;
    }
}