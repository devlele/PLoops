namespace PLoops
{
    partial class frmExercicio1
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnDuplas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(281, 94);
            this.rchtxtFrase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(477, 117);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(131, 337);
            this.btnBranco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(192, 76);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Espaços em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Location = new System.Drawing.Point(417, 337);
            this.btnLetraR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(192, 76);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Conta a quantidade de \"R\"";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnDuplas
            // 
            this.btnDuplas.Location = new System.Drawing.Point(729, 337);
            this.btnDuplas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuplas.Name = "btnDuplas";
            this.btnDuplas.Size = new System.Drawing.Size(192, 76);
            this.btnDuplas.TabIndex = 3;
            this.btnDuplas.Text = "Quantas letras duplas";
            this.btnDuplas.UseVisualStyleBackColor = true;
            this.btnDuplas.Click += new System.EventHandler(this.btnDuplas_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDuplas);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnDuplas;
    }
}