﻿namespace CamadaAplicacao
{
    partial class frmPreparo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.tabPreparo = new System.Windows.Forms.TabControl();
            this.tabDadosGerais = new System.Windows.Forms.TabPage();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFibras = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCarb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSodio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLipidios = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProteinas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.txtPesoUnitario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btFichaTecnica = new System.Windows.Forms.Button();
            this.gridFichaTecnica = new System.Windows.Forms.DataGridView();
            this.cmbPreparos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPreparo.SuspendLayout();
            this.tabDadosGerais.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFichaTecnica)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(720, 434);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 44);
            this.btCancelar.TabIndex = 21;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(720, 373);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(88, 44);
            this.btSalvar.TabIndex = 22;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(720, 310);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(88, 44);
            this.btEditar.TabIndex = 23;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(720, 242);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(88, 44);
            this.btExcluir.TabIndex = 24;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.Location = new System.Drawing.Point(720, 180);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(88, 44);
            this.btIncluir.TabIndex = 25;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // tabPreparo
            // 
            this.tabPreparo.Controls.Add(this.tabDadosGerais);
            this.tabPreparo.Controls.Add(this.tabPage2);
            this.tabPreparo.Controls.Add(this.tabPage3);
            this.tabPreparo.Controls.Add(this.tabPage4);
            this.tabPreparo.Location = new System.Drawing.Point(33, 158);
            this.tabPreparo.Name = "tabPreparo";
            this.tabPreparo.SelectedIndex = 0;
            this.tabPreparo.Size = new System.Drawing.Size(646, 353);
            this.tabPreparo.TabIndex = 20;
            // 
            // tabDadosGerais
            // 
            this.tabDadosGerais.BackColor = System.Drawing.Color.Silver;
            this.tabDadosGerais.Controls.Add(this.txtIdInsumo);
            this.tabDadosGerais.Controls.Add(this.label16);
            this.tabDadosGerais.Controls.Add(this.label3);
            this.tabDadosGerais.Controls.Add(this.txtNome);
            this.tabDadosGerais.Controls.Add(this.label4);
            this.tabDadosGerais.Controls.Add(this.txtDescricao);
            this.tabDadosGerais.Location = new System.Drawing.Point(4, 22);
            this.tabDadosGerais.Name = "tabDadosGerais";
            this.tabDadosGerais.Padding = new System.Windows.Forms.Padding(3);
            this.tabDadosGerais.Size = new System.Drawing.Size(638, 327);
            this.tabDadosGerais.TabIndex = 0;
            this.tabDadosGerais.Text = "Dados Gerais";
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.Enabled = false;
            this.txtIdInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInsumo.Location = new System.Drawing.Point(17, 39);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.Size = new System.Drawing.Size(127, 22);
            this.txtIdInsumo.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(14, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(14, 142);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(601, 46);
            this.txtDescricao.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.txtFibras);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtCarb);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtSodio);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtLipidios);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtProteinas);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCalorias);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Nutricionais";
            // 
            // txtFibras
            // 
            this.txtFibras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFibras.Location = new System.Drawing.Point(191, 276);
            this.txtFibras.Name = "txtFibras";
            this.txtFibras.ReadOnly = true;
            this.txtFibras.Size = new System.Drawing.Size(100, 22);
            this.txtFibras.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(99, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Fibras";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCarb
            // 
            this.txtCarb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarb.Location = new System.Drawing.Point(191, 226);
            this.txtCarb.Name = "txtCarb";
            this.txtCarb.ReadOnly = true;
            this.txtCarb.Size = new System.Drawing.Size(100, 22);
            this.txtCarb.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(66, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Carbohidrato";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSodio
            // 
            this.txtSodio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodio.Location = new System.Drawing.Point(191, 178);
            this.txtSodio.Name = "txtSodio";
            this.txtSodio.ReadOnly = true;
            this.txtSodio.Size = new System.Drawing.Size(100, 22);
            this.txtSodio.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sódio";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLipidios
            // 
            this.txtLipidios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLipidios.Location = new System.Drawing.Point(191, 130);
            this.txtLipidios.Name = "txtLipidios";
            this.txtLipidios.ReadOnly = true;
            this.txtLipidios.Size = new System.Drawing.Size(100, 22);
            this.txtLipidios.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lipídios";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProteinas
            // 
            this.txtProteinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProteinas.Location = new System.Drawing.Point(191, 84);
            this.txtProteinas.Name = "txtProteinas";
            this.txtProteinas.ReadOnly = true;
            this.txtProteinas.Size = new System.Drawing.Size(100, 22);
            this.txtProteinas.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Proteínas";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCalorias
            // 
            this.txtCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorias.Location = new System.Drawing.Point(191, 38);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.ReadOnly = true;
            this.txtCalorias.Size = new System.Drawing.Size(100, 22);
            this.txtCalorias.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Calorias";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.txtRendimento);
            this.tabPage3.Controls.Add(this.txtPesoUnitario);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cmbUnidade);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtPreco);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(638, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quantitativo";
            // 
            // txtRendimento
            // 
            this.txtRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendimento.Location = new System.Drawing.Point(378, 49);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(100, 22);
            this.txtRendimento.TabIndex = 20;
            // 
            // txtPesoUnitario
            // 
            this.txtPesoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoUnitario.Location = new System.Drawing.Point(41, 116);
            this.txtPesoUnitario.Name = "txtPesoUnitario";
            this.txtPesoUnitario.Size = new System.Drawing.Size(100, 22);
            this.txtPesoUnitario.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(378, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Rendimento da Receita";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Peso Unitário (Gramas)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Preço Unitário";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(41, 47);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(121, 24);
            this.cmbUnidade.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Unidade";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(41, 178);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(100, 22);
            this.txtPreco.TabIndex = 14;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.btFichaTecnica);
            this.tabPage4.Controls.Add(this.gridFichaTecnica);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(638, 327);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ficha Técnica";
            // 
            // btFichaTecnica
            // 
            this.btFichaTecnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFichaTecnica.Location = new System.Drawing.Point(488, 12);
            this.btFichaTecnica.Name = "btFichaTecnica";
            this.btFichaTecnica.Size = new System.Drawing.Size(133, 44);
            this.btFichaTecnica.TabIndex = 26;
            this.btFichaTecnica.Text = "Editar Ficha Tecnica";
            this.btFichaTecnica.UseVisualStyleBackColor = true;
            this.btFichaTecnica.Click += new System.EventHandler(this.btFichaTecnica_Click);
            // 
            // gridFichaTecnica
            // 
            this.gridFichaTecnica.AllowUserToAddRows = false;
            this.gridFichaTecnica.AllowUserToDeleteRows = false;
            this.gridFichaTecnica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridFichaTecnica.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFichaTecnica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridFichaTecnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFichaTecnica.EnableHeadersVisualStyles = false;
            this.gridFichaTecnica.Location = new System.Drawing.Point(16, 62);
            this.gridFichaTecnica.MultiSelect = false;
            this.gridFichaTecnica.Name = "gridFichaTecnica";
            this.gridFichaTecnica.ReadOnly = true;
            this.gridFichaTecnica.RowHeadersVisible = false;
            this.gridFichaTecnica.Size = new System.Drawing.Size(605, 248);
            this.gridFichaTecnica.TabIndex = 0;
            // 
            // cmbPreparos
            // 
            this.cmbPreparos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreparos.FormattingEnabled = true;
            this.cmbPreparos.Location = new System.Drawing.Point(37, 37);
            this.cmbPreparos.Name = "cmbPreparos";
            this.cmbPreparos.Size = new System.Drawing.Size(354, 24);
            this.cmbPreparos.TabIndex = 19;
            this.cmbPreparos.SelectionChangeCommitted += new System.EventHandler(this.cmbPreparos_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Preparo";
            // 
            // frmPreparo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 592);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.tabPreparo);
            this.Controls.Add(this.cmbPreparos);
            this.Controls.Add(this.label2);
            this.Name = "frmPreparo";
            this.Text = "Preparo";
            this.Load += new System.EventHandler(this.frmPreparo_Load);
            this.tabPreparo.ResumeLayout(false);
            this.tabDadosGerais.ResumeLayout(false);
            this.tabDadosGerais.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFichaTecnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.TabControl tabPreparo;
        private System.Windows.Forms.TabPage tabDadosGerais;
        private System.Windows.Forms.TextBox txtIdInsumo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFibras;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCarb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSodio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLipidios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProteinas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPreparos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtRendimento;
        private System.Windows.Forms.TextBox txtPesoUnitario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView gridFichaTecnica;
        private System.Windows.Forms.Button btFichaTecnica;
    }
}