namespace Trabalho_Prova.view
{
    partial class FrmTrabalho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabalho));
            System.Windows.Forms.Label cOD_TRABALHOLabel;
            System.Windows.Forms.Label nOME_TRABALHOLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.tRABALHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRABALHOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TRABALHOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.tRABALHOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tRABALHOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tRABALHODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_TRABALHOLabel1 = new System.Windows.Forms.Label();
            this.nOME_TRABALHOTextBox = new System.Windows.Forms.TextBox();
            cOD_TRABALHOLabel = new System.Windows.Forms.Label();
            nOME_TRABALHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingNavigator)).BeginInit();
            this.tRABALHOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRABALHOBindingSource
            // 
            this.tRABALHOBindingSource.DataMember = "TRABALHO";
            this.tRABALHOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // tRABALHOTableAdapter
            // 
            this.tRABALHOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = this.tRABALHOTableAdapter;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // tRABALHOBindingNavigator
            // 
            this.tRABALHOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tRABALHOBindingNavigator.BindingSource = this.tRABALHOBindingSource;
            this.tRABALHOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRABALHOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tRABALHOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tRABALHOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tRABALHOBindingNavigatorSaveItem});
            this.tRABALHOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRABALHOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRABALHOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRABALHOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRABALHOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRABALHOBindingNavigator.Name = "tRABALHOBindingNavigator";
            this.tRABALHOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRABALHOBindingNavigator.Size = new System.Drawing.Size(428, 27);
            this.tRABALHOBindingNavigator.TabIndex = 0;
            this.tRABALHOBindingNavigator.Text = "bindingNavigator1";
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
            // tRABALHOBindingNavigatorSaveItem
            // 
            this.tRABALHOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRABALHOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRABALHOBindingNavigatorSaveItem.Image")));
            this.tRABALHOBindingNavigatorSaveItem.Name = "tRABALHOBindingNavigatorSaveItem";
            this.tRABALHOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tRABALHOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tRABALHOBindingNavigatorSaveItem.Click += new System.EventHandler(this.tRABALHOBindingNavigatorSaveItem_Click);
            // 
            // tRABALHODataGridView
            // 
            this.tRABALHODataGridView.AutoGenerateColumns = false;
            this.tRABALHODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tRABALHODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tRABALHODataGridView.DataSource = this.tRABALHOBindingSource;
            this.tRABALHODataGridView.Location = new System.Drawing.Point(0, 191);
            this.tRABALHODataGridView.Name = "tRABALHODataGridView";
            this.tRABALHODataGridView.RowHeadersWidth = 51;
            this.tRABALHODataGridView.RowTemplate.Height = 24;
            this.tRABALHODataGridView.Size = new System.Drawing.Size(428, 239);
            this.tRABALHODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_TRABALHO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_TRABALHO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_TRABALHO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_TRABALHO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 225;
            // 
            // cOD_TRABALHOLabel
            // 
            cOD_TRABALHOLabel.AutoSize = true;
            cOD_TRABALHOLabel.Location = new System.Drawing.Point(12, 74);
            cOD_TRABALHOLabel.Name = "cOD_TRABALHOLabel";
            cOD_TRABALHOLabel.Size = new System.Drawing.Size(115, 16);
            cOD_TRABALHOLabel.TabIndex = 2;
            cOD_TRABALHOLabel.Text = "COD TRABALHO:";
            // 
            // cOD_TRABALHOLabel1
            // 
            this.cOD_TRABALHOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHOBindingSource, "COD_TRABALHO", true));
            this.cOD_TRABALHOLabel1.Location = new System.Drawing.Point(144, 74);
            this.cOD_TRABALHOLabel1.Name = "cOD_TRABALHOLabel1";
            this.cOD_TRABALHOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cOD_TRABALHOLabel1.TabIndex = 3;
            this.cOD_TRABALHOLabel1.Text = "label1";
            // 
            // nOME_TRABALHOLabel
            // 
            nOME_TRABALHOLabel.AutoSize = true;
            nOME_TRABALHOLabel.Location = new System.Drawing.Point(12, 103);
            nOME_TRABALHOLabel.Name = "nOME_TRABALHOLabel";
            nOME_TRABALHOLabel.Size = new System.Drawing.Size(126, 16);
            nOME_TRABALHOLabel.TabIndex = 4;
            nOME_TRABALHOLabel.Text = "NOME TRABALHO:";
            // 
            // nOME_TRABALHOTextBox
            // 
            this.nOME_TRABALHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHOBindingSource, "NOME_TRABALHO", true));
            this.nOME_TRABALHOTextBox.Location = new System.Drawing.Point(164, 100);
            this.nOME_TRABALHOTextBox.Name = "nOME_TRABALHOTextBox";
            this.nOME_TRABALHOTextBox.Size = new System.Drawing.Size(207, 22);
            this.nOME_TRABALHOTextBox.TabIndex = 5;
            // 
            // FrmTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 433);
            this.Controls.Add(cOD_TRABALHOLabel);
            this.Controls.Add(this.cOD_TRABALHOLabel1);
            this.Controls.Add(nOME_TRABALHOLabel);
            this.Controls.Add(this.nOME_TRABALHOTextBox);
            this.Controls.Add(this.tRABALHODataGridView);
            this.Controls.Add(this.tRABALHOBindingNavigator);
            this.Name = "FrmTrabalho";
            this.Text = "FrmTrabalho";
            this.Load += new System.EventHandler(this.FrmTrabalho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHOBindingNavigator)).EndInit();
            this.tRABALHOBindingNavigator.ResumeLayout(false);
            this.tRABALHOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource tRABALHOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.TRABALHOTableAdapter tRABALHOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRABALHOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tRABALHOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tRABALHODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label cOD_TRABALHOLabel1;
        private System.Windows.Forms.TextBox nOME_TRABALHOTextBox;
    }
}