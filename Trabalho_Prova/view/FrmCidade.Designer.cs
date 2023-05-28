namespace Trabalho_Prova.view
{
    partial class FrmCidade
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
            System.Windows.Forms.Label cOD_CIDADELabel;
            System.Windows.Forms.Label nOME_CIDADELabel;
            System.Windows.Forms.Label cOD_UF_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCidade));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.cIDADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cIDADETableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CIDADETableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.uFTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.UFTableAdapter();
            this.cIDADEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cIDADEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cIDADEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_CIDADELabel1 = new System.Windows.Forms.Label();
            this.nOME_CIDADETextBox = new System.Windows.Forms.TextBox();
            this.cOD_UF_FKComboBox = new System.Windows.Forms.ComboBox();
            this.uFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            cOD_CIDADELabel = new System.Windows.Forms.Label();
            nOME_CIDADELabel = new System.Windows.Forms.Label();
            cOD_UF_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingNavigator)).BeginInit();
            this.cIDADEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_CIDADELabel
            // 
            cOD_CIDADELabel.AutoSize = true;
            cOD_CIDADELabel.Location = new System.Drawing.Point(12, 95);
            cOD_CIDADELabel.Name = "cOD_CIDADELabel";
            cOD_CIDADELabel.Size = new System.Drawing.Size(92, 16);
            cOD_CIDADELabel.TabIndex = 2;
            cOD_CIDADELabel.Text = "COD CIDADE:";
            // 
            // nOME_CIDADELabel
            // 
            nOME_CIDADELabel.AutoSize = true;
            nOME_CIDADELabel.Location = new System.Drawing.Point(12, 124);
            nOME_CIDADELabel.Name = "nOME_CIDADELabel";
            nOME_CIDADELabel.Size = new System.Drawing.Size(103, 16);
            nOME_CIDADELabel.TabIndex = 4;
            nOME_CIDADELabel.Text = "NOME CIDADE:";
            // 
            // cOD_UF_FKLabel
            // 
            cOD_UF_FKLabel.AutoSize = true;
            cOD_UF_FKLabel.Location = new System.Drawing.Point(12, 152);
            cOD_UF_FKLabel.Name = "cOD_UF_FKLabel";
            cOD_UF_FKLabel.Size = new System.Drawing.Size(79, 16);
            cOD_UF_FKLabel.TabIndex = 6;
            cOD_UF_FKLabel.Text = "COD UF FK:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cIDADEBindingSource
            // 
            this.cIDADEBindingSource.DataMember = "CIDADE";
            this.cIDADEBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cIDADETableAdapter
            // 
            this.cIDADETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = null;
            this.tableAdapterManager.CIDADETableAdapter = this.cIDADETableAdapter;
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
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = this.uFTableAdapter;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // uFTableAdapter
            // 
            this.uFTableAdapter.ClearBeforeFill = true;
            // 
            // cIDADEBindingNavigator
            // 
            this.cIDADEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cIDADEBindingNavigator.BindingSource = this.cIDADEBindingSource;
            this.cIDADEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cIDADEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cIDADEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cIDADEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cIDADEBindingNavigatorSaveItem});
            this.cIDADEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cIDADEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cIDADEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cIDADEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cIDADEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cIDADEBindingNavigator.Name = "cIDADEBindingNavigator";
            this.cIDADEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cIDADEBindingNavigator.Size = new System.Drawing.Size(553, 27);
            this.cIDADEBindingNavigator.TabIndex = 0;
            this.cIDADEBindingNavigator.Text = "bindingNavigator1";
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
            // cIDADEBindingNavigatorSaveItem
            // 
            this.cIDADEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cIDADEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cIDADEBindingNavigatorSaveItem.Image")));
            this.cIDADEBindingNavigatorSaveItem.Name = "cIDADEBindingNavigatorSaveItem";
            this.cIDADEBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cIDADEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cIDADEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cIDADEBindingNavigatorSaveItem_Click);
            // 
            // cIDADEDataGridView
            // 
            this.cIDADEDataGridView.AutoGenerateColumns = false;
            this.cIDADEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cIDADEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cIDADEDataGridView.DataSource = this.cIDADEBindingSource;
            this.cIDADEDataGridView.Location = new System.Drawing.Point(0, 280);
            this.cIDADEDataGridView.Name = "cIDADEDataGridView";
            this.cIDADEDataGridView.RowHeadersWidth = 51;
            this.cIDADEDataGridView.RowTemplate.Height = 24;
            this.cIDADEDataGridView.Size = new System.Drawing.Size(553, 230);
            this.cIDADEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_CIDADE";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_CIDADE";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CIDADE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_CIDADE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COD_UF_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "COD_UF_FK";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // cOD_CIDADELabel1
            // 
            this.cOD_CIDADELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIDADEBindingSource, "COD_CIDADE", true));
            this.cOD_CIDADELabel1.Location = new System.Drawing.Point(166, 95);
            this.cOD_CIDADELabel1.Name = "cOD_CIDADELabel1";
            this.cOD_CIDADELabel1.Size = new System.Drawing.Size(121, 23);
            this.cOD_CIDADELabel1.TabIndex = 3;
            this.cOD_CIDADELabel1.Text = "label1";
            // 
            // nOME_CIDADETextBox
            // 
            this.nOME_CIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cIDADEBindingSource, "NOME_CIDADE", true));
            this.nOME_CIDADETextBox.Location = new System.Drawing.Point(166, 121);
            this.nOME_CIDADETextBox.Name = "nOME_CIDADETextBox";
            this.nOME_CIDADETextBox.Size = new System.Drawing.Size(268, 22);
            this.nOME_CIDADETextBox.TabIndex = 5;
            // 
            // cOD_UF_FKComboBox
            // 
            this.cOD_UF_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cIDADEBindingSource, "COD_UF_FK", true));
            this.cOD_UF_FKComboBox.DataSource = this.uFBindingSource;
            this.cOD_UF_FKComboBox.DisplayMember = "SIGLA";
            this.cOD_UF_FKComboBox.FormattingEnabled = true;
            this.cOD_UF_FKComboBox.Location = new System.Drawing.Point(166, 149);
            this.cOD_UF_FKComboBox.Name = "cOD_UF_FKComboBox";
            this.cOD_UF_FKComboBox.Size = new System.Drawing.Size(268, 24);
            this.cOD_UF_FKComboBox.TabIndex = 7;
            this.cOD_UF_FKComboBox.ValueMember = "COD_UF";
            // 
            // uFBindingSource
            // 
            this.uFBindingSource.DataMember = "UF";
            this.uFBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(cOD_CIDADELabel);
            this.Controls.Add(this.cOD_CIDADELabel1);
            this.Controls.Add(nOME_CIDADELabel);
            this.Controls.Add(this.nOME_CIDADETextBox);
            this.Controls.Add(cOD_UF_FKLabel);
            this.Controls.Add(this.cOD_UF_FKComboBox);
            this.Controls.Add(this.cIDADEDataGridView);
            this.Controls.Add(this.cIDADEBindingNavigator);
            this.Name = "FrmCidade";
            this.Text = "FrmCidade";
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEBindingNavigator)).EndInit();
            this.cIDADEBindingNavigator.ResumeLayout(false);
            this.cIDADEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource cIDADEBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CIDADETableAdapter cIDADETableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cIDADEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cIDADEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cIDADEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label cOD_CIDADELabel1;
        private System.Windows.Forms.TextBox nOME_CIDADETextBox;
        private System.Windows.Forms.ComboBox cOD_UF_FKComboBox;
        private DB_TrabalhoDataSetTableAdapters.UFTableAdapter uFTableAdapter;
        private System.Windows.Forms.BindingSource uFBindingSource;
        private System.Windows.Forms.Button button1;
    }
}