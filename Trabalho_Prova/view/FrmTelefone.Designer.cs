namespace Trabalho_Prova.view
{
    partial class FrmTelefone
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
            System.Windows.Forms.Label cOD_TELEFONELabel;
            System.Windows.Forms.Label nUMEROLabel;
            System.Windows.Forms.Label cOD_OPERADORA_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelefone));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.tELEFONEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tELEFONEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cOD_TELEFONELabel1 = new System.Windows.Forms.Label();
            this.nUMEROTextBox = new System.Windows.Forms.TextBox();
            this.cOD_OPERADORA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.dadosTelefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosTelefoneTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.DadosTelefoneTableAdapter();
            this.dadosTelefoneDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPERADORATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.OPERADORATableAdapter();
            cOD_TELEFONELabel = new System.Windows.Forms.Label();
            nUMEROLabel = new System.Windows.Forms.Label();
            cOD_OPERADORA_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingNavigator)).BeginInit();
            this.tELEFONEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTelefoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTelefoneDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_TELEFONELabel
            // 
            cOD_TELEFONELabel.AutoSize = true;
            cOD_TELEFONELabel.Location = new System.Drawing.Point(37, 60);
            cOD_TELEFONELabel.Name = "cOD_TELEFONELabel";
            cOD_TELEFONELabel.Size = new System.Drawing.Size(113, 16);
            cOD_TELEFONELabel.TabIndex = 2;
            cOD_TELEFONELabel.Text = "COD TELEFONE:";
            // 
            // nUMEROLabel
            // 
            nUMEROLabel.AutoSize = true;
            nUMEROLabel.Location = new System.Drawing.Point(37, 89);
            nUMEROLabel.Name = "nUMEROLabel";
            nUMEROLabel.Size = new System.Drawing.Size(70, 16);
            nUMEROLabel.TabIndex = 4;
            nUMEROLabel.Text = "NUMERO:";
            // 
            // cOD_OPERADORA_FKLabel
            // 
            cOD_OPERADORA_FKLabel.AutoSize = true;
            cOD_OPERADORA_FKLabel.Location = new System.Drawing.Point(37, 117);
            cOD_OPERADORA_FKLabel.Name = "cOD_OPERADORA_FKLabel";
            cOD_OPERADORA_FKLabel.Size = new System.Drawing.Size(147, 16);
            cOD_OPERADORA_FKLabel.TabIndex = 6;
            cOD_OPERADORA_FKLabel.Text = "COD OPERADORA FK:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tELEFONEBindingSource
            // 
            this.tELEFONEBindingSource.DataMember = "TELEFONE";
            this.tELEFONEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // tELEFONETableAdapter
            // 
            this.tELEFONETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PARCELAVENDATableAdapter = null;
            this.tableAdapterManager.PRODUTOTableAdapter = null;
            this.tableAdapterManager.RUATableAdapter = null;
            this.tableAdapterManager.SEXOTableAdapter = null;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = this.tELEFONETableAdapter;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // tELEFONEBindingNavigator
            // 
            this.tELEFONEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tELEFONEBindingNavigator.BindingSource = this.tELEFONEBindingSource;
            this.tELEFONEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tELEFONEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tELEFONEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tELEFONEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tELEFONEBindingNavigatorSaveItem});
            this.tELEFONEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tELEFONEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tELEFONEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tELEFONEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tELEFONEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tELEFONEBindingNavigator.Name = "tELEFONEBindingNavigator";
            this.tELEFONEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tELEFONEBindingNavigator.Size = new System.Drawing.Size(501, 27);
            this.tELEFONEBindingNavigator.TabIndex = 0;
            this.tELEFONEBindingNavigator.Text = "bindingNavigator1";
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
            // tELEFONEBindingNavigatorSaveItem
            // 
            this.tELEFONEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tELEFONEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tELEFONEBindingNavigatorSaveItem.Image")));
            this.tELEFONEBindingNavigatorSaveItem.Name = "tELEFONEBindingNavigatorSaveItem";
            this.tELEFONEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tELEFONEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tELEFONEBindingNavigatorSaveItem.Click += new System.EventHandler(this.tELEFONEBindingNavigatorSaveItem_Click);
            // 
            // cOD_TELEFONELabel1
            // 
            this.cOD_TELEFONELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tELEFONEBindingSource, "COD_TELEFONE", true));
            this.cOD_TELEFONELabel1.Location = new System.Drawing.Point(190, 60);
            this.cOD_TELEFONELabel1.Name = "cOD_TELEFONELabel1";
            this.cOD_TELEFONELabel1.Size = new System.Drawing.Size(121, 23);
            this.cOD_TELEFONELabel1.TabIndex = 3;
            this.cOD_TELEFONELabel1.Text = "label1";
            // 
            // nUMEROTextBox
            // 
            this.nUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tELEFONEBindingSource, "NUMERO", true));
            this.nUMEROTextBox.Location = new System.Drawing.Point(190, 86);
            this.nUMEROTextBox.Name = "nUMEROTextBox";
            this.nUMEROTextBox.Size = new System.Drawing.Size(191, 22);
            this.nUMEROTextBox.TabIndex = 5;
            // 
            // cOD_OPERADORA_FKComboBox
            // 
            this.cOD_OPERADORA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tELEFONEBindingSource, "COD_OPERADORA_FK", true));
            this.cOD_OPERADORA_FKComboBox.DataSource = this.oPERADORABindingSource;
            this.cOD_OPERADORA_FKComboBox.DisplayMember = "NOME_OPERADORA";
            this.cOD_OPERADORA_FKComboBox.FormattingEnabled = true;
            this.cOD_OPERADORA_FKComboBox.Location = new System.Drawing.Point(190, 114);
            this.cOD_OPERADORA_FKComboBox.Name = "cOD_OPERADORA_FKComboBox";
            this.cOD_OPERADORA_FKComboBox.Size = new System.Drawing.Size(191, 24);
            this.cOD_OPERADORA_FKComboBox.TabIndex = 7;
            this.cOD_OPERADORA_FKComboBox.ValueMember = "COD_OPERADORA";
            // 
            // dadosTelefoneBindingSource
            // 
            this.dadosTelefoneBindingSource.DataMember = "DadosTelefone";
            this.dadosTelefoneBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // dadosTelefoneTableAdapter
            // 
            this.dadosTelefoneTableAdapter.ClearBeforeFill = true;
            // 
            // dadosTelefoneDataGridView
            // 
            this.dadosTelefoneDataGridView.AutoGenerateColumns = false;
            this.dadosTelefoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosTelefoneDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dadosTelefoneDataGridView.DataSource = this.dadosTelefoneBindingSource;
            this.dadosTelefoneDataGridView.Location = new System.Drawing.Point(0, 244);
            this.dadosTelefoneDataGridView.Name = "dadosTelefoneDataGridView";
            this.dadosTelefoneDataGridView.RowHeadersWidth = 51;
            this.dadosTelefoneDataGridView.RowTemplate.Height = 24;
            this.dadosTelefoneDataGridView.Size = new System.Drawing.Size(501, 227);
            this.dadosTelefoneDataGridView.TabIndex = 7;
            this.dadosTelefoneDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosTelefoneDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NUMERO";
            this.dataGridViewTextBoxColumn1.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_TELEFONE";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_TELEFONE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOME_OPERADORA";
            this.dataGridViewTextBoxColumn3.HeaderText = "NOME_OPERADORA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // oPERADORABindingSource
            // 
            this.oPERADORABindingSource.DataMember = "OPERADORA";
            this.oPERADORABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // oPERADORATableAdapter
            // 
            this.oPERADORATableAdapter.ClearBeforeFill = true;
            // 
            // FrmTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 472);
            this.Controls.Add(this.dadosTelefoneDataGridView);
            this.Controls.Add(cOD_TELEFONELabel);
            this.Controls.Add(this.cOD_TELEFONELabel1);
            this.Controls.Add(nUMEROLabel);
            this.Controls.Add(this.nUMEROTextBox);
            this.Controls.Add(cOD_OPERADORA_FKLabel);
            this.Controls.Add(this.cOD_OPERADORA_FKComboBox);
            this.Controls.Add(this.tELEFONEBindingNavigator);
            this.Name = "FrmTelefone";
            this.Text = "FrmTelefone";
            this.Load += new System.EventHandler(this.FrmTelefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingNavigator)).EndInit();
            this.tELEFONEBindingNavigator.ResumeLayout(false);
            this.tELEFONEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTelefoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosTelefoneDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tELEFONEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tELEFONEBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cOD_TELEFONELabel1;
        private System.Windows.Forms.TextBox nUMEROTextBox;
        private System.Windows.Forms.ComboBox cOD_OPERADORA_FKComboBox;
        private System.Windows.Forms.BindingSource dadosTelefoneBindingSource;
        private DB_TrabalhoDataSetTableAdapters.DadosTelefoneTableAdapter dadosTelefoneTableAdapter;
        private System.Windows.Forms.DataGridView dadosTelefoneDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource oPERADORABindingSource;
        private DB_TrabalhoDataSetTableAdapters.OPERADORATableAdapter oPERADORATableAdapter;
    }
}