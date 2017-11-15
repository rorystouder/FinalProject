namespace FinalProject_RoryStouder
{
    partial class frmStock
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuanity = new System.Windows.Forms.TextBox();
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.errProviderStock = new System.Windows.Forms.ErrorProvider(this.components);
            this.stockDataSet = new FinalProject_RoryStouder.StockDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new FinalProject_RoryStouder.StockDataSetTableAdapters.StockTableAdapter();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1089, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.stockBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(11, 175);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1067, 386);
            this.dgvProducts.TabIndex = 18;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(228, 67);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(174, 27);
            this.txtProductName.TabIndex = 13;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(48, 67);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(174, 27);
            this.txtProductCode.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(929, 54);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 49);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(802, 54);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 49);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quanity";
            // 
            // txtQuanity
            // 
            this.txtQuanity.Location = new System.Drawing.Point(613, 67);
            this.txtQuanity.Name = "txtQuanity";
            this.txtQuanity.Size = new System.Drawing.Size(166, 27);
            this.txtQuanity.TabIndex = 21;
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCalendar.Location = new System.Drawing.Point(407, 67);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(200, 27);
            this.dtpCalendar.TabIndex = 22;
            this.dtpCalendar.Value = new System.DateTime(2017, 11, 14, 21, 0, 0, 0);
            // 
            // errProviderStock
            // 
            this.errProviderStock.ContainerControl = this;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.stockDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productCodeDataGridViewTextBoxColumn.Width = 140;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            this.transDateDataGridViewTextBoxColumn.Width = 74;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 601);
            this.Controls.Add(this.dtpCalendar);
            this.Controls.Add(this.txtQuanity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuanity;
        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.ErrorProvider errProviderStock;
        private StockDataSet stockDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private StockDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}