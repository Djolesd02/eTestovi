namespace eTestovi
{
    partial class Profesor_view
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesor_view));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poeniBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.poeniDataSet1 = new eTestovi.PoeniDataSet1();
            this.poeniDataSet = new eTestovi.PoeniDataSet();
            this.poeniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poeniTableAdapter = new eTestovi.PoeniDataSetTableAdapters.PoeniTableAdapter();
            this.poeniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poeniTableAdapter1 = new eTestovi.PoeniDataSet1TableAdapters.PoeniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(660, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(660, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nazad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 308);
            this.dataGridView1.TabIndex = 2;
            // 
            // poeniBindingSource2
            // 
            this.poeniBindingSource2.DataMember = "Poeni";
            this.poeniBindingSource2.DataSource = this.poeniDataSet1;
            // 
            // poeniDataSet1
            // 
            this.poeniDataSet1.DataSetName = "PoeniDataSet1";
            this.poeniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poeniDataSet
            // 
            this.poeniDataSet.DataSetName = "PoeniDataSet";
            this.poeniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poeniBindingSource
            // 
            this.poeniBindingSource.DataMember = "Poeni";
            this.poeniBindingSource.DataSource = this.poeniDataSet;
            // 
            // poeniTableAdapter
            // 
            this.poeniTableAdapter.ClearBeforeFill = true;
            // 
            // poeniBindingSource1
            // 
            this.poeniBindingSource1.DataMember = "Poeni";
            this.poeniBindingSource1.DataSource = this.poeniDataSet;
            // 
            // poeniTableAdapter1
            // 
            this.poeniTableAdapter1.ClearBeforeFill = true;
            // 
            // Profesor_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Profesor_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor_view";
            this.Load += new System.EventHandler(this.Profesor_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poeniBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoeniDataSet poeniDataSet;
        private System.Windows.Forms.BindingSource poeniBindingSource;
        private PoeniDataSetTableAdapters.PoeniTableAdapter poeniTableAdapter;
        private System.Windows.Forms.BindingSource poeniBindingSource1;
        private PoeniDataSet1 poeniDataSet1;
        private System.Windows.Forms.BindingSource poeniBindingSource2;
        private PoeniDataSet1TableAdapters.PoeniTableAdapter poeniTableAdapter1;
    }
}