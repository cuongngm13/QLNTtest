namespace QLNTtest
{
    partial class FrmHDBan
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
            this.lblHD = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblNgayHD = new System.Windows.Forms.Label();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSLg = new System.Windows.Forms.TextBox();
            this.dtpHD = new System.Windows.Forms.DateTimePicker();
            this.btnIN = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.dtgHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCTHD
            // 
            this.dtgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCTHD.Location = new System.Drawing.Point(0, 22);
            this.dtgCTHD.Name = "dtgCTHD";
            this.dtgCTHD.RowHeadersWidth = 51;
            this.dtgCTHD.RowTemplate.Height = 24;
            this.dtgCTHD.Size = new System.Drawing.Size(505, 311);
            this.dtgCTHD.TabIndex = 1;
            this.dtgCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCTHD_CellContentClick);
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Location = new System.Drawing.Point(16, 407);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(52, 16);
            this.lblHD.TabIndex = 3;
            this.lblHD.Text = "Mã HD:";
            this.lblHD.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Location = new System.Drawing.Point(12, 465);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(55, 16);
            this.lblKH.TabIndex = 4;
            this.lblKH.Text = "Tên KH:";
            // 
            // lblNgayHD
            // 
            this.lblNgayHD.AutoSize = true;
            this.lblNgayHD.Location = new System.Drawing.Point(194, 407);
            this.lblNgayHD.Name = "lblNgayHD";
            this.lblNgayHD.Size = new System.Drawing.Size(66, 16);
            this.lblNgayHD.TabIndex = 5;
            this.lblNgayHD.Text = "Ngày HD:";
            // 
            // lblThuoc
            // 
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.Location = new System.Drawing.Point(584, 410);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Size = new System.Drawing.Size(69, 16);
            this.lblThuoc.TabIndex = 6;
            this.lblThuoc.Text = "Tên thuốc:";
            // 
            // lblDG
            // 
            this.lblDG.AutoSize = true;
            this.lblDG.Location = new System.Drawing.Point(584, 465);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(56, 16);
            this.lblDG.TabIndex = 7;
            this.lblDG.Text = "Đơn giá:";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(840, 410);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(60, 16);
            this.lblSL.TabIndex = 8;
            this.lblSL.Text = "Số lượng";
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(71, 404);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(90, 22);
            this.txtHD.TabIndex = 9;
            this.txtHD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKH
            // 
            this.txtKH.Location = new System.Drawing.Point(71, 459);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(186, 22);
            this.txtKH.TabIndex = 10;
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Location = new System.Drawing.Point(670, 410);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(146, 22);
            this.txtTenthuoc.TabIndex = 11;
            this.txtTenthuoc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(670, 467);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(146, 22);
            this.txtDonGia.TabIndex = 12;
            // 
            // txtSLg
            // 
            this.txtSLg.Location = new System.Drawing.Point(913, 407);
            this.txtSLg.Name = "txtSLg";
            this.txtSLg.Size = new System.Drawing.Size(159, 22);
            this.txtSLg.TabIndex = 13;
            // 
            // dtpHD
            // 
            this.dtpHD.Location = new System.Drawing.Point(289, 402);
            this.dtpHD.Name = "dtpHD";
            this.dtpHD.Size = new System.Drawing.Size(200, 22);
            this.dtpHD.TabIndex = 14;
            // 
            // btnIN
            // 
            this.btnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Location = new System.Drawing.Point(1162, 34);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(103, 62);
            this.btnIN.TabIndex = 15;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1162, 118);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 62);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSUA
            // 
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUA.Location = new System.Drawing.Point(1162, 200);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(103, 62);
            this.btnSUA.TabIndex = 17;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(1162, 278);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(103, 62);
            this.btnXOA.TabIndex = 18;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            // 
            // dtgHoaDon
            // 
            this.dtgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDon.Location = new System.Drawing.Point(6, 22);
            this.dtgHoaDon.Name = "dtgHoaDon";
            this.dtgHoaDon.RowHeadersWidth = 51;
            this.dtgHoaDon.RowTemplate.Height = 24;
            this.dtgHoaDon.Size = new System.Drawing.Size(458, 311);
            this.dtgHoaDon.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 333);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCTHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(587, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 364);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CTHD";
            // 
            // FrmHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.dtpHD);
            this.Controls.Add(this.txtSLg);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenthuoc);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblDG);
            this.Controls.Add(this.lblThuoc);
            this.Controls.Add(this.lblNgayHD);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.lblHD);
            this.Name = "FrmHDBan";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.v);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgCTHD;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label lblNgayHD;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSLg;
        private System.Windows.Forms.DateTimePicker dtpHD;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.DataGridView dtgHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}