using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsNaoMorreu
{
    public partial class frmValores : Form
    {
        public frmValores()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var _descricao = txtDescricao.Text;
            var _valor = txtValor.Text;
            var _tipo = "";

            if (rdDespesa.Checked)
                _tipo = "Despesa";

            if (rdReceita.Checked)
                _tipo = "Receita";

            System.IO.File.WriteAllText(@"C:\Temp\valores.txt", "Descricao: " + _descricao + " - Valor: R$" + _valor +
                " - Tipo:" + _tipo);

            MessageBox.Show("Salvo com sucesso.", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
        }

        private void limparCampos()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";

            rdDespesa.Checked = false;
            rdReceita.Checked = false;

            txtDescricao.Focus();
        }
    }
}
