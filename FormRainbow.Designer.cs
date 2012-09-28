namespace RainbowApp
{
    partial class FormRainbow
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
            this.bttnAlphabetise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnDisplayUnsorted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnAlphabetise
            // 
            this.bttnAlphabetise.Location = new System.Drawing.Point(26, 141);
            this.bttnAlphabetise.Name = "bttnAlphabetise";
            this.bttnAlphabetise.Size = new System.Drawing.Size(124, 46);
            this.bttnAlphabetise.TabIndex = 0;
            this.bttnAlphabetise.Text = "Alphabetise";
            this.bttnAlphabetise.UseVisualStyleBackColor = true;
            this.bttnAlphabetise.Click += new System.EventHandler(this.bttnAlphabetise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colours of the Rainbow:\r\n\r\nR=Red O=orange Y=Yellow G=Green\r\nB=Blue I=Indigo V=Vio" +
                "let";
            // 
            // bttnDisplayUnsorted
            // 
            this.bttnDisplayUnsorted.Location = new System.Drawing.Point(156, 141);
            this.bttnDisplayUnsorted.Name = "bttnDisplayUnsorted";
            this.bttnDisplayUnsorted.Size = new System.Drawing.Size(124, 46);
            this.bttnDisplayUnsorted.TabIndex = 2;
            this.bttnDisplayUnsorted.Text = "Display UnSorted";
            this.bttnDisplayUnsorted.UseVisualStyleBackColor = true;
            this.bttnDisplayUnsorted.Click += new System.EventHandler(this.bttnDisplayUnsorted_Click);
            // 
            // FormRainbow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 307);
            this.Controls.Add(this.bttnDisplayUnsorted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnAlphabetise);
            this.Name = "FormRainbow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colours of the Rainbow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAlphabetise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnDisplayUnsorted;
    }
}

