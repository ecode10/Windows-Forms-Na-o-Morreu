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
    
    public partial class frmDisciplina : Form
    {
        public frmDisciplina()
        {
            InitializeComponent();
        }

        private void frmDisciplina_Load(object sender, EventArgs e)
        {
            selectDados();
        }

        private void selectDados()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoSQLLocal"].ToString()))
            {
                try
                {
                    conn.Open();

                    var sql = @"SELECT 
                                    IdDisc, DescricaoDisc 
                                FROM Disciplinas 
                                ORDER BY DescricaoDisc";

                    SqlCommand sqlCommand = new SqlCommand(sql, conn);
                    //sqlCommand.CommandType = System.Data.CommandType.Text;

                    DataSet dt = new System.Data.DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(sqlCommand);
                    dtAdapter.Fill(dt);

                    this.dtGridDisciplina.DataSource = dt.Tables[0];
                    //preencherCombo(dt.Tables[0]);

                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void preencherCombo(DataTable dt)
        {
            this.cmbDisciplina.DisplayMember = "DescricaoDisc";
            this.cmbDisciplina.ValueMember = "IdDisc";
            this.cmbDisciplina.DataSource = dt;
        }

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValorEscolhido.Text = cmbDisciplina.SelectedValue.ToString();
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            try
            {
                //instancio a classe
                Disciplinas disc = new Disciplinas();
                disc._nomeDisciplina = txtNomeDisciplina.Text;

                //chamo o método para inserir valores
                inserirDados(disc);

                //busco os valores do banco de dados novamente.
                selectDados();

                //apago o valor do campo text e mando o focu.
                txtNomeDisciplina.Text = "";
                txtNomeDisciplina.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void inserirDados(Disciplinas _disciplina)
        {
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoSQLLocal"].ToString()))
                {
                    conn.Open();

                    var sql = "INSERT INTO Disciplinas VALUES (@nomeDisciplina)";
                    SqlCommand sqlCom = new SqlCommand(sql, conn);
                    sqlCom.CommandType = System.Data.CommandType.Text;
                    
                    sqlCom.Parameters.AddWithValue("@nomeDisciplina", _disciplina._nomeDisciplina);
                    sqlCom.ExecuteNonQuery();
                }
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


    public class Disciplinas
    {
        public string _nomeDisciplina { get; set; }
    }
}
