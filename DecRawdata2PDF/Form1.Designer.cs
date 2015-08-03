namespace DecRawdata2PDF
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
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.rawdataReversal = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonPA0 = new System.Windows.Forms.RadioButton();
            this.radioButtonPA1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPA2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPA3 = new System.Windows.Forms.RadioButton();
            this.radioButtonPA4 = new System.Windows.Forms.RadioButton();
            this.radioButtonLA4 = new System.Windows.Forms.RadioButton();
            this.radioButtonLA3 = new System.Windows.Forms.RadioButton();
            this.radioButtonLA2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLA1 = new System.Windows.Forms.RadioButton();
            this.radioButtonLA0 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rawdata File Path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(137, 26);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(211, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(370, 24);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(179, 166);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(87, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "GeneratePDF";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // rawdataReversal
            // 
            this.rawdataReversal.AutoSize = true;
            this.rawdataReversal.Location = new System.Drawing.Point(36, 60);
            this.rawdataReversal.Name = "rawdataReversal";
            this.rawdataReversal.Size = new System.Drawing.Size(117, 17);
            this.rawdataReversal.TabIndex = 4;
            this.rawdataReversal.Text = "Reverse Raw Data";
            this.rawdataReversal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Page Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Portrait:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Landscape:";
            // 
            // radioButtonPA0
            // 
            this.radioButtonPA0.AutoSize = true;
            this.radioButtonPA0.Location = new System.Drawing.Point(113, 102);
            this.radioButtonPA0.Name = "radioButtonPA0";
            this.radioButtonPA0.Size = new System.Drawing.Size(38, 17);
            this.radioButtonPA0.TabIndex = 8;
            this.radioButtonPA0.Text = "A0";
            this.radioButtonPA0.UseVisualStyleBackColor = true;
            this.radioButtonPA0.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPA1
            // 
            this.radioButtonPA1.AutoSize = true;
            this.radioButtonPA1.Location = new System.Drawing.Point(157, 102);
            this.radioButtonPA1.Name = "radioButtonPA1";
            this.radioButtonPA1.Size = new System.Drawing.Size(38, 17);
            this.radioButtonPA1.TabIndex = 9;
            this.radioButtonPA1.Text = "A1";
            this.radioButtonPA1.UseVisualStyleBackColor = true;
            this.radioButtonPA1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPA2
            // 
            this.radioButtonPA2.AutoSize = true;
            this.radioButtonPA2.Location = new System.Drawing.Point(201, 102);
            this.radioButtonPA2.Name = "radioButtonPA2";
            this.radioButtonPA2.Size = new System.Drawing.Size(38, 17);
            this.radioButtonPA2.TabIndex = 10;
            this.radioButtonPA2.Text = "A2";
            this.radioButtonPA2.UseVisualStyleBackColor = true;
            this.radioButtonPA2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPA3
            // 
            this.radioButtonPA3.AutoSize = true;
            this.radioButtonPA3.Location = new System.Drawing.Point(245, 102);
            this.radioButtonPA3.Name = "radioButtonPA3";
            this.radioButtonPA3.Size = new System.Drawing.Size(38, 17);
            this.radioButtonPA3.TabIndex = 11;
            this.radioButtonPA3.Text = "A3";
            this.radioButtonPA3.UseVisualStyleBackColor = true;
            this.radioButtonPA3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPA4
            // 
            this.radioButtonPA4.AutoSize = true;
            this.radioButtonPA4.Checked = true;
            this.radioButtonPA4.Location = new System.Drawing.Point(289, 102);
            this.radioButtonPA4.Name = "radioButtonPA4";
            this.radioButtonPA4.Size = new System.Drawing.Size(38, 17);
            this.radioButtonPA4.TabIndex = 12;
            this.radioButtonPA4.TabStop = true;
            this.radioButtonPA4.Text = "A4";
            this.radioButtonPA4.UseVisualStyleBackColor = true;
            this.radioButtonPA4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLA4
            // 
            this.radioButtonLA4.AutoSize = true;
            this.radioButtonLA4.Location = new System.Drawing.Point(289, 121);
            this.radioButtonLA4.Name = "radioButtonLA4";
            this.radioButtonLA4.Size = new System.Drawing.Size(38, 17);
            this.radioButtonLA4.TabIndex = 17;
            this.radioButtonLA4.Text = "A4";
            this.radioButtonLA4.UseVisualStyleBackColor = true;
            this.radioButtonLA4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLA3
            // 
            this.radioButtonLA3.AutoSize = true;
            this.radioButtonLA3.Location = new System.Drawing.Point(245, 121);
            this.radioButtonLA3.Name = "radioButtonLA3";
            this.radioButtonLA3.Size = new System.Drawing.Size(38, 17);
            this.radioButtonLA3.TabIndex = 16;
            this.radioButtonLA3.Text = "A3";
            this.radioButtonLA3.UseVisualStyleBackColor = true;
            this.radioButtonLA3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLA2
            // 
            this.radioButtonLA2.AutoSize = true;
            this.radioButtonLA2.Location = new System.Drawing.Point(201, 121);
            this.radioButtonLA2.Name = "radioButtonLA2";
            this.radioButtonLA2.Size = new System.Drawing.Size(38, 17);
            this.radioButtonLA2.TabIndex = 15;
            this.radioButtonLA2.Text = "A2";
            this.radioButtonLA2.UseVisualStyleBackColor = true;
            this.radioButtonLA2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLA1
            // 
            this.radioButtonLA1.AutoSize = true;
            this.radioButtonLA1.Location = new System.Drawing.Point(157, 121);
            this.radioButtonLA1.Name = "radioButtonLA1";
            this.radioButtonLA1.Size = new System.Drawing.Size(38, 17);
            this.radioButtonLA1.TabIndex = 14;
            this.radioButtonLA1.Text = "A1";
            this.radioButtonLA1.UseVisualStyleBackColor = true;
            this.radioButtonLA1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLA0
            // 
            this.radioButtonLA0.AutoSize = true;
            this.radioButtonLA0.Location = new System.Drawing.Point(113, 121);
            this.radioButtonLA0.Name = "radioButtonLA0";
            this.radioButtonLA0.Size = new System.Drawing.Size(38, 17);
            this.radioButtonLA0.TabIndex = 13;
            this.radioButtonLA0.Text = "A0";
            this.radioButtonLA0.UseVisualStyleBackColor = true;
            this.radioButtonLA0.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 201);
            this.Controls.Add(this.radioButtonLA4);
            this.Controls.Add(this.radioButtonLA3);
            this.Controls.Add(this.radioButtonLA2);
            this.Controls.Add(this.radioButtonLA1);
            this.Controls.Add(this.radioButtonLA0);
            this.Controls.Add(this.radioButtonPA4);
            this.Controls.Add(this.radioButtonPA3);
            this.Controls.Add(this.radioButtonPA2);
            this.Controls.Add(this.radioButtonPA1);
            this.Controls.Add(this.radioButtonPA0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rawdataReversal);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Tools Make Good Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox rawdataReversal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonPA0;
        private System.Windows.Forms.RadioButton radioButtonPA1;
        private System.Windows.Forms.RadioButton radioButtonPA2;
        private System.Windows.Forms.RadioButton radioButtonPA3;
        private System.Windows.Forms.RadioButton radioButtonPA4;
        private System.Windows.Forms.RadioButton radioButtonLA4;
        private System.Windows.Forms.RadioButton radioButtonLA3;
        private System.Windows.Forms.RadioButton radioButtonLA2;
        private System.Windows.Forms.RadioButton radioButtonLA1;
        private System.Windows.Forms.RadioButton radioButtonLA0;
    }
}

