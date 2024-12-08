namespace atvcrud
{
    partial class cadastroAluno
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbFloresta = new System.Windows.Forms.RadioButton();
            this.rdbBarroca = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbSerie3 = new System.Windows.Forms.RadioButton();
            this.rdbSerie2 = new System.Windows.Forms.RadioButton();
            this.rdbSerie1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTurma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtgAlunos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(73, 411);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(79, 27);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(176, 411);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(76, 27);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(293, 411);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(76, 27);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(394, 411);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(76, 27);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(505, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 27);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(75, 16);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(51, 64);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(281, 20);
            this.txtnome.TabIndex = 8;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(52, 116);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(78, 20);
            this.txtidade.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Idade:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFloresta);
            this.panel1.Controls.Add(this.rdbBarroca);
            this.panel1.Location = new System.Drawing.Point(56, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 51);
            this.panel1.TabIndex = 11;
            // 
            // rdbFloresta
            // 
            this.rdbFloresta.AutoSize = true;
            this.rdbFloresta.Location = new System.Drawing.Point(143, 19);
            this.rdbFloresta.Name = "rdbFloresta";
            this.rdbFloresta.Size = new System.Drawing.Size(62, 17);
            this.rdbFloresta.TabIndex = 1;
            this.rdbFloresta.TabStop = true;
            this.rdbFloresta.Text = "Floresta";
            this.rdbFloresta.UseVisualStyleBackColor = true;
            // 
            // rdbBarroca
            // 
            this.rdbBarroca.AutoSize = true;
            this.rdbBarroca.Location = new System.Drawing.Point(15, 19);
            this.rdbBarroca.Name = "rdbBarroca";
            this.rdbBarroca.Size = new System.Drawing.Size(62, 17);
            this.rdbBarroca.TabIndex = 0;
            this.rdbBarroca.TabStop = true;
            this.rdbBarroca.Text = "Barroca";
            this.rdbBarroca.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbSerie3);
            this.panel2.Controls.Add(this.rdbSerie2);
            this.panel2.Controls.Add(this.rdbSerie1);
            this.panel2.Location = new System.Drawing.Point(371, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 51);
            this.panel2.TabIndex = 12;
            // 
            // rdbSerie3
            // 
            this.rdbSerie3.AutoSize = true;
            this.rdbSerie3.Location = new System.Drawing.Point(189, 19);
            this.rdbSerie3.Name = "rdbSerie3";
            this.rdbSerie3.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie3.TabIndex = 2;
            this.rdbSerie3.TabStop = true;
            this.rdbSerie3.Text = "3º";
            this.rdbSerie3.UseVisualStyleBackColor = true;
            // 
            // rdbSerie2
            // 
            this.rdbSerie2.AutoSize = true;
            this.rdbSerie2.Location = new System.Drawing.Point(111, 19);
            this.rdbSerie2.Name = "rdbSerie2";
            this.rdbSerie2.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie2.TabIndex = 1;
            this.rdbSerie2.TabStop = true;
            this.rdbSerie2.Text = "2º";
            this.rdbSerie2.UseVisualStyleBackColor = true;
            // 
            // rdbSerie1
            // 
            this.rdbSerie1.AutoSize = true;
            this.rdbSerie1.Location = new System.Drawing.Point(20, 19);
            this.rdbSerie1.Name = "rdbSerie1";
            this.rdbSerie1.Size = new System.Drawing.Size(35, 17);
            this.rdbSerie1.TabIndex = 0;
            this.rdbSerie1.TabStop = true;
            this.rdbSerie1.Text = "1º";
            this.rdbSerie1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Série:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unidade:";
            // 
            // cbxTurma
            // 
            this.cbxTurma.FormattingEnabled = true;
            this.cbxTurma.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbxTurma.Location = new System.Drawing.Point(652, 181);
            this.cbxTurma.Name = "cbxTurma";
            this.cbxTurma.Size = new System.Drawing.Size(85, 21);
            this.cbxTurma.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Turma:";
            // 
            // DtgAlunos
            // 
            this.DtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAlunos.Location = new System.Drawing.Point(42, 238);
            this.DtgAlunos.Name = "DtgAlunos";
            this.DtgAlunos.Size = new System.Drawing.Size(715, 167);
            this.DtgAlunos.TabIndex = 17;
            this.DtgAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgAlunos_CellClick);
            this.DtgAlunos.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.DtgAlunos_CellToolTipTextNeeded);
            // 
            // cadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgAlunos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "cadastroAluno";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.cadastroAluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbSerie2;
        private System.Windows.Forms.RadioButton rdbSerie1;
        private System.Windows.Forms.RadioButton rdbBarroca;
        private System.Windows.Forms.RadioButton rdbSerie3;
        private System.Windows.Forms.RadioButton rdbFloresta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTurma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DtgAlunos;
    }
}

