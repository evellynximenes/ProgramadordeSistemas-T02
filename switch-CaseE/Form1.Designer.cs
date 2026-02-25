namespace switch_CaseE
{
    partial class frmSwitch
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.txtCodigoInserido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Gray;
            this.lblTitulo.Controls.Add(this.btnEnviar);
            this.lblTitulo.Controls.Add(this.lbldescricao);
            this.lblTitulo.Controls.Add(this.txtCodigoInserido);
            this.lblTitulo.Controls.Add(this.label1);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(705, 607);
            this.lblTitulo.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnEnviar.ForeColor = System.Drawing.Color.Moccasin;
            this.btnEnviar.Location = new System.Drawing.Point(307, 236);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 50);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEnviar_MouseClick);
            // 
            // lbldescricao
            // 
            this.lbldescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldescricao.Location = new System.Drawing.Point(266, 179);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(185, 32);
            this.lbldescricao.TabIndex = 2;
            this.lbldescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoInserido
            // 
            this.txtCodigoInserido.BackColor = System.Drawing.Color.Moccasin;
            this.txtCodigoInserido.Location = new System.Drawing.Point(307, 115);
            this.txtCodigoInserido.Name = "txtCodigoInserido";
            this.txtCodigoInserido.Size = new System.Drawing.Size(106, 33);
            this.txtCodigoInserido.TabIndex = 1;
            this.txtCodigoInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(229, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o código de 1 a 6";
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 607);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmSwitch";
            this.Text = "Condicional Switch";
            this.lblTitulo.ResumeLayout(false);
            this.lblTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.TextBox txtCodigoInserido;
        private System.Windows.Forms.Button btnEnviar;
    }
}

