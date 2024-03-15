namespace JogoDaMemoria
{
    partial class FormSelecao
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rbLetras = new System.Windows.Forms.RadioButton();
            this.rbNumeros = new System.Windows.Forms.RadioButton();
            this.rbCores = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 13);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(138, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Selecione o tipo das cartas:";
            // 
            // rbLetras
            // 
            this.rbLetras.AutoSize = true;
            this.rbLetras.Checked = true;
            this.rbLetras.Location = new System.Drawing.Point(12, 40);
            this.rbLetras.Name = "rbLetras";
            this.rbLetras.Size = new System.Drawing.Size(54, 17);
            this.rbLetras.TabIndex = 1;
            this.rbLetras.TabStop = true;
            this.rbLetras.Text = "Letras";
            this.rbLetras.UseVisualStyleBackColor = true;
            // 
            // rbNumeros
            // 
            this.rbNumeros.AutoSize = true;
            this.rbNumeros.Location = new System.Drawing.Point(12, 86);
            this.rbNumeros.Name = "rbNumeros";
            this.rbNumeros.Size = new System.Drawing.Size(67, 17);
            this.rbNumeros.TabIndex = 2;
            this.rbNumeros.TabStop = true;
            this.rbNumeros.Text = "Números";
            this.rbNumeros.UseVisualStyleBackColor = true;
            // 
            // rbCores
            // 
            this.rbCores.AutoSize = true;
            this.rbCores.Location = new System.Drawing.Point(12, 63);
            this.rbCores.Name = "rbCores";
            this.rbCores.Size = new System.Drawing.Size(52, 17);
            this.rbCores.TabIndex = 3;
            this.rbCores.TabStop = true;
            this.rbCores.Text = "Cores";
            this.rbCores.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(119, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(209, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 163);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rbCores);
            this.Controls.Add(this.rbNumeros);
            this.Controls.Add(this.rbLetras);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSelecao";
            this.Text = "FormSelecao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.RadioButton rbLetras;
        private System.Windows.Forms.RadioButton rbNumeros;
        private System.Windows.Forms.RadioButton rbCores;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
    }
}