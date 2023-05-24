namespace Trabalho_Prova.view
{
    partial class FrmBairro
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
            System.Windows.Forms.Label cOD_BAIRROLabel;
            System.Windows.Forms.Label nOME_BAIRROLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBairro));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.bAIRROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAIRROTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.BAIRROTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.bAIRROBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bAIRROBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bAIRRODataGridView = new System.Windows.Forms.DataGridView();
            this.cOD_BAIRROLabel1 = new System.Windows.Forms.Label();
            this.nOME_BAIRROTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cOD_BAIRROLabel = new System.Windows.Forms.Label();
            nOME_BAIRROLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingNavigator)).BeginInit();
            this.bAIRROBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRRODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_BAIRROLabel
            // 
            cOD_BAIRROLabel.AutoSize = true;
            cOD_BAIRROLabel.Location = new System.Drawing.Point(28, 85);
            cOD_BAIRROLabel.Name = "cOD_BAIRROLabel";
            cOD_BAIRROLabel.Size = new System.Drawing.Size(93, 16);
            cOD_BAIRROLabel.TabIndex = 2;
            cOD_BAIRROLabel.Text = "COD BAIRRO:";
            // 
            // nOME_BAIRROLabel
            // 
            nOME_BAIRROLabel.AutoSize = true;
            nOME_BAIRROLabel.Location = new System.Drawing.Point(28, 114);
            nOME_BAIRROLabel.Name = "nOME_BAIRROLabel";
            nOME_BAIRROLabel.Size = new System.Drawing.Size(104, 16);
            nOME_BAIRROLabel.TabIndex = 4;
            nOME_BAIRROLabel.Text = "NOME BAIRRO:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bAIRROBindingSource
            // 
            this.bAIRROBindingSource.DataMember = "BAIRRO";
            this.bAIRROBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // bAIRROTableAdapter
            // 
            this.bAIRROTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = this.bAIRROTableAdapter;
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
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // bAIRROBindingNavigator
            // 
            this.bAIRROBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bAIRROBindingNavigator.BindingSource = this.bAIRROBindingSource;
            this.bAIRROBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bAIRROBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bAIRROBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bAIRROBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bAIRROBindingNavigatorSaveItem});
            this.bAIRROBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bAIRROBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bAIRROBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bAIRROBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bAIRROBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bAIRROBindingNavigator.Name = "bAIRROBindingNavigator";
            this.bAIRROBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bAIRROBindingNavigator.Size = new System.Drawing.Size(566, 27);
            this.bAIRROBindingNavigator.TabIndex = 0;
            this.bAIRROBindingNavigator.Text = "bindingNavigator1";
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
            // bAIRROBindingNavigatorSaveItem
            // 
            this.bAIRROBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAIRROBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bAIRROBindingNavigatorSaveItem.Image")));
            this.bAIRROBindingNavigatorSaveItem.Name = "bAIRROBindingNavigatorSaveItem";
            this.bAIRROBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bAIRROBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.bAIRROBindingNavigatorSaveItem.Click += new System.EventHandler(this.bAIRROBindingNavigatorSaveItem_Click);
            // 
            // bAIRRODataGridView
            // 
            this.bAIRRODataGridView.AutoGenerateColumns = false;
            this.bAIRRODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bAIRRODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bAIRRODataGridView.DataSource = this.bAIRROBindingSource;
            this.bAIRRODataGridView.Location = new System.Drawing.Point(0, 232);
            this.bAIRRODataGridView.Name = "bAIRRODataGridView";
            this.bAIRRODataGridView.RowHeadersWidth = 51;
            this.bAIRRODataGridView.RowTemplate.Height = 24;
            this.bAIRRODataGridView.Size = new System.Drawing.Size(566, 240);
            this.bAIRRODataGridView.TabIndex = 1;
            // 
            // cOD_BAIRROLabel1
            // 
            this.cOD_BAIRROLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAIRROBindingSource, "COD_BAIRRO", true));
            this.cOD_BAIRROLabel1.Location = new System.Drawing.Point(138, 85);
            this.cOD_BAIRROLabel1.Name = "cOD_BAIRROLabel1";
            this.cOD_BAIRROLabel1.Size = new System.Drawing.Size(189, 23);
            this.cOD_BAIRROLabel1.TabIndex = 3;
            this.cOD_BAIRROLabel1.Text = "label1";
            // 
            // nOME_BAIRROTextBox
            // 
            this.nOME_BAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAIRROBindingSource, "NOME_BAIRRO", true));
            this.nOME_BAIRROTextBox.Location = new System.Drawing.Point(138, 111);
            this.nOME_BAIRROTextBox.Name = "nOME_BAIRROTextBox";
            this.nOME_BAIRROTextBox.Size = new System.Drawing.Size(189, 22);
            this.nOME_BAIRROTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_BAIRRO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_BAIRRO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_BAIRRO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_BAIRRO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FrmBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 472);
            this.Controls.Add(cOD_BAIRROLabel);
            this.Controls.Add(this.cOD_BAIRROLabel1);
            this.Controls.Add(nOME_BAIRROLabel);
            this.Controls.Add(this.nOME_BAIRROTextBox);
            this.Controls.Add(this.bAIRRODataGridView);
            this.Controls.Add(this.bAIRROBindingNavigator);
            this.Name = "FrmBairro";
            this.Text = "FrmBairro";
            this.Load += new System.EventHandler(this.FrmBairro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRROBindingNavigator)).EndInit();
            this.bAIRROBindingNavigator.ResumeLayout(false);
            this.bAIRROBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAIRRODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource bAIRROBindingSource;
        private DB_TrabalhoDataSetTableAdapters.BAIRROTableAdapter bAIRROTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bAIRROBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bAIRROBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bAIRRODataGridView;
        private System.Windows.Forms.Label cOD_BAIRROLabel1;
        private System.Windows.Forms.TextBox nOME_BAIRROTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}