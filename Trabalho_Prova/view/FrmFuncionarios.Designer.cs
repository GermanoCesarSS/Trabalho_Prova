namespace Trabalho_Prova.view
{
    partial class FrmFuncionarios
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
            System.Windows.Forms.Label cOD_FUNCIONARIOLabel;
            System.Windows.Forms.Label nOME_FUNCIONARIOLabel;
            System.Windows.Forms.Label nUMEROCASALabel;
            System.Windows.Forms.Label cOD_RUA_FKLabel;
            System.Windows.Forms.Label cOD_BAIRRO_FKLabel;
            System.Windows.Forms.Label cOD_CEP_FKLabel;
            System.Windows.Forms.Label cOD_CIDADE_FKLabel;
            System.Windows.Forms.Label cOD_FUNCAO_FKLabel;
            System.Windows.Forms.Label cOD_LOJA_FKLabel;
            System.Windows.Forms.Label sALARIOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarios));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.fUNCIONARIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fUNCIONARIOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dadosFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosFuncionariosTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.DadosFuncionariosTableAdapter();
            this.cOD_FUNCIONARIOLabel1 = new System.Windows.Forms.Label();
            this.nOME_FUNCIONARIOTextBox = new System.Windows.Forms.TextBox();
            this.nUMEROCASATextBox = new System.Windows.Forms.TextBox();
            this.cOD_RUA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.rUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_BAIRRO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.bAIRROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_CEP_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_CIDADE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_FUNCAO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.fUNCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_LOJA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.lOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALARIOTextBox = new System.Windows.Forms.TextBox();
            this.fUNCIONARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rUATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.RUATableAdapter();
            this.bAIRROTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.BAIRROTableAdapter();
            this.cEPTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CEPTableAdapter();
            this.cIDADETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CIDADETableAdapter();
            this.fUNCAOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FUNCAOTableAdapter();
            this.lOJATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.LOJATableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            cOD_FUNCIONARIOLabel = new System.Windows.Forms.Label();
            nOME_FUNCIONARIOLabel = new System.Windows.Forms.Label();
            nUMEROCASALabel = new System.Windows.Forms.Label();
            cOD_RUA_FKLabel = new System.Windows.Forms.Label();
            cOD_BAIRRO_FKLabel = new System.Windows.Forms.Label();
            cOD_CEP_FKLabel = new System.Windows.Forms.Label();
            cOD_CIDADE_FKLabel = new System.Windows.Forms.Label();
            cOD_FUNCAO_FKLabel = new System.Windows.Forms.Label();
            cOD_LOJA_FKLabel = new System.Windows.Forms.Label();
            sALARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingNavigator)).BeginInit();
            this.fUNCIONARIOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_FUNCIONARIOLabel
            // 
            cOD_FUNCIONARIOLabel.AutoSize = true;
            cOD_FUNCIONARIOLabel.Location = new System.Drawing.Point(31, 88);
            cOD_FUNCIONARIOLabel.Name = "cOD_FUNCIONARIOLabel";
            cOD_FUNCIONARIOLabel.Size = new System.Drawing.Size(134, 16);
            cOD_FUNCIONARIOLabel.TabIndex = 2;
            cOD_FUNCIONARIOLabel.Text = "COD FUNCIONARIO:";
            // 
            // nOME_FUNCIONARIOLabel
            // 
            nOME_FUNCIONARIOLabel.AutoSize = true;
            nOME_FUNCIONARIOLabel.Location = new System.Drawing.Point(31, 117);
            nOME_FUNCIONARIOLabel.Name = "nOME_FUNCIONARIOLabel";
            nOME_FUNCIONARIOLabel.Size = new System.Drawing.Size(145, 16);
            nOME_FUNCIONARIOLabel.TabIndex = 4;
            nOME_FUNCIONARIOLabel.Text = "NOME FUNCIONARIO:";
            // 
            // nUMEROCASALabel
            // 
            nUMEROCASALabel.AutoSize = true;
            nUMEROCASALabel.Location = new System.Drawing.Point(31, 145);
            nUMEROCASALabel.Name = "nUMEROCASALabel";
            nUMEROCASALabel.Size = new System.Drawing.Size(106, 16);
            nUMEROCASALabel.TabIndex = 6;
            nUMEROCASALabel.Text = "NUMEROCASA:";
            // 
            // cOD_RUA_FKLabel
            // 
            cOD_RUA_FKLabel.AutoSize = true;
            cOD_RUA_FKLabel.Location = new System.Drawing.Point(31, 173);
            cOD_RUA_FKLabel.Name = "cOD_RUA_FKLabel";
            cOD_RUA_FKLabel.Size = new System.Drawing.Size(90, 16);
            cOD_RUA_FKLabel.TabIndex = 8;
            cOD_RUA_FKLabel.Text = "COD RUA FK:";
            // 
            // cOD_BAIRRO_FKLabel
            // 
            cOD_BAIRRO_FKLabel.AutoSize = true;
            cOD_BAIRRO_FKLabel.Location = new System.Drawing.Point(31, 203);
            cOD_BAIRRO_FKLabel.Name = "cOD_BAIRRO_FKLabel";
            cOD_BAIRRO_FKLabel.Size = new System.Drawing.Size(112, 16);
            cOD_BAIRRO_FKLabel.TabIndex = 10;
            cOD_BAIRRO_FKLabel.Text = "COD BAIRRO FK:";
            // 
            // cOD_CEP_FKLabel
            // 
            cOD_CEP_FKLabel.AutoSize = true;
            cOD_CEP_FKLabel.Location = new System.Drawing.Point(31, 233);
            cOD_CEP_FKLabel.Name = "cOD_CEP_FKLabel";
            cOD_CEP_FKLabel.Size = new System.Drawing.Size(88, 16);
            cOD_CEP_FKLabel.TabIndex = 12;
            cOD_CEP_FKLabel.Text = "COD CEP FK:";
            // 
            // cOD_CIDADE_FKLabel
            // 
            cOD_CIDADE_FKLabel.AutoSize = true;
            cOD_CIDADE_FKLabel.Location = new System.Drawing.Point(31, 263);
            cOD_CIDADE_FKLabel.Name = "cOD_CIDADE_FKLabel";
            cOD_CIDADE_FKLabel.Size = new System.Drawing.Size(111, 16);
            cOD_CIDADE_FKLabel.TabIndex = 14;
            cOD_CIDADE_FKLabel.Text = "COD CIDADE FK:";
            // 
            // cOD_FUNCAO_FKLabel
            // 
            cOD_FUNCAO_FKLabel.AutoSize = true;
            cOD_FUNCAO_FKLabel.Location = new System.Drawing.Point(31, 293);
            cOD_FUNCAO_FKLabel.Name = "cOD_FUNCAO_FKLabel";
            cOD_FUNCAO_FKLabel.Size = new System.Drawing.Size(117, 16);
            cOD_FUNCAO_FKLabel.TabIndex = 16;
            cOD_FUNCAO_FKLabel.Text = "COD FUNCAO FK:";
            // 
            // cOD_LOJA_FKLabel
            // 
            cOD_LOJA_FKLabel.AutoSize = true;
            cOD_LOJA_FKLabel.Location = new System.Drawing.Point(31, 323);
            cOD_LOJA_FKLabel.Name = "cOD_LOJA_FKLabel";
            cOD_LOJA_FKLabel.Size = new System.Drawing.Size(94, 16);
            cOD_LOJA_FKLabel.TabIndex = 18;
            cOD_LOJA_FKLabel.Text = "COD LOJA FK:";
            // 
            // sALARIOLabel
            // 
            sALARIOLabel.AutoSize = true;
            sALARIOLabel.Location = new System.Drawing.Point(31, 353);
            sALARIOLabel.Name = "sALARIOLabel";
            sALARIOLabel.Size = new System.Drawing.Size(67, 16);
            sALARIOLabel.TabIndex = 20;
            sALARIOLabel.Text = "SALARIO:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fUNCIONARIOSBindingNavigator
            // 
            this.fUNCIONARIOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fUNCIONARIOSBindingNavigator.BindingSource = this.fUNCIONARIOSBindingSource;
            this.fUNCIONARIOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fUNCIONARIOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fUNCIONARIOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fUNCIONARIOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fUNCIONARIOSBindingNavigatorSaveItem});
            this.fUNCIONARIOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fUNCIONARIOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fUNCIONARIOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fUNCIONARIOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fUNCIONARIOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fUNCIONARIOSBindingNavigator.Name = "fUNCIONARIOSBindingNavigator";
            this.fUNCIONARIOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fUNCIONARIOSBindingNavigator.Size = new System.Drawing.Size(928, 27);
            this.fUNCIONARIOSBindingNavigator.TabIndex = 0;
            this.fUNCIONARIOSBindingNavigator.Text = "bindingNavigator1";
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
            // fUNCIONARIOSBindingNavigatorSaveItem
            // 
            this.fUNCIONARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fUNCIONARIOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fUNCIONARIOSBindingNavigatorSaveItem.Image")));
            this.fUNCIONARIOSBindingNavigatorSaveItem.Name = "fUNCIONARIOSBindingNavigatorSaveItem";
            this.fUNCIONARIOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.fUNCIONARIOSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fUNCIONARIOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.fUNCIONARIOSBindingNavigatorSaveItem_Click);
            // 
            // dadosFuncionariosBindingSource
            // 
            this.dadosFuncionariosBindingSource.DataMember = "DadosFuncionarios";
            this.dadosFuncionariosBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // dadosFuncionariosTableAdapter
            // 
            this.dadosFuncionariosTableAdapter.ClearBeforeFill = true;
            // 
            // cOD_FUNCIONARIOLabel1
            // 
            this.cOD_FUNCIONARIOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOSBindingSource, "COD_FUNCIONARIO", true));
            this.cOD_FUNCIONARIOLabel1.Location = new System.Drawing.Point(182, 88);
            this.cOD_FUNCIONARIOLabel1.Name = "cOD_FUNCIONARIOLabel1";
            this.cOD_FUNCIONARIOLabel1.Size = new System.Drawing.Size(121, 23);
            this.cOD_FUNCIONARIOLabel1.TabIndex = 3;
            this.cOD_FUNCIONARIOLabel1.Text = "label1";
            // 
            // nOME_FUNCIONARIOTextBox
            // 
            this.nOME_FUNCIONARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOSBindingSource, "NOME_FUNCIONARIO", true));
            this.nOME_FUNCIONARIOTextBox.Location = new System.Drawing.Point(182, 114);
            this.nOME_FUNCIONARIOTextBox.Name = "nOME_FUNCIONARIOTextBox";
            this.nOME_FUNCIONARIOTextBox.Size = new System.Drawing.Size(121, 22);
            this.nOME_FUNCIONARIOTextBox.TabIndex = 5;
            // 
            // nUMEROCASATextBox
            // 
            this.nUMEROCASATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOSBindingSource, "NUMEROCASA", true));
            this.nUMEROCASATextBox.Location = new System.Drawing.Point(182, 142);
            this.nUMEROCASATextBox.Name = "nUMEROCASATextBox";
            this.nUMEROCASATextBox.Size = new System.Drawing.Size(121, 22);
            this.nUMEROCASATextBox.TabIndex = 7;
            // 
            // cOD_RUA_FKComboBox
            // 
            this.cOD_RUA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fUNCIONARIOSBindingSource, "COD_RUA_FK", true));
            this.cOD_RUA_FKComboBox.DataSource = this.rUABindingSource;
            this.cOD_RUA_FKComboBox.DisplayMember = "NOME_RUA";
            this.cOD_RUA_FKComboBox.FormattingEnabled = true;
            this.cOD_RUA_FKComboBox.Location = new System.Drawing.Point(182, 170);
            this.cOD_RUA_FKComboBox.Name = "cOD_RUA_FKComboBox";
            this.cOD_RUA_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_RUA_FKComboBox.TabIndex = 9;
            this.cOD_RUA_FKComboBox.ValueMember = "COD_RUA";
            // 
            // rUABindingSource
            // 
            this.rUABindingSource.DataMember = "RUA";
            this.rUABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_BAIRRO_FKComboBox
            // 
            this.cOD_BAIRRO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fUNCIONARIOSBindingSource, "COD_BAIRRO_FK", true));
            this.cOD_BAIRRO_FKComboBox.DataSource = this.bAIRROBindingSource;
            this.cOD_BAIRRO_FKComboBox.DisplayMember = "NOME_BAIRRO";
            this.cOD_BAIRRO_FKComboBox.FormattingEnabled = true;
            this.cOD_BAIRRO_FKComboBox.Location = new System.Drawing.Point(182, 200);
            this.cOD_BAIRRO_FKComboBox.Name = "cOD_BAIRRO_FKComboBox";
            this.cOD_BAIRRO_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_BAIRRO_FKComboBox.TabIndex = 11;
            this.cOD_BAIRRO_FKComboBox.ValueMember = "COD_BAIRRO";
            // 
            // bAIRROBindingSource
            // 
            this.bAIRROBindingSource.DataMember = "BAIRRO";
            this.bAIRROBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_CEP_FKComboBox
            // 
            this.cOD_CEP_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fUNCIONARIOSBindingSource, "COD_CEP_FK", true));
            this.cOD_CEP_FKComboBox.DataSource = this.cEPBindingSource;
            this.cOD_CEP_FKComboBox.DisplayMember = "NUMERO_CEP";
            this.cOD_CEP_FKComboBox.FormattingEnabled = true;
            this.cOD_CEP_FKComboBox.Location = new System.Drawing.Point(182, 230);
            this.cOD_CEP_FKComboBox.Name = "cOD_CEP_FKComboBox";
            this.cOD_CEP_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_CEP_FKComboBox.TabIndex = 13;
            this.cOD_CEP_FKComboBox.ValueMember = "COD_CEP";
            // 
            // cEPBindingSource
            // 
            this.cEPBindingSource.DataMember = "CEP";
            this.cEPBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_CIDADE_FKComboBox
            // 
            this.cOD_CIDADE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fUNCIONARIOSBindingSource, "COD_CIDADE_FK", true));
            this.cOD_CIDADE_FKComboBox.DataSource = this.cIDADEBindingSource;
            this.cOD_CIDADE_FKComboBox.DisplayMember = "NOME_CIDADE";
            this.cOD_CIDADE_FKComboBox.FormattingEnabled = true;
            this.cOD_CIDADE_FKComboBox.Location = new System.Drawing.Point(182, 260);
            this.cOD_CIDADE_FKComboBox.Name = "cOD_CIDADE_FKComboBox";
            this.cOD_CIDADE_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_CIDADE_FKComboBox.TabIndex = 15;
            this.cOD_CIDADE_FKComboBox.ValueMember = "COD_CIDADE";
            // 
            // cIDADEBindingSource
            // 
            this.cIDADEBindingSource.DataMember = "CIDADE";
            this.cIDADEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_FUNCAO_FKComboBox
            // 
            this.cOD_FUNCAO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fUNCIONARIOSBindingSource, "COD_FUNCAO_FK", true));
            this.cOD_FUNCAO_FKComboBox.DataSource = this.fUNCAOBindingSource;
            this.cOD_FUNCAO_FKComboBox.DisplayMember = "NOME_FUNCAO";
            this.cOD_FUNCAO_FKComboBox.FormattingEnabled = true;
            this.cOD_FUNCAO_FKComboBox.Location = new System.Drawing.Point(182, 290);
            this.cOD_FUNCAO_FKComboBox.Name = "cOD_FUNCAO_FKComboBox";
            this.cOD_FUNCAO_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_FUNCAO_FKComboBox.TabIndex = 17;
            this.cOD_FUNCAO_FKComboBox.ValueMember = "COD_FUNCAO";
            // 
            // fUNCAOBindingSource
            // 
            this.fUNCAOBindingSource.DataMember = "FUNCAO";
            this.fUNCAOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_LOJA_FKComboBox
            // 
            this.cOD_LOJA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fUNCIONARIOSBindingSource, "COD_LOJA_FK", true));
            this.cOD_LOJA_FKComboBox.DataSource = this.lOJABindingSource;
            this.cOD_LOJA_FKComboBox.DisplayMember = "NOME_LOJA";
            this.cOD_LOJA_FKComboBox.FormattingEnabled = true;
            this.cOD_LOJA_FKComboBox.Location = new System.Drawing.Point(182, 320);
            this.cOD_LOJA_FKComboBox.Name = "cOD_LOJA_FKComboBox";
            this.cOD_LOJA_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_LOJA_FKComboBox.TabIndex = 19;
            this.cOD_LOJA_FKComboBox.ValueMember = "COD_LOJA";
            // 
            // lOJABindingSource
            // 
            this.lOJABindingSource.DataMember = "LOJA";
            this.lOJABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // sALARIOTextBox
            // 
            this.sALARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCIONARIOSBindingSource, "SALARIO", true));
            this.sALARIOTextBox.Location = new System.Drawing.Point(182, 350);
            this.sALARIOTextBox.Name = "sALARIOTextBox";
            this.sALARIOTextBox.Size = new System.Drawing.Size(121, 22);
            this.sALARIOTextBox.TabIndex = 21;
            // 
            // fUNCIONARIOSDataGridView
            // 
            this.fUNCIONARIOSDataGridView.AutoGenerateColumns = false;
            this.fUNCIONARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fUNCIONARIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.fUNCIONARIOSDataGridView.DataSource = this.fUNCIONARIOSBindingSource;
            this.fUNCIONARIOSDataGridView.Location = new System.Drawing.Point(463, 30);
            this.fUNCIONARIOSDataGridView.Name = "fUNCIONARIOSDataGridView";
            this.fUNCIONARIOSDataGridView.RowHeadersWidth = 51;
            this.fUNCIONARIOSDataGridView.RowTemplate.Height = 24;
            this.fUNCIONARIOSDataGridView.Size = new System.Drawing.Size(465, 528);
            this.fUNCIONARIOSDataGridView.TabIndex = 21;
            this.fUNCIONARIOSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fUNCIONARIOSDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_FUNCIONARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_FUNCIONARIO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_FUNCIONARIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_FUNCIONARIO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NUMEROCASA";
            this.dataGridViewTextBoxColumn3.HeaderText = "NUMEROCASA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COD_RUA_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "COD_RUA_FK";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "COD_BAIRRO_FK";
            this.dataGridViewTextBoxColumn5.HeaderText = "COD_BAIRRO_FK";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "COD_CEP_FK";
            this.dataGridViewTextBoxColumn6.HeaderText = "COD_CEP_FK";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "COD_CIDADE_FK";
            this.dataGridViewTextBoxColumn7.HeaderText = "COD_CIDADE_FK";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "COD_FUNCAO_FK";
            this.dataGridViewTextBoxColumn8.HeaderText = "COD_FUNCAO_FK";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "COD_LOJA_FK";
            this.dataGridViewTextBoxColumn9.HeaderText = "COD_LOJA_FK";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SALARIO";
            this.dataGridViewTextBoxColumn10.HeaderText = "SALARIO";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(338, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(338, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(338, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // rUATableAdapter
            // 
            this.rUATableAdapter.ClearBeforeFill = true;
            // 
            // bAIRROTableAdapter
            // 
            this.bAIRROTableAdapter.ClearBeforeFill = true;
            // 
            // cEPTableAdapter
            // 
            this.cEPTableAdapter.ClearBeforeFill = true;
            // 
            // cIDADETableAdapter
            // 
            this.cIDADETableAdapter.ClearBeforeFill = true;
            // 
            // fUNCAOTableAdapter
            // 
            this.fUNCAOTableAdapter.ClearBeforeFill = true;
            // 
            // lOJATableAdapter
            // 
            this.lOJATableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(86, 413);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 559);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fUNCIONARIOSDataGridView);
            this.Controls.Add(cOD_FUNCIONARIOLabel);
            this.Controls.Add(this.cOD_FUNCIONARIOLabel1);
            this.Controls.Add(nOME_FUNCIONARIOLabel);
            this.Controls.Add(this.nOME_FUNCIONARIOTextBox);
            this.Controls.Add(nUMEROCASALabel);
            this.Controls.Add(this.nUMEROCASATextBox);
            this.Controls.Add(cOD_RUA_FKLabel);
            this.Controls.Add(this.cOD_RUA_FKComboBox);
            this.Controls.Add(cOD_BAIRRO_FKLabel);
            this.Controls.Add(this.cOD_BAIRRO_FKComboBox);
            this.Controls.Add(cOD_CEP_FKLabel);
            this.Controls.Add(this.cOD_CEP_FKComboBox);
            this.Controls.Add(cOD_CIDADE_FKLabel);
            this.Controls.Add(this.cOD_CIDADE_FKComboBox);
            this.Controls.Add(cOD_FUNCAO_FKLabel);
            this.Controls.Add(this.cOD_FUNCAO_FKComboBox);
            this.Controls.Add(cOD_LOJA_FKLabel);
            this.Controls.Add(this.cOD_LOJA_FKComboBox);
            this.Controls.Add(sALARIOLabel);
            this.Controls.Add(this.sALARIOTextBox);
            this.Controls.Add(this.fUNCIONARIOSBindingNavigator);
            this.Name = "FrmFuncionarios";
            this.Text = "FrmFuncionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingNavigator)).EndInit();
            this.fUNCIONARIOSBindingNavigator.ResumeLayout(false);
            this.fUNCIONARIOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fUNCIONARIOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fUNCIONARIOSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource dadosFuncionariosBindingSource;
        private DB_TrabalhoDataSetTableAdapters.DadosFuncionariosTableAdapter dadosFuncionariosTableAdapter;
        private System.Windows.Forms.Label cOD_FUNCIONARIOLabel1;
        private System.Windows.Forms.TextBox nOME_FUNCIONARIOTextBox;
        private System.Windows.Forms.TextBox nUMEROCASATextBox;
        private System.Windows.Forms.ComboBox cOD_RUA_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_BAIRRO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_CEP_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_CIDADE_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_FUNCAO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_LOJA_FKComboBox;
        private System.Windows.Forms.TextBox sALARIOTextBox;
        private System.Windows.Forms.DataGridView fUNCIONARIOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource rUABindingSource;
        private DB_TrabalhoDataSetTableAdapters.RUATableAdapter rUATableAdapter;
        private System.Windows.Forms.BindingSource bAIRROBindingSource;
        private DB_TrabalhoDataSetTableAdapters.BAIRROTableAdapter bAIRROTableAdapter;
        private System.Windows.Forms.BindingSource cEPBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CEPTableAdapter cEPTableAdapter;
        private System.Windows.Forms.BindingSource cIDADEBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CIDADETableAdapter cIDADETableAdapter;
        private System.Windows.Forms.BindingSource fUNCAOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.FUNCAOTableAdapter fUNCAOTableAdapter;
        private System.Windows.Forms.BindingSource lOJABindingSource;
        private DB_TrabalhoDataSetTableAdapters.LOJATableAdapter lOJATableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}