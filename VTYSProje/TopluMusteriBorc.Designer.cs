namespace VTYSProje
{
    partial class TopluMusteriBorc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopluMusteriBorc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMusterisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vTYSProjeDataSet4 = new VTYSProje.VTYSProjeDataSet4();
            this.rjButton2 = new VTYSProje1.Entity.RJButton();
            this.rjButton1 = new VTYSProje1.Entity.RJButton();
            this.rjButton3 = new VTYSProje1.Entity.RJButton();
            this.tMusterisTableAdapter = new VTYSProje.VTYSProjeDataSet4TableAdapters.tMusterisTableAdapter();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rjButton4 = new VTYSProje1.Entity.RJButton();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMusterisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriAdiDataGridViewTextBoxColumn,
            this.musteriSoyadiDataGridViewTextBoxColumn,
            this.musteriBorcDataGridViewTextBoxColumn,
            this.odenenMiktarDataGridViewTextBoxColumn,
            this.kalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tMusterisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // musteriAdiDataGridViewTextBoxColumn
            // 
            this.musteriAdiDataGridViewTextBoxColumn.DataPropertyName = "musteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.HeaderText = "Müşteri Adı";
            this.musteriAdiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.musteriAdiDataGridViewTextBoxColumn.Name = "musteriAdiDataGridViewTextBoxColumn";
            this.musteriAdiDataGridViewTextBoxColumn.Width = 150;
            // 
            // musteriSoyadiDataGridViewTextBoxColumn
            // 
            this.musteriSoyadiDataGridViewTextBoxColumn.DataPropertyName = "musteriSoyadi";
            this.musteriSoyadiDataGridViewTextBoxColumn.HeaderText = "Müşteri Soyadı";
            this.musteriSoyadiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.musteriSoyadiDataGridViewTextBoxColumn.Name = "musteriSoyadiDataGridViewTextBoxColumn";
            this.musteriSoyadiDataGridViewTextBoxColumn.Width = 150;
            // 
            // musteriBorcDataGridViewTextBoxColumn
            // 
            this.musteriBorcDataGridViewTextBoxColumn.DataPropertyName = "musteriBorc";
            this.musteriBorcDataGridViewTextBoxColumn.HeaderText = "Toplam Satış";
            this.musteriBorcDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.musteriBorcDataGridViewTextBoxColumn.Name = "musteriBorcDataGridViewTextBoxColumn";
            this.musteriBorcDataGridViewTextBoxColumn.Width = 150;
            // 
            // odenenMiktarDataGridViewTextBoxColumn
            // 
            this.odenenMiktarDataGridViewTextBoxColumn.DataPropertyName = "odenenMiktar";
            this.odenenMiktarDataGridViewTextBoxColumn.HeaderText = "Ödenen Miktar";
            this.odenenMiktarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.odenenMiktarDataGridViewTextBoxColumn.Name = "odenenMiktarDataGridViewTextBoxColumn";
            this.odenenMiktarDataGridViewTextBoxColumn.Width = 150;
            // 
            // kalanBorcDataGridViewTextBoxColumn
            // 
            this.kalanBorcDataGridViewTextBoxColumn.DataPropertyName = "kalanBorc";
            this.kalanBorcDataGridViewTextBoxColumn.HeaderText = "Kalan Borç";
            this.kalanBorcDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kalanBorcDataGridViewTextBoxColumn.Name = "kalanBorcDataGridViewTextBoxColumn";
            this.kalanBorcDataGridViewTextBoxColumn.Width = 150;
            // 
            // tMusterisBindingSource
            // 
            this.tMusterisBindingSource.DataMember = "tMusteris";
            this.tMusterisBindingSource.DataSource = this.vTYSProjeDataSet4;
            // 
            // vTYSProjeDataSet4
            // 
            this.vTYSProjeDataSet4.DataSetName = "VTYSProjeDataSet4";
            this.vTYSProjeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Green;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.rjButton2.BorderRadius = 25;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.ImageKey = "microsoft_office_excel_logo_icon_145720.png";
            this.rjButton2.ImageList = this.ımageList2;
            this.rjButton2.Location = new System.Drawing.Point(669, 29);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(184, 135);
            this.rjButton2.TabIndex = 13;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.rjButton1.BorderRadius = 25;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.ImageKey = "file_type_word_icon_130070.png";
            this.rjButton1.ImageList = this.ımageList2;
            this.rjButton1.Location = new System.Drawing.Point(439, 29);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(184, 135);
            this.rjButton1.TabIndex = 14;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.rjButton3.BorderRadius = 25;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.ImageKey = "file_type_pdf_icon_130274.png";
            this.rjButton3.ImageList = this.ımageList2;
            this.rjButton3.Location = new System.Drawing.Point(212, 29);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(184, 135);
            this.rjButton3.TabIndex = 15;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // tMusterisTableAdapter
            // 
            this.tMusterisTableAdapter.ClearBeforeFill = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-go-back-64.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-left-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-return-48.png");
            this.ımageList1.Images.SetKeyName(3, "file_type_pdf_icon_130274.png");
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.Transparent;
            this.rjButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton4.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton4.BorderRadius = 20;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.ImageKey = "icons8-return-48.png";
            this.rjButton4.ImageList = this.ımageList1;
            this.rjButton4.Location = new System.Drawing.Point(12, 12);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(78, 63);
            this.rjButton4.TabIndex = 16;
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "icons8-go-back-64.png");
            this.ımageList2.Images.SetKeyName(1, "icons8-left-48.png");
            this.ımageList2.Images.SetKeyName(2, "icons8-return-48.png");
            this.ımageList2.Images.SetKeyName(3, "file_type_pdf_icon_130274.png");
            this.ımageList2.Images.SetKeyName(4, "microsoft_office_excel_logo_icon_145720.png");
            this.ımageList2.Images.SetKeyName(5, "file_type_word_icon_130070.png");
            // 
            // TopluMusteriBorc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1093, 654);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopluMusteriBorc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu Müşteri Borç Durumu";
            this.Load += new System.EventHandler(this.TopluMusteriBorc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMusterisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VTYSProje1.Entity.RJButton rjButton2;
        private VTYSProje1.Entity.RJButton rjButton1;
        private VTYSProje1.Entity.RJButton rjButton3;
        private VTYSProjeDataSet4 vTYSProjeDataSet4;
        private System.Windows.Forms.BindingSource tMusterisBindingSource;
        private VTYSProjeDataSet4TableAdapters.tMusterisTableAdapter tMusterisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList ımageList1;
        private VTYSProje1.Entity.RJButton rjButton4;
        private System.Windows.Forms.ImageList ımageList2;
    }
}