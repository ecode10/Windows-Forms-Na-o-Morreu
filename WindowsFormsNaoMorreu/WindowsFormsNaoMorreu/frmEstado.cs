using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsNaoMorreu
{
    public partial class frmEstado : Form
    {
        public frmEstado()
        {
            InitializeComponent();
        }

        private void frmEstado_Load(object sender, EventArgs e)
        {
            selecionaDadosEstado();
        }

        private void selecionaDadosEstado()
        {
            var StringConexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoSQLLocal"].ToString();
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                try
                {
                    conn.Open();

                    var sql = @"SELECT IdEstado, NomeEstado FROM Estado ORDER BY NomeEstado";

                    SqlCommand command = new SqlCommand(sql, conn);

                    DataSet dt = new System.Data.DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);
                    dtAdapter.Fill(dt);

                    cmbEstado.DisplayMember = "NomeEstado";
                    cmbEstado.ValueMember = "IdEstado";
                    cmbEstado.DataSource = dt.Tables[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionaCidade();
        }

        private void selecionaCidade()
        {
            var StringConexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoSQLLocal"].ToString();
            using (SqlConnection conn = new SqlConnection(StringConexao))
            {
                try
                {
                    conn.Open();

                    var sql = @"SELECT 
                                    IdCidade, IdEstado, NomeCidade  
                                FROM Cidade
                                WHERE IdEstado = @IdEstado ORDER BY NomeCidade";

                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@IdEstado", cmbEstado.SelectedValue.ToString());

                    DataSet dt = new System.Data.DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);
                    dtAdapter.Fill(dt);

                    cmbCidade.DisplayMember = "NomeCidade";
                    cmbCidade.ValueMember = "IdCidade";
                    cmbCidade.DataSource = dt.Tables[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
