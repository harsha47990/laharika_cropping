namespace laharika_2
{
    partial class main
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_resize = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Rename_btn = new System.Windows.Forms.Button();
            this.rename_txt = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.custombox = new System.Windows.Forms.TextBox();
            this.custombox2 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "OPEN FILES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12x36",
            "11x33",
            "custom"});
            this.comboBox1.Location = new System.Drawing.Point(40, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_resize
            // 
            this.btn_resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resize.Location = new System.Drawing.Point(12, 152);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(146, 42);
            this.btn_resize.TabIndex = 2;
            this.btn_resize.Text = "RESIZE";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar1.Location = new System.Drawing.Point(22, 256);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(284, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_pdf
            // 
            this.btn_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Location = new System.Drawing.Point(173, 152);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(146, 42);
            this.btn_pdf.TabIndex = 4;
            this.btn_pdf.Text = "AUTOMATE";
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(95, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "SETTING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rename_btn
            // 
            this.Rename_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rename_btn.Location = new System.Drawing.Point(217, 48);
            this.Rename_btn.Name = "Rename_btn";
            this.Rename_btn.Size = new System.Drawing.Size(89, 29);
            this.Rename_btn.TabIndex = 6;
            this.Rename_btn.Text = "RENAME";
            this.Rename_btn.UseVisualStyleBackColor = true;
            this.Rename_btn.Click += new System.EventHandler(this.Rename_btn_Click);
            // 
            // rename_txt
            // 
            this.rename_txt.Location = new System.Drawing.Point(218, 86);
            this.rename_txt.Name = "rename_txt";
            this.rename_txt.Size = new System.Drawing.Size(86, 20);
            this.rename_txt.TabIndex = 7;
            this.rename_txt.Visible = false;
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Location = new System.Drawing.Point(218, 112);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(87, 21);
            this.ok_btn.TabIndex = 8;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Visible = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // custombox
            // 
            this.custombox.Location = new System.Drawing.Point(44, 127);
            this.custombox.Name = "custombox";
            this.custombox.Size = new System.Drawing.Size(47, 20);
            this.custombox.TabIndex = 9;
            // 
            // custombox2
            // 
            this.custombox2.Location = new System.Drawing.Point(120, 127);
            this.custombox2.Name = "custombox2";
            this.custombox2.Size = new System.Drawing.Size(47, 20);
            this.custombox2.TabIndex = 10;
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(97, 130);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(20, 20);
            this.X.TabIndex = 12;
            this.X.Text = "X";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 316);
            this.Controls.Add(this.X);
            this.Controls.Add(this.custombox2);
            this.Controls.Add(this.custombox);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.rename_txt);
            this.Controls.Add(this.Rename_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_pdf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Rename_btn;
        private System.Windows.Forms.TextBox rename_txt;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox custombox;
        private System.Windows.Forms.TextBox custombox2;
        private System.Windows.Forms.Label X;
    }
}