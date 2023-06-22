using Casa.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Casa.DAL
{
    public class EstoqueDAL
    {
        public DataTable ListaDeAlimentos
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Alimentos", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }

        public DataTable ListaDeRemedios
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Remedios", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }
        public void Incluir(EstoqueInformation estoque)
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
                cmd.CommandText = "insere_Atualizar_Estoque";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_atualizar_estoque = new SqlParameter("@ID_Atualizar_Estoque", SqlDbType.Int);
                pid_atualizar_estoque.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_atualizar_estoque);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = estoque.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter pquantidade_alimentos = new SqlParameter("@Quantidade_Alimentos", SqlDbType.Decimal);
                pquantidade_alimentos.Value = estoque.Quantidade_Alimentos;
                cmd.Parameters.Add(pquantidade_alimentos);
                SqlParameter premedios = new SqlParameter("@Remedios", SqlDbType.NVarChar, 100);
                premedios.Value = estoque.Remedios;
                cmd.Parameters.Add(premedios);
                SqlParameter pquantidade_remedios = new SqlParameter("@Quantidade_Remedios", SqlDbType.Decimal);
                pquantidade_remedios.Value = estoque.Quantidade_Remedios;
                cmd.Parameters.Add(pquantidade_remedios);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = estoque.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = estoque.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);
                cn.Open();
                cmd.ExecuteNonQuery();

                estoque.ID_Atualizar_Estoque = (Int32)cmd.Parameters["@ID_Atualizar_Estoque"].Value;
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

        public void IncluirAlimento(EstoqueInformation estoquealimento)
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
                cmd.CommandText = "insere_Atualizar_Estoque_Alimento";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_atualizar_estoque = new SqlParameter("@ID_Atualizar_Estoque", SqlDbType.Int);
                pid_atualizar_estoque.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_atualizar_estoque);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = estoquealimento.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter pquantidade_alimentos = new SqlParameter("@Quantidade_Alimentos", SqlDbType.Decimal);
                pquantidade_alimentos.Value = estoquealimento.Quantidade_Alimentos;
                cmd.Parameters.Add(pquantidade_alimentos);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = estoquealimento.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                estoquealimento.ID_Atualizar_Estoque = (Int32)cmd.Parameters["@ID_Atualizar_Estoque"].Value;
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

        public void IncluirRemedio(EstoqueInformation estoqueremedio)
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
                cmd.CommandText = "insere_Atualizar_Estoque_Remedio";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_atualizar_estoque = new SqlParameter("@ID_Atualizar_Estoque", SqlDbType.Int);
                pid_atualizar_estoque.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_atualizar_estoque);
                SqlParameter premedios = new SqlParameter("@Remedios", SqlDbType.NVarChar, 100);
                premedios.Value = estoqueremedio.Remedios;
                cmd.Parameters.Add(premedios);
                SqlParameter pquantidade_remedios = new SqlParameter("@Quantidade_Remedios", SqlDbType.Decimal);
                pquantidade_remedios.Value = estoqueremedio.Quantidade_Remedios;
                cmd.Parameters.Add(pquantidade_remedios);
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = estoqueremedio.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);

                cn.Open();
                cmd.ExecuteNonQuery();

                estoqueremedio.ID_Atualizar_Estoque = (Int32)cmd.Parameters["@ID_Atualizar_Estoque"].Value;
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
    }
}
