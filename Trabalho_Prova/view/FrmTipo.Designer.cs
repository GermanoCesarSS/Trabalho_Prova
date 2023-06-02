namespace Trabalho_Prova.view
{
    partial class FrmTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipo));
            System.Windows.Forms.Label cOD_TIPOLabel;
            System.Windows.Forms.Label nOME_TIPOLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.tIPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TIPOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.tIPOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tIPOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tIPODataGridView = new System.Windows.Forms.DataGridView();
            this.cOD_TIPOTextBox = new System.Windows.Forms.TextBox();
            this.nOME_TIPOTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cOD_TIPOLabel = new System.Windows.Forms.Label();
            nOME_TIPOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingNavigator)).BeginInit();
            this.tIPOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOBindingSource
            // 
            this.tIPOBindingSource.DataMember = "TIPO";
            this.tIPOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // tIPOTableAdapter
            // 
            this.tIPOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = this.tIPOTableAdapter;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // tIPOBindingNavigator
            // 
            this.tIPOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tIPOBindingNavigator.BindingSource = this.tIPOBindingSource;
            this.tIPOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tIPOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tIPOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tIPOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tIPOBindingNavigatorSaveItem});
            this.tIPOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tIPOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tIPOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tIPOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tIPOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tIPOBindingNavigator.Name = "tIPOBindingNavigator";
            this.tIPOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tIPOBindingNavigator.Size = new System.Drawing.Size(574, 27);
            this.tIPOBindingNavigator.TabIndex = 0;
            this.tIPOBindingNavigator.Text = "bindingNavigator1";
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
            // tIPOBindingNavigatorSaveItem
            // 
            this.tIPOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tIPOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tIPOBindingNavigatorSaveItem.Image")));
            this.tIPOBindingNavigatorSaveItem.Name = "tIPOBindingNavigatorSaveItem";
            this.tIPOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tIPOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tIPOBindingNavigatorSaveItem.Click += new System.EventHandler(this.tIPOBindingNavigatorSaveItem_Click);
            // 
            // tIPODataGridView
            // 
            this.tIPODataGridView.AutoGenerateColumns = false;
            this.tIPODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tIPODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tIPODataGridView.DataSource = this.tIPOBindingSource;
            this.tIPODataGridView.Location = new System.Drawing.Point(12, 275);
            this.tIPODataGridView.Name = "tIPODataGridView";
            this.tIPODataGridView.RowHeadersWidth = 51;
            this.tIPODataGridView.RowTemplate.Height = 24;
            this.tIPODataGridView.Size = new System.Drawing.Size(542, 220);
            this.tIPODataGridView.TabIndex = 1;
            // 
            // cOD_TIPOLabel
            // 
            cOD_TIPOLabel.AutoSize = true;
            cOD_TIPOLabel.Location = new System.Drawing.Point(19, 125);
            cOD_TIPOLabel.Name = "cOD_TIPOLabel";
            cOD_TIPOLabel.Size = new System.Drawing.Size(73, 16);
            cOD_TIPOLabel.TabIndex = 2;
            cOD_TIPOLabel.Text = "COD TIPO:";
            // 
            // cOD_TIPOTextBox
            // 
            this.cOD_TIPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPOBindingSource, "COD_TIPO", true));
            this.cOD_TIPOTextBox.Location = new System.Drawing.Point(109, 122);
            this.cOD_TIPOTextBox.Name = "cOD_TIPOTextBox";
            this.cOD_TIPOTextBox.Size = new System.Drawing.Size(209, 22);
            this.cOD_TIPOTextBox.TabIndex = 3;
            // 
            // nOME_TIPOLabel
            // 
            nOME_TIPOLabel.AutoSize = true;
            nOME_TIPOLabel.Location = new System.Drawing.Point(19, 153);
            nOME_TIPOLabel.Name = "nOME_TIPOLabel";
            nOME_TIPOLabel.Size = new System.Drawing.Size(84, 16);
            nOME_TIPOLabel.TabIndex = 4;
            nOME_TIPOLabel.Text = "NOME TIPO:";
            // 
            // nOME_TIPOTextBox
            // 
            this.nOME_TIPOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tIPOBindingSource, "NOME_TIPO", true));
            this.nOME_TIPOTextBox.Location = new System.Drawing.Point(109, 150);
            this.nOME_TIPOTextBox.Name = "nOME_TIPOTextBox";
            this.nOME_TIPOTextBox.Size = new System.Drawing.Size(209, 22);
            this.nOME_TIPOTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_TIPO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_TIPO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_TIPO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_TIPO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FrmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 515);
            this.Controls.Add(cOD_TIPOLabel);
            this.Controls.Add(this.cOD_TIPOTextBox);
            this.Controls.Add(nOME_TIPOLabel);
            this.Controls.Add(this.nOME_TIPOTextBox);
            this.Controls.Add(this.tIPODataGridView);
            this.Controls.Add(this.tIPOBindingNavigator);
            this.Name = "FrmTipo";
            this.Text = "FrmTipo";
            this.Load += new System.EventHandler(this.FrmTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingNavigator)).EndInit();
            this.tIPOBindingNavigator.ResumeLayout(false);
            this.tIPOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource tIPOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.TIPOTableAdapter tIPOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tIPOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tIPOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tIPODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox cOD_TIPOTextBox;
        private System.Windows.Forms.TextBox nOME_TIPOTextBox;
    }
}