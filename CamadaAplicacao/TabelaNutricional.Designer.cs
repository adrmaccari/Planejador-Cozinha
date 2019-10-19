namespace CamadaAplicacao
{
    partial class frmTabelaNutricional
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.gridItensTabela = new System.Windows.Forms.DataGridView();
            this.Coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProteinas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLipidios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSodio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFibra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCarb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroTACO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.radTACO = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFonteDetalhes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPesoAmostra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridItensTabela)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(119, 42);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(378, 22);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // gridItensTabela
            // 
            this.gridItensTabela.AllowUserToAddRows = false;
            this.gridItensTabela.AllowUserToDeleteRows = false;
            this.gridItensTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridItensTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItensTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna1,
            this.Coluna2,
            this.Coluna3});
            this.gridItensTabela.Location = new System.Drawing.Point(119, 87);
            this.gridItensTabela.MultiSelect = false;
            this.gridItensTabela.Name = "gridItensTabela";
            this.gridItensTabela.ReadOnly = true;
            this.gridItensTabela.RowHeadersVisible = false;
            this.gridItensTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItensTabela.Size = new System.Drawing.Size(671, 128);
            this.gridItensTabela.TabIndex = 2;
            this.gridItensTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItensTabela_CellClick);
            this.gridItensTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItensTabela_CellContentClick);
            this.gridItensTabela.SelectionChanged += new System.EventHandler(this.gridItensTabela_SelectionChanged);
            // 
            // Coluna1
            // 
            this.Coluna1.HeaderText = "ID Item";
            this.Coluna1.Name = "Coluna1";
            this.Coluna1.ReadOnly = true;
            this.Coluna1.Width = 66;
            // 
            // Coluna2
            // 
            this.Coluna2.HeaderText = "Nome Item";
            this.Coluna2.Name = "Coluna2";
            this.Coluna2.ReadOnly = true;
            this.Coluna2.Width = 83;
            // 
            // Coluna3
            // 
            this.Coluna3.HeaderText = "Observação";
            this.Coluna3.Name = "Coluna3";
            this.Coluna3.ReadOnly = true;
            this.Coluna3.Width = 90;
            // 
            // txtCalorias
            // 
            this.txtCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorias.Location = new System.Drawing.Point(650, 389);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(140, 22);
            this.txtCalorias.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calorias";
            // 
            // txtProteinas
            // 
            this.txtProteinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProteinas.Location = new System.Drawing.Point(650, 435);
            this.txtProteinas.Name = "txtProteinas";
            this.txtProteinas.Size = new System.Drawing.Size(140, 22);
            this.txtProteinas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proteínas";
            // 
            // txtLipidios
            // 
            this.txtLipidios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLipidios.Location = new System.Drawing.Point(650, 480);
            this.txtLipidios.Name = "txtLipidios";
            this.txtLipidios.Size = new System.Drawing.Size(140, 22);
            this.txtLipidios.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lipídios";
            // 
            // txtSodio
            // 
            this.txtSodio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodio.Location = new System.Drawing.Point(650, 526);
            this.txtSodio.Name = "txtSodio";
            this.txtSodio.Size = new System.Drawing.Size(140, 22);
            this.txtSodio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sódio";
            // 
            // txtFibra
            // 
            this.txtFibra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFibra.Location = new System.Drawing.Point(650, 572);
            this.txtFibra.Name = "txtFibra";
            this.txtFibra.Size = new System.Drawing.Size(140, 22);
            this.txtFibra.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fibras";
            // 
            // txtCarb
            // 
            this.txtCarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarb.Location = new System.Drawing.Point(650, 615);
            this.txtCarb.Name = "txtCarb";
            this.txtCarb.Size = new System.Drawing.Size(140, 22);
            this.txtCarb.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Carbohidratos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroTACO);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.radManual);
            this.groupBox1.Controls.Add(this.radTACO);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(123, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonte";
            // 
            // txtNumeroTACO
            // 
            this.txtNumeroTACO.Enabled = false;
            this.txtNumeroTACO.Location = new System.Drawing.Point(124, 40);
            this.txtNumeroTACO.Name = "txtNumeroTACO";
            this.txtNumeroTACO.Size = new System.Drawing.Size(130, 22);
            this.txtNumeroTACO.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Número TACO";
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Location = new System.Drawing.Point(18, 84);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(70, 20);
            this.radManual.TabIndex = 1;
            this.radManual.TabStop = true;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            // 
            // radTACO
            // 
            this.radTACO.AutoSize = true;
            this.radTACO.Location = new System.Drawing.Point(18, 43);
            this.radTACO.Name = "radTACO";
            this.radTACO.Size = new System.Drawing.Size(63, 20);
            this.radTACO.TabIndex = 0;
            this.radTACO.TabStop = true;
            this.radTACO.Text = "TACO";
            this.radTACO.UseVisualStyleBackColor = true;
            this.radTACO.CheckedChanged += new System.EventHandler(this.radTACO_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(123, 266);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(667, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nome";
            // 
            // txtFonteDetalhes
            // 
            this.txtFonteDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFonteDetalhes.Location = new System.Drawing.Point(123, 570);
            this.txtFonteDetalhes.Multiline = true;
            this.txtFonteDetalhes.Name = "txtFonteDetalhes";
            this.txtFonteDetalhes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFonteDetalhes.Size = new System.Drawing.Size(374, 65);
            this.txtFonteDetalhes.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fonte Detalhes";
            // 
            // txtPesoAmostra
            // 
            this.txtPesoAmostra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoAmostra.Location = new System.Drawing.Point(650, 324);
            this.txtPesoAmostra.Name = "txtPesoAmostra";
            this.txtPesoAmostra.Size = new System.Drawing.Size(140, 22);
            this.txtPesoAmostra.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(619, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Peso da Amostra (Gramas)";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(123, 327);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacao.Size = new System.Drawing.Size(374, 57);
            this.txtObservacao.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(123, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Observação";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(871, 517);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 44);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(871, 456);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(88, 44);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(871, 393);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(88, 44);
            this.btEditar.TabIndex = 14;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(871, 325);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(88, 44);
            this.btExcluir.TabIndex = 13;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btIncluir
            // 
            this.btIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.Location = new System.Drawing.Point(871, 263);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(88, 44);
            this.btIncluir.TabIndex = 12;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // frmTabelaNutricional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 663);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.txtFonteDetalhes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPesoAmostra);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarb);
            this.Controls.Add(this.txtFibra);
            this.Controls.Add(this.txtSodio);
            this.Controls.Add(this.txtLipidios);
            this.Controls.Add(this.txtProteinas);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.gridItensTabela);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label1);
            this.Name = "frmTabelaNutricional";
            this.Text = "TabelaNutricional";
            this.Load += new System.EventHandler(this.frmTabelaNutricional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItensTabela)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView gridItensTabela;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProteinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLipidios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSodio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFibra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radManual;
        private System.Windows.Forms.RadioButton radTACO;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFonteDetalhes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPesoAmostra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumeroTACO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna3;
    }
}