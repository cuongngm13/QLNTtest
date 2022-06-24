namespace QLNTtest
{
    partial class FormHDNhap
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
            this.dtgCTHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.dtpNgayHD = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtThuoc = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgHDN = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHDN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCTHD
            // 
            this.dtgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCTHD.Location = new System.Drawing.Point(29, 45);
            this.dtgCTHD.Name = "dtgCTHD";
            this.dtgCTHD.RowHeadersWidth = 51;
            this.dtgCTHD.RowTemplate.Height = 24;
            this.dtgCTHD.Size = new System.Drawing.Size(313, 270);
            this.dtgCTHD.TabIndex = 1;
            this.dtgCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCTHD_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Be Vietnam Pro Thin", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã HD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Be Vietnam Pro Thin", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Be Vietnam Pro Thin", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "NgayHD:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Be Vietnam Pro Thin", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Be Vietnam Pro Thin", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Be Vietnam Pro Thin", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên thuốc:";
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(733, 27);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(103, 62);
            this.btnXOA.TabIndex = 22;
            this.btnXOA.Text = "XOA";
            this.btnXOA.UseVisualStyleBackColor = true;
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(523, 27);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(103, 62);
            this.btnSUA.TabIndex = 21;
            this.btnSUA.Text = "SỬA";
            this.btnSUA.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(245, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 62);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnIN
            // 
            this.btnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Location = new System.Drawing.Point(40, 27);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(103, 62);
            this.btnIN.TabIndex = 19;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // dtpNgayHD
            // 
            this.dtpNgayHD.Location = new System.Drawing.Point(100, 431);
            this.dtpNgayHD.Name = "dtpNgayHD";
            this.dtpNgayHD.Size = new System.Drawing.Size(260, 22);
            this.dtpNgayHD.TabIndex = 23;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(100, 492);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(79, 22);
            this.txtMaHD.TabIndex = 24;
            this.txtMaHD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(100, 549);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(343, 22);
            this.txtNCC.TabIndex = 25;
            this.txtNCC.TextChanged += new System.EventHandler(this.txtNV_TextChanged);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(604, 489);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(76, 22);
            this.txtSL.TabIndex = 26;
            // 
            // txtThuoc
            // 
            this.txtThuoc.Location = new System.Drawing.Point(604, 433);
            this.txtThuoc.Name = "txtThuoc";
            this.txtThuoc.Size = new System.Drawing.Size(232, 22);
            this.txtThuoc.TabIndex = 27;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(604, 553);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(158, 22);
            this.txtDonGia.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgHDN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 315);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // dtgHDN
            // 
            this.dtgHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHDN.Location = new System.Drawing.Point(7, 39);
            this.dtgHDN.Name = "dtgHDN";
            this.dtgHDN.RowHeadersWidth = 51;
            this.dtgHDN.RowTemplate.Height = 24;
            this.dtgHDN.Size = new System.Drawing.Size(313, 270);
            this.dtgHDN.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCTHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(481, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 315);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CTHD";
            // 
            // FormHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtThuoc);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtNCC);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.dtpNgayHD);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHDNhap";
            this.Text = "FormHDNhap";
            this.Load += new System.EventHandler(this.FormHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHDN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgCTHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.DateTimePicker dtpNgayHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtThuoc;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgHDN;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}