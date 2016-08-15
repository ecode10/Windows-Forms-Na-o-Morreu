namespace WindowsFormsNaoMorreu
{
    partial class frmDisciplina
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
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblValorEscolhido = new System.Windows.Forms.Label();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.cmdInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(12, 104);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.RowTemplate.Height = 28;
            this.dtGridDisciplina.Size = new System.Drawing.Size(519, 285);
            this.dtGridDisciplina.TabIndex = 0;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(12, 395);
            this.cmbDisciplina.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(299, 28);
            this.cmbDisciplina.TabIndex = 1;
            this.cmbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplina_SelectedIndexChanged);
            // 
            // lblValorEscolhido
            // 
            this.lblValorEscolhido.AutoSize = true;
            this.lblValorEscolhido.Location = new System.Drawing.Point(11, 434);
            this.lblValorEscolhido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorEscolhido.Name = "lblValorEscolhido";
            this.lblValorEscolhido.Size = new System.Drawing.Size(119, 20);
            this.lblValorEscolhido.TabIndex = 2;
            this.lblValorEscolhido.Text = "Valor Escolhido";
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(15, 39);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(341, 26);
            this.txtNomeDisciplina.TabIndex = 3;
            // 
            // cmdInserir
            // 
            this.cmdInserir.Location = new System.Drawing.Point(362, 33);
            this.cmdInserir.Name = "cmdInserir";
            this.cmdInserir.Size = new System.Drawing.Size(151, 39);
            this.cmdInserir.TabIndex = 4;
            this.cmdInserir.Text = "Inserir";
            this.cmdInserir.UseVisualStyleBackColor = true;
            this.cmdInserir.Click += new System.EventHandler(this.cmdInserir_Click);
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 472);
            this.Controls.Add(this.cmdInserir);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Controls.Add(this.lblValorEscolhido);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.dtGridDisciplina);
            this.Name = "frmDisciplina";
            this.Text = "Disciplina";
            this.Load += new System.EventHandler(this.frmDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label lblValorEscolhido;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.Button cmdInserir;
    }
}