namespace APS2020.Views
{
    partial class MensagemServidor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lklVoltar = new System.Windows.Forms.LinkLabel();
            this.txtEnviado = new System.Windows.Forms.TextBox();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conectado como Servidor";
            // 
            // lklVoltar
            // 
            this.lklVoltar.AutoSize = true;
            this.lklVoltar.Location = new System.Drawing.Point(12, 17);
            this.lklVoltar.Name = "lklVoltar";
            this.lklVoltar.Size = new System.Drawing.Size(37, 15);
            this.lklVoltar.TabIndex = 1;
            this.lklVoltar.TabStop = true;
            this.lklVoltar.Text = "Voltar";
            this.lklVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklVoltar_LinkClicked);
            // 
            // txtEnviado
            // 
            this.txtEnviado.Location = new System.Drawing.Point(12, 75);
            this.txtEnviado.Multiline = true;
            this.txtEnviado.Name = "txtEnviado";
            this.txtEnviado.Size = new System.Drawing.Size(396, 60);
            this.txtEnviado.TabIndex = 2;
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnviar.Location = new System.Drawing.Point(12, 52);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(147, 20);
            this.lblEnviar.TabIndex = 3;
            this.lblEnviar.Text = "Enviar informações:";
            // 
            // txtRecebido
            // 
            this.txtRecebido.Location = new System.Drawing.Point(12, 219);
            this.txtRecebido.Multiline = true;
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(396, 176);
            this.txtRecebido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recebido dos Clientes:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(333, 141);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 36);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTerminar.Location = new System.Drawing.Point(120, 421);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(163, 39);
            this.btnTerminar.TabIndex = 7;
            this.btnTerminar.Text = "Terminar Transmissão";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // MensagemServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 472);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecebido);
            this.Controls.Add(this.lblEnviar);
            this.Controls.Add(this.txtEnviado);
            this.Controls.Add(this.lklVoltar);
            this.Controls.Add(this.label1);
            this.Name = "MensagemServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklVoltar;
        private System.Windows.Forms.TextBox txtEnviado;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnTerminar;
    }
}