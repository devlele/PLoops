namespace PLoops
{
    partial class frmExercicio3
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
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Location = new System.Drawing.Point(200, 146);
            this.txtPalindromo.MaxLength = 50;
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(395, 22);
            this.txtPalindromo.TabIndex = 0;
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(334, 266);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(113, 47);
            this.btnPalindromo.TabIndex = 1;
            this.btnPalindromo.Text = "É palindromo?";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.txtPalindromo);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalindromo;
        private System.Windows.Forms.Button btnPalindromo;
    }
}