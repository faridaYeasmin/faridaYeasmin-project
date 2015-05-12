namespace StudentYearlyCostCalculatorApp
{
    partial class YearlyCostCalculatorUI
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
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.classesComboBox);
            this.groupBox1.Controls.Add(this.discountCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator for yearly cost of a student";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate total amount for one year";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.totalAmountCalculateButton_Click);
            // 
            // classesComboBox
            // 
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(120, 45);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(185, 23);
            this.classesComboBox.TabIndex = 4;
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountCheckBox.Location = new System.Drawing.Point(120, 84);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(221, 19);
            this.discountCheckBox.TabIndex = 2;
            this.discountCheckBox.Text = "Get 5% discount for early admission";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Class : ";
            // 
            // YearlyCostCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(426, 301);
            this.Controls.Add(this.groupBox1);
            this.Name = "YearlyCostCalculatorUI";
            this.Text = "Yearly Cost Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.Button button1;
    }
}

