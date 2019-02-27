namespace katalogos
{
    partial class katalogosMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(katalogosMainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.katalogosDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clearFilters = new System.Windows.Forms.Button();
            this.katalogosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katalogosDataSet = new katalogos.katalogosDataSet();
            this.katalogosTableAdapter = new katalogos.katalogosDataSetTableAdapters.katalogosTableAdapter();
            this.tableAdapterManager = new katalogos.katalogosDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antapokritisFilter = new wmgCMS.WaterMarkTextBox();
            this.arithmosFilter = new wmgCMS.WaterMarkTextBox();
            this.titlosFilter = new wmgCMS.WaterMarkTextBox();
            this.stratopedoPerioxiFIlter = new wmgCMS.WaterMarkTextBox();
            this.paratirisisFilter = new wmgCMS.WaterMarkTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katalogosDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katalogosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.katalogosDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // katalogosDataGridView
            // 
            this.katalogosDataGridView.AllowUserToAddRows = false;
            this.katalogosDataGridView.AllowUserToDeleteRows = false;
            this.katalogosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.katalogosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.katalogosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.katalogosDataGridView.AutoGenerateColumns = false;
            this.katalogosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.katalogosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.katalogosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.katalogosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.katalogosDataGridView.DataSource = this.katalogosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.katalogosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.katalogosDataGridView.Location = new System.Drawing.Point(3, 73);
            this.katalogosDataGridView.Name = "katalogosDataGridView";
            this.katalogosDataGridView.ReadOnly = true;
            this.katalogosDataGridView.RowHeadersWidth = 20;
            this.katalogosDataGridView.Size = new System.Drawing.Size(1178, 505);
            this.katalogosDataGridView.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.clearFilters, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.antapokritisFilter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.arithmosFilter, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.titlosFilter, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.stratopedoPerioxiFIlter, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.paratirisisFilter, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1178, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // clearFilters
            // 
            this.clearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFilters.Location = new System.Drawing.Point(928, 23);
            this.clearFilters.Name = "clearFilters";
            this.clearFilters.Size = new System.Drawing.Size(247, 38);
            this.clearFilters.TabIndex = 3;
            this.clearFilters.Text = "ΚΑΘΑΡΙΣΜΟΣ ΦΙΛΤΡΟΥ";
            this.clearFilters.UseVisualStyleBackColor = true;
            this.clearFilters.Click += new System.EventHandler(this.clearFilters_Click);
            // 
            // katalogosBindingSource
            // 
            this.katalogosBindingSource.DataMember = "katalogos";
            this.katalogosBindingSource.DataSource = this.katalogosDataSet;
            // 
            // katalogosDataSet
            // 
            this.katalogosDataSet.DataSetName = "katalogosDataSet";
            this.katalogosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // katalogosTableAdapter
            // 
            this.katalogosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.katalogosTableAdapter = this.katalogosTableAdapter;
            this.tableAdapterManager.UpdateOrder = katalogos.katalogosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 34;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "antapokritis";
            this.dataGridViewTextBoxColumn2.HeaderText = "ΑΝΤΑΠΟΚΡΙΤΗΣ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "arithmos";
            this.dataGridViewTextBoxColumn3.HeaderText = "ΑΡΙΘΜΟΣ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pliris_titlos";
            this.dataGridViewTextBoxColumn4.HeaderText = "ΠΛΗΡΗΣ ΤΙΤΛΟΣ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "stratopedo";
            this.dataGridViewTextBoxColumn5.HeaderText = "ΣΤΡΑΤΟΠΕΔΟ-ΠΕΡΙΟΧΗ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "paratirisis";
            this.dataGridViewTextBoxColumn6.HeaderText = "ΠΑΡΑΤΗΡΗΣΕΙΣ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // antapokritisFilter
            // 
            this.antapokritisFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.antapokritisFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antapokritisFilter.Location = new System.Drawing.Point(3, 29);
            this.antapokritisFilter.Name = "antapokritisFilter";
            this.antapokritisFilter.Size = new System.Drawing.Size(179, 26);
            this.antapokritisFilter.TabIndex = 4;
            this.antapokritisFilter.WaterMarkColor = System.Drawing.Color.Gray;
            this.antapokritisFilter.WaterMarkText = "ΑΝΤΑΠΟΚΡΙΤΗΣ";
            this.antapokritisFilter.TextChanged += new System.EventHandler(this.antapokritisFilter_TextChanged);
            // 
            // arithmosFilter
            // 
            this.arithmosFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.arithmosFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arithmosFilter.Location = new System.Drawing.Point(188, 29);
            this.arithmosFilter.Name = "arithmosFilter";
            this.arithmosFilter.Size = new System.Drawing.Size(179, 26);
            this.arithmosFilter.TabIndex = 5;
            this.arithmosFilter.WaterMarkColor = System.Drawing.Color.Gray;
            this.arithmosFilter.WaterMarkText = "ΑΡΙΘΜΟΣ";
            this.arithmosFilter.TextChanged += new System.EventHandler(this.arithmosFilter_TextChanged);
            // 
            // titlosFilter
            // 
            this.titlosFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titlosFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlosFilter.Location = new System.Drawing.Point(373, 29);
            this.titlosFilter.Name = "titlosFilter";
            this.titlosFilter.Size = new System.Drawing.Size(179, 26);
            this.titlosFilter.TabIndex = 6;
            this.titlosFilter.WaterMarkColor = System.Drawing.Color.Gray;
            this.titlosFilter.WaterMarkText = "ΤΙΤΛΟΣ";
            this.titlosFilter.TextChanged += new System.EventHandler(this.titlosFilter_TextChanged);
            // 
            // stratopedoPerioxiFIlter
            // 
            this.stratopedoPerioxiFIlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stratopedoPerioxiFIlter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stratopedoPerioxiFIlter.Location = new System.Drawing.Point(558, 29);
            this.stratopedoPerioxiFIlter.Name = "stratopedoPerioxiFIlter";
            this.stratopedoPerioxiFIlter.Size = new System.Drawing.Size(179, 26);
            this.stratopedoPerioxiFIlter.TabIndex = 7;
            this.stratopedoPerioxiFIlter.WaterMarkColor = System.Drawing.Color.Gray;
            this.stratopedoPerioxiFIlter.WaterMarkText = "ΣΤΡΑΤΟΠΕΔΟ-ΠΕΡΙΟΧΗ";
            this.stratopedoPerioxiFIlter.TextChanged += new System.EventHandler(this.stratopedoPerioxiFIlter_TextChanged);
            // 
            // paratirisisFilter
            // 
            this.paratirisisFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paratirisisFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paratirisisFilter.Location = new System.Drawing.Point(743, 29);
            this.paratirisisFilter.Name = "paratirisisFilter";
            this.paratirisisFilter.Size = new System.Drawing.Size(179, 26);
            this.paratirisisFilter.TabIndex = 8;
            this.paratirisisFilter.WaterMarkColor = System.Drawing.Color.Gray;
            this.paratirisisFilter.WaterMarkText = "ΠΑΡΑΤΗΡΗΣΕΙΣ";
            this.paratirisisFilter.TextChanged += new System.EventHandler(this.paratirisisFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 6);
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1172, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ΤΑ ΦΙΛΤΡΑ ΛΕΙΤΟΥΡΓΟΥΝ ΚΑΙ ΣΕ ΣΥΝΔΥΑΣΜΟ ΜΕΤΑΞΥ ΤΟΥΣ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // katalogosMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 39);
            this.Name = "katalogosMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ΚΑΤΑΛΟΓΟΣ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.katalogosDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katalogosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katalogosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private katalogosDataSet katalogosDataSet;
        private System.Windows.Forms.BindingSource katalogosBindingSource;
        private katalogosDataSetTableAdapters.katalogosTableAdapter katalogosTableAdapter;
        private katalogosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView katalogosDataGridView;
        private System.Windows.Forms.Button clearFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private wmgCMS.WaterMarkTextBox antapokritisFilter;
        private wmgCMS.WaterMarkTextBox arithmosFilter;
        private wmgCMS.WaterMarkTextBox titlosFilter;
        private wmgCMS.WaterMarkTextBox stratopedoPerioxiFIlter;
        private wmgCMS.WaterMarkTextBox paratirisisFilter;
        private System.Windows.Forms.Label label1;
    }
}

