namespace Trabalho_Prova.view
{
    partial class FrmLogin
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
            System.Windows.Forms.Label cOD_LOGINSLabel;
            System.Windows.Forms.Label uSUARIOLabel;
            System.Windows.Forms.Label sENHALabel;
            System.Windows.Forms.Label cOD_FUNCIONARIO_FKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.lOGINSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.LOGINSTableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.fUNCIONARIOSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter();
            this.lOGINSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lOGINSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lOGINSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_LOGINSLabel1 = new System.Windows.Forms.Label();
            this.uSUARIOTextBox = new System.Windows.Forms.TextBox();
            this.sENHATextBox = new System.Windows.Forms.TextBox();
            this.cOD_FUNCIONARIO_FKComboBox = new System.Windows.Forms.ComboBox();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cOD_LOGINSLabel = new System.Windows.Forms.Label();
            uSUARIOLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            cOD_FUNCIONARIO_FKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSBindingNavigator)).BeginInit();
            this.lOGINSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_LOGINSLabel
            // 
            cOD_LOGINSLabel.AutoSize = true;
            cOD_LOGINSLabel.Location = new System.Drawing.Point(12, 139);
            cOD_LOGINSLabel.Name = "cOD_LOGINSLabel";
            cOD_LOGINSLabel.Size = new System.Drawing.Size(91, 16);
            cOD_LOGINSLabel.TabIndex = 2;
            cOD_LOGINSLabel.Text = "COD LOGINS:";
            // 
            // uSUARIOLabel
            // 
            uSUARIOLabel.AutoSize = true;
            uSUARIOLabel.Location = new System.Drawing.Point(12, 168);
            uSUARIOLabel.Name = "uSUARIOLabel";
            uSUARIOLabel.Size = new System.Drawing.Size(71, 16);
            uSUARIOLabel.TabIndex = 4;
            uSUARIOLabel.Text = "USUARIO:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.Location = new System.Drawing.Point(12, 196);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(57, 16);
            sENHALabel.TabIndex = 6;
            sENHALabel.Text = "SENHA:";
            // 
            // cOD_FUNCIONARIO_FKLabel
            // 
            cOD_FUNCIONARIO_FKLabel.AutoSize = true;
            cOD_FUNCIONARIO_FKLabel.Location = new System.Drawing.Point(12, 224);
            cOD_FUNCIONARIO_FKLabel.Name = "cOD_FUNCIONARIO_FKLabel";
            cOD_FUNCIONARIO_FKLabel.Size = new System.Drawing.Size(153, 16);
            cOD_FUNCIONARIO_FKLabel.TabIndex = 8;
            cOD_FUNCIONARIO_FKLabel.Text = "COD FUNCIONARIO FK:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOGINSBindingSource
            // 
            this.lOGINSBindingSource.DataMember = "LOGINS";
            this.lOGINSBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // lOGINSTableAdapter
            // 
            this.lOGINSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = this.fUNCIONARIOSTableAdapter;
            this.tableAdapterManager.IMAGENSTableAdapter = null;
            this.tableAdapterManager.ITENS_ACESSOLOGINTableAdapter = null;
            this.tableAdapterManager.ITENS_COMPRA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_CLITableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_FORTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_FUNTableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_LOJATableAdapter = null;
            this.tableAdapterManager.ITENS_TEL_TRATableAdapter = null;
            this.tableAdapterManager.ITENS_VENDAPRODUTOTableAdapter = null;
            this.tableAdapterManager.LOGINSTableAdapter = this.lOGINSTableAdapter;
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
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // lOGINSBindingNavigator
            // 
            this.lOGINSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lOGINSBindingNavigator.BindingSource = this.lOGINSBindingSource;
            this.lOGINSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lOGINSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lOGINSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lOGINSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lOGINSBindingNavigatorSaveItem});
            this.lOGINSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lOGINSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lOGINSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lOGINSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lOGINSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lOGINSBindingNavigator.Name = "lOGINSBindingNavigator";
            this.lOGINSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lOGINSBindingNavigator.Size = new System.Drawing.Size(947, 27);
            this.lOGINSBindingNavigator.TabIndex = 0;
            this.lOGINSBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // lOGINSBindingNavigatorSaveItem
            // 
            this.lOGINSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lOGINSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lOGINSBindingNavigatorSaveItem.Image")));
            this.lOGINSBindingNavigatorSaveItem.Name = "lOGINSBindingNavigatorSaveItem";
            this.lOGINSBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.lOGINSBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.lOGINSBindingNavigatorSaveItem.Click += new System.EventHandler(this.lOGINSBindingNavigatorSaveItem_Click);
            // 
            // lOGINSDataGridView
            // 
            this.lOGINSDataGridView.AutoGenerateColumns = false;
            this.lOGINSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOGINSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.lOGINSDataGridView.DataSource = this.lOGINSBindingSource;
            this.lOGINSDataGridView.Location = new System.Drawing.Point(362, 30);
            this.lOGINSDataGridView.Name = "lOGINSDataGridView";
            this.lOGINSDataGridView.RowHeadersWidth = 51;
            this.lOGINSDataGridView.RowTemplate.Height = 24;
            this.lOGINSDataGridView.Size = new System.Drawing.Size(565, 419);
            this.lOGINSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_LOGINS";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_LOGINS";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "USUARIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "USUARIO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SENHA";
            this.dataGridViewTextBoxColumn3.HeaderText = "SENHA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COD_FUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn4.HeaderText = "COD_FUNCIONARIO_FK";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // cOD_LOGINSLabel1
            // 
            this.cOD_LOGINSLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINSBindingSource, "COD_LOGINS", true));
            this.cOD_LOGINSLabel1.Location = new System.Drawing.Point(186, 139);
            this.cOD_LOGINSLabel1.Name = "cOD_LOGINSLabel1";
            this.cOD_LOGINSLabel1.Size = new System.Drawing.Size(121, 23);
            this.cOD_LOGINSLabel1.TabIndex = 3;
            this.cOD_LOGINSLabel1.Text = "label1";
            // 
            // uSUARIOTextBox
            // 
            this.uSUARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINSBindingSource, "USUARIO", true));
            this.uSUARIOTextBox.Location = new System.Drawing.Point(186, 165);
            this.uSUARIOTextBox.Name = "uSUARIOTextBox";
            this.uSUARIOTextBox.Size = new System.Drawing.Size(156, 22);
            this.uSUARIOTextBox.TabIndex = 5;
            // 
            // sENHATextBox
            // 
            this.sENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOGINSBindingSource, "SENHA", true));
            this.sENHATextBox.Location = new System.Drawing.Point(186, 193);
            this.sENHATextBox.Name = "sENHATextBox";
            this.sENHATextBox.Size = new System.Drawing.Size(156, 22);
            this.sENHATextBox.TabIndex = 7;
            // 
            // cOD_FUNCIONARIO_FKComboBox
            // 
            this.cOD_FUNCIONARIO_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOGINSBindingSource, "COD_FUNCIONARIO_FK", true));
            this.cOD_FUNCIONARIO_FKComboBox.DataSource = this.fUNCIONARIOSBindingSource;
            this.cOD_FUNCIONARIO_FKComboBox.DisplayMember = "NOME_FUNCIONARIO";
            this.cOD_FUNCIONARIO_FKComboBox.FormattingEnabled = true;
            this.cOD_FUNCIONARIO_FKComboBox.Location = new System.Drawing.Point(186, 221);
            this.cOD_FUNCIONARIO_FKComboBox.Name = "cOD_FUNCIONARIO_FKComboBox";
            this.cOD_FUNCIONARIO_FKComboBox.Size = new System.Drawing.Size(156, 24);
            this.cOD_FUNCIONARIO_FKComboBox.TabIndex = 9;
            this.cOD_FUNCIONARIO_FKComboBox.ValueMember = "COD_FUNCIONARIO";
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 469);
            this.Controls.Add(cOD_LOGINSLabel);
            this.Controls.Add(this.cOD_LOGINSLabel1);
            this.Controls.Add(uSUARIOLabel);
            this.Controls.Add(this.uSUARIOTextBox);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.sENHATextBox);
            this.Controls.Add(cOD_FUNCIONARIO_FKLabel);
            this.Controls.Add(this.cOD_FUNCIONARIO_FKComboBox);
            this.Controls.Add(this.lOGINSDataGridView);
            this.Controls.Add(this.lOGINSBindingNavigator);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSBindingNavigator)).EndInit();
            this.lOGINSBindingNavigator.ResumeLayout(false);
            this.lOGINSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource lOGINSBindingSource;
        private DB_TrabalhoDataSetTableAdapters.LOGINSTableAdapter lOGINSTableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lOGINSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lOGINSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lOGINSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label cOD_LOGINSLabel1;
        private System.Windows.Forms.TextBox uSUARIOTextBox;
        private System.Windows.Forms.TextBox sENHATextBox;
        private System.Windows.Forms.ComboBox cOD_FUNCIONARIO_FKComboBox;
        private DB_TrabalhoDataSetTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
    }
}