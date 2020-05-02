namespace APS2020.Views
{
    partial class MainMenu
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuItemMensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUsuarioCadatro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMensagem,
            this.menuItemUsuario});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(808, 43);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuBar";
            // 
            // menuItemMensagem
            // 
            this.menuItemMensagem.BackColor = System.Drawing.SystemColors.Menu;
            this.menuItemMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuItemMensagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuItemMensagem.ForeColor = System.Drawing.Color.Black;
            this.menuItemMensagem.Name = "menuItemMensagem";
            this.menuItemMensagem.Size = new System.Drawing.Size(89, 39);
            this.menuItemMensagem.Text = "Mensagens";
            // 
            // menuItemUsuario
            // 
            this.menuItemUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.menuItemUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUsuarioCadatro});
            this.menuItemUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuItemUsuario.Name = "menuItemUsuario";
            this.menuItemUsuario.Size = new System.Drawing.Size(73, 39);
            this.menuItemUsuario.Text = "Usuarios";
            // 
            // menuItemUsuarioCadatro
            // 
            this.menuItemUsuarioCadatro.Name = "menuItemUsuarioCadatro";
            this.menuItemUsuarioCadatro.Size = new System.Drawing.Size(130, 22);
            this.menuItemUsuarioCadatro.Text = "Cadastro";
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(808, 315);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemMensagem;
        private System.Windows.Forms.ToolStripMenuItem menuItemUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuItemUsuarioCadatro;
    }
}