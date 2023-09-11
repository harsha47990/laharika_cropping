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
            this.addfront_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.custombox = new System.Windows.Forms.TextBox();
            this.custombox2 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.studioName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addback_btn = new System.Windows.Forms.Button();
            this.fb_combo_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 54);
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
            this.comboBox1.Location = new System.Drawing.Point(30, 132);
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
            // addfront_btn
            // 
            this.addfront_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfront_btn.Location = new System.Drawing.Point(255, 101);
            this.addfront_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addfront_btn.Name = "addfront_btn";
            this.addfront_btn.Size = new System.Drawing.Size(104, 45);
            this.addfront_btn.TabIndex = 6;
            this.addfront_btn.Text = "Add Front";
            this.addfront_btn.UseVisualStyleBackColor = true;
            this.addfront_btn.Click += new System.EventHandler(this.addFront_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.Location = new System.Drawing.Point(296, 156);
            this.ok_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(130, 32);
            this.ok_btn.TabIndex = 8;
            this.ok_btn.Text = "SAVE";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // custombox
            // 
            this.custombox.Location = new System.Drawing.Point(42, 178);
            this.custombox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custombox.Name = "custombox";
            this.custombox.Size = new System.Drawing.Size(68, 26);
            this.custombox.TabIndex = 9;
            // 
            // custombox2
            // 
            this.custombox2.Location = new System.Drawing.Point(156, 178);
            this.custombox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custombox2.Name = "custombox2";
            this.custombox2.Size = new System.Drawing.Size(68, 26);
            this.custombox2.TabIndex = 10;
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(122, 183);
            this.X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(30, 31);
            this.X.TabIndex = 12;
            this.X.Text = "X";
            // 
            // studioName
            // 
            this.studioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studioName.Location = new System.Drawing.Point(235, 227);
            this.studioName.Name = "studioName";
            this.studioName.Size = new System.Drawing.Size(219, 35);
            this.studioName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Studio Name :";
            // 
            // addback_btn
            // 
            this.addback_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addback_btn.Location = new System.Drawing.Point(367, 101);
            this.addback_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addback_btn.Name = "addback_btn";
            this.addback_btn.Size = new System.Drawing.Size(103, 45);
            this.addback_btn.TabIndex = 16;
            this.addback_btn.Text = "Add Back";
            this.addback_btn.UseVisualStyleBackColor = true;
            this.addback_btn.Click += new System.EventHandler(this.addBack_btn_Click);
            // 
            // fb_combo_box
            // 
            this.fb_combo_box.FormattingEnabled = true;
            this.fb_combo_box.Items.AddRange(new object[] {
            "12X18",
            "12X36"});
            this.fb_combo_box.Location = new System.Drawing.Point(255, 54);
            this.fb_combo_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fb_combo_box.Name = "fb_combo_box";
            this.fb_combo_box.Size = new System.Drawing.Size(205, 28);
            this.fb_combo_box.TabIndex = 17;
            this.fb_combo_box.SelectedIndexChanged += new System.EventHandler(this.fb_combo_box_SelectedIndexChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.Controls.Add(this.fb_combo_box);
            this.Controls.Add(this.addback_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studioName);
            this.Controls.Add(this.X);
            this.Controls.Add(this.custombox2);
            this.Controls.Add(this.custombox);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.addfront_btn);
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
        private System.Windows.Forms.Button addfront_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox custombox;
        private System.Windows.Forms.TextBox custombox2;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.TextBox studioName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addback_btn;
        private System.Windows.Forms.ComboBox fb_combo_box;
    }
}