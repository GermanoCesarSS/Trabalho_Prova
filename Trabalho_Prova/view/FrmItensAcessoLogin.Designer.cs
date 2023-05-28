namespace Trabalho_Prova.view
{
    partial class FrmItensAcessoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItensAcessoLogin));
            System.Windows.Forms.Label cOD_ACESSO_FKLabel;
            System.Windows.Forms.Label cOD_LOGINS_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.iTENS_ACESSOLOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENS_ACESSOLOGINTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.ITENS_ACESSOLOGINTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.iTENS_ACESSOLOGINBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iTENS_ACESSOLOGINDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_ACESSO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.cOD_LOGINS_FKComboBox = new System.Windows.Forms.ComboBox();
            cOD_ACESSO_FKLabel = new System.Windows.Forms.Label();
            cOD_LOGINS_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_ACESSOLOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_ACESSOLOGINBindingNavigator)).BeginInit();
            this.iTENS_ACESSOLOGINBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_ACESSOLOGINDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTENS_ACESSOLOGINBindingSource
            // 
            this.iTENS_ACESSOLOGINBindingSource.DataMember = "ITENS_ACESSOLOGIN";
            this.iTENS_ACESSOLOGINBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // iTENS_ACESSOLOGINTableAdapter
            // 
            this.iTENS_ACESSOLOGINTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ITENS_ACESSOLOGINTableAdapter = this.iTENS_ACESSOLOGINTableAdapter;
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
            // iTENS_ACESSOLOGINBindingNavigator
            // 
            this.iTENS_ACESSOLOGINBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iTENS_ACESSOLOGINBindingNavigator.BindingSource = this.iTENS_ACESSOLOGINBindingSource;
            this.iTENS_ACESSOLOGINBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iTENS_ACESSOLOGINBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iTENS_ACESSOLOGINBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iTENS_ACESSOLOGINBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem});
            this.iTENS_ACESSOLOGINBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iTENS_ACESSOLOGINBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iTENS_ACESSOLOGINBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iTENS_ACESSOLOGINBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iTENS_ACESSOLOGINBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iTENS_ACESSOLOGINBindingNavigator.Name = "iTENS_ACESSOLOGINBindingNavigator";
            this.iTENS_ACESSOLOGINBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iTENS_ACESSOLOGINBindingNavigator.Size = new System.Drawing.Size(388, 27);
            this.iTENS_ACESSOLOGINBindingNavigator.TabIndex = 0;
            this.iTENS_ACESSOLOGINBindingNavigator.Text = "bindingNavigator1";
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
            // iTENS_ACESSOLOGINBindingNavigatorSaveItem
            // 
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iTENS_ACESSOLOGINBindingNavigatorSaveItem.Image")));
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem.Name = "iTENS_ACESSOLOGINBindingNavigatorSaveItem";
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iTENS_ACESSOLOGINBindingNavigatorSaveItem.Click += new System.EventHandler(this.iTENS_ACESSOLOGINBindingNavigatorSaveItem_Click);
            // 
            // iTENS_ACESSOLOGINDataGridView
            // 
            this.iTENS_ACESSOLOGINDataGridView.AutoGenerateColumns = false;
            this.iTENS_ACESSOLOGINDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTENS_ACESSOLOGINDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.iTENS_ACESSOLOGINDataGridView.DataSource = this.iTENS_ACESSOLOGINBindingSource;
            this.iTENS_ACESSOLOGINDataGridView.Location = new System.Drawing.Point(0, 244);
            this.iTENS_ACESSOLOGINDataGridView.Name = "iTENS_ACESSOLOGINDataGridView";
            this.iTENS_ACESSOLOGINDataGridView.RowHeadersWidth = 51;
            this.iTENS_ACESSOLOGINDataGridView.RowTemplate.Height = 24;
            this.iTENS_ACESSOLOGINDataGridView.Size = new System.Drawing.Size(388, 233);
            this.iTENS_ACESSOLOGINDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_ACESSO_FK";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_ACESSO_FK";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COD_LOGINS_FK";
            this.dataGridViewTextBoxColumn2.HeaderText = "COD_LOGINS_FK";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_ACESSO_FKLabel
            // 
            cOD_ACESSO_FKLabel.AutoSize = true;
            cOD_ACESSO_FKLabel.Location = new System.Drawing.Point(21, 155);
            cOD_ACESSO_FKLabel.Name = "cOD_ACESSO_FKLabel";
            cOD_ACESSO_FKLabel.Size = new System.Drawing.Size(116, 16);
            cOD_ACESSO_FKLabel.TabIndex = 2;
            cOD_ACESSO_FKLabel.Text = "COD ACESSO FK:";
            // 
            // cOD_ACESSO_FKComboBox
            // 
            this.cOD_ACESSO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENS_ACESSOLOGINBindingSource, "COD_ACESSO_FK", true));
            this.cOD_ACESSO_FKComboBox.FormattingEnabled = true;
            this.cOD_ACESSO_FKComboBox.Location = new System.Drawing.Point(143, 152);
            this.cOD_ACESSO_FKComboBox.Name = "cOD_ACESSO_FKComboBox";
            this.cOD_ACESSO_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_ACESSO_FKComboBox.TabIndex = 3;
            // 
            // cOD_LOGINS_FKLabel
            // 
            cOD_LOGINS_FKLabel.AutoSize = true;
            cOD_LOGINS_FKLabel.Location = new System.Drawing.Point(21, 185);
            cOD_LOGINS_FKLabel.Name = "cOD_LOGINS_FKLabel";
            cOD_LOGINS_FKLabel.Size = new System.Drawing.Size(110, 16);
            cOD_LOGINS_FKLabel.TabIndex = 4;
            cOD_LOGINS_FKLabel.Text = "COD LOGINS FK:";
            // 
            // cOD_LOGINS_FKComboBox
            // 
            this.cOD_LOGINS_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTENS_ACESSOLOGINBindingSource, "COD_LOGINS_FK", true));
            this.cOD_LOGINS_FKComboBox.FormattingEnabled = true;
            this.cOD_LOGINS_FKComboBox.Location = new System.Drawing.Point(143, 182);
            this.cOD_LOGINS_FKComboBox.Name = "cOD_LOGINS_FKComboBox";
            this.cOD_LOGINS_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_LOGINS_FKComboBox.TabIndex = 5;
            // 
            // FrmItensAcessoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 479);
            this.Controls.Add(cOD_ACESSO_FKLabel);
            this.Controls.Add(this.cOD_ACESSO_FKComboBox);
            this.Controls.Add(cOD_LOGINS_FKLabel);
            this.Controls.Add(this.cOD_LOGINS_FKComboBox);
            this.Controls.Add(this.iTENS_ACESSOLOGINDataGridView);
            this.Controls.Add(this.iTENS_ACESSOLOGINBindingNavigator);
            this.Name = "FrmItensAcessoLogin";
            this.Text = "FrmItensAcessoLogin";
            this.Load += new System.EventHandler(this.FrmItensAcessoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_ACESSOLOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_ACESSOLOGINBindingNavigator)).EndInit();
            this.iTENS_ACESSOLOGINBindingNavigator.ResumeLayout(false);
            this.iTENS_ACESSOLOGINBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTENS_ACESSOLOGINDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource iTENS_ACESSOLOGINBindingSource;
        private DB_TrabalhoDataSetTableAdapters.ITENS_ACESSOLOGINTableAdapter iTENS_ACESSOLOGINTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iTENS_ACESSOLOGINBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iTENS_ACESSOLOGINBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iTENS_ACESSOLOGINDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cOD_ACESSO_FKComboBox;
        private System.Windows.Forms.ComboBox cOD_LOGINS_FKComboBox;
    }
}