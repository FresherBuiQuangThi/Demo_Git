namespace TH_WF_Tuan01_BuiQuangThi_2001140242
{
    partial class List
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
            this.panel_2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Ngang = new System.Windows.Forms.RadioButton();
            this.rdo_Doc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_List = new System.Windows.Forms.Panel();
            this.panel_2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_2
            // 
            this.panel_2.Controls.Add(this.groupBox1);
            this.panel_2.Controls.Add(this.button1);
            this.panel_2.Controls.Add(this.textBox1);
            this.panel_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_2.Location = new System.Drawing.Point(0, 0);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(546, 160);
            this.panel_2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Ngang);
            this.groupBox1.Controls.Add(this.rdo_Doc);
            this.groupBox1.Location = new System.Drawing.Point(136, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 79);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon";
            // 
            // rdo_Ngang
            // 
            this.rdo_Ngang.AutoSize = true;
            this.rdo_Ngang.Location = new System.Drawing.Point(17, 35);
            this.rdo_Ngang.Name = "rdo_Ngang";
            this.rdo_Ngang.Size = new System.Drawing.Size(57, 17);
            this.rdo_Ngang.TabIndex = 2;
            this.rdo_Ngang.TabStop = true;
            this.rdo_Ngang.Text = "Ngang";
            this.rdo_Ngang.UseVisualStyleBackColor = true;
            this.rdo_Ngang.CheckedChanged += new System.EventHandler(this.rdo_Ngang_CheckedChanged_1);
            // 
            // rdo_Doc
            // 
            this.rdo_Doc.AutoSize = true;
            this.rdo_Doc.Location = new System.Drawing.Point(141, 35);
            this.rdo_Doc.Name = "rdo_Doc";
            this.rdo_Doc.Size = new System.Drawing.Size(45, 17);
            this.rdo_Doc.TabIndex = 2;
            this.rdo_Doc.TabStop = true;
            this.rdo_Doc.Text = "Dọc";
            this.rdo_Doc.UseVisualStyleBackColor = true;
            this.rdo_Doc.CheckedChanged += new System.EventHandler(this.bdo_Doc_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 8;
            // 
            // panel_List
            // 
            this.panel_List.Location = new System.Drawing.Point(0, 160);
            this.panel_List.Name = "panel_List";
            this.panel_List.Size = new System.Drawing.Size(546, 362);
            this.panel_List.TabIndex = 9;
            this.panel_List.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_List_Paint);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 518);
            this.Controls.Add(this.panel_List);
            this.Controls.Add(this.panel_2);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Ngang;
        private System.Windows.Forms.RadioButton rdo_Doc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel_List;
    }
}