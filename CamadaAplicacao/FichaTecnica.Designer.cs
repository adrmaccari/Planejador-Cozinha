namespace CamadaAplicacao
{
    partial class FichaTecnica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.gridItensReceita = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterarQtd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeBusca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridInsumos = new System.Windows.Forms.DataGridView();
            this.btIncluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridItensReceita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rendimento da Receita";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(42, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(358, 22);
            this.txtNome.TabIndex = 3;
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbUnidade.Enabled = false;
            this.cmbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(431, 82);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(121, 24);
            this.cmbUnidade.TabIndex = 4;
            // 
            // txtRendimento
            // 
            this.txtRendimento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendimento.Location = new System.Drawing.Point(603, 84);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.ReadOnly = true;
            this.txtRendimento.Size = new System.Drawing.Size(100, 22);
            this.txtRendimento.TabIndex = 5;
            // 
            // gridItensReceita
            // 
            this.gridItensReceita.AllowUserToAddRows = false;
            this.gridItensReceita.AllowUserToDeleteRows = false;
            this.gridItensReceita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridItensReceita.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItensReceita.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItensReceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItensReceita.EnableHeadersVisualStyles = false;
            this.gridItensReceita.Location = new System.Drawing.Point(42, 369);
            this.gridItensReceita.MultiSelect = false;
            this.gridItensReceita.Name = "gridItensReceita";
            this.gridItensReceita.ReadOnly = true;
            this.gridItensReceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItensReceita.Size = new System.Drawing.Size(740, 270);
            this.gridItensReceita.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ficha Técnica";
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(816, 369);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(91, 47);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterarQtd
            // 
            this.btAlterarQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarQtd.Location = new System.Drawing.Point(816, 440);
            this.btAlterarQtd.Name = "btAlterarQtd";
            this.btAlterarQtd.Size = new System.Drawing.Size(91, 43);
            this.btAlterarQtd.TabIndex = 3;
            this.btAlterarQtd.Text = "Alterar Quantidade";
            this.btAlterarQtd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insumos";
            // 
            // txtNomeBusca
            // 
            this.txtNomeBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBusca.Location = new System.Drawing.Point(135, 165);
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.Size = new System.Drawing.Size(294, 22);
            this.txtNomeBusca.TabIndex = 10;
            this.txtNomeBusca.TextChanged += new System.EventHandler(this.TxtNomeBusca_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar nome";
            // 
            // gridInsumos
            // 
            this.gridInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridInsumos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInsumos.EnableHeadersVisualStyles = false;
            this.gridInsumos.Location = new System.Drawing.Point(47, 212);
            this.gridInsumos.Name = "gridInsumos";
            this.gridInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInsumos.Size = new System.Drawing.Size(735, 102);
            this.gridInsumos.TabIndex = 11;
            // 
            // btIncluir
            // 
            this.btIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.Location = new System.Drawing.Point(816, 212);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(91, 49);
            this.btIncluir.TabIndex = 12;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.BtIncluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adicionar Insumo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Preparo";
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(816, 590);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(91, 49);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // FichaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 662);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.gridInsumos);
            this.Controls.Add(this.txtNomeBusca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAlterarQtd);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.gridItensReceita);
            this.Controls.Add(this.txtRendimento);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FichaTecnica";
            this.Text = "FichaTecnica";
            this.Load += new System.EventHandler(this.FichaTecnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItensReceita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.TextBox txtRendimento;
        private System.Windows.Forms.DataGridView gridItensReceita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterarQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeBusca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridInsumos;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSair;
    }
}