namespace Trabalho_Prova.view
{
    partial class FrmControle_LoginSistema
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
            System.Windows.Forms.Label cOD_CONTROLELabel;
            System.Windows.Forms.Label cOD_LOGINS_FKLabel;
            System.Windows.Forms.Label dATASLabel;
            System.Windows.Forms.Label hORALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControle_LoginSistema));
            this.dB_TrabalhoDataSet = new Trabalho_Prova.DB_TrabalhoDataSet();
            this.cONTROLE_LOGSISTEMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONTROLE_LOGSISTEMATableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.CONTROLE_LOGSISTEMATableAdapter();
            this.tableAdapterManager = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.TableAdapterManager();
            this.lOGINSTableAdapter = new Trabalho_Prova.DB_TrabalhoDataSetTableAdapters.LOGINSTableAdapter();
            this.cONTROLE_LOGSISTEMABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cONTROLE_LOGSISTEMADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOD_CONTROLELabel1 = new System.Windows.Forms.Label();
            this.cOD_LOGINS_FKComboBox = new System.Windows.Forms.ComboBox();
            this.lOGINSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATASDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hORATextBox = new System.Windows.Forms.TextBox();
            cOD_CONTROLELabel = new System.Windows.Forms.Label();
            cOD_LOGINS_FKLabel = new System.Windows.Forms.Label();
            dATASLabel = new System.Windows.Forms.Label();
            hORALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLE_LOGSISTEMABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLE_LOGSISTEMABindingNavigator)).BeginInit();
            this.cONTROLE_LOGSISTEMABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLE_LOGSISTEMADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cOD_CONTROLELabel
            // 
            cOD_CONTROLELabel.AutoSize = true;
            cOD_CONTROLELabel.Location = new System.Drawing.Point(24, 92);
            cOD_CONTROLELabel.Name = "cOD_CONTROLELabel";
            cOD_CONTROLELabel.Size = new System.Drawing.Size(116, 16);
            cOD_CONTROLELabel.TabIndex = 2;
            cOD_CONTROLELabel.Text = "COD CONTROLE:";
            // 
            // cOD_LOGINS_FKLabel
            // 
            cOD_LOGINS_FKLabel.AutoSize = true;
            cOD_LOGINS_FKLabel.Location = new System.Drawing.Point(24, 121);
            cOD_LOGINS_FKLabel.Name = "cOD_LOGINS_FKLabel";
            cOD_LOGINS_FKLabel.Size = new System.Drawing.Size(110, 16);
            cOD_LOGINS_FKLabel.TabIndex = 4;
            cOD_LOGINS_FKLabel.Text = "COD LOGINS FK:";
            // 
            // dATASLabel
            // 
            dATASLabel.AutoSize = true;
            dATASLabel.Location = new System.Drawing.Point(24, 152);
            dATASLabel.Name = "dATASLabel";
            dATASLabel.Size = new System.Drawing.Size(56, 16);
            dATASLabel.TabIndex = 6;
            dATASLabel.Text = "DATAS:";
            // 
            // hORALabel
            // 
            hORALabel.AutoSize = true;
            hORALabel.Location = new System.Drawing.Point(24, 179);
            hORALabel.Name = "hORALabel";
            hORALabel.Size = new System.Drawing.Size(49, 16);
            hORALabel.TabIndex = 8;
            hORALabel.Text = "HORA:";
            // 
            // dB_TrabalhoDataSet
            // 
            this.dB_TrabalhoDataSet.DataSetName = "DB_TrabalhoDataSet";
            this.dB_TrabalhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTROLE_LOGSISTEMABindingSource
            // 
            this.cONTROLE_LOGSISTEMABindingSource.DataMember = "CONTROLE_LOGSISTEMA";
            this.cONTROLE_LOGSISTEMABindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // cONTROLE_LOGSISTEMATableAdapter
            // 
            this.cONTROLE_LOGSISTEMATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CONTROLE_LOGSISTEMATableAdapter = this.cONTROLE_LOGSISTEMATableAdapter;
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
            // lOGINSTableAdapter
            // 
            this.lOGINSTableAdapter.ClearBeforeFill = true;
            // 
            // cONTROLE_LOGSISTEMABindingNavigator
            // 
            this.cONTROLE_LOGSISTEMABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.BindingSource = this.cONTROLE_LOGSISTEMABindingSource;
            this.cONTROLE_LOGSISTEMABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cONTROLE_LOGSISTEMABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem});
            this.cONTROLE_LOGSISTEMABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cONTROLE_LOGSISTEMABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.Name = "cONTROLE_LOGSISTEMABindingNavigator";
            this.cONTROLE_LOGSISTEMABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cONTROLE_LOGSISTEMABindingNavigator.Size = new System.Drawing.Size(955, 27);
            this.cONTROLE_LOGSISTEMABindingNavigator.TabIndex = 0;
            this.cONTROLE_LOGSISTEMABindingNavigator.Text = "bindingNavigator1";
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
            // cONTROLE_LOGSISTEMABindingNavigatorSaveItem
            // 
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cONTROLE_LOGSISTEMABindingNavigatorSaveItem.Image")));
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem.Name = "cONTROLE_LOGSISTEMABindingNavigatorSaveItem";
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem.Click += new System.EventHandler(this.cONTROLE_LOGSISTEMABindingNavigatorSaveItem_Click);
            // 
            // cONTROLE_LOGSISTEMADataGridView
            // 
            this.cONTROLE_LOGSISTEMADataGridView.AutoGenerateColumns = false;
            this.cONTROLE_LOGSISTEMADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cONTROLE_LOGSISTEMADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cONTROLE_LOGSISTEMADataGridView.DataSource = this.cONTROLE_LOGSISTEMABindingSource;
            this.cONTROLE_LOGSISTEMADataGridView.Location = new System.Drawing.Point(376, 30);
            this.cONTROLE_LOGSISTEMADataGridView.Name = "cONTROLE_LOGSISTEMADataGridView";
            this.cONTROLE_LOGSISTEMADataGridView.RowHeadersWidth = 51;
            this.cONTROLE_LOGSISTEMADataGridView.RowTemplate.Height = 24;
            this.cONTROLE_LOGSISTEMADataGridView.Size = new System.Drawing.Size(559, 421);
            this.cONTROLE_LOGSISTEMADataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "COD_CONTROLE";
            this.dataGridViewTextBoxColumn1.HeaderText = "COD_CONTROLE";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATAS";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATAS";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HORA";
            this.dataGridViewTextBoxColumn4.HeaderText = "HORA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // cOD_CONTROLELabel1
            // 
            this.cOD_CONTROLELabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTROLE_LOGSISTEMABindingSource, "COD_CONTROLE", true));
            this.cOD_CONTROLELabel1.Location = new System.Drawing.Point(170, 92);
            this.cOD_CONTROLELabel1.Name = "cOD_CONTROLELabel1";
            this.cOD_CONTROLELabel1.Size = new System.Drawing.Size(200, 23);
            this.cOD_CONTROLELabel1.TabIndex = 3;
            this.cOD_CONTROLELabel1.Text = "label1";
            // 
            // cOD_LOGINS_FKComboBox
            // 
            this.cOD_LOGINS_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cONTROLE_LOGSISTEMABindingSource, "COD_LOGINS_FK", true));
            this.cOD_LOGINS_FKComboBox.DataSource = this.lOGINSBindingSource;
            this.cOD_LOGINS_FKComboBox.DisplayMember = "USUARIO";
            this.cOD_LOGINS_FKComboBox.FormattingEnabled = true;
            this.cOD_LOGINS_FKComboBox.Location = new System.Drawing.Point(170, 118);
            this.cOD_LOGINS_FKComboBox.Name = "cOD_LOGINS_FKComboBox";
            this.cOD_LOGINS_FKComboBox.Size = new System.Drawing.Size(200, 24);
            this.cOD_LOGINS_FKComboBox.TabIndex = 5;
            this.cOD_LOGINS_FKComboBox.ValueMember = "COD_LOGINS";
            // 
            // lOGINSBindingSource
            // 
            this.lOGINSBindingSource.DataMember = "LOGINS";
            this.lOGINSBindingSource.DataSource = this.dB_TrabalhoDataSet;
            // 
            // dATASDateTimePicker
            // 
            this.dATASDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cONTROLE_LOGSISTEMABindingSource, "DATAS", true));
            this.dATASDateTimePicker.Location = new System.Drawing.Point(170, 148);
            this.dATASDateTimePicker.Name = "dATASDateTimePicker";
            this.dATASDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dATASDateTimePicker.TabIndex = 7;
            // 
            // hORATextBox
            // 
            this.hORATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONTROLE_LOGSISTEMABindingSource, "HORA", true));
            this.hORATextBox.Location = new System.Drawing.Point(170, 176);
            this.hORATextBox.Name = "hORATextBox";
            this.hORATextBox.Size = new System.Drawing.Size(200, 22);
            this.hORATextBox.TabIndex = 9;
            // 
            // FrmControle_LoginSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 471);
            this.Controls.Add(cOD_CONTROLELabel);
            this.Controls.Add(this.cOD_CONTROLELabel1);
            this.Controls.Add(cOD_LOGINS_FKLabel);
            this.Controls.Add(this.cOD_LOGINS_FKComboBox);
            this.Controls.Add(dATASLabel);
            this.Controls.Add(this.dATASDateTimePicker);
            this.Controls.Add(hORALabel);
            this.Controls.Add(this.hORATextBox);
            this.Controls.Add(this.cONTROLE_LOGSISTEMADataGridView);
            this.Controls.Add(this.cONTROLE_LOGSISTEMABindingNavigator);
            this.Name = "FrmControle_LoginSistema";
            this.Text = "FrmControle_LoginSistema";
            this.Load += new System.EventHandler(this.FrmControle_LoginSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_TrabalhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLE_LOGSISTEMABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLE_LOGSISTEMABindingNavigator)).EndInit();
            this.cONTROLE_LOGSISTEMABindingNavigator.ResumeLayout(false);
            this.cONTROLE_LOGSISTEMABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTROLE_LOGSISTEMADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_TrabalhoDataSet dB_TrabalhoDataSet;
        private System.Windows.Forms.BindingSource cONTROLE_LOGSISTEMABindingSource;
        private DB_TrabalhoDataSetTableAdapters.CONTROLE_LOGSISTEMATableAdapter cONTROLE_LOGSISTEMATableAdapter;
        private DB_TrabalhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cONTROLE_LOGSISTEMABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cONTROLE_LOGSISTEMABindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cONTROLE_LOGSISTEMADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DB_TrabalhoDataSetTableAdapters.LOGINSTableAdapter lOGINSTableAdapter;
        private System.Windows.Forms.Label cOD_CONTROLELabel1;
        private System.Windows.Forms.ComboBox cOD_LOGINS_FKComboBox;
        private System.Windows.Forms.DateTimePicker dATASDateTimePicker;
        private System.Windows.Forms.TextBox hORATextBox;
        private System.Windows.Forms.BindingSource lOGINSBindingSource;
    }
}