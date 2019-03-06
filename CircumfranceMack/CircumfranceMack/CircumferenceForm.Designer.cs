namespace CircumfranceMack
{
    partial class frmCircumference
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(0, 12);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(173, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Enter the radius of the circle(in cm):";
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.Location = new System.Drawing.Point(-3, 156);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(109, 13);
            this.lblCircumference.TabIndex = 1;
            this.lblCircumference.Text = "The circumference is:";
            this.lblCircumference.Click += new System.EventHandler(this.lblCircumference_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(192, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(98, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(189, 156);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "label1";
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmCircumference";
            this.Text = "Circumfrence";
            this.Load += new System.EventHandler(this.CircumfranceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAnswer;
    }
}

