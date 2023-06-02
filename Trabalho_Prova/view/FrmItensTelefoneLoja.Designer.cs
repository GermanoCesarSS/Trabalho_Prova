namespace Trabalho_Prova.view
{
    partial class FrmItensTelefoneLoja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensTelefoneLoja));
            System.Windows.Forms.Label cOD_LOJA_FKLabel;
            System.Windows.Forms.Label cOD_TELEFONE_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.iTENS_TEL_LOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENS_TEL_LOJATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.ITENS_TEL_LOJATableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.iTENS_TEL_LOJABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENS_TEL_LOJABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iTENS_TEL_LOJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_LOJA_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_TELEFONE_FKComboBox = new System.Windows.Forms.ComboBox();
            this.lOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOJATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.LOJATableAdapter();
            this.tELEFONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tELEFONETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            cOD_LOJA_FKLabel = new System.Windows.Forms.Label();
            cOD_TELEFONE_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_LOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_LOJABindingNavigator)).BeginInit();
            this.iTENS_TEL_LOJABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_LOJADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENS_TEL_LOJABindingSource
            // 
            this.iTENS_TEL_LOJABindingSource.DataMember = "ITENS_TEL_LOJA";
            this.iTENS_TEL_LOJABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // iTENS_TEL_LOJATableAdapter
            // 
            this.iTENS_TEL_LOJATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENS_TEL_LOJATableAdapter = this.iTENS_TEL_LOJATableAdapter;
            this.tableAdapterManager.ITENS_TEL_TRATableAdapter = null;
            this.tableAdapterManager.ITENS_VENDAPRODUTOTableAdapter = null;
            this.tableAdapterManager.LOGINSTableAdapter = null;
            this.tableAdapterManager.LOJATableAdapter = this.lOJATableAdapter;
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
            // iTENS_TEL_LOJABindingNavigator
            // 
            this.iTENS_TEL_LOJABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENS_TEL_LOJABindingNavigator.BindingSource = this.iTENS_TEL_LOJABindingSource;
            this.iTENS_TEL_LOJABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENS_TEL_LOJABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENS_TEL_LOJABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iTENS_TEL_LOJABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENS_TEL_LOJABindingNavigatorSaveItem});
            this.iTENS_TEL_LOJABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENS_TEL_LOJABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENS_TEL_LOJABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENS_TEL_LOJABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENS_TEL_LOJABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENS_TEL_LOJABindingNavigator.Name = "iTENS_TEL_LOJABindingNavigator";
            this.iTENS_TEL_LOJABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENS_TEL_LOJABindingNavigator.Size = new System.Drawing.Size(412, 27);
            this.iTENS_TEL_LOJABindingNavigator.TabIndex = 0;
            this.iTENS_TEL_LOJABindingNavigator.Text = "bindingNavigator1";
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
            // iTENS_TEL_LOJABindingNavigatorSaveItem
            // 
            this.iTENS_TEL_LOJABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENS_TEL_LOJABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENS_TEL_LOJABindingNavigatorSaveItem.Image")));
            this.iTENS_TEL_LOJABindingNavigatorSaveItem.Name = "iTENS_TEL_LOJABindingNavigatorSaveItem";
            this.iTENS_TEL_LOJABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iTENS_TEL_LOJABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENS_TEL_LOJABindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENS_TEL_LOJABindingNavigatorSaveItem_Click);
            // 
            // iTENS_TEL_LOJADataGridView
            // 
            this.iTENS_TEL_LOJADataGridView.AutoGenerateColumns = false;
            this.iTENS_TEL_LOJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENS_TEL_LOJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENS_TEL_LOJADataGridView.DataSource = this.iTENS_TEL_LOJABindingSource;
            this.iTENS_TEL_LOJADataGridView.Location = new System.Drawing.Point(0, 203);
            this.iTENS_TEL_LOJADataGridView.Name = "iTENS_TEL_LOJADataGridView";
            this.iTENS_TEL_LOJADataGridView.RowHeadersWidth = 51;
            this.iTENS_TEL_LOJADataGridView.RowTemplate.Height = 24;
            this.iTENS_TEL_LOJADataGridView.Size = new System.Drawing.Size(413, 250);
            this.iTENS_TEL_LOJADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_LOJA_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_LOJA_FK";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_TELEFONE_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_TELEFONE_FK";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 225;
            // 
            // cOD_LOJA_FKLabel
            // 
            cOD_LOJA_FKLabel.AutoSize = true;
            cOD_LOJA_FKLabel.Location = new System.Drawing.Point(34, 69);
            cOD_LOJA_FKLabel.Name = "cOD_LOJA_FKLabel";
            cOD_LOJA_FKLabel.Size = new System.Drawing.Size(94, 16);
            cOD_LOJA_FKLabel.TabIndex = 2;
            cOD_LOJA_FKLabel.Text = "COD LOJA FK:";
            // 
            // cOD_LOJA_FKComboBox
            // 
            this.cOD_LOJA_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_TEL_LOJABindingSource, "COD_LOJA_FK", true));
            this.cOD_LOJA_FKComboBox.DataSource = this.lOJABindingSource;
            this.cOD_LOJA_FKComboBox.DisplayMember = "NOME_LOJA";
            this.cOD_LOJA_FKComboBox.FormattingEnabled = true;
            this.cOD_LOJA_FKComboBox.Location = new System.Drawing.Point(172, 66);
            this.cOD_LOJA_FKComboBox.Name = "cOD_LOJA_FKComboBox";
            this.cOD_LOJA_FKComboBox.Size = new System.Drawing.Size(117, 24);
            this.cOD_LOJA_FKComboBox.TabIndex = 3;
            this.cOD_LOJA_FKComboBox.ValueMember = "COD_LOJA";
            // 
            // cOD_TELEFONE_FKLabel
            // 
            cOD_TELEFONE_FKLabel.AutoSize = true;
            cOD_TELEFONE_FKLabel.Location = new System.Drawing.Point(34, 117);
            cOD_TELEFONE_FKLabel.Name = "cOD_TELEFONE_FKLabel";
            cOD_TELEFONE_FKLabel.Size = new System.Drawing.Size(132, 16);
            cOD_TELEFONE_FKLabel.TabIndex = 4;
            cOD_TELEFONE_FKLabel.Text = "COD TELEFONE FK:";
            // 
            // cOD_TELEFONE_FKComboBox
            // 
            this.cOD_TELEFONE_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iTENS_TEL_LOJABindingSource, "COD_TELEFONE_FK", true));
            this.cOD_TELEFONE_FKComboBox.DataSource = this.tELEFONEBindingSource;
            this.cOD_TELEFONE_FKComboBox.DisplayMember = "NUMERO";
            this.cOD_TELEFONE_FKComboBox.FormattingEnabled = true;
            this.cOD_TELEFONE_FKComboBox.Location = new System.Drawing.Point(172, 114);
            this.cOD_TELEFONE_FKComboBox.Name = "cOD_TELEFONE_FKComboBox";
            this.cOD_TELEFONE_FKComboBox.Size = new System.Drawing.Size(117, 24);
            this.cOD_TELEFONE_FKComboBox.TabIndex = 5;
            this.cOD_TELEFONE_FKComboBox.ValueMember = "COD_TELEFONE";
            // 
            // lOJABindingSource
            // 
            this.lOJABindingSource.DataMember = "LOJA";
            this.lOJABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // lOJATableAdapter
            // 
            this.lOJATableAdapter.ClearBeforeFill = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmItensTelefoneLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(cOD_LOJA_FKLabel);
            this.Controls.Add(this.cOD_LOJA_FKComboBox);
            this.Controls.Add(cOD_TELEFONE_FKLabel);
            this.Controls.Add(this.cOD_TELEFONE_FKComboBox);
            this.Controls.Add(this.iTENS_TEL_LOJADataGridView);
            this.Controls.Add(this.iTENS_TEL_LOJABindingNavigator);
            this.Name = "FrmItensTelefoneLoja";
            this.Text = "FrmItensTelefoneLoja";
            this.Load += new System.EventHandler(this.FrmItensTelefoneLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_LOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_LOJABindingNavigator)).EndInit();
            this.iTENS_TEL_LOJABindingNavigator.ResumeLayout(false);
            this.iTENS_TEL_LOJABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_TEL_LOJADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tELEFONEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource iTENS_TEL_LOJABindingSource;
        private DB_TrabalhoDataSetTableAdapters.ITENS_TEL_LOJATableAdapter iTENS_TEL_LOJATableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENS_TEL_LOJABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENS_TEL_LOJABindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iTENS_TEL_LOJADataGridView;
        private DB_TrabalhoDataSetTableAdapters.LOJATableAdapter lOJATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cOD_LOJA_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_TELEFONE_FKComboBox;
        private System.Windows.Forms.BindingSource lOJABindingSource;
        private DB_TrabalhoDataSetTableAdapters.TELEFONETableAdapter tELEFONETableAdapter;
        private System.Windows.Forms.BindingSource tELEFONEBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}