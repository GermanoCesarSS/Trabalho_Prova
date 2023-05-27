namespace Trabalho_Prova.view
{
    partial class FrmOperadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperadora));
            System.Windows.Forms.Label cOD_OPERADORALabel;
            System.Windows.Forms.Label nOME_OPERADORALabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.oPERADORABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPERADORATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.OPERADORATableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.oPERADORABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oPERADORABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oPERADORADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_OPERADORALabel1 = new System.Windows.Forms.Label();
            this.nOME_OPERADORATextBox = new System.Windows.Forms.TextBox();
            cOD_OPERADORALabel = new System.Windows.Forms.Label();
            nOME_OPERADORALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingNavigator)).BeginInit();
            this.oPERADORABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.OPERADORATableAdapter = this.oPERADORATableAdapter;
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
            // oPERADORABindingNavigator
            // 
            this.oPERADORABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oPERADORABindingNavigator.BindingSource = this.oPERADORABindingSource;
            this.oPERADORABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oPERADORABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oPERADORABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oPERADORABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oPERADORABindingNavigatorSaveItem});
            this.oPERADORABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oPERADORABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oPERADORABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oPERADORABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oPERADORABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oPERADORABindingNavigator.Name = "oPERADORABindingNavigator";
            this.oPERADORABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oPERADORABindingNavigator.Size = new System.Drawing.Size(515, 27);
            this.oPERADORABindingNavigator.TabIndex = 0;
            this.oPERADORABindingNavigator.Text = "bindingNavigator1";
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
            // oPERADORABindingNavigatorSaveItem
            // 
            this.oPERADORABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oPERADORABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oPERADORABindingNavigatorSaveItem.Image")));
            this.oPERADORABindingNavigatorSaveItem.Name = "oPERADORABindingNavigatorSaveItem";
            this.oPERADORABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.oPERADORABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.oPERADORABindingNavigatorSaveItem.Click += new System.EventHandler(this.oPERADORABindingNavigatorSaveItem_Click);
            // 
            // oPERADORADataGridView
            // 
            this.oPERADORADataGridView.AutoGenerateColumns = false;
            this.oPERADORADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oPERADORADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.oPERADORADataGridView.DataSource = this.oPERADORABindingSource;
            this.oPERADORADataGridView.Location = new System.Drawing.Point(0, 204);
            this.oPERADORADataGridView.Name = "oPERADORADataGridView";
            this.oPERADORADataGridView.RowHeadersWidth = 51;
            this.oPERADORADataGridView.RowTemplate.Height = 24;
            this.oPERADORADataGridView.Size = new System.Drawing.Size(515, 241);
            this.oPERADORADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_OPERADORA";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_OPERADORA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_OPERADORA";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_OPERADORA";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_OPERADORALabel
            // 
            cOD_OPERADORALabel.AutoSize = true;
            cOD_OPERADORALabel.Location = new System.Drawing.Point(30, 95);
            cOD_OPERADORALabel.Name = "cOD_OPERADORALabel";
            cOD_OPERADORALabel.Size = new System.Drawing.Size(128, 16);
            cOD_OPERADORALabel.TabIndex = 2;
            cOD_OPERADORALabel.Text = "COD OPERADORA:";
            // 
            // cOD_OPERADORALabel1
            // 
            this.cOD_OPERADORALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPERADORABindingSource, "COD_OPERADORA", true));
            this.cOD_OPERADORALabel1.Location = new System.Drawing.Point(175, 95);
            this.cOD_OPERADORALabel1.Name = "cOD_OPERADORALabel1";
            this.cOD_OPERADORALabel1.Size = new System.Drawing.Size(100, 23);
            this.cOD_OPERADORALabel1.TabIndex = 3;
            this.cOD_OPERADORALabel1.Text = "label1";
            // 
            // nOME_OPERADORALabel
            // 
            nOME_OPERADORALabel.AutoSize = true;
            nOME_OPERADORALabel.Location = new System.Drawing.Point(30, 124);
            nOME_OPERADORALabel.Name = "nOME_OPERADORALabel";
            nOME_OPERADORALabel.Size = new System.Drawing.Size(139, 16);
            nOME_OPERADORALabel.TabIndex = 4;
            nOME_OPERADORALabel.Text = "NOME OPERADORA:";
            // 
            // nOME_OPERADORATextBox
            // 
            this.nOME_OPERADORATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPERADORABindingSource, "NOME_OPERADORA", true));
            this.nOME_OPERADORATextBox.Location = new System.Drawing.Point(175, 121);
            this.nOME_OPERADORATextBox.Name = "nOME_OPERADORATextBox";
            this.nOME_OPERADORATextBox.Size = new System.Drawing.Size(322, 22);
            this.nOME_OPERADORATextBox.TabIndex = 5;
            // 
            // FrmOperadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 446);
            this.Controls.Add(cOD_OPERADORALabel);
            this.Controls.Add(this.cOD_OPERADORALabel1);
            this.Controls.Add(nOME_OPERADORALabel);
            this.Controls.Add(this.nOME_OPERADORATextBox);
            this.Controls.Add(this.oPERADORADataGridView);
            this.Controls.Add(this.oPERADORABindingNavigator);
            this.Name = "FrmOperadora";
            this.Text = "FrmOperadora";
            this.Load += new System.EventHandler(this.FrmOperadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORABindingNavigator)).EndInit();
            this.oPERADORABindingNavigator.ResumeLayout(false);
            this.oPERADORABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPERADORADataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource oPERADORABindingSource;
        private DB_TrabalhoDataSetTableAdapters.OPERADORATableAdapter oPERADORATableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oPERADORABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oPERADORABindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView oPERADORADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label cOD_OPERADORALabel1;
        private System.Windows.Forms.TextBox nOME_OPERADORATextBox;
    }
}