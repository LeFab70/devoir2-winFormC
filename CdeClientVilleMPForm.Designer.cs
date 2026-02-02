namespace devoir2
{
    partial class CdeClientVilleMPForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label code_du_clientLabel;
            System.Windows.Forms.Label sociétéLabel;
            System.Windows.Forms.Label paysLabel;
            System.Windows.Forms.Label téléphoneLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CdeClientVilleMPForm));
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new devoir2.NorthwindDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.customersTableAdapter = new devoir2.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new devoir2.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new devoir2.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.code_du_clientTextBox = new System.Windows.Forms.TextBox();
            this.sociétéTextBox = new System.Windows.Forms.TextBox();
            this.paysTextBox = new System.Windows.Forms.TextBox();
            this.téléphoneTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.filtrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.xmlToolStripButton = new System.Windows.Forms.ToolStripButton();
            code_du_clientLabel = new System.Windows.Forms.Label();
            sociétéLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            téléphoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // code_du_clientLabel
            // 
            code_du_clientLabel.AutoSize = true;
            code_du_clientLabel.Location = new System.Drawing.Point(45, 111);
            code_du_clientLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            code_du_clientLabel.Name = "code_du_clientLabel";
            code_du_clientLabel.Size = new System.Drawing.Size(156, 25);
            code_du_clientLabel.TabIndex = 1;
            code_du_clientLabel.Text = "Code du client:";
            // 
            // sociétéLabel
            // 
            sociétéLabel.AutoSize = true;
            sociétéLabel.Location = new System.Drawing.Point(45, 175);
            sociétéLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sociétéLabel.Name = "sociétéLabel";
            sociétéLabel.Size = new System.Drawing.Size(90, 25);
            sociétéLabel.TabIndex = 3;
            sociétéLabel.Text = "Société:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Location = new System.Drawing.Point(45, 235);
            paysLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(66, 25);
            paysLabel.TabIndex = 5;
            paysLabel.Text = "Pays:";
            // 
            // téléphoneLabel
            // 
            téléphoneLabel.AutoSize = true;
            téléphoneLabel.Location = new System.Drawing.Point(45, 294);
            téléphoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            téléphoneLabel.Name = "téléphoneLabel";
            téléphoneLabel.Size = new System.Drawing.Size(120, 25);
            téléphoneLabel.TabIndex = 7;
            téléphoneLabel.Text = "Téléphone:";
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = null;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = null;
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.printToolStripButton,
            this.filtrerToolStripButton,
            this.xmlToolStripButton});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1835, 50);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(24, 378);
            this.ordersDataGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersWidth = 82;
            this.ordersDataGridView.Size = new System.Drawing.Size(1784, 881);
            this.ordersDataGridView.TabIndex = 11;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = devoir2.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // code_du_clientTextBox
            // 
            this.code_du_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Code du client", true));
            this.code_du_clientTextBox.Location = new System.Drawing.Point(213, 111);
            this.code_du_clientTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.code_du_clientTextBox.Name = "code_du_clientTextBox";
            this.code_du_clientTextBox.Size = new System.Drawing.Size(356, 31);
            this.code_du_clientTextBox.TabIndex = 12;
            // 
            // sociétéTextBox
            // 
            this.sociétéTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Société", true));
            this.sociétéTextBox.Location = new System.Drawing.Point(213, 175);
            this.sociétéTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sociétéTextBox.Name = "sociétéTextBox";
            this.sociétéTextBox.Size = new System.Drawing.Size(356, 31);
            this.sociétéTextBox.TabIndex = 13;
            // 
            // paysTextBox
            // 
            this.paysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Pays", true));
            this.paysTextBox.Location = new System.Drawing.Point(213, 235);
            this.paysTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paysTextBox.Name = "paysTextBox";
            this.paysTextBox.Size = new System.Drawing.Size(356, 31);
            this.paysTextBox.TabIndex = 14;
            // 
            // téléphoneTextBox
            // 
            this.téléphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Téléphone", true));
            this.téléphoneTextBox.Location = new System.Drawing.Point(213, 294);
            this.téléphoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.téléphoneTextBox.Name = "téléphoneTextBox";
            this.téléphoneTextBox.Size = new System.Drawing.Size(356, 31);
            this.téléphoneTextBox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numéro de la commande";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Numéro de la commande";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date de commande";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date de commande";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date requise";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date requise";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vendeur";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vendeur";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "FK_Customers_Orders";
            this.ordersBindingSource.DataSource = this.customersBindingSource;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = global::devoir2.Properties.Resources.printer;
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(46, 44);
            this.printToolStripButton.Text = "Imprimer";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // filtrerToolStripButton
            // 
            this.filtrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filtrerToolStripButton.Image = global::devoir2.Properties.Resources.filter;
            this.filtrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtrerToolStripButton.Name = "filtrerToolStripButton";
            this.filtrerToolStripButton.Size = new System.Drawing.Size(46, 44);
            this.filtrerToolStripButton.Text = "Filtrer";
            this.filtrerToolStripButton.Click += new System.EventHandler(this.filtrerToolStripButton_Click);
            // 
            // xmlToolStripButton
            // 
            this.xmlToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xmlToolStripButton.Image = global::devoir2.Properties.Resources.page;
            this.xmlToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.xmlToolStripButton.Name = "xmlToolStripButton";
            this.xmlToolStripButton.Size = new System.Drawing.Size(46, 44);
            this.xmlToolStripButton.Text = "A partir de xml";
            this.xmlToolStripButton.Click += new System.EventHandler(this.xmlToolStripButton_Click);
            // 
            // CdeClientVilleMPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 1284);
            this.Controls.Add(this.téléphoneTextBox);
            this.Controls.Add(this.paysTextBox);
            this.Controls.Add(this.sociétéTextBox);
            this.Controls.Add(this.code_du_clientTextBox);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(code_du_clientLabel);
            this.Controls.Add(sociétéLabel);
            this.Controls.Add(paysLabel);
            this.Controls.Add(téléphoneLabel);
            this.Controls.Add(this.customersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "CdeClientVilleMPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commandes requises des clients des villes M et P";
            this.Load += new System.EventHandler(this.CdeClientVilleMPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.TextBox code_du_clientTextBox;
        private System.Windows.Forms.TextBox sociétéTextBox;
        private System.Windows.Forms.TextBox paysTextBox;
        private System.Windows.Forms.TextBox téléphoneTextBox;
        private System.Windows.Forms.ToolStripButton filtrerToolStripButton;
        private System.Windows.Forms.ToolStripButton xmlToolStripButton;
    }
}