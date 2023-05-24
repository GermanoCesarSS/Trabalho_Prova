namespace Trabalho_Prova.view
{
    partial class FrmSexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSexo));
            System.Windows.Forms.Label cOD_SEXOLabel;
            System.Windows.Forms.Label nOME_SEXOLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.sEXOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEXOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.SEXOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.sEXOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sEXOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sEXODataGridView = new System.Windows.Forms.DataGridView();
            this.cOD_SEXOLabel1 = new System.Windows.Forms.Label();
            this.nOME_SEXOTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cOD_SEXOLabel = new System.Windows.Forms.Label();
            nOME_SEXOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingNavigator)).BeginInit();
            this.sEXOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEXODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEXOBindingSource
            // 
            this.sEXOBindingSource.DataMember = "SEXO";
            this.sEXOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // sEXOTableAdapter
            // 
            this.sEXOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SEXOTableAdapter = this.sEXOTableAdapter;
            this.tableAdapterManager.SITUACAOTableAdapter = null;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // sEXOBindingNavigator
            // 
            this.sEXOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sEXOBindingNavigator.BindingSource = this.sEXOBindingSource;
            this.sEXOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sEXOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sEXOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sEXOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sEXOBindingNavigatorSaveItem});
            this.sEXOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sEXOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sEXOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sEXOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sEXOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sEXOBindingNavigator.Name = "sEXOBindingNavigator";
            this.sEXOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sEXOBindingNavigator.Size = new System.Drawing.Size(565, 27);
            this.sEXOBindingNavigator.TabIndex = 0;
            this.sEXOBindingNavigator.Text = "bindingNavigator1";
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
            // sEXOBindingNavigatorSaveItem
            // 
            this.sEXOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sEXOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sEXOBindingNavigatorSaveItem.Image")));
            this.sEXOBindingNavigatorSaveItem.Name = "sEXOBindingNavigatorSaveItem";
            this.sEXOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sEXOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.sEXOBindingNavigatorSaveItem.Click += new System.EventHandler(this.sEXOBindingNavigatorSaveItem_Click);
            // 
            // sEXODataGridView
            // 
            this.sEXODataGridView.AutoGenerateColumns = false;
            this.sEXODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sEXODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sEXODataGridView.DataSource = this.sEXOBindingSource;
            this.sEXODataGridView.Location = new System.Drawing.Point(0, 200);
            this.sEXODataGridView.Name = "sEXODataGridView";
            this.sEXODataGridView.RowHeadersWidth = 51;
            this.sEXODataGridView.RowTemplate.Height = 24;
            this.sEXODataGridView.Size = new System.Drawing.Size(565, 251);
            this.sEXODataGridView.TabIndex = 1;
            // 
            // cOD_SEXOLabel
            // 
            cOD_SEXOLabel.AutoSize = true;
            cOD_SEXOLabel.Location = new System.Drawing.Point(33, 91);
            cOD_SEXOLabel.Name = "cOD_SEXOLabel";
            cOD_SEXOLabel.Size = new System.Drawing.Size(78, 16);
            cOD_SEXOLabel.TabIndex = 2;
            cOD_SEXOLabel.Text = "COD SEXO:";
            // 
            // cOD_SEXOLabel1
            // 
            this.cOD_SEXOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sEXOBindingSource, "COD_SEXO", true));
            this.cOD_SEXOLabel1.Location = new System.Drawing.Point(128, 91);
            this.cOD_SEXOLabel1.Name = "cOD_SEXOLabel1";
            this.cOD_SEXOLabel1.Size = new System.Drawing.Size(211, 23);
            this.cOD_SEXOLabel1.TabIndex = 3;
            this.cOD_SEXOLabel1.Text = "label1";
            // 
            // nOME_SEXOLabel
            // 
            nOME_SEXOLabel.AutoSize = true;
            nOME_SEXOLabel.Location = new System.Drawing.Point(33, 120);
            nOME_SEXOLabel.Name = "nOME_SEXOLabel";
            nOME_SEXOLabel.Size = new System.Drawing.Size(89, 16);
            nOME_SEXOLabel.TabIndex = 4;
            nOME_SEXOLabel.Text = "NOME SEXO:";
            // 
            // nOME_SEXOTextBox
            // 
            this.nOME_SEXOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sEXOBindingSource, "NOME_SEXO", true));
            this.nOME_SEXOTextBox.Location = new System.Drawing.Point(128, 117);
            this.nOME_SEXOTextBox.Name = "nOME_SEXOTextBox";
            this.nOME_SEXOTextBox.Size = new System.Drawing.Size(211, 22);
            this.nOME_SEXOTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_SEXO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_SEXO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_SEXO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_SEXO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FrmSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(cOD_SEXOLabel);
            this.Controls.Add(this.cOD_SEXOLabel1);
            this.Controls.Add(nOME_SEXOLabel);
            this.Controls.Add(this.nOME_SEXOTextBox);
            this.Controls.Add(this.sEXODataGridView);
            this.Controls.Add(this.sEXOBindingNavigator);
            this.Name = "FrmSexo";
            this.Text = "FrmSexo";
            this.Load += new System.EventHandler(this.FrmSexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEXOBindingNavigator)).EndInit();
            this.sEXOBindingNavigator.ResumeLayout(false);
            this.sEXOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sEXODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource sEXOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.SEXOTableAdapter sEXOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sEXOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sEXOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sEXODataGridView;
        private System.Windows.Forms.Label cOD_SEXOLabel1;
        private System.Windows.Forms.TextBox nOME_SEXOTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}