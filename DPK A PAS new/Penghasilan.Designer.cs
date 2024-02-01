namespace DPK_A_PAS_new
{
    partial class Penghasilan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.penghasilanTableAdapter1 = new DPK_A_PAS_new.penghasilanDataSet1TableAdapters.penghasilanTableAdapter();
            this.penghasilanDataSet2 = new DPK_A_PAS_new.penghasilanDataSet2();
            this.penghasilanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.penghasilanTableAdapter = new DPK_A_PAS_new.penghasilanDataSet2TableAdapters.penghasilanTableAdapter();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodePembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penghasilanDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penghasilanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn,
            this.totalPesananDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn,
            this.metodePembayaranDataGridViewTextBoxColumn,
            this.waktuDataGridViewTextBoxColumn,
            this.Harga});
            this.dataGridView1.DataSource = this.penghasilanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(867, 575);
            this.dataGridView1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(12, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 46);
            this.button5.TabIndex = 24;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(836, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 36);
            this.button3.TabIndex = 23;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(201, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // penghasilanTableAdapter1
            // 
            this.penghasilanTableAdapter1.ClearBeforeFill = true;
            // 
            // penghasilanDataSet2
            // 
            this.penghasilanDataSet2.DataSetName = "penghasilanDataSet2";
            this.penghasilanDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penghasilanBindingSource
            // 
            this.penghasilanBindingSource.DataMember = "penghasilan";
            this.penghasilanBindingSource.DataSource = this.penghasilanDataSet2;
            // 
            // penghasilanTableAdapter
            // 
            this.penghasilanTableAdapter.ClearBeforeFill = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.FillWeight = 56.81816F;
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 79;
            // 
            // totalPesananDataGridViewTextBoxColumn
            // 
            this.totalPesananDataGridViewTextBoxColumn.DataPropertyName = "Total Pesanan";
            this.totalPesananDataGridViewTextBoxColumn.FillWeight = 110.7954F;
            this.totalPesananDataGridViewTextBoxColumn.HeaderText = "Total Pesanan";
            this.totalPesananDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPesananDataGridViewTextBoxColumn.Name = "totalPesananDataGridViewTextBoxColumn";
            this.totalPesananDataGridViewTextBoxColumn.Width = 147;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "Total Harga";
            this.totalHargaDataGridViewTextBoxColumn.FillWeight = 110.7954F;
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "Total Harga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.Width = 128;
            // 
            // metodePembayaranDataGridViewTextBoxColumn
            // 
            this.metodePembayaranDataGridViewTextBoxColumn.DataPropertyName = "Metode Pembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.FillWeight = 110.7954F;
            this.metodePembayaranDataGridViewTextBoxColumn.HeaderText = "Metode Pembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.metodePembayaranDataGridViewTextBoxColumn.Name = "metodePembayaranDataGridViewTextBoxColumn";
            this.metodePembayaranDataGridViewTextBoxColumn.Width = 192;
            // 
            // waktuDataGridViewTextBoxColumn
            // 
            this.waktuDataGridViewTextBoxColumn.DataPropertyName = "Waktu";
            this.waktuDataGridViewTextBoxColumn.FillWeight = 110.7954F;
            this.waktuDataGridViewTextBoxColumn.HeaderText = "Waktu";
            this.waktuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.waktuDataGridViewTextBoxColumn.Name = "waktuDataGridViewTextBoxColumn";
            this.waktuDataGridViewTextBoxColumn.Width = 91;
            // 
            // Harga
            // 
            this.Harga.DataPropertyName = "Harga";
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 8;
            this.Harga.Name = "Harga";
            this.Harga.Visible = false;
            this.Harga.Width = 89;
            // 
            // Penghasilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(890, 642);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Penghasilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penghasilan";
            this.Load += new System.EventHandler(this.Pesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penghasilanDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penghasilanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private penghasilanDataSet1TableAdapters.penghasilanTableAdapter penghasilanTableAdapter1;
        private penghasilanDataSet2 penghasilanDataSet2;
        private System.Windows.Forms.BindingSource penghasilanBindingSource;
        private penghasilanDataSet2TableAdapters.penghasilanTableAdapter penghasilanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodePembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
    }
}