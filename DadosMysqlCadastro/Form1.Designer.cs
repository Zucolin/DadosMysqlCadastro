namespace DadosMysqlCadastro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelnome = new System.Windows.Forms.Label();
            this.textnome = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.senhalabel = new System.Windows.Forms.Label();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.botao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbusca = new System.Windows.Forms.TextBox();
            this.listusuario = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuexcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.buscarbotao = new System.Windows.Forms.Button();
            this.botaonovo = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(28, 24);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(47, 16);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "Nome:";
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(27, 55);
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(405, 22);
            this.textnome.TabIndex = 1;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(28, 121);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(44, 16);
            this.emaillabel.TabIndex = 2;
            this.emaillabel.Text = "Email:";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(27, 165);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(405, 22);
            this.textemail.TabIndex = 3;
            // 
            // senhalabel
            // 
            this.senhalabel.AutoSize = true;
            this.senhalabel.Location = new System.Drawing.Point(28, 240);
            this.senhalabel.Name = "senhalabel";
            this.senhalabel.Size = new System.Drawing.Size(49, 16);
            this.senhalabel.TabIndex = 4;
            this.senhalabel.Text = "Senha:";
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(27, 284);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(405, 22);
            this.textsenha.TabIndex = 5;
            // 
            // botao
            // 
            this.botao.BackColor = System.Drawing.Color.YellowGreen;
            this.botao.Location = new System.Drawing.Point(98, 342);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(250, 46);
            this.botao.TabIndex = 6;
            this.botao.Text = "Enviar";
            this.botao.UseVisualStyleBackColor = false;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Usuario:";
            // 
            // textbusca
            // 
            this.textbusca.Location = new System.Drawing.Point(472, 75);
            this.textbusca.Name = "textbusca";
            this.textbusca.Size = new System.Drawing.Size(405, 22);
            this.textbusca.TabIndex = 8;
            // 
            // listusuario
            // 
            this.listusuario.ContextMenuStrip = this.contextMenuStrip1;
            this.listusuario.HideSelection = false;
            this.listusuario.Location = new System.Drawing.Point(454, 121);
            this.listusuario.MultiSelect = false;
            this.listusuario.Name = "listusuario";
            this.listusuario.Size = new System.Drawing.Size(629, 524);
            this.listusuario.TabIndex = 9;
            this.listusuario.UseCompatibleStateImageBehavior = false;
            this.listusuario.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listusuario_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuexcluir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 28);
            // 
            // menuexcluir
            // 
            this.menuexcluir.Name = "menuexcluir";
            this.menuexcluir.Size = new System.Drawing.Size(175, 24);
            this.menuexcluir.Text = "Excluir Usuario";
            this.menuexcluir.Click += new System.EventHandler(this.menuexcluir_Click_1);
            // 
            // buscarbotao
            // 
            this.buscarbotao.BackColor = System.Drawing.Color.YellowGreen;
            this.buscarbotao.Location = new System.Drawing.Point(938, 69);
            this.buscarbotao.Name = "buscarbotao";
            this.buscarbotao.Size = new System.Drawing.Size(101, 34);
            this.buscarbotao.TabIndex = 10;
            this.buscarbotao.Text = "Buscar";
            this.buscarbotao.UseVisualStyleBackColor = false;
            this.buscarbotao.Click += new System.EventHandler(this.buscarbotao_Click);
            // 
            // botaonovo
            // 
            this.botaonovo.BackColor = System.Drawing.Color.YellowGreen;
            this.botaonovo.Location = new System.Drawing.Point(98, 422);
            this.botaonovo.Name = "botaonovo";
            this.botaonovo.Size = new System.Drawing.Size(250, 46);
            this.botaonovo.TabIndex = 11;
            this.botaonovo.Text = "Novo";
            this.botaonovo.UseVisualStyleBackColor = false;
            this.botaonovo.Click += new System.EventHandler(this.botaonovo_Click);
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.botaoexcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botaoexcluir.Location = new System.Drawing.Point(98, 500);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(250, 46);
            this.botaoexcluir.TabIndex = 12;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = false;
            this.botaoexcluir.Click += new System.EventHandler(this.botaoexcluir_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 657);
            this.Controls.Add(this.botaoexcluir);
            this.Controls.Add(this.botaonovo);
            this.Controls.Add(this.buscarbotao);
            this.Controls.Add(this.listusuario);
            this.Controls.Add(this.textbusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.senhalabel);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.textnome);
            this.Controls.Add(this.labelnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label senhalabel;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbusca;
        private System.Windows.Forms.ListView listusuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button buscarbotao;
        private System.Windows.Forms.Button botaonovo;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuexcluir;
    }
}

