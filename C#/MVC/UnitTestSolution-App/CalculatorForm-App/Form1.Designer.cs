namespace CalculatorForm_App
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
            this.cubeBtn = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cubeBtn
            // 
            this.cubeBtn.Location = new System.Drawing.Point(245, 103);
            this.cubeBtn.Name = "cubeBtn";
            this.cubeBtn.Size = new System.Drawing.Size(75, 23);
            this.cubeBtn.TabIndex = 0;
            this.cubeBtn.Text = "Cube";
            this.cubeBtn.UseVisualStyleBackColor = true;
            this.cubeBtn.Click += new System.EventHandler(this.cubeBtn_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(92, 105);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(100, 20);
            this.inputTextbox.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(134, 184);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(43, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 378);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.cubeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cubeBtn;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label resultLabel;
    }
}

