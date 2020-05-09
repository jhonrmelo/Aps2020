namespace APS2020.Views
{
    partial class MensagemCliente
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
            this.txtEnviado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.lblRecebido = new System.Windows.Forms.Label();
            this.lklVoltar = new System.Windows.Forms.LinkLabel();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnviado
            // 
            this.txtEnviado.Location = new System.Drawing.Point(12, 131);
            this.txtEnviado.Multiline = true;
            this.txtEnviado.Name = "txtEnviado";
            this.txtEnviado.Size = new System.Drawing.Size(396, 64);
            this.txtEnviado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conectado como Cliente";
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnviar.Location = new System.Drawing.Point(12, 108);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(147, 20);
            this.lblEnviar.TabIndex = 2;
            this.lblEnviar.Text = "Enviar informações:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(333, 201);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 34);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtRecebido
            // 
            this.txtRecebido.Location = new System.Drawing.Point(12, 269);
            this.txtRecebido.Multiline = true;
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(396, 227);
            this.txtRecebido.TabIndex = 4;
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecebido.Location = new System.Drawing.Point(12, 246);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(163, 20);
            this.lblRecebido.TabIndex = 2;
            this.lblRecebido.Text = "Recebido do Servidor:";
            // 
            // lklVoltar
            // 
            this.lklVoltar.AutoSize = true;
            this.lklVoltar.Location = new System.Drawing.Point(12, 17);
            this.lklVoltar.Name = "lklVoltar";
            this.lklVoltar.Size = new System.Drawing.Size(37, 15);
            this.lklVoltar.TabIndex = 5;
            this.lklVoltar.TabStop = true;
            this.lklVoltar.Text = "Voltar";
            this.lklVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklVoltar_LinkClicked);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Firebrick;
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDesconectar.Location = new System.Drawing.Point(308, 61);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(100, 34);
            this.btnDesconectar.TabIndex = 6;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // MensagemCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 508);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lklVoltar);
            this.Controls.Add(this.lblRecebido);
            this.Controls.Add(this.txtRecebido);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblEnviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnviado);
            this.Name = "MensagemCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnviado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Label lblRecebido;
        private System.Windows.Forms.LinkLabel lklVoltar;
        private System.Windows.Forms.Button btnDesconectar;
    }
}