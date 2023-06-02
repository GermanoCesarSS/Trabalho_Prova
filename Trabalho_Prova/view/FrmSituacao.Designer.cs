namespace Trabalho_Prova.view
{
    partial class FrmSituacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSituacao));
            System.Windows.Forms.Label cOD_SITUACAOLabel;
            System.Windows.Forms.Label nOME_SITUACAOLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.sITUACAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sITUACAOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.SITUACAOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.sITUACAOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sITUACAOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sITUACAODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_SITUACAOTextBox = new System.Windows.Forms.TextBox();
            this.nOME_SITUACAOTextBox = new System.Windows.Forms.TextBox();
            cOD_SITUACAOLabel = new System.Windows.Forms.Label();
            nOME_SITUACAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingNavigator)).BeginInit();
            this.sITUACAOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sITUACAOBindingSource
            // 
            this.sITUACAOBindingSource.DataMember = "SITUACAO";
            this.sITUACAOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // sITUACAOTableAdapter
            // 
            this.sITUACAOTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SITUACAOTableAdapter = this.sITUACAOTableAdapter;
            this.tableAdapterManager.TELEFONETableAdapter = null;
            this.tableAdapterManager.TIPOTableAdapter = null;
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // sITUACAOBindingNavigator
            // 
            this.sITUACAOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sITUACAOBindingNavigator.BindingSource = this.sITUACAOBindingSource;
            this.sITUACAOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sITUACAOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sITUACAOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sITUACAOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sITUACAOBindingNavigatorSaveItem});
            this.sITUACAOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sITUACAOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sITUACAOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sITUACAOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sITUACAOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sITUACAOBindingNavigator.Name = "sITUACAOBindingNavigator";
            this.sITUACAOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sITUACAOBindingNavigator.Size = new System.Drawing.Size(567, 27);
            this.sITUACAOBindingNavigator.TabIndex = 0;
            this.sITUACAOBindingNavigator.Text = "bindingNavigator1";
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
            // sITUACAOBindingNavigatorSaveItem
            // 
            this.sITUACAOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sITUACAOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sITUACAOBindingNavigatorSaveItem.Image")));
            this.sITUACAOBindingNavigatorSaveItem.Name = "sITUACAOBindingNavigatorSaveItem";
            this.sITUACAOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sITUACAOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.sITUACAOBindingNavigatorSaveItem.Click += new System.EventHandler(this.sITUACAOBindingNavigatorSaveItem_Click);
            // 
            // sITUACAODataGridView
            // 
            this.sITUACAODataGridView.AutoGenerateColumns = false;
            this.sITUACAODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sITUACAODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sITUACAODataGridView.DataSource = this.sITUACAOBindingSource;
            this.sITUACAODataGridView.Location = new System.Drawing.Point(12, 372);
            this.sITUACAODataGridView.Name = "sITUACAODataGridView";
            this.sITUACAODataGridView.RowHeadersWidth = 51;
            this.sITUACAODataGridView.RowTemplate.Height = 24;
            this.sITUACAODataGridView.Size = new System.Drawing.Size(535, 220);
            this.sITUACAODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_SITUACAO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_SITUACAO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_SITUACAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_SITUACAO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_SITUACAOLabel
            // 
            cOD_SITUACAOLabel.AutoSize = true;
            cOD_SITUACAOLabel.Location = new System.Drawing.Point(20, 173);
            cOD_SITUACAOLabel.Name = "cOD_SITUACAOLabel";
            cOD_SITUACAOLabel.Size = new System.Drawing.Size(110, 16);
            cOD_SITUACAOLabel.TabIndex = 2;
            cOD_SITUACAOLabel.Text = "COD SITUACAO:";
            // 
            // cOD_SITUACAOTextBox
            // 
            this.cOD_SITUACAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sITUACAOBindingSource, "COD_SITUACAO", true));
            this.cOD_SITUACAOTextBox.Location = new System.Drawing.Point(147, 170);
            this.cOD_SITUACAOTextBox.Name = "cOD_SITUACAOTextBox";
            this.cOD_SITUACAOTextBox.Size = new System.Drawing.Size(215, 22);
            this.cOD_SITUACAOTextBox.TabIndex = 3;
            // 
            // nOME_SITUACAOLabel
            // 
            nOME_SITUACAOLabel.AutoSize = true;
            nOME_SITUACAOLabel.Location = new System.Drawing.Point(20, 201);
            nOME_SITUACAOLabel.Name = "nOME_SITUACAOLabel";
            nOME_SITUACAOLabel.Size = new System.Drawing.Size(121, 16);
            nOME_SITUACAOLabel.TabIndex = 4;
            nOME_SITUACAOLabel.Text = "NOME SITUACAO:";
            // 
            // nOME_SITUACAOTextBox
            // 
            this.nOME_SITUACAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sITUACAOBindingSource, "NOME_SITUACAO", true));
            this.nOME_SITUACAOTextBox.Location = new System.Drawing.Point(147, 198);
            this.nOME_SITUACAOTextBox.Name = "nOME_SITUACAOTextBox";
            this.nOME_SITUACAOTextBox.Size = new System.Drawing.Size(215, 22);
            this.nOME_SITUACAOTextBox.TabIndex = 5;
            // 
            // FrmSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 612);
            this.Controls.Add(cOD_SITUACAOLabel);
            this.Controls.Add(this.cOD_SITUACAOTextBox);
            this.Controls.Add(nOME_SITUACAOLabel);
            this.Controls.Add(this.nOME_SITUACAOTextBox);
            this.Controls.Add(this.sITUACAODataGridView);
            this.Controls.Add(this.sITUACAOBindingNavigator);
            this.Name = "FrmSituacao";
            this.Text = "FrmSituacao";
            this.Load += new System.EventHandler(this.FrmSituacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAOBindingNavigator)).EndInit();
            this.sITUACAOBindingNavigator.ResumeLayout(false);
            this.sITUACAOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sITUACAODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource sITUACAOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.SITUACAOTableAdapter sITUACAOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sITUACAOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sITUACAOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sITUACAODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox cOD_SITUACAOTextBox;
        private System.Windows.Forms.TextBox nOME_SITUACAOTextBox;
    }
}