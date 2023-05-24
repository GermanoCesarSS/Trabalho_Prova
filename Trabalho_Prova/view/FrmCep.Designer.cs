namespace Trabalho_Prova.view
{
    partial class FrmCep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCep));
            System.Windows.Forms.Label cOD_CEPLabel;
            System.Windows.Forms.Label nUMERO_CEPLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.cEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cEPTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CEPTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.cEPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cEPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cEPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_CEPLabel1 = new System.Windows.Forms.Label();
            this.nUMERO_CEPTextBox = new System.Windows.Forms.TextBox();
            cOD_CEPLabel = new System.Windows.Forms.Label();
            nUMERO_CEPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingNavigator)).BeginInit();
            this.cEPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEPDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cEPBindingSource
            // 
            this.cEPBindingSource.DataMember = "CEP";
            this.cEPBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cEPTableAdapter
            // 
            this.cEPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAIRROTableAdapter = null;
            this.tableAdapterManager.CEPTableAdapter = this.cEPTableAdapter;
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
            // cEPBindingNavigator
            // 
            this.cEPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cEPBindingNavigator.BindingSource = this.cEPBindingSource;
            this.cEPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cEPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cEPBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cEPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cEPBindingNavigatorSaveItem});
            this.cEPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cEPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cEPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cEPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cEPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cEPBindingNavigator.Name = "cEPBindingNavigator";
            this.cEPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cEPBindingNavigator.Size = new System.Drawing.Size(430, 27);
            this.cEPBindingNavigator.TabIndex = 0;
            this.cEPBindingNavigator.Text = "bindingNavigator1";
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
            // cEPBindingNavigatorSaveItem
            // 
            this.cEPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cEPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cEPBindingNavigatorSaveItem.Image")));
            this.cEPBindingNavigatorSaveItem.Name = "cEPBindingNavigatorSaveItem";
            this.cEPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cEPBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cEPBindingNavigatorSaveItem.Click += new System.EventHandler(this.cEPBindingNavigatorSaveItem_Click);
            // 
            // cEPDataGridView
            // 
            this.cEPDataGridView.AutoGenerateColumns = false;
            this.cEPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cEPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cEPDataGridView.DataSource = this.cEPBindingSource;
            this.cEPDataGridView.Location = new System.Drawing.Point(0, 231);
            this.cEPDataGridView.Name = "cEPDataGridView";
            this.cEPDataGridView.RowHeadersWidth = 51;
            this.cEPDataGridView.RowTemplate.Height = 24;
            this.cEPDataGridView.Size = new System.Drawing.Size(410, 220);
            this.cEPDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_CEP";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_CEP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUMERO_CEP";
            this.dataGridViewTextBoxColumn2.HeaderText = "NUMERO_CEP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_CEPLabel
            // 
            cOD_CEPLabel.AutoSize = true;
            cOD_CEPLabel.Location = new System.Drawing.Point(15, 79);
            cOD_CEPLabel.Name = "cOD_CEPLabel";
            cOD_CEPLabel.Size = new System.Drawing.Size(69, 16);
            cOD_CEPLabel.TabIndex = 2;
            cOD_CEPLabel.Text = "COD CEP:";
            // 
            // cOD_CEPLabel1
            // 
            this.cOD_CEPLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cEPBindingSource, "COD_CEP", true));
            this.cOD_CEPLabel1.Location = new System.Drawing.Point(121, 79);
            this.cOD_CEPLabel1.Name = "cOD_CEPLabel1";
            this.cOD_CEPLabel1.Size = new System.Drawing.Size(246, 23);
            this.cOD_CEPLabel1.TabIndex = 3;
            this.cOD_CEPLabel1.Text = "label1";
            // 
            // nUMERO_CEPLabel
            // 
            nUMERO_CEPLabel.AutoSize = true;
            nUMERO_CEPLabel.Location = new System.Drawing.Point(15, 108);
            nUMERO_CEPLabel.Name = "nUMERO_CEPLabel";
            nUMERO_CEPLabel.Size = new System.Drawing.Size(100, 16);
            nUMERO_CEPLabel.TabIndex = 4;
            nUMERO_CEPLabel.Text = "NUMERO CEP:";
            // 
            // nUMERO_CEPTextBox
            // 
            this.nUMERO_CEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cEPBindingSource, "NUMERO_CEP", true));
            this.nUMERO_CEPTextBox.Location = new System.Drawing.Point(121, 105);
            this.nUMERO_CEPTextBox.Name = "nUMERO_CEPTextBox";
            this.nUMERO_CEPTextBox.Size = new System.Drawing.Size(246, 22);
            this.nUMERO_CEPTextBox.TabIndex = 5;
            // 
            // FrmCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 471);
            this.Controls.Add(cOD_CEPLabel);
            this.Controls.Add(this.cOD_CEPLabel1);
            this.Controls.Add(nUMERO_CEPLabel);
            this.Controls.Add(this.nUMERO_CEPTextBox);
            this.Controls.Add(this.cEPDataGridView);
            this.Controls.Add(this.cEPBindingNavigator);
            this.Name = "FrmCep";
            this.Text = "FrmCep";
            this.Load += new System.EventHandler(this.FrmCep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPBindingNavigator)).EndInit();
            this.cEPBindingNavigator.ResumeLayout(false);
            this.cEPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEPDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource cEPBindingSource;
        private DB_TrabalhoDataSetTableAdapters.CEPTableAdapter cEPTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cEPBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cEPBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cEPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label cOD_CEPLabel1;
        private System.Windows.Forms.TextBox nUMERO_CEPTextBox;
    }
}