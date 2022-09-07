namespace S2_POE_Part_1
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
            this.Map = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gameLog = new System.Windows.Forms.TextBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.Backward = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(25, 272);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(92, 94);
            this.Map.TabIndex = 60;
            this.Map.Text = "Map";
            this.Map.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Stats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameLog
            // 
            this.gameLog.Location = new System.Drawing.Point(12, 94);
            this.gameLog.Multiline = true;
            this.gameLog.Name = "gameLog";
            this.gameLog.Size = new System.Drawing.Size(122, 161);
            this.gameLog.TabIndex = 62;
            this.gameLog.TextChanged += new System.EventHandler(this.gameLog_TextChanged);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(370, 665);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 51);
            this.leftButton.TabIndex = 63;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(451, 632);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(75, 53);
            this.Forward.TabIndex = 64;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(532, 665);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 51);
            this.rightButton.TabIndex = 65;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // Backward
            // 
            this.Backward.Location = new System.Drawing.Point(451, 691);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(75, 52);
            this.Backward.TabIndex = 66;
            this.Backward.Text = "Backward";
            this.Backward.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(798, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 68;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(798, 164);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(153, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.gameLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Map);
            this.Name = "Form1";
            this.Text = "Part 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gameLog;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

