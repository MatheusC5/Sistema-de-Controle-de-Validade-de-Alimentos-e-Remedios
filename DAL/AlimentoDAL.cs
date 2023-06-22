using Casa.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Casa.DAL
{
    public class AlimentoDAL
    {
        public void Incluir(AlimentoInformation alimento)
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
                cmd.CommandText = "insere_Alimentos";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = alimento.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pmarca = new SqlParameter("@Marca", SqlDbType.NVarChar, 100);
                pmarca.Value = alimento.Marca;
                cmd.Parameters.Add(pmarca);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = alimento.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = alimento.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = alimento.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = alimento.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();

                alimento.ID_Alimento = (Int32)cmd.Parameters["@ID_Alimento"].Value;
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

        public void IncluirSemMarca(AlimentoInformation alimento)
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
                cmd.CommandText = "insere_Alimentos_Sem_Marca";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = alimento.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = alimento.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = alimento.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = alimento.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = alimento.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();

                alimento.ID_Alimento = (Int32)cmd.Parameters["@ID_Alimento"].Value;
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

        public void Alterar(AlimentoInformation alimento)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "alterar_Alimentos";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = alimento.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = alimento.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter pmarca = new SqlParameter("@Marca", SqlDbType.NVarChar, 100);
                pmarca.Value = alimento.Marca;
                cmd.Parameters.Add(pmarca);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = alimento.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = alimento.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = alimento.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = alimento.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();
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

        public void AlterarSemMarca(AlimentoInformation alimento)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "alterar_Alimentos_Sem_Marca";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = alimento.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pnome = new SqlParameter("@Nome", SqlDbType.NVarChar, 100);
                pnome.Value = alimento.Nome;
                cmd.Parameters.Add(pnome);
                SqlParameter punidade = new SqlParameter("@Unidade", SqlDbType.Int);
                punidade.Value = alimento.Unidade;
                cmd.Parameters.Add(punidade);
                SqlParameter pvalidade = new SqlParameter("@Validade", SqlDbType.Date);
                pvalidade.Value = alimento.Validade;
                cmd.Parameters.Add(pvalidade);
                SqlParameter pestoque = new SqlParameter("@Estoque", SqlDbType.Decimal);
                pestoque.Value = alimento.Estoque;
                cmd.Parameters.Add(pestoque);
                SqlParameter ppeso = new SqlParameter("@Peso", SqlDbType.NVarChar, 20);
                ppeso.Value = alimento.Peso;
                cmd.Parameters.Add(ppeso);

                cn.Open();
                cmd.ExecuteNonQuery();
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

        public void Excluir(int ID_Alimento)
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
                cmd.CommandText = "excluir_Alimentos";
                //parametros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                //pcodigo.Direction = ParameterDirection.Output;
                pcodigo.Value = ID_Alimento;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o alimento! " + ID_Alimento);

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

        public decimal VerificaEstoqueAlimento(EstoqueInformation estoque)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                int num = estoque.ID_Alimento;
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Estoque from Alimentos where ID_Alimento = @ID_Alimento";
                cmd.Parameters.AddWithValue("@ID_Alimento", num);

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
            DataTable alimento = new DataTable();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from Alimentos where Validade >= CAST(GETDATE() AS DATE)";
                da.SelectCommand.Connection = cn;

                da.Fill(alimento);

                return alimento;
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
            DataTable alimento = new DataTable();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "select * from Alimentos where Validade < CAST(GETDATE() AS DATE)";
                da.SelectCommand.Connection = cn;

                da.Fill(alimento);

                return alimento;
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
