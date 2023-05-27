namespace Trabalho_Prova.view
{
    partial class FrmFuncao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncao));
            System.Windows.Forms.Label cOD_FUNCAOLabel;
            System.Windows.Forms.Label nOME_FUNCAOLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.fUNCAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCAOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FUNCAOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.fUNCAOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fUNCAOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fUNCAODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_FUNCAOLabel1 = new System.Windows.Forms.Label();
            this.nOME_FUNCAOTextBox = new System.Windows.Forms.TextBox();
            cOD_FUNCAOLabel = new System.Windows.Forms.Label();
            nOME_FUNCAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingNavigator)).BeginInit();
            this.fUNCAOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCAOBindingSource
            // 
            this.fUNCAOBindingSource.DataMember = "FUNCAO";
            this.fUNCAOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // fUNCAOTableAdapter
            // 
            this.fUNCAOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FUNCAOTableAdapter = this.fUNCAOTableAdapter;
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
            // fUNCAOBindingNavigator
            // 
            this.fUNCAOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fUNCAOBindingNavigator.BindingSource = this.fUNCAOBindingSource;
            this.fUNCAOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fUNCAOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fUNCAOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fUNCAOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fUNCAOBindingNavigatorSaveItem});
            this.fUNCAOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fUNCAOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fUNCAOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fUNCAOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fUNCAOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fUNCAOBindingNavigator.Name = "fUNCAOBindingNavigator";
            this.fUNCAOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fUNCAOBindingNavigator.Size = new System.Drawing.Size(386, 27);
            this.fUNCAOBindingNavigator.TabIndex = 0;
            this.fUNCAOBindingNavigator.Text = "bindingNavigator1";
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
            // fUNCAOBindingNavigatorSaveItem
            // 
            this.fUNCAOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fUNCAOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fUNCAOBindingNavigatorSaveItem.Image")));
            this.fUNCAOBindingNavigatorSaveItem.Name = "fUNCAOBindingNavigatorSaveItem";
            this.fUNCAOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fUNCAOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fUNCAOBindingNavigatorSaveItem.Click += new System.EventHandler(this.fUNCAOBindingNavigatorSaveItem_Click);
            // 
            // fUNCAODataGridView
            // 
            this.fUNCAODataGridView.AutoGenerateColumns = false;
            this.fUNCAODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fUNCAODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.fUNCAODataGridView.DataSource = this.fUNCAOBindingSource;
            this.fUNCAODataGridView.Location = new System.Drawing.Point(0, 190);
            this.fUNCAODataGridView.Name = "fUNCAODataGridView";
            this.fUNCAODataGridView.RowHeadersWidth = 51;
            this.fUNCAODataGridView.RowTemplate.Height = 24;
            this.fUNCAODataGridView.Size = new System.Drawing.Size(385, 220);
            this.fUNCAODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_FUNCAO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_FUNCAO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_FUNCAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_FUNCAO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_FUNCAOLabel
            // 
            cOD_FUNCAOLabel.AutoSize = true;
            cOD_FUNCAOLabel.Location = new System.Drawing.Point(35, 78);
            cOD_FUNCAOLabel.Name = "cOD_FUNCAOLabel";
            cOD_FUNCAOLabel.Size = new System.Drawing.Size(98, 16);
            cOD_FUNCAOLabel.TabIndex = 2;
            cOD_FUNCAOLabel.Text = "COD FUNCAO:";
            // 
            // cOD_FUNCAOLabel1
            // 
            this.cOD_FUNCAOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCAOBindingSource, "COD_FUNCAO", true));
            this.cOD_FUNCAOLabel1.Location = new System.Drawing.Point(150, 78);
            this.cOD_FUNCAOLabel1.Name = "cOD_FUNCAOLabel1";
            this.cOD_FUNCAOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cOD_FUNCAOLabel1.TabIndex = 3;
            this.cOD_FUNCAOLabel1.Text = "label1";
            // 
            // nOME_FUNCAOLabel
            // 
            nOME_FUNCAOLabel.AutoSize = true;
            nOME_FUNCAOLabel.Location = new System.Drawing.Point(35, 107);
            nOME_FUNCAOLabel.Name = "nOME_FUNCAOLabel";
            nOME_FUNCAOLabel.Size = new System.Drawing.Size(109, 16);
            nOME_FUNCAOLabel.TabIndex = 4;
            nOME_FUNCAOLabel.Text = "NOME FUNCAO:";
            // 
            // nOME_FUNCAOTextBox
            // 
            this.nOME_FUNCAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fUNCAOBindingSource, "NOME_FUNCAO", true));
            this.nOME_FUNCAOTextBox.Location = new System.Drawing.Point(168, 104);
            this.nOME_FUNCAOTextBox.Name = "nOME_FUNCAOTextBox";
            this.nOME_FUNCAOTextBox.Size = new System.Drawing.Size(143, 22);
            this.nOME_FUNCAOTextBox.TabIndex = 5;
            // 
            // FrmFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 412);
            this.Controls.Add(cOD_FUNCAOLabel);
            this.Controls.Add(this.cOD_FUNCAOLabel1);
            this.Controls.Add(nOME_FUNCAOLabel);
            this.Controls.Add(this.nOME_FUNCAOTextBox);
            this.Controls.Add(this.fUNCAODataGridView);
            this.Controls.Add(this.fUNCAOBindingNavigator);
            this.Name = "FrmFuncao";
            this.Text = "FrmFuncao";
            this.Load += new System.EventHandler(this.FrmFuncao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAOBindingNavigator)).EndInit();
            this.fUNCAOBindingNavigator.ResumeLayout(false);
            this.fUNCAOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCAODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource fUNCAOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.FUNCAOTableAdapter fUNCAOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fUNCAOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fUNCAOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView fUNCAODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label cOD_FUNCAOLabel1;
        private System.Windows.Forms.TextBox nOME_FUNCAOTextBox;
    }
}