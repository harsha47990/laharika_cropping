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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_resize = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.Rename_btn = new System.Windows.Forms.Button();
            this.rename_txt = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.custombox = new System.Windows.Forms.TextBox();
            this.custombox2 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.studioName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 65);
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
            this.comboBox1.Location = new System.Drawing.Point(60, 154);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_resize
            // 
            this.btn_resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resize.Location = new System.Drawing.Point(18, 288);
            this.btn_resize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(219, 65);
            this.btn_resize.TabIndex = 2;
            this.btn_resize.Text = "RESIZE";
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBar1.Location = new System.Drawing.Point(34, 383);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(426, 37);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_pdf
            // 
            this.btn_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Location = new System.Drawing.Point(260, 288);
            this.btn_pdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(219, 65);
            this.btn_pdf.TabIndex = 4;
            this.btn_pdf.Text = "AUTOMATE";
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // Rename_btn
            // 
            this.Rename_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rename_btn.Location = new System.Drawing.Point(326, 74);
            this.Rename_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rename_btn.Name = "Rename_btn";
            this.Rename_btn.Size = new System.Drawing.Size(134, 45);
            this.Rename_btn.TabIndex = 6;
            this.Rename_btn.Text = "RENAME";
            this.Rename_btn.UseVisualStyleBackColor = true;
            this.Rename_btn.Click += new System.EventHandler(this.Rename_btn_Click);
            // 
            // rename_txt
            // 
            this.rename_txt.Location = new System.Drawing.Point(327, 132);
            this.rename_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rename_txt.Name = "rename_txt";
            this.rename_txt.Size = new System.Drawing.Size(127, 26);
            this.rename_txt.TabIndex = 7;
            this.rename_txt.Visible = false;
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Location = new System.Drawing.Point(327, 172);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(130, 32);
            this.ok_btn.TabIndex = 8;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Visible = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // custombox
            // 
            this.custombox.Location = new System.Drawing.Point(66, 195);
            this.custombox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custombox.Name = "custombox";
            this.custombox.Size = new System.Drawing.Size(68, 26);
            this.custombox.TabIndex = 9;
            // 
            // custombox2
            // 
            this.custombox2.Location = new System.Drawing.Point(180, 195);
            this.custombox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custombox2.Name = "custombox2";
            this.custombox2.Size = new System.Drawing.Size(68, 26);
            this.custombox2.TabIndex = 10;
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(146, 200);
            this.X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(30, 31);
            this.X.TabIndex = 12;
            this.X.Text = "X";
            // 
            // studioName
            // 
            this.studioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studioName.Location = new System.Drawing.Point(235, 236);
            this.studioName.Name = "studioName";
            this.studioName.Size = new System.Drawing.Size(219, 35);
            this.studioName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Studio Name :";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studioName);
            this.Controls.Add(this.X);
            this.Controls.Add(this.custombox2);
            this.Controls.Add(this.custombox);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.rename_txt);
            this.Controls.Add(this.Rename_btn);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button Rename_btn;
        private System.Windows.Forms.TextBox rename_txt;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox custombox;
        private System.Windows.Forms.TextBox custombox2;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox studioName;
        private System.Windows.Forms.Label label1;
    }
}