namespace eTestovi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ucenik = new System.Windows.Forms.Button();
            this.Profesor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ucenik
            // 
            this.Ucenik.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ucenik.ForeColor = System.Drawing.Color.White;
            this.Ucenik.Location = new System.Drawing.Point(274, 257);
            this.Ucenik.Name = "Ucenik";
            this.Ucenik.Size = new System.Drawing.Size(162, 64);
            this.Ucenik.TabIndex = 1;
            this.Ucenik.Text = "Učenik";
            this.Ucenik.UseVisualStyleBackColor = false;
            this.Ucenik.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profesor
            // 
            this.Profesor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Profesor.ForeColor = System.Drawing.Color.White;
            this.Profesor.Location = new System.Drawing.Point(552, 257);
            this.Profesor.Name = "Profesor";
            this.Profesor.Size = new System.Drawing.Size(162, 64);
            this.Profesor.TabIndex = 2;
            this.Profesor.Text = "Profesor";
            this.Profesor.UseVisualStyleBackColor = false;
            this.Profesor.Click += new System.EventHandler(this.Profesor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(793, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Izlaz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 608);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Profesor);
            this.Controls.Add(this.Ucenik);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eTestovi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ucenik;
        private System.Windows.Forms.Button Profesor;
        private System.Windows.Forms.Button button2;
    }
}

