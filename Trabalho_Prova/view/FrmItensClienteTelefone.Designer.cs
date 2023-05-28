namespace Trabalho_Prova.view
{
    partial class FrmItensClienteTelefone
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
            System.Windows.Forms.Label cOD_TELEFONE_FKLabel;
            System.Windows.Forms.Label cOD_CLIENTE_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensClienteTelefone));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.iTENS_TEL_CLIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENS_TEL_CLITableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.ITENS_TEL_CLITableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.cLIENTETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CLIENTETableAdapter();
            this.tELEFONETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter();
            this.iTENS_TEL_CLIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENS_TEL_CLIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iTENS_TEL_CLIDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_TELEFONE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOD_CLIENTE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            cOD_TELEFONE_FKLabel = new System.Windows.Forms.Label();
            cOD_CLIENTE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_CLIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_CLIBindingNavigator)).BeginInit();
            this.iTENS_TEL_CLIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_CLIDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_TELEFONE_FKLabel
            // 
            cOD_TELEFONE_FKLabel.AutoSize = true;
            cOD_TELEFONE_FKLabel.Location = new System.Drawing.Point(12, 115);
            cOD_TELEFONE_FKLabel.Name = "cOD_TELEFONE_FKLabel";
            cOD_TELEFONE_FKLabel.Size = new System.Drawing.Size(132, 16);
            cOD_TELEFONE_FKLabel.TabIndex = 2;
            cOD_TELEFONE_FKLabel.Text = "COD TELEFONE FK:";
            // 
            // cOD_CLIENTE_FKLabel
            // 
            cOD_CLIENTE_FKLabel.AutoSize = true;
            cOD_CLIENTE_FKLabel.Location = new System.Drawing.Point(12, 145);
            cOD_CLIENTE_FKLabel.Name = "cOD_CLIENTE_FKLabel";
            cOD_CLIENTE_FKLabel.Size = new System.Drawing.Size(117, 16);
            cOD_CLIENTE_FKLabel.TabIndex = 4;
            cOD_CLIENTE_FKLabel.Text = "COD CLIENTE FK:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENS_TEL_CLIBindingSource
            // 
            this.iTENS_TEL_CLIBindingSource.DataMember = "ITENS_TEL_CLI";
            this.iTENS_TEL_CLIBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // iTENS_TEL_CLITableAdapter
            // 
            this.iTENS_TEL_CLITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.IMAGENSTableAdapter = null;
            this.tableAdapterManager.ITENS_ACESSOLOGINTableAdapter = null;
            this.tableAdapterManager.ITENS_COMPRA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_CLITableAdapter = this.iTENS_TEL_CLITableAdapter;
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
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tELEFONETableAdapter
            // 
            this.tELEFONETableAdapter.ClearBeforeFill = true;
            // 
            // iTENS_TEL_CLIBindingNavigator
            // 
            this.iTENS_TEL_CLIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENS_TEL_CLIBindingNavigator.BindingSource = this.iTENS_TEL_CLIBindingSource;
            this.iTENS_TEL_CLIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENS_TEL_CLIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENS_TEL_CLIBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iTENS_TEL_CLIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENS_TEL_CLIBindingNavigatorSaveItem});
            this.iTENS_TEL_CLIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENS_TEL_CLIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENS_TEL_CLIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENS_TEL_CLIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENS_TEL_CLIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENS_TEL_CLIBindingNavigator.Name = "iTENS_TEL_CLIBindingNavigator";
            this.iTENS_TEL_CLIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENS_TEL_CLIBindingNavigator.Size = new System.Drawing.Size(447, 27);
            this.iTENS_TEL_CLIBindingNavigator.TabIndex = 0;
            this.iTENS_TEL_CLIBindingNavigator.Text = "bindingNavigator1";
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
            // iTENS_TEL_CLIBindingNavigatorSaveItem
            // 
            this.iTENS_TEL_CLIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENS_TEL_CLIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENS_TEL_CLIBindingNavigatorSaveItem.Image")));
            this.iTENS_TEL_CLIBindingNavigatorSaveItem.Name = "iTENS_TEL_CLIBindingNavigatorSaveItem";
            this.iTENS_TEL_CLIBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.iTENS_TEL_CLIBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENS_TEL_CLIBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENS_TEL_CLIBindingNavigatorSaveItem_Click);
            // 
            // iTENS_TEL_CLIDataGridView
            // 
            this.iTENS_TEL_CLIDataGridView.AutoGenerateColumns = false;
            this.iTENS_TEL_CLIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENS_TEL_CLIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENS_TEL_CLIDataGridView.DataSource = this.iTENS_TEL_CLIBindingSource;
            this.iTENS_TEL_CLIDataGridView.Location = new System.Drawing.Point(0, 258);
            this.iTENS_TEL_CLIDataGridView.Name = "iTENS_TEL_CLIDataGridView";
            this.iTENS_TEL_CLIDataGridView.RowHeadersWidth = 51;
            this.iTENS_TEL_CLIDataGridView.RowTemplate.Height = 24;
            this.iTENS_TEL_CLIDataGridView.Size = new System.Drawing.Size(427, 220);
            this.iTENS_TEL_CLIDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_TELEFONE_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_TELEFONE_FK";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_CLIENTE_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_CLIENTE_FK";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_TELEFONE_FKComboBox
            // 
            this.cOD_TELEFONE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_TEL_CLIBindingSource, "COD_TELEFONE_FK", true));
            this.cOD_TELEFONE_FKComboBox.DataSource = this.tELEFONEBindingSource;
            this.cOD_TELEFONE_FKComboBox.DisplayMember = "NUMERO";
            this.cOD_TELEFONE_FKComboBox.FormattingEnabled = true;
            this.cOD_TELEFONE_FKComboBox.Location = new System.Drawing.Point(150, 112);
            this.cOD_TELEFONE_FKComboBox.Name = "cOD_TELEFONE_FKComboBox";
            this.cOD_TELEFONE_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_TELEFONE_FKComboBox.TabIndex = 3;
            this.cOD_TELEFONE_FKComboBox.ValueMember = "COD_TELEFONE";
            // 
            // tELEFONEBindingSource
            // 
            this.tELEFONEBindingSource.DataMember = "TELEFONE";
            this.tELEFONEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cOD_CLIENTE_FKComboBox
            // 
            this.cOD_CLIENTE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_TEL_CLIBindingSource, "COD_CLIENTE_FK", true));
            this.cOD_CLIENTE_FKComboBox.DataSource = this.cLIENTEBindingSource;
            this.cOD_CLIENTE_FKComboBox.DisplayMember = "NOME_CLIENTE";
            this.cOD_CLIENTE_FKComboBox.FormattingEnabled = true;
            this.cOD_CLIENTE_FKComboBox.Location = new System.Drawing.Point(150, 142);
            this.cOD_CLIENTE_FKComboBox.Name = "cOD_CLIENTE_FKComboBox";
            this.cOD_CLIENTE_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_CLIENTE_FKComboBox.TabIndex = 5;
            this.cOD_CLIENTE_FKComboBox.ValueMember = "COD_CLIENTE";
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmItensClienteTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(cOD_TELEFONE_FKLabel);
            this.Controls.Add(this.cOD_TELEFONE_FKComboBox);
            this.Controls.Add(cOD_CLIENTE_FKLabel);
            this.Controls.Add(this.cOD_CLIENTE_FKComboBox);
            this.Controls.Add(this.iTENS_TEL_CLIDataGridView);
            this.Controls.Add(this.iTENS_TEL_CLIBindingNavigator);
            this.Name = "FrmItensClienteTelefone";
            this.Text = "FrmItensClienteTelefone";
            this.Load += new System.EventHandler(this.FrmItensClienteTelefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_CLIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_CLIBindingNavigator)).EndInit();
            this.iTENS_TEL_CLIBindingNavigator.ResumeLayout(false);
            this.iTENS_TEL_CLIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_CLIDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource iTENS_TEL_CLIBindingSource;
        private DB_TrabalhoDataSetTableAdapters.ITENS_TEL_CLITableAdapter iTENS_TEL_CLITableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENS_TEL_CLIBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENS_TEL_CLIBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iTENS_TEL_CLIDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cOD_TELEFONE_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_CLIENTE_FKComboBox;
        private DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}