namespace Trabalho_Prova.view
{
    partial class FrmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            System.Windows.Forms.Label cOD_FORNECEDORLabel;
            System.Windows.Forms.Label nOME_FORNECEDORLabel;
            System.Windows.Forms.Label nUMEROCASALabel;
            System.Windows.Forms.Label cOD_RUA_FKLabel;
            System.Windows.Forms.Label cOD_BAIRRO_FKLabel;
            System.Windows.Forms.Label cOD_CEP_FKLabel;
            System.Windows.Forms.Label cOD_CIDADE_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FORNECEDORTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.fORNECEDORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fORNECEDORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fORNECEDORDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.nOME_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.nUMEROCASATextBox = new System.Windows.Forms.TextBox();
            this.cOD_RUA_FKTextBox = new System.Windows.Forms.TextBox();
            this.cOD_BAIRRO_FKTextBox = new System.Windows.Forms.TextBox();
            this.cOD_CEP_FKTextBox = new System.Windows.Forms.TextBox();
            this.cOD_CIDADE_FKTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            cOD_FORNECEDORLabel = new System.Windows.Forms.Label();
            nOME_FORNECEDORLabel = new System.Windows.Forms.Label();
            nUMEROCASALabel = new System.Windows.Forms.Label();
            cOD_RUA_FKLabel = new System.Windows.Forms.Label();
            cOD_BAIRRO_FKLabel = new System.Windows.Forms.Label();
            cOD_CEP_FKLabel = new System.Windows.Forms.Label();
            cOD_CIDADE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingNavigator)).BeginInit();
            this.fORNECEDORBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORNECEDORBindingSource
            // 
            this.fORNECEDORBindingSource.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // fORNECEDORTableAdapter
            // 
            this.fORNECEDORTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FORNECEDORTableAdapter = this.fORNECEDORTableAdapter;
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
            // fORNECEDORBindingNavigator
            // 
            this.fORNECEDORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fORNECEDORBindingNavigator.BindingSource = this.fORNECEDORBindingSource;
            this.fORNECEDORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fORNECEDORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fORNECEDORBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fORNECEDORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fORNECEDORBindingNavigatorSaveItem});
            this.fORNECEDORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fORNECEDORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fORNECEDORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fORNECEDORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fORNECEDORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fORNECEDORBindingNavigator.Name = "fORNECEDORBindingNavigator";
            this.fORNECEDORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fORNECEDORBindingNavigator.Size = new System.Drawing.Size(629, 27);
            this.fORNECEDORBindingNavigator.TabIndex = 0;
            this.fORNECEDORBindingNavigator.Text = "bindingNavigator1";
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
            // fORNECEDORBindingNavigatorSaveItem
            // 
            this.fORNECEDORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fORNECEDORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fORNECEDORBindingNavigatorSaveItem.Image")));
            this.fORNECEDORBindingNavigatorSaveItem.Name = "fORNECEDORBindingNavigatorSaveItem";
            this.fORNECEDORBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fORNECEDORBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fORNECEDORBindingNavigatorSaveItem.Click += new System.EventHandler(this.fORNECEDORBindingNavigatorSaveItem_Click);
            // 
            // fORNECEDORDataGridView
            // 
            this.fORNECEDORDataGridView.AutoGenerateColumns = false;
            this.fORNECEDORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fORNECEDORDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.fORNECEDORDataGridView.DataSource = this.fORNECEDORBindingSource;
            this.fORNECEDORDataGridView.Location = new System.Drawing.Point(12, 290);
            this.fORNECEDORDataGridView.Name = "fORNECEDORDataGridView";
            this.fORNECEDORDataGridView.RowHeadersWidth = 51;
            this.fORNECEDORDataGridView.RowTemplate.Height = 24;
            this.fORNECEDORDataGridView.Size = new System.Drawing.Size(597, 220);
            this.fORNECEDORDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_FORNECEDOR";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_FORNECEDOR";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_FORNECEDOR";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_FORNECEDOR";
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
            // cOD_FORNECEDORLabel
            // 
            cOD_FORNECEDORLabel.AutoSize = true;
            cOD_FORNECEDORLabel.Location = new System.Drawing.Point(26, 64);
            cOD_FORNECEDORLabel.Name = "cOD_FORNECEDORLabel";
            cOD_FORNECEDORLabel.Size = new System.Drawing.Size(137, 16);
            cOD_FORNECEDORLabel.TabIndex = 2;
            cOD_FORNECEDORLabel.Text = "COD FORNECEDOR:";
            // 
            // cOD_FORNECEDORTextBox
            // 
            this.cOD_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "COD_FORNECEDOR", true));
            this.cOD_FORNECEDORTextBox.Location = new System.Drawing.Point(180, 61);
            this.cOD_FORNECEDORTextBox.Name = "cOD_FORNECEDORTextBox";
            this.cOD_FORNECEDORTextBox.Size = new System.Drawing.Size(278, 22);
            this.cOD_FORNECEDORTextBox.TabIndex = 3;
            // 
            // nOME_FORNECEDORLabel
            // 
            nOME_FORNECEDORLabel.AutoSize = true;
            nOME_FORNECEDORLabel.Location = new System.Drawing.Point(26, 92);
            nOME_FORNECEDORLabel.Name = "nOME_FORNECEDORLabel";
            nOME_FORNECEDORLabel.Size = new System.Drawing.Size(148, 16);
            nOME_FORNECEDORLabel.TabIndex = 4;
            nOME_FORNECEDORLabel.Text = "NOME FORNECEDOR:";
            // 
            // nOME_FORNECEDORTextBox
            // 
            this.nOME_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "NOME_FORNECEDOR", true));
            this.nOME_FORNECEDORTextBox.Location = new System.Drawing.Point(180, 89);
            this.nOME_FORNECEDORTextBox.Name = "nOME_FORNECEDORTextBox";
            this.nOME_FORNECEDORTextBox.Size = new System.Drawing.Size(278, 22);
            this.nOME_FORNECEDORTextBox.TabIndex = 5;
            // 
            // nUMEROCASALabel
            // 
            nUMEROCASALabel.AutoSize = true;
            nUMEROCASALabel.Location = new System.Drawing.Point(26, 120);
            nUMEROCASALabel.Name = "nUMEROCASALabel";
            nUMEROCASALabel.Size = new System.Drawing.Size(106, 16);
            nUMEROCASALabel.TabIndex = 6;
            nUMEROCASALabel.Text = "NUMEROCASA:";
            // 
            // nUMEROCASATextBox
            // 
            this.nUMEROCASATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "NUMEROCASA", true));
            this.nUMEROCASATextBox.Location = new System.Drawing.Point(180, 117);
            this.nUMEROCASATextBox.Name = "nUMEROCASATextBox";
            this.nUMEROCASATextBox.Size = new System.Drawing.Size(278, 22);
            this.nUMEROCASATextBox.TabIndex = 7;
            // 
            // cOD_RUA_FKLabel
            // 
            cOD_RUA_FKLabel.AutoSize = true;
            cOD_RUA_FKLabel.Location = new System.Drawing.Point(26, 148);
            cOD_RUA_FKLabel.Name = "cOD_RUA_FKLabel";
            cOD_RUA_FKLabel.Size = new System.Drawing.Size(90, 16);
            cOD_RUA_FKLabel.TabIndex = 8;
            cOD_RUA_FKLabel.Text = "COD RUA FK:";
            // 
            // cOD_RUA_FKTextBox
            // 
            this.cOD_RUA_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "COD_RUA_FK", true));
            this.cOD_RUA_FKTextBox.Location = new System.Drawing.Point(180, 145);
            this.cOD_RUA_FKTextBox.Name = "cOD_RUA_FKTextBox";
            this.cOD_RUA_FKTextBox.Size = new System.Drawing.Size(278, 22);
            this.cOD_RUA_FKTextBox.TabIndex = 9;
            // 
            // cOD_BAIRRO_FKLabel
            // 
            cOD_BAIRRO_FKLabel.AutoSize = true;
            cOD_BAIRRO_FKLabel.Location = new System.Drawing.Point(26, 176);
            cOD_BAIRRO_FKLabel.Name = "cOD_BAIRRO_FKLabel";
            cOD_BAIRRO_FKLabel.Size = new System.Drawing.Size(112, 16);
            cOD_BAIRRO_FKLabel.TabIndex = 10;
            cOD_BAIRRO_FKLabel.Text = "COD BAIRRO FK:";
            // 
            // cOD_BAIRRO_FKTextBox
            // 
            this.cOD_BAIRRO_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "COD_BAIRRO_FK", true));
            this.cOD_BAIRRO_FKTextBox.Location = new System.Drawing.Point(180, 173);
            this.cOD_BAIRRO_FKTextBox.Name = "cOD_BAIRRO_FKTextBox";
            this.cOD_BAIRRO_FKTextBox.Size = new System.Drawing.Size(278, 22);
            this.cOD_BAIRRO_FKTextBox.TabIndex = 11;
            // 
            // cOD_CEP_FKLabel
            // 
            cOD_CEP_FKLabel.AutoSize = true;
            cOD_CEP_FKLabel.Location = new System.Drawing.Point(26, 204);
            cOD_CEP_FKLabel.Name = "cOD_CEP_FKLabel";
            cOD_CEP_FKLabel.Size = new System.Drawing.Size(88, 16);
            cOD_CEP_FKLabel.TabIndex = 12;
            cOD_CEP_FKLabel.Text = "COD CEP FK:";
            // 
            // cOD_CEP_FKTextBox
            // 
            this.cOD_CEP_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "COD_CEP_FK", true));
            this.cOD_CEP_FKTextBox.Location = new System.Drawing.Point(180, 201);
            this.cOD_CEP_FKTextBox.Name = "cOD_CEP_FKTextBox";
            this.cOD_CEP_FKTextBox.Size = new System.Drawing.Size(278, 22);
            this.cOD_CEP_FKTextBox.TabIndex = 13;
            // 
            // cOD_CIDADE_FKLabel
            // 
            cOD_CIDADE_FKLabel.AutoSize = true;
            cOD_CIDADE_FKLabel.Location = new System.Drawing.Point(26, 232);
            cOD_CIDADE_FKLabel.Name = "cOD_CIDADE_FKLabel";
            cOD_CIDADE_FKLabel.Size = new System.Drawing.Size(111, 16);
            cOD_CIDADE_FKLabel.TabIndex = 14;
            cOD_CIDADE_FKLabel.Text = "COD CIDADE FK:";
            // 
            // cOD_CIDADE_FKTextBox
            // 
            this.cOD_CIDADE_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORBindingSource, "COD_CIDADE_FK", true));
            this.cOD_CIDADE_FKTextBox.Location = new System.Drawing.Point(180, 229);
            this.cOD_CIDADE_FKTextBox.Name = "cOD_CIDADE_FKTextBox";
            this.cOD_CIDADE_FKTextBox.Size = new System.Drawing.Size(278, 22);
            this.cOD_CIDADE_FKTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 530);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cOD_FORNECEDORLabel);
            this.Controls.Add(this.cOD_FORNECEDORTextBox);
            this.Controls.Add(nOME_FORNECEDORLabel);
            this.Controls.Add(this.nOME_FORNECEDORTextBox);
            this.Controls.Add(nUMEROCASALabel);
            this.Controls.Add(this.nUMEROCASATextBox);
            this.Controls.Add(cOD_RUA_FKLabel);
            this.Controls.Add(this.cOD_RUA_FKTextBox);
            this.Controls.Add(cOD_BAIRRO_FKLabel);
            this.Controls.Add(this.cOD_BAIRRO_FKTextBox);
            this.Controls.Add(cOD_CEP_FKLabel);
            this.Controls.Add(this.cOD_CEP_FKTextBox);
            this.Controls.Add(cOD_CIDADE_FKLabel);
            this.Controls.Add(this.cOD_CIDADE_FKTextBox);
            this.Controls.Add(this.fORNECEDORDataGridView);
            this.Controls.Add(this.fORNECEDORBindingNavigator);
            this.Name = "FrmFornecedor";
            this.Text = "FrmFornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingNavigator)).EndInit();
            this.fORNECEDORBindingNavigator.ResumeLayout(false);
            this.fORNECEDORBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private DB_TrabalhoDataSetTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fORNECEDORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fORNECEDORBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView fORNECEDORDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox cOD_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox nOME_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox nUMEROCASATextBox;
        private System.Windows.Forms.TextBox cOD_RUA_FKTextBox;
        private System.Windows.Forms.TextBox cOD_BAIRRO_FKTextBox;
        private System.Windows.Forms.TextBox cOD_CEP_FKTextBox;
        private System.Windows.Forms.TextBox cOD_CIDADE_FKTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}