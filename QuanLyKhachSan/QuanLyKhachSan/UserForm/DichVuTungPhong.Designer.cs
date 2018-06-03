namespace QuanLyKhachSan.UserForm
{
    partial class DichVuTungPhong
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
            this.bt_qua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_lu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_tt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_mp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_qua
            // 
            this.bt_qua.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_qua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_qua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_qua.Location = new System.Drawing.Point(521, 208);
            this.bt_qua.Name = "bt_qua";
            this.bt_qua.Size = new System.Drawing.Size(55, 28);
            this.bt_qua.TabIndex = 24;
            this.bt_qua.Text = ">>";
            this.bt_qua.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Số Lượng";
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(448, 125);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(55, 20);
            this.txt_sl.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.Gia});
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(331, 302);
            this.dataGridView1.TabIndex = 21;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "MaDv";
            this.Ma.HeaderText = "Mã";
            this.Ma.Name = "Ma";
            this.Ma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ma.Width = 50;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "TenDv";
            this.Ten.HeaderText = "Tên Dịch Vụ";
            this.Ten.Name = "Ten";
            this.Ten.Width = 158;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.Width = 80;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(448, 168);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(128, 20);
            this.txt_gia.TabIndex = 20;
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(448, 250);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(128, 20);
            this.txt_dc.TabIndex = 19;
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.ForeColor = System.Drawing.Color.MintCream;
            this.bt_huy.Location = new System.Drawing.Point(494, 363);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(101, 30);
            this.bt_huy.TabIndex = 17;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = false;
            // 
            // bt_lu
            // 
            this.bt_lu.BackColor = System.Drawing.Color.DarkCyan;
            this.bt_lu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lu.ForeColor = System.Drawing.Color.MintCream;
            this.bt_lu.Location = new System.Drawing.Point(367, 363);
            this.bt_lu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_lu.Name = "bt_lu";
            this.bt_lu.Size = new System.Drawing.Size(105, 30);
            this.bt_lu.TabIndex = 18;
            this.bt_lu.Text = "Thêm";
            this.bt_lu.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(582, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vnd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(547, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vnd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(582, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vnd";
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tt.Location = new System.Drawing.Point(455, 303);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(17, 17);
            this.lb_tt.TabIndex = 12;
            this.lb_tt.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thành Tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bảng Dịch Vụ Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tiền Đặt Cọc";
            // 
            // lb_mp
            // 
            this.lb_mp.AutoSize = true;
            this.lb_mp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mp.Location = new System.Drawing.Point(380, 16);
            this.lb_mp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mp.Name = "lb_mp";
            this.lb_mp.Size = new System.Drawing.Size(64, 22);
            this.lb_mp.TabIndex = 8;
            this.lb_mp.Text = "label1";
            // 
            // DichVuTungPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 415);
            this.Controls.Add(this.bt_qua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_sl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_dc);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_lu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_tt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_mp);
            this.Name = "DichVuTungPhong";
            this.Text = "DichVuTungPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_qua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_lu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_tt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_mp;
    }
}