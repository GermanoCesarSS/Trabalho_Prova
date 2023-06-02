namespace Trabalho_Prova.view
{
    partial class FrmParcelaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcelaVenda));
            System.Windows.Forms.Label cOD_PARCELALabel;
            System.Windows.Forms.Label dATA_VENCIMENTOLabel;
            System.Windows.Forms.Label vALORLabel;
            System.Windows.Forms.Label cOD_SITUACAO_FKLabel;
            System.Windows.Forms.Label cOD_VENDA_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.pARCELAVENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARCELAVENDATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.PARCELAVENDATableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.pARCELAVENDABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pARCELAVENDABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pARCELAVENDADataGridView = new System.Windows.Forms.DataGridView();
            this.cOD_PARCELALabel1 = new System.Windows.Forms.Label();
            this.dATA_VENCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.cOD_SITUACAO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_VENDA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.vENDAPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENDAPRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.VENDAPRODUTOTableAdapter();
            this.sITUACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITUACAOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.SITUACAOTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cOD_PARCELALabel = new System.Windows.Forms.Label();
            dATA_VENCIMENTOLabel = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            cOD_SITUACAO_FKLabel = new System.Windows.Forms.Label();
            cOD_VENDA_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingNavigator)).BeginInit();
            this.pARCELAVENDABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARCELAVENDABindingSource
            // 
            this.pARCELAVENDABindingSource.DataMember = "PARCELAVENDA";
            this.pARCELAVENDABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // pARCELAVENDATableAdapter
            // 
            this.pARCELAVENDATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PARCELAVENDATableAdapter = this.pARCELAVENDATableAdapter;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = this.sITUACAOTableAdapter;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = this.vENDAPRODUTOTableAdapter;
            // 
            // pARCELAVENDABindingNavigator
            // 
            this.pARCELAVENDABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pARCELAVENDABindingNavigator.BindingSource = this.pARCELAVENDABindingSource;
            this.pARCELAVENDABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pARCELAVENDABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pARCELAVENDABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pARCELAVENDABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pARCELAVENDABindingNavigatorSaveItem});
            this.pARCELAVENDABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pARCELAVENDABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pARCELAVENDABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pARCELAVENDABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pARCELAVENDABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pARCELAVENDABindingNavigator.Name = "pARCELAVENDABindingNavigator";
            this.pARCELAVENDABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pARCELAVENDABindingNavigator.Size = new System.Drawing.Size(692, 27);
            this.pARCELAVENDABindingNavigator.TabIndex = 0;
            this.pARCELAVENDABindingNavigator.Text = "bindingNavigator1";
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
            // pARCELAVENDABindingNavigatorSaveItem
            // 
            this.pARCELAVENDABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pARCELAVENDABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pARCELAVENDABindingNavigatorSaveItem.Image")));
            this.pARCELAVENDABindingNavigatorSaveItem.Name = "pARCELAVENDABindingNavigatorSaveItem";
            this.pARCELAVENDABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pARCELAVENDABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pARCELAVENDABindingNavigatorSaveItem.Click += new System.EventHandler(this.pARCELAVENDABindingNavigatorSaveItem_Click);
            // 
            // pARCELAVENDADataGridView
            // 
            this.pARCELAVENDADataGridView.AutoGenerateColumns = false;
            this.pARCELAVENDADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pARCELAVENDADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pARCELAVENDADataGridView.DataSource = this.pARCELAVENDABindingSource;
            this.pARCELAVENDADataGridView.Location = new System.Drawing.Point(12, 256);
            this.pARCELAVENDADataGridView.Name = "pARCELAVENDADataGridView";
            this.pARCELAVENDADataGridView.RowHeadersWidth = 51;
            this.pARCELAVENDADataGridView.RowTemplate.Height = 24;
            this.pARCELAVENDADataGridView.Size = new System.Drawing.Size(660, 220);
            this.pARCELAVENDADataGridView.TabIndex = 1;
            // 
            // cOD_PARCELALabel
            // 
            cOD_PARCELALabel.AutoSize = true;
            cOD_PARCELALabel.Location = new System.Drawing.Point(22, 83);
            cOD_PARCELALabel.Name = "cOD_PARCELALabel";
            cOD_PARCELALabel.Size = new System.Drawing.Size(104, 16);
            cOD_PARCELALabel.TabIndex = 2;
            cOD_PARCELALabel.Text = "COD PARCELA:";
            // 
            // cOD_PARCELALabel1
            // 
            this.cOD_PARCELALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pARCELAVENDABindingSource, "COD_PARCELA", true));
            this.cOD_PARCELALabel1.Location = new System.Drawing.Point(167, 83);
            this.cOD_PARCELALabel1.Name = "cOD_PARCELALabel1";
            this.cOD_PARCELALabel1.Size = new System.Drawing.Size(313, 23);
            this.cOD_PARCELALabel1.TabIndex = 3;
            this.cOD_PARCELALabel1.Text = "label1";
            // 
            // dATA_VENCIMENTOLabel
            // 
            dATA_VENCIMENTOLabel.AutoSize = true;
            dATA_VENCIMENTOLabel.Location = new System.Drawing.Point(22, 113);
            dATA_VENCIMENTOLabel.Name = "dATA_VENCIMENTOLabel";
            dATA_VENCIMENTOLabel.Size = new System.Drawing.Size(139, 16);
            dATA_VENCIMENTOLabel.TabIndex = 4;
            dATA_VENCIMENTOLabel.Text = "DATA VENCIMENTO:";
            // 
            // dATA_VENCIMENTODateTimePicker
            // 
            this.dATA_VENCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pARCELAVENDABindingSource, "DATA_VENCIMENTO", true));
            this.dATA_VENCIMENTODateTimePicker.Location = new System.Drawing.Point(167, 109);
            this.dATA_VENCIMENTODateTimePicker.Name = "dATA_VENCIMENTODateTimePicker";
            this.dATA_VENCIMENTODateTimePicker.Size = new System.Drawing.Size(313, 22);
            this.dATA_VENCIMENTODateTimePicker.TabIndex = 5;
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(22, 140);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(55, 16);
            vALORLabel.TabIndex = 6;
            vALORLabel.Text = "VALOR:";
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pARCELAVENDABindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(167, 137);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(313, 22);
            this.vALORTextBox.TabIndex = 7;
            // 
            // cOD_SITUACAO_FKLabel
            // 
            cOD_SITUACAO_FKLabel.AutoSize = true;
            cOD_SITUACAO_FKLabel.Location = new System.Drawing.Point(22, 168);
            cOD_SITUACAO_FKLabel.Name = "cOD_SITUACAO_FKLabel";
            cOD_SITUACAO_FKLabel.Size = new System.Drawing.Size(129, 16);
            cOD_SITUACAO_FKLabel.TabIndex = 8;
            cOD_SITUACAO_FKLabel.Text = "COD SITUACAO FK:";
            // 
            // cOD_SITUACAO_FKComboBox
            // 
            this.cOD_SITUACAO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pARCELAVENDABindingSource, "COD_SITUACAO_FK", true));
            this.cOD_SITUACAO_FKComboBox.DataSource = this.sITUACAOBindingSource;
            this.cOD_SITUACAO_FKComboBox.DisplayMember = "NOME_SITUACAO";
            this.cOD_SITUACAO_FKComboBox.FormattingEnabled = true;
            this.cOD_SITUACAO_FKComboBox.Location = new System.Drawing.Point(167, 165);
            this.cOD_SITUACAO_FKComboBox.Name = "cOD_SITUACAO_FKComboBox";
            this.cOD_SITUACAO_FKComboBox.Size = new System.Drawing.Size(313, 24);
            this.cOD_SITUACAO_FKComboBox.TabIndex = 9;
            this.cOD_SITUACAO_FKComboBox.ValueMember = "COD_SITUACAO";
            // 
            // cOD_VENDA_FKLabel
            // 
            cOD_VENDA_FKLabel.AutoSize = true;
            cOD_VENDA_FKLabel.Location = new System.Drawing.Point(22, 198);
            cOD_VENDA_FKLabel.Name = "cOD_VENDA_FKLabel";
            cOD_VENDA_FKLabel.Size = new System.Drawing.Size(108, 16);
            cOD_VENDA_FKLabel.TabIndex = 10;
            cOD_VENDA_FKLabel.Text = "COD VENDA FK:";
            // 
            // cOD_VENDA_FKComboBox
            // 
            this.cOD_VENDA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pARCELAVENDABindingSource, "COD_VENDA_FK", true));
            this.cOD_VENDA_FKComboBox.DataSource = this.vENDAPRODUTOBindingSource;
            this.cOD_VENDA_FKComboBox.DisplayMember = "COD_VENDA";
            this.cOD_VENDA_FKComboBox.FormattingEnabled = true;
            this.cOD_VENDA_FKComboBox.Location = new System.Drawing.Point(167, 195);
            this.cOD_VENDA_FKComboBox.Name = "cOD_VENDA_FKComboBox";
            this.cOD_VENDA_FKComboBox.Size = new System.Drawing.Size(313, 24);
            this.cOD_VENDA_FKComboBox.TabIndex = 11;
            this.cOD_VENDA_FKComboBox.ValueMember = "COD_VENDA";
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
            // sITUACAOBindingSource
            // 
            this.sITUACAOBindingSource.DataMember = "SITUACAO";
            this.sITUACAOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // sITUACAOTableAdapter
            // 
            this.sITUACAOTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(536, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(536, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_PARCELA";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_PARCELA";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COD_VENDA_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "COD_VENDA_FK";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // FrmParcelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 496);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(cOD_PARCELALabel);
            this.Controls.Add(this.cOD_PARCELALabel1);
            this.Controls.Add(dATA_VENCIMENTOLabel);
            this.Controls.Add(this.dATA_VENCIMENTODateTimePicker);
            this.Controls.Add(vALORLabel);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(cOD_SITUACAO_FKLabel);
            this.Controls.Add(this.cOD_SITUACAO_FKComboBox);
            this.Controls.Add(cOD_VENDA_FKLabel);
            this.Controls.Add(this.cOD_VENDA_FKComboBox);
            this.Controls.Add(this.pARCELAVENDADataGridView);
            this.Controls.Add(this.pARCELAVENDABindingNavigator);
            this.Name = "FrmParcelaVenda";
            this.Text = "FrmParcelaVenda";
            this.Load += new System.EventHandler(this.FrmParcelaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDABindingNavigator)).EndInit();
            this.pARCELAVENDABindingNavigator.ResumeLayout(false);
            this.pARCELAVENDABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pARCELAVENDADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDAPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource pARCELAVENDABindingSource;
        private DB_TrabalhoDataSetTableAdapters.PARCELAVENDATableAdapter pARCELAVENDATableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pARCELAVENDABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pARCELAVENDABindingNavigatorSaveItem;
        private DB_TrabalhoDataSetTableAdapters.VENDAPRODUTOTableAdapter vENDAPRODUTOTableAdapter;
        private System.Windows.Forms.DataGridView pARCELAVENDADataGridView;
        private System.Windows.Forms.Label cOD_PARCELALabel1;
        private System.Windows.Forms.DateTimePicker dATA_VENCIMENTODateTimePicker;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.ComboBox cOD_SITUACAO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_VENDA_FKComboBox;
        private System.Windows.Forms.BindingSource vENDAPRODUTOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.SITUACAOTableAdapter sITUACAOTableAdapter;
        private System.Windows.Forms.BindingSource sITUACAOBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}