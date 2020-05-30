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
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(31, 147);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(931, 328);
            this.dgvConsulta.TabIndex = 0;
            // 
            // btnGrupoAno
            // 
            this.btnGrupoAno.Location = new System.Drawing.Point(45, 37);
            this.btnGrupoAno.Name = "btnGrupoAno";
            this.btnGrupoAno.Size = new System.Drawing.Size(120, 46);
            this.btnGrupoAno.TabIndex = 1;
            this.btnGrupoAno.Text = "Agrupar Ano";
            this.btnGrupoAno.UseVisualStyleBackColor = true;
            this.btnGrupoAno.Click += new System.EventHandler(this.btnGrupoAno_Click);
            // 
            // btnPivot
            // 
            this.btnPivot.Location = new System.Drawing.Point(180, 37);
            this.btnPivot.Name = "btnPivot";
            this.btnPivot.Size = new System.Drawing.Size(120, 46);
            this.btnPivot.TabIndex = 2;
            this.btnPivot.Text = "Pivot Table";
            this.btnPivot.UseVisualStyleBackColor = true;
            this.btnPivot.Click += new System.EventHandler(this.btnPivot_Click);
            // 
            // btnPivotArray
            // 
            this.btnPivotArray.Location = new System.Drawing.Point(321, 37);
            this.btnPivotArray.Name = "btnPivotArray";
            this.btnPivotArray.Size = new System.Drawing.Size(120, 46);
            this.btnPivotArray.TabIndex = 3;
            this.btnPivotArray.Text = "Pivot EXCEL";
            this.btnPivotArray.UseVisualStyleBackColor = true;
            this.btnPivotArray.Click += new System.EventHandler(this.btnPivotArray_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.Location = new System.Drawing.Point(447, 37);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(120, 46);
            this.btnHtml.TabIndex = 4;
            this.btnHtml.Text = "Agrupar HTML";
            this.btnHtml.UseVisualStyleBackColor = true;
            this.btnHtml.Click += new System.EventHandler(this.btnHtml_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 536);
            this.Controls.Add(this.btnHtml);
            this.Controls.Add(this.btnPivotArray);
            this.Controls.Add(this.btnPivot);
            this.Controls.Add(this.btnGrupoAno);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnGrupoAno;
        private System.Windows.Forms.Button btnPivot;
        private System.Windows.Forms.Button btnPivotArray;
        private System.Windows.Forms.Button btnHtml;
    }
}