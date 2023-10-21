namespace DoAn_QuanLyCLB_Bi_a
{
    partial class form_LichSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LichSu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.btn_TongKet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.da_LichSu = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.da_LichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(74, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 69);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(782, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 42);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_XemCT);
            this.panel2.Controls.Add(this.btn_TongKet);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.da_LichSu);
            this.panel2.Controls.Add(this.txtTimkiem);
            this.panel2.Location = new System.Drawing.Point(74, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 541);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(144)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(23, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tìm khách hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(144)))));
            this.btn_XemCT.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_XemCT.FlatAppearance.BorderSize = 0;
            this.btn_XemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemCT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_XemCT.Location = new System.Drawing.Point(521, 28);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(141, 28);
            this.btn_XemCT.TabIndex = 18;
            this.btn_XemCT.Text = "Xem chi tiết ";
            this.btn_XemCT.UseVisualStyleBackColor = false;
            // 
            // btn_TongKet
            // 
            this.btn_TongKet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(144)))));
            this.btn_TongKet.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_TongKet.FlatAppearance.BorderSize = 0;
            this.btn_TongKet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TongKet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TongKet.Location = new System.Drawing.Point(680, 28);
            this.btn_TongKet.Name = "btn_TongKet";
            this.btn_TongKet.Size = new System.Drawing.Size(141, 28);
            this.btn_TongKet.TabIndex = 17;
            this.btn_TongKet.Text = "Tổng kết ngày";
            this.btn_TongKet.UseVisualStyleBackColor = false;
            this.btn_TongKet.Click += new System.EventHandler(this.btn_TongKet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(303, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp xếp";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // da_LichSu
            // 
            this.da_LichSu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.da_LichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.da_LichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.da_LichSu.Location = new System.Drawing.Point(31, 79);
            this.da_LichSu.Name = "da_LichSu";
            this.da_LichSu.RowHeadersWidth = 51;
            this.da_LichSu.RowTemplate.Height = 24;
            this.da_LichSu.Size = new System.Drawing.Size(790, 432);
            this.da_LichSu.TabIndex = 2;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(170, 28);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(127, 24);
            this.txtTimkiem.TabIndex = 0;
            // 
            // form_LichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_LichSu";
            this.Text = "form_LichSu";
            this.Load += new System.EventHandler(this.form_LichSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.da_LichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_XemCT;
        private System.Windows.Forms.Button btn_TongKet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView da_LichSu;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button button1;
    }
}