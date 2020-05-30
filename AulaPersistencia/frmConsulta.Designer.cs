namespace AulaPersistencia
{
    partial class frmConsulta
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
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnGrupoAno = new System.Windows.Forms.Button();
            this.btnPivot = new System.Windows.Forms.Button();
            this.btnPivotArray = new System.Windows.Forms.Button();
            this.btnHtml = new System.Windows.Forms.Button();
            this.gpbRelatório = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFiltraGrupo = new System.Windows.Forms.Button();
            this.btnFiltraProduto = new System.Windows.Forms.Button();
            this.btnFiltraPeriodo = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdutoID = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.gpbRelatório.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(44, 378);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(931, 290);
            this.dgvConsulta.TabIndex = 0;
            // 
            // btnGrupoAno
            // 
            this.btnGrupoAno.Location = new System.Drawing.Point(69, 175);
            this.btnGrupoAno.Name = "btnGrupoAno";
            this.btnGrupoAno.Size = new System.Drawing.Size(120, 46);
            this.btnGrupoAno.TabIndex = 1;
            this.btnGrupoAno.Text = "Agrupar Ano";
            this.btnGrupoAno.UseVisualStyleBackColor = true;
            this.btnGrupoAno.Click += new System.EventHandler(this.btnGrupoAno_Click);
            // 
            // btnPivot
            // 
            this.btnPivot.Location = new System.Drawing.Point(69, 63);
            this.btnPivot.Name = "btnPivot";
            this.btnPivot.Size = new System.Drawing.Size(120, 46);
            this.btnPivot.TabIndex = 2;
            this.btnPivot.Text = "Pivot Table";
            this.btnPivot.UseVisualStyleBackColor = true;
            this.btnPivot.Click += new System.EventHandler(this.btnPivot_Click);
            // 
            // btnPivotArray
            // 
            this.btnPivotArray.Location = new System.Drawing.Point(205, 63);
            this.btnPivotArray.Name = "btnPivotArray";
            this.btnPivotArray.Size = new System.Drawing.Size(120, 46);
            this.btnPivotArray.TabIndex = 3;
            this.btnPivotArray.Text = "Pivot EXCEL";
            this.btnPivotArray.UseVisualStyleBackColor = true;
            this.btnPivotArray.Click += new System.EventHandler(this.btnPivotArray_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.Location = new System.Drawing.Point(205, 175);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(120, 46);
            this.btnHtml.TabIndex = 4;
            this.btnHtml.Text = "Agrupar HTML";
            this.btnHtml.UseVisualStyleBackColor = true;
            this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
            // 
            // gpbRelatório
            // 
            this.gpbRelatório.Controls.Add(this.button1);
            this.gpbRelatório.Controls.Add(this.txtDescricao);
            this.gpbRelatório.Controls.Add(this.label6);
            this.gpbRelatório.Controls.Add(this.btnFiltraGrupo);
            this.gpbRelatório.Controls.Add(this.btnFiltraProduto);
            this.gpbRelatório.Controls.Add(this.btnFiltraPeriodo);
            this.gpbRelatório.Controls.Add(this.dtpFim);
            this.gpbRelatório.Controls.Add(this.dtpInicio);
            this.gpbRelatório.Controls.Add(this.label5);
            this.gpbRelatório.Controls.Add(this.label4);
            this.gpbRelatório.Controls.Add(this.txtProdutoID);
            this.gpbRelatório.Controls.Add(this.txtGrupo);
            this.gpbRelatório.Controls.Add(this.label3);
            this.gpbRelatório.Controls.Add(this.label2);
            this.gpbRelatório.Controls.Add(this.label1);
            this.gpbRelatório.Location = new System.Drawing.Point(419, 12);
            this.gpbRelatório.Name = "gpbRelatório";
            this.gpbRelatório.Size = new System.Drawing.Size(501, 319);
            this.gpbRelatório.TabIndex = 5;
            this.gpbRelatório.TabStop = false;
            this.gpbRelatório.Text = "Relatórios Itens Venda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "Vendas Por Descrição";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(133, 146);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 22);
            this.txtDescricao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descrição:";
            // 
            // btnFiltraGrupo
            // 
            this.btnFiltraGrupo.Location = new System.Drawing.Point(341, 21);
            this.btnFiltraGrupo.Name = "btnFiltraGrupo";
            this.btnFiltraGrupo.Size = new System.Drawing.Size(109, 57);
            this.btnFiltraGrupo.TabIndex = 10;
            this.btnFiltraGrupo.Text = "Vendas Por Grupo";
            this.btnFiltraGrupo.UseVisualStyleBackColor = true;
            this.btnFiltraGrupo.Click += new System.EventHandler(this.btnFiltraGrupo_Click);
            // 
            // btnFiltraProduto
            // 
            this.btnFiltraProduto.Location = new System.Drawing.Point(341, 84);
            this.btnFiltraProduto.Name = "btnFiltraProduto";
            this.btnFiltraProduto.Size = new System.Drawing.Size(109, 52);
            this.btnFiltraProduto.TabIndex = 9;
            this.btnFiltraProduto.Text = "Vendas Por Produto ID";
            this.btnFiltraProduto.UseVisualStyleBackColor = true;
            this.btnFiltraProduto.Click += new System.EventHandler(this.btnFiltraProduto_Click);
            // 
            // btnFiltraPeriodo
            // 
            this.btnFiltraPeriodo.Location = new System.Drawing.Point(341, 251);
            this.btnFiltraPeriodo.Name = "btnFiltraPeriodo";
            this.btnFiltraPeriodo.Size = new System.Drawing.Size(109, 51);
            this.btnFiltraPeriodo.TabIndex = 6;
            this.btnFiltraPeriodo.Text = "Vendas Por Perído";
            this.btnFiltraPeriodo.UseVisualStyleBackColor = true;
            this.btnFiltraPeriodo.Click += new System.EventHandler(this.btnFiltraPeriodo_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(177, 258);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(131, 30);
            this.dtpFim.TabIndex = 8;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(31, 258);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(125, 30);
            this.dtpInicio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Início:";
            // 
            // txtProdutoID
            // 
            this.txtProdutoID.Location = new System.Drawing.Point(134, 88);
            this.txtProdutoID.Name = "txtProdutoID";
            this.txtProdutoID.Size = new System.Drawing.Size(100, 22);
            this.txtProdutoID.TabIndex = 4;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(133, 38);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtGrupo.TabIndex = 3;
            this.txtGrupo.TextChanged += new System.EventHandler(this.txtGrupo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Período";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 695);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gpbRelatório);
            this.Controls.Add(this.btnHtml);
            this.Controls.Add(this.btnPivotArray);
            this.Controls.Add(this.btnPivot);
            this.Controls.Add(this.btnGrupoAno);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.gpbRelatório.ResumeLayout(false);
            this.gpbRelatório.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnGrupoAno;
        private System.Windows.Forms.Button btnPivot;
        private System.Windows.Forms.Button btnPivotArray;
        private System.Windows.Forms.Button btnHtml;
        private System.Windows.Forms.GroupBox gpbRelatório;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdutoID;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltraGrupo;
        private System.Windows.Forms.Button btnFiltraProduto;
        private System.Windows.Forms.Button btnFiltraPeriodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}