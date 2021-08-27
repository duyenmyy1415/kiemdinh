namespace PhanMemQLNhaSach
{
    partial class frmNhapSach
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
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHASACHDataSet1 = new PhanMemQLNhaSach.QL_NHASACHDataSet1();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nru1 = new System.Windows.Forms.NumericUpDown();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.sACHTableAdapter = new PhanMemQLNhaSach.QL_NHASACHDataSet1TableAdapters.SACHTableAdapter();
            this.gb3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nru1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.btnTim);
            this.gb3.Controls.Add(this.txtTim);
            this.gb3.Controls.Add(this.lblMaPN);
            this.gb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb3.Location = new System.Drawing.Point(10, 358);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(420, 117);
            this.gb3.TabIndex = 7;
            this.gb3.TabStop = false;
            this.gb3.Text = "Tìm Kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(296, 60);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 32);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(167, 28);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(204, 26);
            this.txtTim.TabIndex = 1;
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPN.Location = new System.Drawing.Point(34, 31);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(109, 19);
            this.lblMaPN.TabIndex = 0;
            this.lblMaPN.Text = "Mã phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(436, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 464);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(14, 25);
            this.dgv1.Name = "dgv1";
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(533, 414);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClear1);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.cboTenHang);
            this.groupBox1.Controls.Add(this.btnThemPN);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.nru1);
            this.groupBox1.Controls.Add(this.lblSL);
            this.groupBox1.Controls.Add(this.lblTen);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 341);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(171, 120);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(216, 26);
            this.txtDonGia.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Đơn Giá";
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(349, 264);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(65, 50);
            this.btnClear1.TabIndex = 18;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(224, 264);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 50);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboTenHang
            // 
            this.cboTenHang.DataSource = this.sACHBindingSource;
            this.cboTenHang.DisplayMember = "TENSACH";
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Location = new System.Drawing.Point(171, 80);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(219, 28);
            this.cboTenHang.TabIndex = 16;
            this.cboTenHang.ValueMember = "GIA";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qL_NHASACHDataSet1;
            // 
            // qL_NHASACHDataSet1
            // 
            this.qL_NHASACHDataSet1.DataSetName = "QL_NHASACHDataSet1";
            this.qL_NHASACHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThemPN
            // 
            this.btnThemPN.Location = new System.Drawing.Point(315, 25);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(56, 41);
            this.btnThemPN.TabIndex = 15;
            this.btnThemPN.Text = "+";
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(106, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 50);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 264);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 50);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "add";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nru1
            // 
            this.nru1.Location = new System.Drawing.Point(173, 162);
            this.nru1.Name = "nru1";
            this.nru1.Size = new System.Drawing.Size(62, 26);
            this.nru1.TabIndex = 10;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSL.Location = new System.Drawing.Point(36, 164);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(69, 19);
            this.lblSL.TabIndex = 5;
            this.lblSL.Text = "Số lượng";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Location = new System.Drawing.Point(34, 83);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(71, 19);
            this.lblTen.TabIndex = 3;
            this.lblTen.Text = "Tên hàng";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(171, 40);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(99, 26);
            this.txtMa.TabIndex = 2;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMa.Location = new System.Drawing.Point(34, 40);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(109, 19);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã phiếu nhập";
            this.lblMa.Click += new System.EventHandler(this.lblMa_Click);
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 484);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapSach";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHASACHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nru1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nru1;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private QL_NHASACHDataSet1 qL_NHASACHDataSet1;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QL_NHASACHDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;

    }
}