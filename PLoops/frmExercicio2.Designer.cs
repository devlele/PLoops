namespace PLoops
{
    partial class frmExercicio2
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
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.btnNumeroH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(234, 170);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(293, 22);
            this.txtNumeroN.TabIndex = 0;
            this.txtNumeroN.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroN_Validating);
            // 
            // btnNumeroH
            // 
            this.btnNumeroH.Location = new System.Drawing.Point(314, 277);
            this.btnNumeroH.Name = "btnNumeroH";
            this.btnNumeroH.Size = new System.Drawing.Size(113, 23);
            this.btnNumeroH.TabIndex = 1;
            this.btnNumeroH.Text = "Gerar numero H";
            this.btnNumeroH.UseVisualStyleBackColor = true;
            this.btnNumeroH.Click += new System.EventHandler(this.btnNumeroH_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNumeroH);
            this.Controls.Add(this.txtNumeroN);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Button btnNumeroH;
    }
}