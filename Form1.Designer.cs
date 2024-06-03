namespace CS_HinhChuNhat
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(195, 27);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 21);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(195, 68);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 21);
            this.txtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "b";
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(61, 153);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(100, 28);
            this.btnCV.TabIndex = 4;
            this.btnCV.Text = "Chu Vi";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnDT
            // 
            this.btnDT.Location = new System.Drawing.Point(168, 153);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(100, 28);
            this.btnDT.TabIndex = 5;
            this.btnDT.Text = "Dien Tich";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(274, 153);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(195, 108);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 21);
            this.txtKQ.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Location = new System.Drawing.Point(435, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(435, 153);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 28);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Location = new System.Drawing.Point(17, 21);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(38, 17);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "CV";
            this.rdbCV.UseVisualStyleBackColor = true;
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Location = new System.Drawing.Point(17, 45);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(38, 17);
            this.rdbDT.TabIndex = 0;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "DT";
            this.rdbDT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 207);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Tình Tính HCN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.RadioButton rdbCV;
    }
}

