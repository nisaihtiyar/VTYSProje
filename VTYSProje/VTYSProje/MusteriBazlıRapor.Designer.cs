namespace VTYSProje
{
    partial class MusteriBazlıRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBazlıRapor));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rjButton3 = new VTYSProje1.Entity.RJButton();
            this.vTYSProjeDataSet5 = new VTYSProje.VTYSProjeDataSet5();
            this.tBorcsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBorcsTableAdapter = new VTYSProje.VTYSProjeDataSet5TableAdapters.tBorcsTableAdapter();
            this.vTYSProjeDataSet6 = new VTYSProje.VTYSProjeDataSet6();
            this.tSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tSatisTableAdapter = new VTYSProje.VTYSProjeDataSet6TableAdapters.tSatisTableAdapter();
            this.borcTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBorcsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisTarihDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.satisTutarDataGridViewTextBoxColumn,
            this.satisMiktarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tSatisBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(571, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(543, 477);
            this.dataGridView2.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borcTarihiDataGridViewTextBoxColumn,
            this.musteriIdDataGridViewTextBoxColumn,
            this.borcMiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBorcsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(513, 477);
            this.dataGridView1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(854, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Satılan Ürün Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Müşteri Borç Tablosu";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-go-back-64.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-left-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-return-48.png");
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
            this.rjButton3.TabIndex = 47;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // vTYSProjeDataSet5
            // 
            this.vTYSProjeDataSet5.DataSetName = "VTYSProjeDataSet5";
            this.vTYSProjeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBorcsBindingSource
            // 
            this.tBorcsBindingSource.DataMember = "tBorcs";
            this.tBorcsBindingSource.DataSource = this.vTYSProjeDataSet5;
            // 
            // tBorcsTableAdapter
            // 
            this.tBorcsTableAdapter.ClearBeforeFill = true;
            // 
            // vTYSProjeDataSet6
            // 
            this.vTYSProjeDataSet6.DataSetName = "VTYSProjeDataSet6";
            this.vTYSProjeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tSatisBindingSource
            // 
            this.tSatisBindingSource.DataMember = "tSatis";
            this.tSatisBindingSource.DataSource = this.vTYSProjeDataSet6;
            // 
            // tSatisTableAdapter
            // 
            this.tSatisTableAdapter.ClearBeforeFill = true;
            // 
            // borcTarihiDataGridViewTextBoxColumn
            // 
            this.borcTarihiDataGridViewTextBoxColumn.DataPropertyName = "borcTarihi";
            this.borcTarihiDataGridViewTextBoxColumn.HeaderText = "Borç Tarihi";
            this.borcTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.borcTarihiDataGridViewTextBoxColumn.Name = "borcTarihiDataGridViewTextBoxColumn";
            this.borcTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "musteriId";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "Müşteri ID";
            this.musteriIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // borcMiktarDataGridViewTextBoxColumn
            // 
            this.borcMiktarDataGridViewTextBoxColumn.DataPropertyName = "borcMiktar";
            this.borcMiktarDataGridViewTextBoxColumn.HeaderText = "Borç Miktarı";
            this.borcMiktarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.borcMiktarDataGridViewTextBoxColumn.Name = "borcMiktarDataGridViewTextBoxColumn";
            this.borcMiktarDataGridViewTextBoxColumn.Width = 150;
            // 
            // satisTarihDataGridViewTextBoxColumn
            // 
            this.satisTarihDataGridViewTextBoxColumn.DataPropertyName = "satisTarih";
            this.satisTarihDataGridViewTextBoxColumn.HeaderText = "Satış Tarihi";
            this.satisTarihDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.satisTarihDataGridViewTextBoxColumn.Name = "satisTarihDataGridViewTextBoxColumn";
            this.satisTarihDataGridViewTextBoxColumn.Width = 150;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 150;
            // 
            // satisTutarDataGridViewTextBoxColumn
            // 
            this.satisTutarDataGridViewTextBoxColumn.DataPropertyName = "satisTutar";
            this.satisTutarDataGridViewTextBoxColumn.HeaderText = "Satış Tutar";
            this.satisTutarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.satisTutarDataGridViewTextBoxColumn.Name = "satisTutarDataGridViewTextBoxColumn";
            this.satisTutarDataGridViewTextBoxColumn.Width = 150;
            // 
            // satisMiktarDataGridViewTextBoxColumn
            // 
            this.satisMiktarDataGridViewTextBoxColumn.DataPropertyName = "satisMiktar";
            this.satisMiktarDataGridViewTextBoxColumn.HeaderText = "Satış Miktarı";
            this.satisMiktarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.satisMiktarDataGridViewTextBoxColumn.Name = "satisMiktarDataGridViewTextBoxColumn";
            this.satisMiktarDataGridViewTextBoxColumn.Width = 150;
            // 
            // MusteriBazlıRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1126, 654);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriBazlıRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bazlı Rapor";
            this.Load += new System.EventHandler(this.MusteriBazlıRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBorcsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private VTYSProje1.Entity.RJButton rjButton3;
        private VTYSProjeDataSet5 vTYSProjeDataSet5;
        private System.Windows.Forms.BindingSource tBorcsBindingSource;
        private VTYSProjeDataSet5TableAdapters.tBorcsTableAdapter tBorcsTableAdapter;
        private VTYSProjeDataSet6 vTYSProjeDataSet6;
        private System.Windows.Forms.BindingSource tSatisBindingSource;
        private VTYSProjeDataSet6TableAdapters.tSatisTableAdapter tSatisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcMiktarDataGridViewTextBoxColumn;
    }
}