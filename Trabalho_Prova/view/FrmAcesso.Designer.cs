﻿namespace Trabalho_Prova.view
{
    partial class FrmAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcesso));
            System.Windows.Forms.Label cOD_ACESSOLabel;
            System.Windows.Forms.Label nOME_ACESSOLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.aCESSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCESSOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.ACESSOTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.aCESSOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aCESSOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aCESSODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_ACESSOLabel1 = new System.Windows.Forms.Label();
            this.nOME_ACESSOTextBox = new System.Windows.Forms.TextBox();
            cOD_ACESSOLabel = new System.Windows.Forms.Label();
            nOME_ACESSOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingNavigator)).BeginInit();
            this.aCESSOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aCESSOBindingSource
            // 
            this.aCESSOBindingSource.DataMember = "ACESSO";
            this.aCESSOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // aCESSOTableAdapter
            // 
            this.aCESSOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACESSOTableAdapter = this.aCESSOTableAdapter;
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
            this.tableAdapterManager.TRABALHOTableAdapter = null;
            this.tableAdapterManager.UFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDAPRODUTOTableAdapter = null;
            // 
            // aCESSOBindingNavigator
            // 
            this.aCESSOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aCESSOBindingNavigator.BindingSource = this.aCESSOBindingSource;
            this.aCESSOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aCESSOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aCESSOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aCESSOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aCESSOBindingNavigatorSaveItem});
            this.aCESSOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aCESSOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aCESSOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aCESSOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aCESSOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aCESSOBindingNavigator.Name = "aCESSOBindingNavigator";
            this.aCESSOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aCESSOBindingNavigator.Size = new System.Drawing.Size(370, 27);
            this.aCESSOBindingNavigator.TabIndex = 0;
            this.aCESSOBindingNavigator.Text = "bindingNavigator1";
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
            // aCESSOBindingNavigatorSaveItem
            // 
            this.aCESSOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aCESSOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aCESSOBindingNavigatorSaveItem.Image")));
            this.aCESSOBindingNavigatorSaveItem.Name = "aCESSOBindingNavigatorSaveItem";
            this.aCESSOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aCESSOBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.aCESSOBindingNavigatorSaveItem.Click += new System.EventHandler(this.aCESSOBindingNavigatorSaveItem_Click);
            // 
            // aCESSODataGridView
            // 
            this.aCESSODataGridView.AutoGenerateColumns = false;
            this.aCESSODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aCESSODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.aCESSODataGridView.DataSource = this.aCESSOBindingSource;
            this.aCESSODataGridView.Location = new System.Drawing.Point(0, 196);
            this.aCESSODataGridView.Name = "aCESSODataGridView";
            this.aCESSODataGridView.RowHeadersWidth = 51;
            this.aCESSODataGridView.RowTemplate.Height = 24;
            this.aCESSODataGridView.Size = new System.Drawing.Size(370, 220);
            this.aCESSODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_ACESSO";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_ACESSO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_ACESSO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_ACESSO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // cOD_ACESSOLabel
            // 
            cOD_ACESSOLabel.AutoSize = true;
            cOD_ACESSOLabel.Location = new System.Drawing.Point(12, 68);
            cOD_ACESSOLabel.Name = "cOD_ACESSOLabel";
            cOD_ACESSOLabel.Size = new System.Drawing.Size(97, 16);
            cOD_ACESSOLabel.TabIndex = 2;
            cOD_ACESSOLabel.Text = "COD ACESSO:";
            // 
            // cOD_ACESSOLabel1
            // 
            this.cOD_ACESSOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCESSOBindingSource, "COD_ACESSO", true));
            this.cOD_ACESSOLabel1.Location = new System.Drawing.Point(204, 68);
            this.cOD_ACESSOLabel1.Name = "cOD_ACESSOLabel1";
            this.cOD_ACESSOLabel1.Size = new System.Drawing.Size(100, 23);
            this.cOD_ACESSOLabel1.TabIndex = 3;
            this.cOD_ACESSOLabel1.Text = "label1";
            // 
            // nOME_ACESSOLabel
            // 
            nOME_ACESSOLabel.AutoSize = true;
            nOME_ACESSOLabel.Location = new System.Drawing.Point(12, 97);
            nOME_ACESSOLabel.Name = "nOME_ACESSOLabel";
            nOME_ACESSOLabel.Size = new System.Drawing.Size(108, 16);
            nOME_ACESSOLabel.TabIndex = 4;
            nOME_ACESSOLabel.Text = "NOME ACESSO:";
            // 
            // nOME_ACESSOTextBox
            // 
            this.nOME_ACESSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aCESSOBindingSource, "NOME_ACESSO", true));
            this.nOME_ACESSOTextBox.Location = new System.Drawing.Point(147, 94);
            this.nOME_ACESSOTextBox.Name = "nOME_ACESSOTextBox";
            this.nOME_ACESSOTextBox.Size = new System.Drawing.Size(211, 22);
            this.nOME_ACESSOTextBox.TabIndex = 5;
            // 
            // FrmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 417);
            this.Controls.Add(cOD_ACESSOLabel);
            this.Controls.Add(this.cOD_ACESSOLabel1);
            this.Controls.Add(nOME_ACESSOLabel);
            this.Controls.Add(this.nOME_ACESSOTextBox);
            this.Controls.Add(this.aCESSODataGridView);
            this.Controls.Add(this.aCESSOBindingNavigator);
            this.Name = "FrmAcesso";
            this.Text = "FrmAcesso";
            this.Load += new System.EventHandler(this.FrmAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSOBindingNavigator)).EndInit();
            this.aCESSOBindingNavigator.ResumeLayout(false);
            this.aCESSOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCESSODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource aCESSOBindingSource;
        private DB_TrabalhoDataSetTableAdapters.ACESSOTableAdapter aCESSOTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aCESSOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aCESSOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView aCESSODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label cOD_ACESSOLabel1;
        private System.Windows.Forms.TextBox nOME_ACESSOTextBox;
    }
}