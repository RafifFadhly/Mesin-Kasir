namespace DPK_A_PAS_new
{
    partial class Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuDataSet3 = new DPK_A_PAS_new.MenuDataSet3();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesananDataSet3 = new DPK_A_PAS_new.PesananDataSet3();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuTableAdapter = new DPK_A_PAS_new.MenuDataSet3TableAdapters.MenuTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesananTableAdapter = new DPK_A_PAS_new.PesananDataSet3TableAdapters.PesananTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kalkulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Menu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "harga Menu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jumlah Pesanan Menu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(416, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(416, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(416, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(349, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(416, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(349, 26);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "0";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Makanan",
            "Minuman"});
            this.comboBox1.Location = new System.Drawing.Point(416, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(722, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(679, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 337);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.menuDataSet3;
            // 
            // menuDataSet3
            // 
            this.menuDataSet3.DataSetName = "MenuDataSet3";
            this.menuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeDataGridViewTextBoxColumn1,
            this.menuDataGridViewTextBoxColumn,
            this.jmlDataGridViewTextBoxColumn1,
            this.hargaDataGridViewTextBoxColumn1,
            this.diskonDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pesananBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(777, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(498, 579);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // kodeDataGridViewTextBoxColumn1
            // 
            this.kodeDataGridViewTextBoxColumn1.DataPropertyName = "Kode";
            this.kodeDataGridViewTextBoxColumn1.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.kodeDataGridViewTextBoxColumn1.Name = "kodeDataGridViewTextBoxColumn1";
            // 
            // menuDataGridViewTextBoxColumn
            // 
            this.menuDataGridViewTextBoxColumn.DataPropertyName = "Menu";
            this.menuDataGridViewTextBoxColumn.HeaderText = "Menu";
            this.menuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.menuDataGridViewTextBoxColumn.Name = "menuDataGridViewTextBoxColumn";
            // 
            // jmlDataGridViewTextBoxColumn1
            // 
            this.jmlDataGridViewTextBoxColumn1.DataPropertyName = "Jml";
            this.jmlDataGridViewTextBoxColumn1.HeaderText = "Jml";
            this.jmlDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.jmlDataGridViewTextBoxColumn1.Name = "jmlDataGridViewTextBoxColumn1";
            // 
            // hargaDataGridViewTextBoxColumn1
            // 
            this.hargaDataGridViewTextBoxColumn1.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn1.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn1.Name = "hargaDataGridViewTextBoxColumn1";
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
            this.pesananBindingSource.DataSource = this.pesananDataSet3;
            // 
            // pesananDataSet3
            // 
            this.pesananDataSet3.DataSetName = "PesananDataSet3";
            this.pesananDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1001, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pesanan";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chocolate;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(436, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 46);
            this.button4.TabIndex = 21;
            this.button4.Text = "selesai";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(247, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 46);
            this.button5.TabIndex = 22;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Menu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(416, 232);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(88, 26);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Diskon (%)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "%";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kodeDataGridViewTextBoxColumn2
            // 
            this.kodeDataGridViewTextBoxColumn2.DataPropertyName = "Kode";
            this.kodeDataGridViewTextBoxColumn2.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.kodeDataGridViewTextBoxColumn2.Name = "kodeDataGridViewTextBoxColumn2";
            this.kodeDataGridViewTextBoxColumn2.Width = 209;
            // 
            // jmlDataGridViewTextBoxColumn
            // 
            this.jmlDataGridViewTextBoxColumn.DataPropertyName = "Jml";
            this.jmlDataGridViewTextBoxColumn.HeaderText = "Jml";
            this.jmlDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jmlDataGridViewTextBoxColumn.Name = "jmlDataGridViewTextBoxColumn";
            this.jmlDataGridViewTextBoxColumn.Width = 209;
            // 
            // pesananTableAdapter
            // 
            this.pesananTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 26);
            this.label11.TabIndex = 33;
            this.label11.Text = "Cafe Watu";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chocolate;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalkulatorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 33);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kalkulatorToolStripMenuItem
            // 
            this.kalkulatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kalkulatorToolStripMenuItem.Name = "kalkulatorToolStripMenuItem";
            this.kalkulatorToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.kalkulatorToolStripMenuItem.Text = "Kalkulator";
            this.kalkulatorToolStripMenuItem.Click += new System.EventHandler(this.kalkulatorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1292, 675);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private MenuDataSet3 menuDataSet3;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private MenuDataSet3TableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlDataGridViewTextBoxColumn;
        private PesananDataSet3 pesananDataSet3;
        private System.Windows.Forms.BindingSource pesananBindingSource;
        private PesananDataSet3TableAdapters.PesananTableAdapter pesananTableAdapter;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kalkulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}