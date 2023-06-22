using Casa.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Casa.DAL
{
    public class RemedioDAL
    {
        public void Incluir(RemedioInformation remedio)
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
                cmd.CommandText = "insere_Remedios";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_remedio);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = remedio.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pmarca = new SqlParameter("@Marca", SqlDbType.NVarChar, 100);
                pmarca.Value = remedio.Marca;
                cmd.Parameters.Add(pmarca);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = remedio.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = remedio.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = remedio.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = remedio.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();

                remedio.ID_Remedio = (Int32)cmd.Parameters["@ID_Remedio"].Value;
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
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

        public void IncluirSemMarca(RemedioInformation remedio)
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
                cmd.CommandText = "insere_Remedios_Sem_Marca";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_remedio);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = remedio.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = remedio.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = remedio.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = remedio.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = remedio.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();

                remedio.ID_Remedio = (Int32)cmd.Parameters["@ID_Remedio"].Value;
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
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

        public void Alterar(RemedioInformation remedio)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "alterar_Remedios";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = remedio.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = remedio.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pmarca = new SqlParameter("@Marca", SqlDbType.NVarChar, 100);
                pmarca.Value = remedio.Marca;
                cmd.Parameters.Add(pmarca);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = remedio.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = remedio.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = remedio.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = remedio.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();
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

        public void AlterarSemMarca(RemedioInformation remedio)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "alterar_Remedios_Sem_Marca";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = remedio.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = remedio.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = remedio.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = remedio.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = remedio.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = remedio.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();
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

        public void Excluir(int ID_Remedio)
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
                cmd.CommandText = "excluir_Remedios";
                //parametros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                //pcodigo.Direction = ParameterDirection.Output;
                pcodigo.Value = ID_Remedio;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o remédio! " + ID_Remedio);

                }
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            {
                cn.Close();
            }
        }

        public decimal VerificaEstoqueRemedio(EstoqueInformation estoque)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                int num = estoque.ID_Remedio;
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Estoque from Remedios where ID_Remedio = @ID_Remedio";
                cmd.Parameters.AddWithValue("@ID_Remedio", num);

                cn.Open();

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }

            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro: " + ex.Number);
            }

            finally
            {
                cn.Close();
            }
        }

        public DataTable DentroValidade()
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable remedio = new DataTable();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from Remedios where Validade >= CAST(GETDATE() AS DATE)";
                da.SelectCommand.Connection = cn;

                da.Fill(remedio);

                return remedio;
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

        public DataTable ForaValidade()
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable remedio = new DataTable();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from Remedios where Validade < CAST(GETDATE() AS DATE)";
                da.SelectCommand.Connection = cn;

                da.Fill(remedio);

                return remedio;
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
