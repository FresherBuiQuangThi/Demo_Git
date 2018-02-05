namespace TH_WF_Tuan01_BuiQuangThi_2001140242
{
    partial class Game_Caro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_BanCo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.prsbar_Cot = new System.Windows.Forms.ProgressBar();
            this.prsbar_Dong = new System.Windows.Forms.ProgressBar();
            this.cmb_SoO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pn_BanCo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 664);
            this.panel1.TabIndex = 0;
            // 
            // pn_BanCo
            // 
            this.pn_BanCo.AutoScroll = true;
            this.pn_BanCo.AutoSize = true;
            this.pn_BanCo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_BanCo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_BanCo.Location = new System.Drawing.Point(0, 0);
            this.pn_BanCo.Name = "pn_BanCo";
            this.pn_BanCo.Size = new System.Drawing.Size(4, 664);
            this.pn_BanCo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Tao);
            this.panel2.Controls.Add(this.prsbar_Cot);
            this.panel2.Controls.Add(this.prsbar_Dong);
            this.panel2.Controls.Add(this.cmb_SoO);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(918, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 664);
            this.panel2.TabIndex = 1;
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(185, 52);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(75, 23);
            this.btn_Tao.TabIndex = 10;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click_1);
            // 
            // prsbar_Cot
            // 
            this.prsbar_Cot.Location = new System.Drawing.Point(34, 151);
            this.prsbar_Cot.Name = "prsbar_Cot";
            this.prsbar_Cot.Size = new System.Drawing.Size(234, 23);
            this.prsbar_Cot.TabIndex = 9;
            // 
            // prsbar_Dong
            // 
            this.prsbar_Dong.Location = new System.Drawing.Point(34, 105);
            this.prsbar_Dong.Name = "prsbar_Dong";
            this.prsbar_Dong.Size = new System.Drawing.Size(132, 23);
            this.prsbar_Dong.TabIndex = 8;
            // 
            // cmb_SoO
            // 
            this.cmb_SoO.FormattingEnabled = true;
            this.cmb_SoO.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmb_SoO.Location = new System.Drawing.Point(34, 52);
            this.cmb_SoO.Name = "cmb_SoO";
            this.cmb_SoO.Size = new System.Drawing.Size(132, 21);
            this.cmb_SoO.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số ô bàn cờ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1208, 664);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_BanCo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.ProgressBar prsbar_Cot;
        private System.Windows.Forms.ProgressBar prsbar_Dong;
        private System.Windows.Forms.ComboBox cmb_SoO;
        private System.Windows.Forms.Label label1;
    }
}

