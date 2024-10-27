namespace PLoops
{
    partial class frmExercicio4
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatrícula = new System.Windows.Forms.Label();
            this.lblProdução = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratificação = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtProdução = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.btnCalcSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(80, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(131, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do funcionário";
            // 
            // lblMatrícula
            // 
            this.lblMatrícula.AutoSize = true;
            this.lblMatrícula.Location = new System.Drawing.Point(80, 100);
            this.lblMatrícula.Name = "lblMatrícula";
            this.lblMatrícula.Size = new System.Drawing.Size(61, 16);
            this.lblMatrícula.TabIndex = 1;
            this.lblMatrícula.Text = "Matrícula";
            // 
            // lblProdução
            // 
            this.lblProdução.AutoSize = true;
            this.lblProdução.Location = new System.Drawing.Point(80, 163);
            this.lblProdução.Name = "lblProdução";
            this.lblProdução.Size = new System.Drawing.Size(66, 16);
            this.lblProdução.TabIndex = 2;
            this.lblProdução.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(80, 222);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(50, 16);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário";
            // 
            // lblGratificação
            // 
            this.lblGratificação.AutoSize = true;
            this.lblGratificação.Location = new System.Drawing.Point(80, 283);
            this.lblGratificação.Name = "lblGratificação";
            this.lblGratificação.Size = new System.Drawing.Size(84, 16);
            this.lblGratificação.TabIndex = 4;
            this.lblGratificação.Text = "Gradificação";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(264, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(264, 94);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(319, 22);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtProdução
            // 
            this.txtProdução.Location = new System.Drawing.Point(264, 157);
            this.txtProdução.Name = "txtProdução";
            this.txtProdução.Size = new System.Drawing.Size(319, 22);
            this.txtProdução.TabIndex = 7;
            this.txtProdução.Validating += new System.ComponentModel.CancelEventHandler(this.txtProdução_Validating);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(264, 216);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(319, 22);
            this.txtSalario.TabIndex = 8;
            this.txtSalario.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalario_Validating);
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(264, 277);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(319, 22);
            this.txtGratificacao.TabIndex = 9;
            this.txtGratificacao.Validating += new System.ComponentModel.CancelEventHandler(this.txtGratificacao_Validating);
            // 
            // btnCalcSalario
            // 
            this.btnCalcSalario.Location = new System.Drawing.Point(208, 349);
            this.btnCalcSalario.Name = "btnCalcSalario";
            this.btnCalcSalario.Size = new System.Drawing.Size(138, 67);
            this.btnCalcSalario.TabIndex = 10;
            this.btnCalcSalario.Text = "Calcular salário bruto";
            this.btnCalcSalario.UseVisualStyleBackColor = true;
            this.btnCalcSalario.Click += new System.EventHandler(this.btnCalcSalario_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcSalario);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtProdução);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGratificação);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProdução);
            this.Controls.Add(this.lblMatrícula);
            this.Controls.Add(this.lblNome);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatrícula;
        private System.Windows.Forms.Label lblProdução;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratificação;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtProdução;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.Button btnCalcSalario;
    }
}