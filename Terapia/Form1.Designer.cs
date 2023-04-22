namespace Terapia
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.terapeutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerAgendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasAgendadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terapeutasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.agendamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // terapeutasToolStripMenuItem
            // 
            this.terapeutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.atualizarCadastroToolStripMenuItem});
            this.terapeutasToolStripMenuItem.Name = "terapeutasToolStripMenuItem";
            this.terapeutasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.terapeutasToolStripMenuItem.Text = "Terapeutas";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPacienteToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // cadastrarPacienteToolStripMenuItem
            // 
            this.cadastrarPacienteToolStripMenuItem.Name = "cadastrarPacienteToolStripMenuItem";
            this.cadastrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarPacienteToolStripMenuItem.Text = "Cadastrar Paciente";
            this.cadastrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPacienteToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerAgendamentoToolStripMenuItem,
            this.consultasAgendadasToolStripMenuItem});
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // fazerAgendamentoToolStripMenuItem
            // 
            this.fazerAgendamentoToolStripMenuItem.Name = "fazerAgendamentoToolStripMenuItem";
            this.fazerAgendamentoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fazerAgendamentoToolStripMenuItem.Text = "Fazer Agendamento";
            // 
            // consultasAgendadasToolStripMenuItem
            // 
            this.consultasAgendadasToolStripMenuItem.Name = "consultasAgendadasToolStripMenuItem";
            this.consultasAgendadasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.consultasAgendadasToolStripMenuItem.Text = "Consultas Agendadas";
            // 
            // atualizarCadastroToolStripMenuItem
            // 
            this.atualizarCadastroToolStripMenuItem.Name = "atualizarCadastroToolStripMenuItem";
            this.atualizarCadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarCadastroToolStripMenuItem.Text = "Atualizar Cadastro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 265);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema Terapia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terapeutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerAgendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasAgendadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarCadastroToolStripMenuItem;
    }
}

