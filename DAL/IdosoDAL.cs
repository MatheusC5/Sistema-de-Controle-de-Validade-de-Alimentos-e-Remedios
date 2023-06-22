using System;
using Casa.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Casa.DAL
{
    public class IdosoDAL
    {
        public void Incluir(IdosoInformation idoso)
        {
            //conexão
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                // nome da stored procedure
                cmd.CommandText = "insere_Idosos";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = idoso.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pdata = new SqlParameter("@Data_Nascimento", SqlDbType.DateTime);
                pdata.Value = idoso.Data_Nascimento;
                cmd.Parameters.Add(pdata);
                SqlParameter pendereco_responsavel = new SqlParameter("@Endereco_Responsavel", SqlDbType.NVarChar, 300);
                pendereco_responsavel.Value = idoso.Endereco_Responsavel;
                cmd.Parameters.Add(pendereco_responsavel);
                SqlParameter ptelefone_responsavel = new SqlParameter("@Telefone_Responsavel", SqlDbType.NVarChar, 20);
                ptelefone_responsavel.Value = idoso.Telefone_Responsavel;
                cmd.Parameters.Add(ptelefone_responsavel);
                SqlParameter pcelular_responsavel = new SqlParameter("@Celular_Responsavel", SqlDbType.NVarChar, 20);
                pcelular_responsavel.Value = idoso.Celular_Responsavel;
                cmd.Parameters.Add(pcelular_responsavel);
                SqlParameter ptelefone_emergencia = new SqlParameter("@Telefone_Emergencia", SqlDbType.NVarChar, 20);
                ptelefone_emergencia.Value = idoso.Telefone_Emergencia;
                cmd.Parameters.Add(ptelefone_emergencia);

                cn.Open();
                cmd.ExecuteNonQuery();

                idoso.ID_Idoso = (Int32)cmd.Parameters["@ID_Idoso"].Value;
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor Sql Erro: " + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                cn.Close();
            }
        }

        public void Alterar(IdosoInformation idoso)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "alterar_Idosos";
                //parametros da stored procedure
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Value = idoso.ID_Idoso;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = idoso.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pdata = new SqlParameter("@Data_Nascimento", SqlDbType.DateTime);
                pdata.Value = idoso.Data_Nascimento;
                cmd.Parameters.Add(pdata);
                SqlParameter pendereco_responsavel = new SqlParameter("@Endereco_Responsavel", SqlDbType.NVarChar, 300);
                pendereco_responsavel.Value = idoso.Endereco_Responsavel;
                cmd.Parameters.Add(pendereco_responsavel);
                SqlParameter ptelefone_responsavel = new SqlParameter("@Telefone_Responsavel", SqlDbType.NVarChar, 20);
                ptelefone_responsavel.Value = idoso.Telefone_Responsavel;
                cmd.Parameters.Add(ptelefone_responsavel);
                SqlParameter pcelular_responsavel = new SqlParameter("@Celular_Responsavel", SqlDbType.NVarChar, 20);
                pcelular_responsavel.Value = idoso.Celular_Responsavel;
                cmd.Parameters.Add(pcelular_responsavel);
                SqlParameter ptelefone_emergencia = new SqlParameter("@Telefone_Emergencia", SqlDbType.NVarChar, 20);
                ptelefone_emergencia.Value = idoso.Telefone_Emergencia;
                cmd.Parameters.Add(ptelefone_emergencia);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: " + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int ID_Idoso)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "excluir_Idosos";
                //parametros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                //pcodigo.Direction = ParameterDirection.Output;
                pcodigo.Value = ID_Idoso;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o idoso! " + ID_Idoso);

                }
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: " + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            {
                cn.Close();
            }
        }

        public DataTable Pesquisar(string pesquisar)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable idoso = new DataTable();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "pesquisar_Idosos";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros de stored procedure
                SqlParameter ppesquisar;
                ppesquisar = da.SelectCommand.Parameters.Add("@pesquisar", SqlDbType.Text);
                ppesquisar.Value = pesquisar;

                da.Fill(idoso);

                return idoso;
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL erro: " + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                cn.Close();
            }
        }
    }
}
