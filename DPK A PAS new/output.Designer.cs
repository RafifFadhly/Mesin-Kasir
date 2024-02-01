namespace DPK_A_PAS_new
{
    partial class output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(output));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesananDataSet4 = new DPK_A_PAS_new.PesananDataSet4();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pesananDataSet = new DPK_A_PAS_new.PesananDataSet();
            this.pesananDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesananTableAdapter = new DPK_A_PAS_new.PesananDataSet4TableAdapters.PesananTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeDataGridViewTextBoxColumn,
            this.menuDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.jmlDataGridViewTextBoxColumn,
            this.diskonDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pesananBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 154);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(604, 333);
            this.dataGridView2.TabIndex = 19;
            // 
            // kodeDataGridViewTextBoxColumn
            // 
            this.kodeDataGridViewTextBoxColumn.DataPropertyName = "Kode";
            this.kodeDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodeDataGridViewTextBoxColumn.Name = "kodeDataGridViewTextBoxColumn";
            // 
            // menuDataGridViewTextBoxColumn
            // 
            this.menuDataGridViewTextBoxColumn.DataPropertyName = "Menu";
            this.menuDataGridViewTextBoxColumn.HeaderText = "Menu";
            this.menuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.menuDataGridViewTextBoxColumn.Name = "menuDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // jmlDataGridViewTextBoxColumn
            // 
            this.jmlDataGridViewTextBoxColumn.DataPropertyName = "Jml";
            this.jmlDataGridViewTextBoxColumn.HeaderText = "Jml";
            this.jmlDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jmlDataGridViewTextBoxColumn.Name = "jmlDataGridViewTextBoxColumn";
            // 
            // diskonDataGridViewTextBoxColumn
            // 
            this.diskonDataGridViewTextBoxColumn.DataPropertyName = "Diskon";
            this.diskonDataGridViewTextBoxColumn.HeaderText = "Diskon";
            this.diskonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diskonDataGridViewTextBoxColumn.Name = "diskonDataGridViewTextBoxColumn";
            // 
            // pesananBindingSource
            // 
            this.pesananBindingSource.DataMember = "Pesanan";
            this.pesananBindingSource.DataSource = this.pesananDataSet4;
            // 
            // pesananDataSet4
            // 
            this.pesananDataSet4.DataSetName = "PesananDataSet4";
            this.pesananDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 498);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 26);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 530);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 26);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tunai",
            "Debit"});
            this.comboBox1.Location = new System.Drawing.Point(425, 562);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(666, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 36);
            this.button3.TabIndex = 23;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pesananDataSet
            // 
            this.pesananDataSet.DataSetName = "PesananDataSet";
            this.pesananDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesananDataSetBindingSource
            // 
            this.pesananDataSetBindingSource.DataSource = this.pesananDataSet;
            this.pesananDataSetBindingSource.Position = 0;
            // 
            // pesananTableAdapter
            // 
            this.pesananTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Metode Pembayaran";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total Pesanan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Kasir = ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 26);
            this.textBox3.TabIndex = 28;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(314, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 49);
            this.button1.TabIndex = 29;
            this.button1.Text = "Selesai";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 59);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cafe Watu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(336, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(58, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 49);
            this.button2.TabIndex = 30;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 26);
            this.textBox4.TabIndex = 34;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Waktu = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Uang Bayar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(310, 597);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(306, 26);
            this.textBox5.TabIndex = 36;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(632, 690);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "output";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "output";
            this.Load += new System.EventHandler(this.output_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource pesananDataSetBindingSource;
        private PesananDataSet pesananDataSet;
        private PesananDataSet4 pesananDataSet4;
        private System.Windows.Forms.BindingSource pesananBindingSource;
        private PesananDataSet4TableAdapters.PesananTableAdapter pesananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox5;
    }
}