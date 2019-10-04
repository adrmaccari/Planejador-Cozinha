namespace CamadaAplicacao
{
    partial class frmConfiguracoes
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
            this.tabGeral = new System.Windows.Forms.TabControl();
            this.tabUnidades = new System.Windows.Forms.TabPage();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstboxUnidadesConsumo = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabGeral.SuspendLayout();
            this.tabUnidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.tabUnidades);
            this.tabGeral.Controls.Add(this.tabPage2);
            this.tabGeral.Location = new System.Drawing.Point(27, 29);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.SelectedIndex = 0;
            this.tabGeral.Size = new System.Drawing.Size(640, 510);
            this.tabGeral.TabIndex = 2;
            // 
            // tabUnidades
            // 
            this.tabUnidades.Controls.Add(this.btCancelar);
            this.tabUnidades.Controls.Add(this.btSalvar);
            this.tabUnidades.Controls.Add(this.label3);
            this.tabUnidades.Controls.Add(this.label2);
            this.tabUnidades.Controls.Add(this.txtDescricao);
            this.tabUnidades.Controls.Add(this.txtSimbolo);
            this.tabUnidades.Controls.Add(this.btEditar);
            this.tabUnidades.Controls.Add(this.btIncluir);
            this.tabUnidades.Controls.Add(this.btExcluir);
            this.tabUnidades.Controls.Add(this.label1);
            this.tabUnidades.Controls.Add(this.lstboxUnidadesConsumo);
            this.tabUnidades.Location = new System.Drawing.Point(4, 22);
            this.tabUnidades.Name = "tabUnidades";
            this.tabUnidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnidades.Size = new System.Drawing.Size(632, 484);
            this.tabUnidades.TabIndex = 0;
            this.tabUnidades.Text = "Unidades de Consumo";
            this.tabUnidades.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(525, 242);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(525, 193);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Símbolo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(283, 155);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(192, 155);
            this.txtDescricao.TabIndex = 8;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(283, 75);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(55, 20);
            this.txtSimbolo.TabIndex = 7;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(525, 152);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(525, 59);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 5;
            this.btIncluir.Text = "Novo";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(525, 104);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unidades de Consumo";
            // 
            // lstboxUnidadesConsumo
            // 
            this.lstboxUnidadesConsumo.FormattingEnabled = true;
            this.lstboxUnidadesConsumo.Location = new System.Drawing.Point(26, 59);
            this.lstboxUnidadesConsumo.Name = "lstboxUnidadesConsumo";
            this.lstboxUnidadesConsumo.Size = new System.Drawing.Size(229, 251);
            this.lstboxUnidadesConsumo.TabIndex = 1;
            this.lstboxUnidadesConsumo.Click += new System.EventHandler(this.lstboxUnidadesConsumo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.tabGeral);
            this.Name = "frmConfiguracoes";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            this.tabGeral.ResumeLayout(false);
            this.tabUnidades.ResumeLayout(false);
            this.tabUnidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeral;
        private System.Windows.Forms.TabPage tabUnidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstboxUnidadesConsumo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
    }
}