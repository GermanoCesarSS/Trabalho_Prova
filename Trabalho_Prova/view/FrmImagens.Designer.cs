namespace Trabalho_Prova.view
{
    partial class FrmImagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagens));
            System.Windows.Forms.Label cOD_IMAGENSLabel;
            System.Windows.Forms.Label iMAGEMLabel;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label cOD_PRODUTO_FKLabel;
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.iMAGENSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMAGENSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.IMAGENSTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.pRODUTOTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter();
            this.iMAGENSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.iMAGENSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iMAGENSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.cOD_IMAGENSLabel1 = new System.Windows.Forms.Label();
            this.iMAGEMPictureBox = new System.Windows.Forms.PictureBox();
            this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.cOD_PRODUTO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.pRODUTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            cOD_IMAGENSLabel = new System.Windows.Forms.Label();
            iMAGEMLabel = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            cOD_PRODUTO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingNavigator)).BeginInit();
            this.iMAGENSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEMPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iMAGENSBindingSource
            // 
            this.iMAGENSBindingSource.DataMember = "IMAGENS";
            this.iMAGENSBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // iMAGENSTableAdapter
            // 
            this.iMAGENSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.IMAGENSTableAdapter = this.iMAGENSTableAdapter;
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
            this.tableAdapterManager.PRODUTOTableAdapter = this.pRODUTOTableAdapter;
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
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // iMAGENSBindingNavigator
            // 
            this.iMAGENSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.iMAGENSBindingNavigator.BindingSource = this.iMAGENSBindingSource;
            this.iMAGENSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.iMAGENSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.iMAGENSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.iMAGENSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.iMAGENSBindingNavigatorSaveItem});
            this.iMAGENSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.iMAGENSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.iMAGENSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.iMAGENSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.iMAGENSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.iMAGENSBindingNavigator.Name = "iMAGENSBindingNavigator";
            this.iMAGENSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.iMAGENSBindingNavigator.Size = new System.Drawing.Size(558, 27);
            this.iMAGENSBindingNavigator.TabIndex = 0;
            this.iMAGENSBindingNavigator.Text = "bindingNavigator1";
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
            // iMAGENSBindingNavigatorSaveItem
            // 
            this.iMAGENSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.iMAGENSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("iMAGENSBindingNavigatorSaveItem.Image")));
            this.iMAGENSBindingNavigatorSaveItem.Name = "iMAGENSBindingNavigatorSaveItem";
            this.iMAGENSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.iMAGENSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.iMAGENSBindingNavigatorSaveItem.Click += new System.EventHandler(this.iMAGENSBindingNavigatorSaveItem_Click);
            // 
            // iMAGENSDataGridView
            // 
            this.iMAGENSDataGridView.AutoGenerateColumns = false;
            this.iMAGENSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iMAGENSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.iMAGENSDataGridView.DataSource = this.iMAGENSBindingSource;
            this.iMAGENSDataGridView.Location = new System.Drawing.Point(12, 218);
            this.iMAGENSDataGridView.Name = "iMAGENSDataGridView";
            this.iMAGENSDataGridView.RowHeadersWidth = 51;
            this.iMAGENSDataGridView.RowTemplate.Height = 24;
            this.iMAGENSDataGridView.Size = new System.Drawing.Size(526, 220);
            this.iMAGENSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_IMAGENS";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_IMAGENS";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "IMAGEM";
            this.dataGridViewImageColumn1.HeaderText = "IMAGEM";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRICAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRICAO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COD_PRODUTO_FK";
            this.dataGridViewTextBoxColumn3.HeaderText = "COD_PRODUTO_FK";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(335, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cOD_IMAGENSLabel
            // 
            cOD_IMAGENSLabel.AutoSize = true;
            cOD_IMAGENSLabel.Location = new System.Drawing.Point(57, 49);
            cOD_IMAGENSLabel.Name = "cOD_IMAGENSLabel";
            cOD_IMAGENSLabel.Size = new System.Drawing.Size(103, 16);
            cOD_IMAGENSLabel.TabIndex = 34;
            cOD_IMAGENSLabel.Text = "COD IMAGENS:";
            // 
            // cOD_IMAGENSLabel1
            // 
            this.cOD_IMAGENSLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iMAGENSBindingSource, "COD_IMAGENS", true));
            this.cOD_IMAGENSLabel1.Location = new System.Drawing.Point(192, 49);
            this.cOD_IMAGENSLabel1.Name = "cOD_IMAGENSLabel1";
            this.cOD_IMAGENSLabel1.Size = new System.Drawing.Size(121, 23);
            this.cOD_IMAGENSLabel1.TabIndex = 35;
            this.cOD_IMAGENSLabel1.Text = "label1";
            // 
            // iMAGEMLabel
            // 
            iMAGEMLabel.AutoSize = true;
            iMAGEMLabel.Location = new System.Drawing.Point(347, 41);
            iMAGEMLabel.Name = "iMAGEMLabel";
            iMAGEMLabel.Size = new System.Drawing.Size(63, 16);
            iMAGEMLabel.TabIndex = 36;
            iMAGEMLabel.Text = "IMAGEM:";
            // 
            // iMAGEMPictureBox
            // 
            this.iMAGEMPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.iMAGENSBindingSource, "IMAGEM", true));
            this.iMAGEMPictureBox.Location = new System.Drawing.Point(417, 41);
            this.iMAGEMPictureBox.Name = "iMAGEMPictureBox";
            this.iMAGEMPictureBox.Size = new System.Drawing.Size(121, 109);
            this.iMAGEMPictureBox.TabIndex = 37;
            this.iMAGEMPictureBox.TabStop = false;
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Location = new System.Drawing.Point(57, 83);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(88, 16);
            dESCRICAOLabel.TabIndex = 38;
            dESCRICAOLabel.Text = "DESCRICAO:";
            // 
            // dESCRICAOTextBox
            // 
            this.dESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iMAGENSBindingSource, "DESCRICAO", true));
            this.dESCRICAOTextBox.Location = new System.Drawing.Point(192, 80);
            this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
            this.dESCRICAOTextBox.Size = new System.Drawing.Size(121, 22);
            this.dESCRICAOTextBox.TabIndex = 39;
            // 
            // cOD_PRODUTO_FKLabel
            // 
            cOD_PRODUTO_FKLabel.AutoSize = true;
            cOD_PRODUTO_FKLabel.Location = new System.Drawing.Point(57, 111);
            cOD_PRODUTO_FKLabel.Name = "cOD_PRODUTO_FKLabel";
            cOD_PRODUTO_FKLabel.Size = new System.Drawing.Size(129, 16);
            cOD_PRODUTO_FKLabel.TabIndex = 40;
            cOD_PRODUTO_FKLabel.Text = "COD PRODUTO FK:";
            // 
            // cOD_PRODUTO_FKComboBox
            // 
            this.cOD_PRODUTO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iMAGENSBindingSource, "COD_PRODUTO_FK", true));
            this.cOD_PRODUTO_FKComboBox.DataSource = this.pRODUTOBindingSource1;
            this.cOD_PRODUTO_FKComboBox.DisplayMember = "NOME_PRODUTO";
            this.cOD_PRODUTO_FKComboBox.FormattingEnabled = true;
            this.cOD_PRODUTO_FKComboBox.Location = new System.Drawing.Point(192, 108);
            this.cOD_PRODUTO_FKComboBox.Name = "cOD_PRODUTO_FKComboBox";
            this.cOD_PRODUTO_FKComboBox.Size = new System.Drawing.Size(121, 24);
            this.cOD_PRODUTO_FKComboBox.TabIndex = 41;
            this.cOD_PRODUTO_FKComboBox.ValueMember = "COD_PRODUTO";
            // 
            // pRODUTOBindingSource1
            // 
            this.pRODUTOBindingSource1.DataMember = "PRODUTO";
            this.pRODUTOBindingSource1.DataSource = this.dB_TrabalhoDataSet;
            // 
            // FrmImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 458);
            this.Controls.Add(cOD_IMAGENSLabel);
            this.Controls.Add(this.cOD_IMAGENSLabel1);
            this.Controls.Add(iMAGEMLabel);
            this.Controls.Add(this.iMAGEMPictureBox);
            this.Controls.Add(dESCRICAOLabel);
            this.Controls.Add(this.dESCRICAOTextBox);
            this.Controls.Add(cOD_PRODUTO_FKLabel);
            this.Controls.Add(this.cOD_PRODUTO_FKComboBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.iMAGENSDataGridView);
            this.Controls.Add(this.iMAGENSBindingNavigator);
            this.Name = "FrmImagens";
            this.Text = "FrmImagens";
            this.Load += new System.EventHandler(this.FrmImagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSBindingNavigator)).EndInit();
            this.iMAGENSBindingNavigator.ResumeLayout(false);
            this.iMAGENSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGEMPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource iMAGENSBindingSource;
        private DB_TrabalhoDataSetTableAdapters.IMAGENSTableAdapter iMAGENSTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator iMAGENSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton iMAGENSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView iMAGENSDataGridView;
        private DB_TrabalhoDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label cOD_IMAGENSLabel1;
        private System.Windows.Forms.PictureBox iMAGEMPictureBox;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;
        private System.Windows.Forms.ComboBox cOD_PRODUTO_FKComboBox;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource1;
    }
}