
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tSRC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(348, 56);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(483, 173);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scan :";
            // 
            // tSRC
            // 
            this.tSRC.Location = new System.Drawing.Point(68, 59);
            this.tSRC.MaxLength = 10;
            this.tSRC.Name = "tSRC";
            this.tSRC.Size = new System.Drawing.Size(274, 20);
            this.tSRC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Virus Scan tool";
            // 
            // btnScan
            // 
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(429, 56);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 273);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tSRC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tSRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog fDialog;
        private System.Windows.Forms.Button btnScan;
    }

