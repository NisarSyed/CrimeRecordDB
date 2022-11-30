namespace CrimeRecordDB
{
    partial class Form7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.criminalcnictb = new System.Windows.Forms.TextBox();
            this.casenumtb = new System.Windows.Forms.TextBox();
            this.crimnametb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CNICtb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.criminalGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.criminalcnictb);
            this.groupBox1.Controls.Add(this.casenumtb);
            this.groupBox1.Controls.Add(this.crimnametb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CNICtb);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // criminalcnictb
            // 
            this.criminalcnictb.Location = new System.Drawing.Point(107, 19);
            this.criminalcnictb.Name = "criminalcnictb";
            this.criminalcnictb.Size = new System.Drawing.Size(237, 20);
            this.criminalcnictb.TabIndex = 1;
            this.criminalcnictb.TextChanged += new System.EventHandler(this.criminalcnictb_TextChanged);
            // 
            // casenumtb
            // 
            this.casenumtb.Location = new System.Drawing.Point(107, 114);
            this.casenumtb.Name = "casenumtb";
            this.casenumtb.Size = new System.Drawing.Size(237, 20);
            this.casenumtb.TabIndex = 1;
            this.casenumtb.TextChanged += new System.EventHandler(this.casenumtb_TextChanged);
            // 
            // crimnametb
            // 
            this.crimnametb.Location = new System.Drawing.Point(107, 70);
            this.crimnametb.Name = "crimnametb";
            this.crimnametb.Size = new System.Drawing.Size(237, 20);
            this.crimnametb.TabIndex = 1;
            this.crimnametb.TextChanged += new System.EventHandler(this.crimnametb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Case Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // CNICtb
            // 
            this.CNICtb.AutoSize = true;
            this.CNICtb.Location = new System.Drawing.Point(18, 26);
            this.CNICtb.Name = "CNICtb";
            this.CNICtb.Size = new System.Drawing.Size(32, 13);
            this.CNICtb.TabIndex = 0;
            this.CNICtb.Text = "CNIC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.criminalGrid);
            this.groupBox2.Location = new System.Drawing.Point(27, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // criminalGrid
            // 
            this.criminalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminalGrid.Location = new System.Drawing.Point(6, 19);
            this.criminalGrid.Name = "criminalGrid";
            this.criminalGrid.Size = new System.Drawing.Size(613, 131);
            this.criminalGrid.TabIndex = 0;
            this.criminalGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.criminalGrid_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Criminal Search";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.criminalGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox criminalcnictb;
        private System.Windows.Forms.TextBox casenumtb;
        private System.Windows.Forms.TextBox crimnametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CNICtb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView criminalGrid;
        private System.Windows.Forms.Button button2;
    }
}