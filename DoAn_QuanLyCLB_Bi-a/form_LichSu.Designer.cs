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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_XemCT = new System.Windows.Forms.Button();
            this.btn_TongKet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.da_LichSu = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.txt_tongket = new System.Windows.Forms.TextBox();
            this.btn_timban = new System.Windows.Forms.Button();
            this.txt_tkban = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(75, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 69);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.btn_timban);
            this.panel2.Controls.Add(this.txt_tkban);
            this.panel2.Controls.Add(this.txt_tongket);
            this.panel2.Controls.Add(this.btn_timkiem);
            this.panel2.Controls.Add(this.btn_XemCT);
            this.panel2.Controls.Add(this.btn_TongKet);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.da_LichSu);
            this.panel2.Controls.Add(this.txtTimkiem);
            this.panel2.Location = new System.Drawing.Point(75, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 542);
            this.panel2.TabIndex = 5;
            // 
            // btn_XemCT
            // 
            this.btn_XemCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(144)))));
            this.btn_XemCT.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_XemCT.FlatAppearance.BorderSize = 0;
            this.btn_XemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemCT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_XemCT.Location = new System.Drawing.Point(323, 15);
            this.btn_XemCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XemCT.Name = "btn_XemCT";
            this.btn_XemCT.Size = new System.Drawing.Size(146, 36);
            this.btn_XemCT.TabIndex = 18;
            this.btn_XemCT.Text = "Xem chi tiết ";
            this.btn_XemCT.UseVisualStyleBackColor = false;
            this.btn_XemCT.Click += new System.EventHandler(this.btn_XemCT_Click);
            // 
            // btn_TongKet
            // 
            this.btn_TongKet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(144)))));
            this.btn_TongKet.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_TongKet.FlatAppearance.BorderSize = 0;
            this.btn_TongKet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TongKet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TongKet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TongKet.Location = new System.Drawing.Point(517, 15);
            this.btn_TongKet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TongKet.Name = "btn_TongKet";
            this.btn_TongKet.Size = new System.Drawing.Size(141, 32);
            this.btn_TongKet.TabIndex = 17;
            this.btn_TongKet.Text = "Tổng kết ngày";
            this.btn_TongKet.UseVisualStyleBackColor = false;
            this.btn_TongKet.Click += new System.EventHandler(this.btn_TongKet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(323, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(202, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp xếp";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 20);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // da_LichSu
            // 
            this.da_LichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.da_LichSu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.da_LichSu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.da_LichSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.da_LichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.da_LichSu.Location = new System.Drawing.Point(31, 111);
            this.da_LichSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.da_LichSu.Name = "da_LichSu";
            this.da_LichSu.RowHeadersWidth = 51;
            this.da_LichSu.RowTemplate.Height = 24;
            this.da_LichSu.Size = new System.Drawing.Size(789, 400);
            this.da_LichSu.TabIndex = 2;
            this.da_LichSu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.da_LichSu_CellContentClick);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(170, 15);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(127, 36);
            this.txtTimkiem.TabIndex = 0;
            // 
            // txt_tongket
            // 
            this.txt_tongket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongket.Location = new System.Drawing.Point(664, 15);
            this.txt_tongket.Multiline = true;
            this.txt_tongket.Name = "txt_tongket";
            this.txt_tongket.Size = new System.Drawing.Size(110, 30);
            this.txt_tongket.TabIndex = 20;
            // 
            // btn_timban
            // 
            this.btn_timban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(144)))));
            this.btn_timban.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_timban.FlatAppearance.BorderSize = 0;
            this.btn_timban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timban.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_timban.Image = global::DoAn_QuanLyCLB_Bi_a.Properties.Resources.icons8_find_35;
            this.btn_timban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timban.Location = new System.Drawing.Point(23, 58);
            this.btn_timban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timban.Name = "btn_timban";
            this.btn_timban.Size = new System.Drawing.Size(141, 36);
            this.btn_timban.TabIndex = 22;
            this.btn_timban.Text = "Tìm Bàn";
            this.btn_timban.UseVisualStyleBackColor = false;
            this.btn_timban.Click += new System.EventHandler(this.btn_timban_Click);
            // 
            // txt_tkban
            // 
            this.txt_tkban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tkban.Location = new System.Drawing.Point(170, 58);
            this.txt_tkban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tkban.Multiline = true;
            this.txt_tkban.Name = "txt_tkban";
            this.txt_tkban.Size = new System.Drawing.Size(127, 36);
            this.txt_tkban.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(781, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 42);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(47)))), ((int)(((byte)(144)))));
            this.btn_timkiem.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_timkiem.FlatAppearance.BorderSize = 0;
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_timkiem.Image = global::DoAn_QuanLyCLB_Bi_a.Properties.Resources.icons8_find_35;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(23, 15);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(141, 36);
            this.btn_timkiem.TabIndex = 19;
            this.btn_timkiem.Text = "Tìm KH";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_LichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_timban;
        private System.Windows.Forms.TextBox txt_tkban;
        private System.Windows.Forms.TextBox txt_tongket;
    }
}