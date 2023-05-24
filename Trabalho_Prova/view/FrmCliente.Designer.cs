namespace Trabalho_Prova.view
{
    partial class FrmCliente
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
            System.Windows.Forms.Label cOD_CLIENTELabel;
            System.Windows.Forms.Label nOME_CLIENTELabel;
            System.Windows.Forms.Label fOTO_CLIENTELabel;
            System.Windows.Forms.Label dATANASC_CLIENTELabel;
            System.Windows.Forms.Label cOD_SEXO_FKLabel;
            System.Windows.Forms.Label cOD_RUA_FKLabel;
            System.Windows.Forms.Label cOD_BAIRRO_FKLabel;
            System.Windows.Forms.Label cOD_CEP_FKLabel;
            System.Windows.Forms.Label cOD_CIDADE_FKLabel;
            System.Windows.Forms.Label cOD_TRABALHO_FKLabel;
            System.Windows.Forms.Label sALARIO_CLIENTELabel;
            System.Windows.Forms.Label nUMEROCASALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CLIENTETableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.bAIRROTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.BAIRROTableAdapter();
            this.rUATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.RUATableAdapter();
            this.sEXOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.SEXOTableAdapter();
            this.cLIENTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cLIENTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cOD_CLIENTELabel1 = new System.Windows.Forms.Label();
            this.nOME_CLIENTETextBox = new System.Windows.Forms.TextBox();
            this.fOTO_CLIENTEPictureBox = new System.Windows.Forms.PictureBox();
            this.dATANASC_CLIENTEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cOD_SEXO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.sEXOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_RUA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.rUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_BAIRRO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.bAIRROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_CEP_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_CIDADE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_TRABALHO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.sALARIO_CLIENTETextBox = new System.Windows.Forms.TextBox();
            this.nUMEROCASATextBox = new System.Windows.Forms.TextBox();
            this.cLIENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CEPTableAdapter();
            this.cIDADETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CIDADETableAdapter();
            this.tRABALHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRABALHOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TRABALHOTableAdapter();
            cOD_CLIENTELabel = new System.Windows.Forms.Label();
            nOME_CLIENTELabel = new System.Windows.Forms.Label();
            fOTO_CLIENTELabel = new System.Windows.Forms.Label();
            dATANASC_CLIENTELabel = new System.Windows.Forms.Label();
            cOD_SEXO_FKLabel = new System.Windows.Forms.Label();
            cOD_RUA_FKLabel = new System.Windows.Forms.Label();
            cOD_BAIRRO_FKLabel = new System.Windows.Forms.Label();
            cOD_CEP_FKLabel = new System.Windows.Forms.Label();
            cOD_CIDADE_FKLabel = new System.Windows.Forms.Label();
            cOD_TRABALHO_FKLabel = new System.Windows.Forms.Label();
            sALARIO_CLIENTELabel = new System.Windows.Forms.Label();
            nUMEROCASALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingNavigator)).BeginInit();
            this.cLIENTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOTO_CLIENTEPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_CLIENTELabel
            // 
            cOD_CLIENTELabel.AutoSize = true;
            cOD_CLIENTELabel.Location = new System.Drawing.Point(21, 68);
            cOD_CLIENTELabel.Name = "cOD_CLIENTELabel";
            cOD_CLIENTELabel.Size = new System.Drawing.Size(98, 16);
            cOD_CLIENTELabel.TabIndex = 1;
            cOD_CLIENTELabel.Text = "COD CLIENTE:";
            // 
            // nOME_CLIENTELabel
            // 
            nOME_CLIENTELabel.AutoSize = true;
            nOME_CLIENTELabel.Location = new System.Drawing.Point(21, 97);
            nOME_CLIENTELabel.Name = "nOME_CLIENTELabel";
            nOME_CLIENTELabel.Size = new System.Drawing.Size(109, 16);
            nOME_CLIENTELabel.TabIndex = 3;
            nOME_CLIENTELabel.Text = "NOME CLIENTE:";
            // 
            // fOTO_CLIENTELabel
            // 
            fOTO_CLIENTELabel.AutoSize = true;
            fOTO_CLIENTELabel.Location = new System.Drawing.Point(21, 122);
            fOTO_CLIENTELabel.Name = "fOTO_CLIENTELabel";
            fOTO_CLIENTELabel.Size = new System.Drawing.Size(106, 16);
            fOTO_CLIENTELabel.TabIndex = 5;
            fOTO_CLIENTELabel.Text = "FOTO CLIENTE:";
            // 
            // dATANASC_CLIENTELabel
            // 
            dATANASC_CLIENTELabel.AutoSize = true;
            dATANASC_CLIENTELabel.Location = new System.Drawing.Point(21, 182);
            dATANASC_CLIENTELabel.Name = "dATANASC_CLIENTELabel";
            dATANASC_CLIENTELabel.Size = new System.Drawing.Size(143, 16);
            dATANASC_CLIENTELabel.TabIndex = 7;
            dATANASC_CLIENTELabel.Text = "DATANASC CLIENTE:";
            // 
            // cOD_SEXO_FKLabel
            // 
            cOD_SEXO_FKLabel.AutoSize = true;
            cOD_SEXO_FKLabel.Location = new System.Drawing.Point(21, 209);
            cOD_SEXO_FKLabel.Name = "cOD_SEXO_FKLabel";
            cOD_SEXO_FKLabel.Size = new System.Drawing.Size(97, 16);
            cOD_SEXO_FKLabel.TabIndex = 9;
            cOD_SEXO_FKLabel.Text = "COD SEXO FK:";
            // 
            // cOD_RUA_FKLabel
            // 
            cOD_RUA_FKLabel.AutoSize = true;
            cOD_RUA_FKLabel.Location = new System.Drawing.Point(21, 239);
            cOD_RUA_FKLabel.Name = "cOD_RUA_FKLabel";
            cOD_RUA_FKLabel.Size = new System.Drawing.Size(90, 16);
            cOD_RUA_FKLabel.TabIndex = 11;
            cOD_RUA_FKLabel.Text = "COD RUA FK:";
            // 
            // cOD_BAIRRO_FKLabel
            // 
            cOD_BAIRRO_FKLabel.AutoSize = true;
            cOD_BAIRRO_FKLabel.Location = new System.Drawing.Point(21, 269);
            cOD_BAIRRO_FKLabel.Name = "cOD_BAIRRO_FKLabel";
            cOD_BAIRRO_FKLabel.Size = new System.Drawing.Size(112, 16);
            cOD_BAIRRO_FKLabel.TabIndex = 13;
            cOD_BAIRRO_FKLabel.Text = "COD BAIRRO FK:";
            // 
            // cOD_CEP_FKLabel
            // 
            cOD_CEP_FKLabel.AutoSize = true;
            cOD_CEP_FKLabel.Location = new System.Drawing.Point(21, 299);
            cOD_CEP_FKLabel.Name = "cOD_CEP_FKLabel";
            cOD_CEP_FKLabel.Size = new System.Drawing.Size(88, 16);
            cOD_CEP_FKLabel.TabIndex = 15;
            cOD_CEP_FKLabel.Text = "COD CEP FK:";
            // 
            // cOD_CIDADE_FKLabel
            // 
            cOD_CIDADE_FKLabel.AutoSize = true;
            cOD_CIDADE_FKLabel.Location = new System.Drawing.Point(21, 329);
            cOD_CIDADE_FKLabel.Name = "cOD_CIDADE_FKLabel";
            cOD_CIDADE_FKLabel.Size = new System.Drawing.Size(111, 16);
            cOD_CIDADE_FKLabel.TabIndex = 17;
            cOD_CIDADE_FKLabel.Text = "COD CIDADE FK:";
            // 
            // cOD_TRABALHO_FKLabel
            // 
            cOD_TRABALHO_FKLabel.AutoSize = true;
            cOD_TRABALHO_FKLabel.Location = new System.Drawing.Point(21, 359);
            cOD_TRABALHO_FKLabel.Name = "cOD_TRABALHO_FKLabel";
            cOD_TRABALHO_FKLabel.Size = new System.Drawing.Size(134, 16);
            cOD_TRABALHO_FKLabel.TabIndex = 19;
            cOD_TRABALHO_FKLabel.Text = "COD TRABALHO FK:";
            // 
            // sALARIO_CLIENTELabel
            // 
            sALARIO_CLIENTELabel.AutoSize = true;
            sALARIO_CLIENTELabel.Location = new System.Drawing.Point(21, 389);
            sALARIO_CLIENTELabel.Name = "sALARIO_CLIENTELabel";
            sALARIO_CLIENTELabel.Size = new System.Drawing.Size(126, 16);
            sALARIO_CLIENTELabel.TabIndex = 21;
            sALARIO_CLIENTELabel.Text = "SALARIO CLIENTE:";
            // 
            // nUMEROCASALabel
            // 
            nUMEROCASALabel.AutoSize = true;
            nUMEROCASALabel.Location = new System.Drawing.Point(21, 417);
            nUMEROCASALabel.Name = "nUMEROCASALabel";
            nUMEROCASALabel.Size = new System.Drawing.Size(106, 16);
            nUMEROCASALabel.TabIndex = 23;
            nUMEROCASALabel.Text = "NUMEROCASA:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = this.bAIRROTableAdapter;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = this.cLIENTETableAdapter;
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
            this.tableAdapterManager.RUATableAdapter = this.rUATableAdapter;
            this.tableAdapterManager.SEXOTableAdapter = this.sEXOTableAdapter;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // bAIRROTableAdapter
            // 
            this.bAIRROTableAdapter.ClearBeforeFill = true;
            // 
            // rUATableAdapter
            // 
            this.rUATableAdapter.ClearBeforeFill = true;
            // 
            // sEXOTableAdapter
            // 
            this.sEXOTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTEBindingNavigator
            // 
            this.cLIENTEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTEBindingNavigator.BindingSource = this.cLIENTEBindingSource;
            this.cLIENTEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cLIENTEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cLIENTEBindingNavigatorSaveItem});
            this.cLIENTEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLIENTEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTEBindingNavigator.Name = "cLIENTEBindingNavigator";
            this.cLIENTEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTEBindingNavigator.Size = new System.Drawing.Size(823, 27);
            this.cLIENTEBindingNavigator.TabIndex = 0;
            this.cLIENTEBindingNavigator.Text = "bindingNavigator1";
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
            // cLIENTEBindingNavigatorSaveItem
            // 
            this.cLIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTEBindingNavigatorSaveItem.Image")));
            this.cLIENTEBindingNavigatorSaveItem.Name = "cLIENTEBindingNavigatorSaveItem";
            this.cLIENTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cLIENTEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cLIENTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTEBindingNavigatorSaveItem_Click);
            // 
            // cOD_CLIENTELabel1
            // 
            this.cOD_CLIENTELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "COD_CLIENTE", true));
            this.cOD_CLIENTELabel1.Location = new System.Drawing.Point(170, 68);
            this.cOD_CLIENTELabel1.Name = "cOD_CLIENTELabel1";
            this.cOD_CLIENTELabel1.Size = new System.Drawing.Size(200, 23);
            this.cOD_CLIENTELabel1.TabIndex = 2;
            this.cOD_CLIENTELabel1.Text = "label1";
            // 
            // nOME_CLIENTETextBox
            // 
            this.nOME_CLIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "NOME_CLIENTE", true));
            this.nOME_CLIENTETextBox.Location = new System.Drawing.Point(170, 94);
            this.nOME_CLIENTETextBox.Name = "nOME_CLIENTETextBox";
            this.nOME_CLIENTETextBox.Size = new System.Drawing.Size(200, 22);
            this.nOME_CLIENTETextBox.TabIndex = 4;
            // 
            // fOTO_CLIENTEPictureBox
            // 
            this.fOTO_CLIENTEPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cLIENTEBindingSource, "FOTO_CLIENTE", true));
            this.fOTO_CLIENTEPictureBox.Location = new System.Drawing.Point(170, 122);
            this.fOTO_CLIENTEPictureBox.Name = "fOTO_CLIENTEPictureBox";
            this.fOTO_CLIENTEPictureBox.Size = new System.Drawing.Size(200, 50);
            this.fOTO_CLIENTEPictureBox.TabIndex = 6;
            this.fOTO_CLIENTEPictureBox.TabStop = false;
            // 
            // dATANASC_CLIENTEDateTimePicker
            // 
            this.dATANASC_CLIENTEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cLIENTEBindingSource, "DATANASC_CLIENTE", true));
            this.dATANASC_CLIENTEDateTimePicker.Location = new System.Drawing.Point(170, 178);
            this.dATANASC_CLIENTEDateTimePicker.Name = "dATANASC_CLIENTEDateTimePicker";
            this.dATANASC_CLIENTEDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dATANASC_CLIENTEDateTimePicker.TabIndex = 8;
            // 
            // cOD_SEXO_FKComboBox
            // 
            this.cOD_SEXO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "COD_SEXO_FK", true));
            this.cOD_SEXO_FKComboBox.DataSource = this.sEXOBindingSource;
            this.cOD_SEXO_FKComboBox.DisplayMember = "NOME_SEXO";
            this.cOD_SEXO_FKComboBox.FormattingEnabled = true;
            this.cOD_SEXO_FKComboBox.Location = new System.Drawing.Point(170, 206);
            this.cOD_SEXO_FKComboBox.Name = "cOD_SEXO_FKComboBox";
            this.cOD_SEXO_FKComboBox.Size = new System.Drawing.Size(200, 24);
            this.cOD_SEXO_FKComboBox.TabIndex = 10;
            this.cOD_SEXO_FKComboBox.ValueMember = "COD_SEXO";
            // 
            // sEXOBindingSource
            // 
            this.sEXOBindingSource.DataMember = "SEXO";
            this.sEXOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_RUA_FKComboBox
            // 
            this.cOD_RUA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "COD_RUA_FK", true));
            this.cOD_RUA_FKComboBox.DataSource = this.rUABindingSource;
            this.cOD_RUA_FKComboBox.DisplayMember = "NOME_RUA";
            this.cOD_RUA_FKComboBox.FormattingEnabled = true;
            this.cOD_RUA_FKComboBox.Location = new System.Drawing.Point(170, 236);
            this.cOD_RUA_FKComboBox.Name = "cOD_RUA_FKComboBox";
            this.cOD_RUA_FKComboBox.Size = new System.Drawing.Size(200, 24);
            this.cOD_RUA_FKComboBox.TabIndex = 12;
            this.cOD_RUA_FKComboBox.ValueMember = "COD_RUA";
            // 
            // rUABindingSource
            // 
            this.rUABindingSource.DataMember = "RUA";
            this.rUABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_BAIRRO_FKComboBox
            // 
            this.cOD_BAIRRO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "COD_BAIRRO_FK", true));
            this.cOD_BAIRRO_FKComboBox.DataSource = this.bAIRROBindingSource;
            this.cOD_BAIRRO_FKComboBox.DisplayMember = "NOME_BAIRRO";
            this.cOD_BAIRRO_FKComboBox.FormattingEnabled = true;
            this.cOD_BAIRRO_FKComboBox.Location = new System.Drawing.Point(170, 266);
            this.cOD_BAIRRO_FKComboBox.Name = "cOD_BAIRRO_FKComboBox";
            this.cOD_BAIRRO_FKComboBox.Size = new System.Drawing.Size(200, 24);
            this.cOD_BAIRRO_FKComboBox.TabIndex = 14;
            this.cOD_BAIRRO_FKComboBox.ValueMember = "COD_BAIRRO";
            // 
            // bAIRROBindingSource
            // 
            this.bAIRROBindingSource.DataMember = "BAIRRO";
            this.bAIRROBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_CEP_FKComboBox
            // 
            this.cOD_CEP_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "COD_CEP_FK", true));
            this.cOD_CEP_FKComboBox.DataSource = this.cEPBindingSource;
            this.cOD_CEP_FKComboBox.DisplayMember = "NUMERO_CEP";
            this.cOD_CEP_FKComboBox.FormattingEnabled = true;
            this.cOD_CEP_FKComboBox.Location = new System.Drawing.Point(170, 296);
            this.cOD_CEP_FKComboBox.Name = "cOD_CEP_FKComboBox";
            this.cOD_CEP_FKComboBox.Size = new System.Drawing.Size(200, 24);
            this.cOD_CEP_FKComboBox.TabIndex = 16;
            this.cOD_CEP_FKComboBox.ValueMember = "COD_CEP";
            // 
            // cEPBindingSource
            // 
            this.cEPBindingSource.DataMember = "CEP";
            this.cEPBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_CIDADE_FKComboBox
            // 
            this.cOD_CIDADE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "COD_CIDADE_FK", true));
            this.cOD_CIDADE_FKComboBox.DataSource = this.cIDADEBindingSource;
            this.cOD_CIDADE_FKComboBox.DisplayMember = "NOME_CIDADE";
            this.cOD_CIDADE_FKComboBox.FormattingEnabled = true;
            this.cOD_CIDADE_FKComboBox.Location = new System.Drawing.Point(170, 326);
            this.cOD_CIDADE_FKComboBox.Name = "cOD_CIDADE_FKComboBox";
            this.cOD_CIDADE_FKComboBox.Size = new System.Drawing.Size(200, 24);
            this.cOD_CIDADE_FKComboBox.TabIndex = 18;
            this.cOD_CIDADE_FKComboBox.ValueMember = "COD_CIDADE";
            // 
            // cIDADEBindingSource
            // 
            this.cIDADEBindingSource.DataMember = "CIDADE";
            this.cIDADEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_TRABALHO_FKComboBox
            // 
            this.cOD_TRABALHO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "COD_TRABALHO_FK", true));
            this.cOD_TRABALHO_FKComboBox.DataSource = this.tRABALHOBindingSource;
            this.cOD_TRABALHO_FKComboBox.DisplayMember = "NOME_TRABALHO";
            this.cOD_TRABALHO_FKComboBox.FormattingEnabled = true;
            this.cOD_TRABALHO_FKComboBox.Location = new System.Drawing.Point(170, 356);
            this.cOD_TRABALHO_FKComboBox.Name = "cOD_TRABALHO_FKComboBox";
            this.cOD_TRABALHO_FKComboBox.Size = new System.Drawing.Size(200, 24);
            this.cOD_TRABALHO_FKComboBox.TabIndex = 20;
            this.cOD_TRABALHO_FKComboBox.ValueMember = "COD_TRABALHO";
            // 
            // sALARIO_CLIENTETextBox
            // 
            this.sALARIO_CLIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "SALARIO_CLIENTE", true));
            this.sALARIO_CLIENTETextBox.Location = new System.Drawing.Point(170, 386);
            this.sALARIO_CLIENTETextBox.Name = "sALARIO_CLIENTETextBox";
            this.sALARIO_CLIENTETextBox.Size = new System.Drawing.Size(200, 22);
            this.sALARIO_CLIENTETextBox.TabIndex = 22;
            // 
            // nUMEROCASATextBox
            // 
            this.nUMEROCASATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "NUMEROCASA", true));
            this.nUMEROCASATextBox.Location = new System.Drawing.Point(170, 414);
            this.nUMEROCASATextBox.Name = "nUMEROCASATextBox";
            this.nUMEROCASATextBox.Size = new System.Drawing.Size(200, 22);
            this.nUMEROCASATextBox.TabIndex = 24;
            // 
            // cLIENTEDataGridView
            // 
            this.cLIENTEDataGridView.AutoGenerateColumns = false;
            this.cLIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.cLIENTEDataGridView.DataSource = this.cLIENTEBindingSource;
            this.cLIENTEDataGridView.Location = new System.Drawing.Point(388, 0);
            this.cLIENTEDataGridView.Name = "cLIENTEDataGridView";
            this.cLIENTEDataGridView.RowHeadersWidth = 51;
            this.cLIENTEDataGridView.RowTemplate.Height = 24;
            this.cLIENTEDataGridView.Size = new System.Drawing.Size(432, 461);
            this.cLIENTEDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_CLIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_CLIENTE";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CLIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_CLIENTE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "FOTO_CLIENTE";
            this.dataGridViewImageColumn1.HeaderText = "FOTO_CLIENTE";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATANASC_CLIENTE";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATANASC_CLIENTE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COD_SEXO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "COD_SEXO_FK";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COD_RUA_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "COD_RUA_FK";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "COD_BAIRRO_FK";
            this.dataGridViewTextBoxColumn6.HeaderText = "COD_BAIRRO_FK";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "COD_CEP_FK";
            this.dataGridViewTextBoxColumn7.HeaderText = "COD_CEP_FK";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "COD_CIDADE_FK";
            this.dataGridViewTextBoxColumn8.HeaderText = "COD_CIDADE_FK";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "COD_TRABALHO_FK";
            this.dataGridViewTextBoxColumn9.HeaderText = "COD_TRABALHO_FK";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SALARIO_CLIENTE";
            this.dataGridViewTextBoxColumn10.HeaderText = "SALARIO_CLIENTE";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NUMEROCASA";
            this.dataGridViewTextBoxColumn11.HeaderText = "NUMEROCASA";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // cEPTableAdapter
            // 
            this.cEPTableAdapter.ClearBeforeFill = true;
            // 
            // cIDADETableAdapter
            // 
            this.cIDADETableAdapter.ClearBeforeFill = true;
            // 
            // tRABALHOBindingSource
            // 
            this.tRABALHOBindingSource.DataMember = "TRABALHO";
            this.tRABALHOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // tRABALHOTableAdapter
            // 
            this.tRABALHOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 461);
            this.Controls.Add(this.cLIENTEDataGridView);
            this.Controls.Add(cOD_CLIENTELabel);
            this.Controls.Add(this.cOD_CLIENTELabel1);
            this.Controls.Add(nOME_CLIENTELabel);
            this.Controls.Add(this.nOME_CLIENTETextBox);
            this.Controls.Add(fOTO_CLIENTELabel);
            this.Controls.Add(this.fOTO_CLIENTEPictureBox);
            this.Controls.Add(dATANASC_CLIENTELabel);
            this.Controls.Add(this.dATANASC_CLIENTEDateTimePicker);
            this.Controls.Add(cOD_SEXO_FKLabel);
            this.Controls.Add(this.cOD_SEXO_FKComboBox);
            this.Controls.Add(cOD_RUA_FKLabel);
            this.Controls.Add(this.cOD_RUA_FKComboBox);
            this.Controls.Add(cOD_BAIRRO_FKLabel);
            this.Controls.Add(this.cOD_BAIRRO_FKComboBox);
            this.Controls.Add(cOD_CEP_FKLabel);
            this.Controls.Add(this.cOD_CEP_FKComboBox);
            this.Controls.Add(cOD_CIDADE_FKLabel);
            this.Controls.Add(this.cOD_CIDADE_FKComboBox);
            this.Controls.Add(cOD_TRABALHO_FKLabel);
            this.Controls.Add(this.cOD_TRABALHO_FKComboBox);
            this.Controls.Add(sALARIO_CLIENTELabel);
            this.Controls.Add(this.sALARIO_CLIENTETextBox);
            this.Controls.Add(nUMEROCASALabel);
            this.Controls.Add(this.nUMEROCASATextBox);
            this.Controls.Add(this.cLIENTEBindingNavigator);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingNavigator)).EndInit();
            this.cLIENTEBindingNavigator.ResumeLayout(false);
            this.cLIENTEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOTO_CLIENTEPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cLIENTEBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cOD_CLIENTELabel1;
        private System.Windows.Forms.TextBox nOME_CLIENTETextBox;
        private System.Windows.Forms.PictureBox fOTO_CLIENTEPictureBox;
        private System.Windows.Forms.DateTimePicker dATANASC_CLIENTEDateTimePicker;
        private System.Windows.Forms.ComboBox cOD_SEXO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_RUA_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_BAIRRO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_CEP_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_CIDADE_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_TRABALHO_FKComboBox;
        private System.Windows.Forms.TextBox sALARIO_CLIENTETextBox;
        private System.Windows.Forms.TextBox nUMEROCASATextBox;
        private DB_TrabalhoDataSetTableAdapters.SEXOTableAdapter sEXOTableAdapter;
        private System.Windows.Forms.DataGridView cLIENTEDataGridView;
        private System.Windows.Forms.BindingSource sEXOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DB_TrabalhoDataSetTableAdapters.RUATableAdapter rUATableAdapter;
        private System.Windows.Forms.BindingSource rUABindingSource;
        private DB_TrabalhoDataSetTableAdapters.BAIRROTableAdapter bAIRROTableAdapter;
        private System.Windows.Forms.BindingSource bAIRROBindingSource;
        private System.Windows.Forms.BindingSource cEPBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CEPTableAdapter cEPTableAdapter;
        private System.Windows.Forms.BindingSource cIDADEBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CIDADETableAdapter cIDADETableAdapter;
        private System.Windows.Forms.BindingSource tRABALHOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.TRABALHOTableAdapter tRABALHOTableAdapter;
    }
}