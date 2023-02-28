namespace VTYSProje
{
    partial class TedarikciTopluBorc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedarikciTopluBorc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.vTYSProjeDataSet2 = new VTYSProje.VTYSProjeDataSet2();
            this.ttedarikciOdemesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttedarikciOdemesTableAdapter = new VTYSProje.VTYSProjeDataSet2TableAdapters.ttedarikciOdemesTableAdapter();
            this.tedarikciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjButton3 = new VTYSProje1.Entity.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttedarikciOdemesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tedarikciIDDataGridViewTextBoxColumn,
            this.toplamBorcDataGridViewTextBoxColumn,
            this.odenenMiktarDataGridViewTextBoxColumn,
            this.kalanMiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ttedarikciOdemesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 376);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "TEDARİKÇİ BORÇ DURUMU";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-go-back-64.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-left-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-return-48.png");
            // 
            // vTYSProjeDataSet2
            // 
            this.vTYSProjeDataSet2.DataSetName = "VTYSProjeDataSet2";
            this.vTYSProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ttedarikciOdemesBindingSource
            // 
            this.ttedarikciOdemesBindingSource.DataMember = "ttedarikciOdemes";
            this.ttedarikciOdemesBindingSource.DataSource = this.vTYSProjeDataSet2;
            // 
            // ttedarikciOdemesTableAdapter
            // 
            this.ttedarikciOdemesTableAdapter.ClearBeforeFill = true;
            // 
            // tedarikciIDDataGridViewTextBoxColumn
            // 
            this.tedarikciIDDataGridViewTextBoxColumn.DataPropertyName = "tedarikciID";
            this.tedarikciIDDataGridViewTextBoxColumn.HeaderText = "Tedarikçi ID";
            this.tedarikciIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tedarikciIDDataGridViewTextBoxColumn.Name = "tedarikciIDDataGridViewTextBoxColumn";
            this.tedarikciIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // toplamBorcDataGridViewTextBoxColumn
            // 
            this.toplamBorcDataGridViewTextBoxColumn.DataPropertyName = "toplamBorc";
            this.toplamBorcDataGridViewTextBoxColumn.HeaderText = "Toplam Borç";
            this.toplamBorcDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.toplamBorcDataGridViewTextBoxColumn.Name = "toplamBorcDataGridViewTextBoxColumn";
            this.toplamBorcDataGridViewTextBoxColumn.Width = 150;
            // 
            // odenenMiktarDataGridViewTextBoxColumn
            // 
            this.odenenMiktarDataGridViewTextBoxColumn.DataPropertyName = "odenenMiktar";
            this.odenenMiktarDataGridViewTextBoxColumn.HeaderText = "Ödenen Miktar";
            this.odenenMiktarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.odenenMiktarDataGridViewTextBoxColumn.Name = "odenenMiktarDataGridViewTextBoxColumn";
            this.odenenMiktarDataGridViewTextBoxColumn.Width = 150;
            // 
            // kalanMiktarDataGridViewTextBoxColumn
            // 
            this.kalanMiktarDataGridViewTextBoxColumn.DataPropertyName = "kalanMiktar";
            this.kalanMiktarDataGridViewTextBoxColumn.HeaderText = "Kalan Miktar";
            this.kalanMiktarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kalanMiktarDataGridViewTextBoxColumn.Name = "kalanMiktarDataGridViewTextBoxColumn";
            this.kalanMiktarDataGridViewTextBoxColumn.Width = 150;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.Transparent;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.ImageKey = "icons8-return-48.png";
            this.rjButton3.ImageList = this.ımageList1;
            this.rjButton3.Location = new System.Drawing.Point(12, 12);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(78, 63);
            this.rjButton3.TabIndex = 14;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // TedarikciTopluBorc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1102, 538);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TedarikciTopluBorc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Borç Görüntüleme Ekranı";
            this.Load += new System.EventHandler(this.TedarikciTopluBorc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttedarikciOdemesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private VTYSProje1.Entity.RJButton rjButton3;
        private VTYSProjeDataSet2 vTYSProjeDataSet2;
        private System.Windows.Forms.BindingSource ttedarikciOdemesBindingSource;
        private VTYSProjeDataSet2TableAdapters.ttedarikciOdemesTableAdapter ttedarikciOdemesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanMiktarDataGridViewTextBoxColumn;
    }
}