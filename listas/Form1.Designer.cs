
namespace listas
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
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.Idade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.Turma = new System.Windows.Forms.Label();
            this.txtNone = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lstDados = new System.Windows.Forms.ListBox();
            this.Listar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(20, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(23, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(23, 142);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(100, 20);
            this.txtTurma.TabIndex = 3;
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(20, 87);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(34, 13);
            this.Idade.TabIndex = 2;
            this.Idade.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(23, 103);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Location = new System.Drawing.Point(20, 126);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(37, 13);
            this.Turma.TabIndex = 4;
            this.Turma.Text = "Turma";
            // 
            // txtNone
            // 
            this.txtNone.Location = new System.Drawing.Point(23, 64);
            this.txtNone.Name = "txtNone";
            this.txtNone.Size = new System.Drawing.Size(100, 20);
            this.txtNone.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(20, 48);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(193, 61);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(122, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lstDados
            // 
            this.lstDados.FormattingEnabled = true;
            this.lstDados.Location = new System.Drawing.Point(96, 196);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(120, 160);
            this.lstDados.TabIndex = 9;
            // 
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(193, 90);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(122, 23);
            this.Listar.TabIndex = 10;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.btnLocalizar.Location = new System.Drawing.Point(193, 121);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(122, 23);
            this.btnLocalizar.TabIndex = 11;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 372);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.lstDados);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNone);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.Turma);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label Turma;
        private System.Windows.Forms.TextBox txtNone;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox lstDados;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.Button btnLocalizar;
    }
}

