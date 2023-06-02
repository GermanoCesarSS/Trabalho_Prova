namespace Trabalho_Prova.view
{
    partial class FrmParcelaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcelaCompra));
            System.Windows.Forms.Label cOD_PARCELACOMPRALabel;
            System.Windows.Forms.Label dATA_VENCIMENTOLabel;
            System.Windows.Forms.Label vALORLabel;
            System.Windows.Forms.Label cOD_SITUACAO_FKLabel;
            System.Windows.Forms.Label cOD_COMPRA_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.pARCELACOMPRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARCELACOMPRATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.PARCELACOMPRATableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.pARCELACOMPRABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pARCELACOMPRABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pARCELACOMPRADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_PARCELACOMPRALabel1 = new System.Windows.Forms.Label();
            this.dATA_VENCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.cOD_SITUACAO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_COMPRA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sITUACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITUACAOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.SITUACAOTableAdapter();
            this.cOMPRAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPRAPRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.COMPRAPRODUTOTableAdapter();
            this.cOMPRAPRODUTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            cOD_PARCELACOMPRALabel = new System.Windows.Forms.Label();
            dATA_VENCIMENTOLabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            cOD_SITUACAO_FKLabel = new System.Windows.Forms.Label();
            cOD_COMPRA_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELACOMPRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELACOMPRABindingNavigator)).BeginInit();
            this.pARCELACOMPRABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELACOMPRADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARCELACOMPRABindingSource
            // 
            this.pARCELACOMPRABindingSource.DataMember = "PARCELACOMPRA";
            this.pARCELACOMPRABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // pARCELACOMPRATableAdapter
            // 
            this.pARCELACOMPRATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PARCELACOMPRATableAdapter = this.pARCELACOMPRATableAdapter;
            this.tableAdapterManager.PARCELAVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = this.sITUACAOTableAdapter;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // pARCELACOMPRABindingNavigator
            // 
            this.pARCELACOMPRABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pARCELACOMPRABindingNavigator.BindingSource = this.pARCELACOMPRABindingSource;
            this.pARCELACOMPRABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pARCELACOMPRABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pARCELACOMPRABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pARCELACOMPRABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pARCELACOMPRABindingNavigatorSaveItem});
            this.pARCELACOMPRABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pARCELACOMPRABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pARCELACOMPRABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pARCELACOMPRABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pARCELACOMPRABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pARCELACOMPRABindingNavigator.Name = "pARCELACOMPRABindingNavigator";
            this.pARCELACOMPRABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pARCELACOMPRABindingNavigator.Size = new System.Drawing.Size(566, 27);
            this.pARCELACOMPRABindingNavigator.TabIndex = 0;
            this.pARCELACOMPRABindingNavigator.Text = "bindingNavigator1";
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
            // pARCELACOMPRABindingNavigatorSaveItem
            // 
            this.pARCELACOMPRABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pARCELACOMPRABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pARCELACOMPRABindingNavigatorSaveItem.Image")));
            this.pARCELACOMPRABindingNavigatorSaveItem.Name = "pARCELACOMPRABindingNavigatorSaveItem";
            this.pARCELACOMPRABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pARCELACOMPRABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pARCELACOMPRABindingNavigatorSaveItem.Click += new System.EventHandler(this.pARCELACOMPRABindingNavigatorSaveItem_Click);
            // 
            // pARCELACOMPRADataGridView
            // 
            this.pARCELACOMPRADataGridView.AutoGenerateColumns = false;
            this.pARCELACOMPRADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pARCELACOMPRADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pARCELACOMPRADataGridView.DataSource = this.pARCELACOMPRABindingSource;
            this.pARCELACOMPRADataGridView.Location = new System.Drawing.Point(12, 218);
            this.pARCELACOMPRADataGridView.Name = "pARCELACOMPRADataGridView";
            this.pARCELACOMPRADataGridView.RowHeadersWidth = 51;
            this.pARCELACOMPRADataGridView.RowTemplate.Height = 24;
            this.pARCELACOMPRADataGridView.Size = new System.Drawing.Size(534, 220);
            this.pARCELACOMPRADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_PARCELACOMPRA";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_PARCELACOMPRA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATA_VENCIMENTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "DATA_VENCIMENTO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VALOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "VALOR";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COD_SITUACAO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "COD_SITUACAO_FK";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COD_COMPRA_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "COD_COMPRA_FK";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // cOD_PARCELACOMPRALabel
            // 
            cOD_PARCELACOMPRALabel.AutoSize = true;
            cOD_PARCELACOMPRALabel.Location = new System.Drawing.Point(12, 51);
            cOD_PARCELACOMPRALabel.Name = "cOD_PARCELACOMPRALabel";
            cOD_PARCELACOMPRALabel.Size = new System.Drawing.Size(162, 16);
            cOD_PARCELACOMPRALabel.TabIndex = 2;
            cOD_PARCELACOMPRALabel.Text = "COD PARCELACOMPRA:";
            // 
            // cOD_PARCELACOMPRALabel1
            // 
            this.cOD_PARCELACOMPRALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pARCELACOMPRABindingSource, "COD_PARCELACOMPRA", true));
            this.cOD_PARCELACOMPRALabel1.Location = new System.Drawing.Point(180, 51);
            this.cOD_PARCELACOMPRALabel1.Name = "cOD_PARCELACOMPRALabel1";
            this.cOD_PARCELACOMPRALabel1.Size = new System.Drawing.Size(269, 23);
            this.cOD_PARCELACOMPRALabel1.TabIndex = 3;
            this.cOD_PARCELACOMPRALabel1.Text = "label1";
            // 
            // dATA_VENCIMENTOLabel
            // 
            dATA_VENCIMENTOLabel.AutoSize = true;
            dATA_VENCIMENTOLabel.Location = new System.Drawing.Point(12, 81);
            dATA_VENCIMENTOLabel.Name = "dATA_VENCIMENTOLabel";
            dATA_VENCIMENTOLabel.Size = new System.Drawing.Size(139, 16);
            dATA_VENCIMENTOLabel.TabIndex = 4;
            dATA_VENCIMENTOLabel.Text = "DATA VENCIMENTO:";
            // 
            // dATA_VENCIMENTODateTimePicker
            // 
            this.dATA_VENCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pARCELACOMPRABindingSource, "DATA_VENCIMENTO", true));
            this.dATA_VENCIMENTODateTimePicker.Location = new System.Drawing.Point(180, 77);
            this.dATA_VENCIMENTODateTimePicker.Name = "dATA_VENCIMENTODateTimePicker";
            this.dATA_VENCIMENTODateTimePicker.Size = new System.Drawing.Size(269, 22);
            this.dATA_VENCIMENTODateTimePicker.TabIndex = 5;
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(12, 108);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(55, 16);
            vALORLabel.TabIndex = 6;
            vALORLabel.Text = "VALOR:";
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pARCELACOMPRABindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(180, 105);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(269, 22);
            this.vALORTextBox.TabIndex = 7;
            // 
            // cOD_SITUACAO_FKLabel
            // 
            cOD_SITUACAO_FKLabel.AutoSize = true;
            cOD_SITUACAO_FKLabel.Location = new System.Drawing.Point(12, 136);
            cOD_SITUACAO_FKLabel.Name = "cOD_SITUACAO_FKLabel";
            cOD_SITUACAO_FKLabel.Size = new System.Drawing.Size(129, 16);
            cOD_SITUACAO_FKLabel.TabIndex = 8;
            cOD_SITUACAO_FKLabel.Text = "COD SITUACAO FK:";
            // 
            // cOD_SITUACAO_FKComboBox
            // 
            this.cOD_SITUACAO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pARCELACOMPRABindingSource, "COD_SITUACAO_FK", true));
            this.cOD_SITUACAO_FKComboBox.DataSource = this.sITUACAOBindingSource;
            this.cOD_SITUACAO_FKComboBox.DisplayMember = "NOME_SITUACAO";
            this.cOD_SITUACAO_FKComboBox.FormattingEnabled = true;
            this.cOD_SITUACAO_FKComboBox.Location = new System.Drawing.Point(180, 133);
            this.cOD_SITUACAO_FKComboBox.Name = "cOD_SITUACAO_FKComboBox";
            this.cOD_SITUACAO_FKComboBox.Size = new System.Drawing.Size(269, 24);
            this.cOD_SITUACAO_FKComboBox.TabIndex = 9;
            this.cOD_SITUACAO_FKComboBox.ValueMember = "COD_SITUACAO";
            // 
            // cOD_COMPRA_FKLabel
            // 
            cOD_COMPRA_FKLabel.AutoSize = true;
            cOD_COMPRA_FKLabel.Location = new System.Drawing.Point(12, 166);
            cOD_COMPRA_FKLabel.Name = "cOD_COMPRA_FKLabel";
            cOD_COMPRA_FKLabel.Size = new System.Drawing.Size(119, 16);
            cOD_COMPRA_FKLabel.TabIndex = 10;
            cOD_COMPRA_FKLabel.Text = "COD COMPRA FK:";
            // 
            // cOD_COMPRA_FKComboBox
            // 
            this.cOD_COMPRA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pARCELACOMPRABindingSource, "COD_COMPRA_FK", true));
            this.cOD_COMPRA_FKComboBox.DataSource = this.cOMPRAPRODUTOBindingSource1;
            this.cOD_COMPRA_FKComboBox.DisplayMember = "COD_COMPRA";
            this.cOD_COMPRA_FKComboBox.FormattingEnabled = true;
            this.cOD_COMPRA_FKComboBox.Location = new System.Drawing.Point(180, 163);
            this.cOD_COMPRA_FKComboBox.Name = "cOD_COMPRA_FKComboBox";
            this.cOD_COMPRA_FKComboBox.Size = new System.Drawing.Size(269, 24);
            this.cOD_COMPRA_FKComboBox.TabIndex = 11;
            this.cOD_COMPRA_FKComboBox.ValueMember = "COD_COMPRA";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(471, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(471, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sITUACAOBindingSource
            // 
            this.sITUACAOBindingSource.DataMember = "SITUACAO";
            this.sITUACAOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // sITUACAOTableAdapter
            // 
            this.sITUACAOTableAdapter.ClearBeforeFill = true;
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
            // cOMPRAPRODUTOBindingSource1
            // 
            this.cOMPRAPRODUTOBindingSource1.DataMember = "COMPRAPRODUTO";
            this.cOMPRAPRODUTOBindingSource1.DataSource = this.dB_TrabalhoDataSet;
            // 
            // FrmParcelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 458);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(cOD_PARCELACOMPRALabel);
            this.Controls.Add(this.cOD_PARCELACOMPRALabel1);
            this.Controls.Add(dATA_VENCIMENTOLabel);
            this.Controls.Add(this.dATA_VENCIMENTODateTimePicker);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(cOD_SITUACAO_FKLabel);
            this.Controls.Add(this.cOD_SITUACAO_FKComboBox);
            this.Controls.Add(cOD_COMPRA_FKLabel);
            this.Controls.Add(this.cOD_COMPRA_FKComboBox);
            this.Controls.Add(this.pARCELACOMPRADataGridView);
            this.Controls.Add(this.pARCELACOMPRABindingNavigator);
            this.Name = "FrmParcelaCompra";
            this.Text = "FrmParcelaCompra";
            this.Load += new System.EventHandler(this.FrmParcelaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELACOMPRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELACOMPRABindingNavigator)).EndInit();
            this.pARCELACOMPRABindingNavigator.ResumeLayout(false);
            this.pARCELACOMPRABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELACOMPRADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRAPRODUTOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource pARCELACOMPRABindingSource;
        private DB_TrabalhoDataSetTableAdapters.PARCELACOMPRATableAdapter pARCELACOMPRATableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pARCELACOMPRABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pARCELACOMPRABindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pARCELACOMPRADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label cOD_PARCELACOMPRALabel1;
        private System.Windows.Forms.DateTimePicker dATA_VENCIMENTODateTimePicker;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.ComboBox cOD_SITUACAO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_COMPRA_FKComboBox;
        private DB_TrabalhoDataSetTableAdapters.SITUACAOTableAdapter sITUACAOTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource sITUACAOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.COMPRAPRODUTOTableAdapter cOMPRAPRODUTOTableAdapter;
        private System.Windows.Forms.BindingSource cOMPRAPRODUTOBindingSource;
        private System.Windows.Forms.BindingSource cOMPRAPRODUTOBindingSource1;
    }
}