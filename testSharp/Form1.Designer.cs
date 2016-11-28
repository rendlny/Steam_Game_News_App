namespace testSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGameId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewsBox = new System.Windows.Forms.TextBox();
            this.labelPageNum = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelNewsTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGameId
            // 
            this.txtGameId.Location = new System.Drawing.Point(59, 59);
            this.txtGameId.Name = "txtGameId";
            this.txtGameId.Size = new System.Drawing.Size(137, 20);
            this.txtGameId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Game ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewsBox
            // 
            this.txtNewsBox.Location = new System.Drawing.Point(263, 30);
            this.txtNewsBox.Multiline = true;
            this.txtNewsBox.Name = "txtNewsBox";
            this.txtNewsBox.Size = new System.Drawing.Size(334, 255);
            this.txtNewsBox.TabIndex = 3;
            // 
            // labelPageNum
            // 
            this.labelPageNum.AutoSize = true;
            this.labelPageNum.BackColor = System.Drawing.Color.Transparent;
            this.labelPageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelPageNum.ForeColor = System.Drawing.Color.White;
            this.labelPageNum.Location = new System.Drawing.Point(416, 310);
            this.labelPageNum.Name = "labelPageNum";
            this.labelPageNum.Size = new System.Drawing.Size(24, 15);
            this.labelPageNum.TabIndex = 4;
            this.labelPageNum.Text = "0/0";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(322, 299);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(71, 33);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(144)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(460, 299);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelNewsTitle
            // 
            this.labelNewsTitle.AutoSize = true;
            this.labelNewsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelNewsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelNewsTitle.ForeColor = System.Drawing.Color.White;
            this.labelNewsTitle.Location = new System.Drawing.Point(397, 9);
            this.labelNewsTitle.Name = "labelNewsTitle";
            this.labelNewsTitle.Size = new System.Drawing.Size(42, 15);
            this.labelNewsTitle.TabIndex = 12;
            this.labelNewsTitle.Text = "News";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Example Game ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(59, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "252490";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(121)))), ((int)(((byte)(144)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Get Latest News";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(59, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "https://steamdb.info/apps/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Get Game IDs Here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::testSharp.Properties.Resources.pixels;
            this.ClientSize = new System.Drawing.Size(634, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNewsTitle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.labelPageNum);
            this.Controls.Add(this.txtNewsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGameId);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Steam Game News";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewsBox;
        private System.Windows.Forms.Label labelPageNum;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelNewsTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

