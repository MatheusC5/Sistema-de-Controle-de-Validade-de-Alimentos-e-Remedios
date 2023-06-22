using Casa.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Casa.DAL
{
    public class ProntuarioDAL
    {
        public DataTable ListaDeIdosos
        {
            get
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("select * from Idosos", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }

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

        public void Incluir(ProntuarioInformation prontuario)
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
                cmd.CommandText = "insere_Prontuarios";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_prontuario = new SqlParameter("@ID_Prontuario", SqlDbType.Int);
                pid_prontuario.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_prontuario);
                SqlParameter pidosos = new SqlParameter("@Idosos", SqlDbType.NVarChar, 100);
                pidosos.Value = prontuario.Idosos;
                cmd.Parameters.Add(pidosos);
                SqlParameter penfermidades = new SqlParameter("@Enfermidades", SqlDbType.NVarChar, 100);
                penfermidades.Value = prontuario.Enfermidades;
                cmd.Parameters.Add(penfermidades);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = prontuario.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter premedios = new SqlParameter("@Remedios", SqlDbType.NVarChar, 100);
                premedios.Value = prontuario.Remedios;
                cmd.Parameters.Add(premedios);
                SqlParameter pdata_criacao = new SqlParameter("@Data_Criacao", SqlDbType.DateTime);
                pdata_criacao.Value = prontuario.Data_Criacao;
                cmd.Parameters.Add(pdata_criacao);
                SqlParameter pdata_uso = new SqlParameter("@Data_Uso", SqlDbType.DateTime);
                pdata_uso.Value = prontuario.Data_Uso;
                cmd.Parameters.Add(pdata_uso);
                SqlParameter pprescricao_observacoes = new SqlParameter("@Prescricao_Observacoes", SqlDbType.NVarChar, 300);
                pprescricao_observacoes.Value = prontuario.Prescricao_Observacoes;
                cmd.Parameters.Add(pprescricao_observacoes);
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Value = prontuario.ID_Idoso;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = prontuario.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = prontuario.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);

                cn.Open();
                cmd.ExecuteNonQuery();

                prontuario.ID_Prontuario = (Int32)cmd.Parameters["@ID_Prontuario"].Value;
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

        public void IncluirSemPrescricaoObservacoes(ProntuarioInformation prontuario)
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
                cmd.CommandText = "insere_Prontuarios_Sem_Prescricao_Observacoes";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_prontuario = new SqlParameter("@ID_Prontuario", SqlDbType.Int);
                pid_prontuario.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_prontuario);
                SqlParameter pidosos = new SqlParameter("@Idosos", SqlDbType.NVarChar, 100);
                pidosos.Value = prontuario.Idosos;
                cmd.Parameters.Add(pidosos);
                SqlParameter penfermidades = new SqlParameter("@Enfermidades", SqlDbType.NVarChar, 100);
                penfermidades.Value = prontuario.Enfermidades;
                cmd.Parameters.Add(penfermidades);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = prontuario.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter premedios = new SqlParameter("@Remedios", SqlDbType.NVarChar, 100);
                premedios.Value = prontuario.Remedios;
                cmd.Parameters.Add(premedios);
                SqlParameter pdata_criacao = new SqlParameter("@Data_Criacao", SqlDbType.DateTime);
                pdata_criacao.Value = prontuario.Data_Criacao;
                cmd.Parameters.Add(pdata_criacao);
                SqlParameter pdata_uso = new SqlParameter("@Data_Uso", SqlDbType.DateTime);
                pdata_uso.Value = prontuario.Data_Uso;
                cmd.Parameters.Add(pdata_uso);
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Value = prontuario.ID_Idoso;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = prontuario.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = prontuario.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);

                cn.Open();
                cmd.ExecuteNonQuery();

                prontuario.ID_Prontuario = (Int32)cmd.Parameters["@ID_Prontuario"].Value;
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

        public void IncluirAlimento(ProntuarioInformation prontuario)
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
                cmd.CommandText = "insere_Prontuarios_Alimentos";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_prontuario = new SqlParameter("@ID_Prontuario", SqlDbType.Int);
                pid_prontuario.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pid_prontuario);
                SqlParameter pidosos = new SqlParameter("@Idosos", SqlDbType.NVarChar, 100);
                pidosos.Value = prontuario.Idosos;
                cmd.Parameters.Add(pidosos);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = prontuario.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter pdata_criacao = new SqlParameter("@Data_Criacao", SqlDbType.DateTime);
                pdata_criacao.Value = prontuario.Data_Criacao;
                cmd.Parameters.Add(pdata_criacao);
                SqlParameter pdata_uso = new SqlParameter("@Data_Uso", SqlDbType.DateTime);
                pdata_uso.Value = prontuario.Data_Uso;
                cmd.Parameters.Add(pdata_uso);
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Value = prontuario.ID_Idoso;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = prontuario.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);

                cn.Open();
                cmd.ExecuteNonQuery();

                prontuario.ID_Prontuario = (Int32)cmd.Parameters["@ID_Prontuario"].Value;
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

        public void Alterar(ProntuarioInformation prontuario)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "alterar_Prontuarios";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_prontuario = new SqlParameter("@ID_Prontuario", SqlDbType.Int);
                pid_prontuario.Value = prontuario.ID_Prontuario;
                cmd.Parameters.Add(pid_prontuario);
                SqlParameter pidosos = new SqlParameter("@Idosos", SqlDbType.NVarChar, 100);
                pidosos.Value = prontuario.Idosos;
                cmd.Parameters.Add(pidosos);
                SqlParameter penfermidades = new SqlParameter("@Enfermidades", SqlDbType.NVarChar, 100);
                penfermidades.Value = prontuario.Enfermidades;
                cmd.Parameters.Add(penfermidades);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = prontuario.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter premedios = new SqlParameter("@Remedios", SqlDbType.NVarChar, 100);
                premedios.Value = prontuario.Remedios;
                cmd.Parameters.Add(premedios);
                SqlParameter pdata_criacao = new SqlParameter("@Data_Criacao", SqlDbType.DateTime);
                pdata_criacao.Value = prontuario.Data_Criacao;
                cmd.Parameters.Add(pdata_criacao);
                SqlParameter pdata_uso = new SqlParameter("@Data_Uso", SqlDbType.DateTime);
                pdata_uso.Value = prontuario.Data_Uso;
                cmd.Parameters.Add(pdata_uso);
                SqlParameter pprescricao_observacoes = new SqlParameter("@Prescricao_Observacoes", SqlDbType.NVarChar, 300);
                pprescricao_observacoes.Value = prontuario.Prescricao_Observacoes;
                cmd.Parameters.Add(pprescricao_observacoes);
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Value = prontuario.ID_Idoso;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = prontuario.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = prontuario.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);

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

        public void AlterarSemPrescricaoObservacoes(ProntuarioInformation prontuario)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "alterar_Prontuarios_Sem_Prescricao_Observacoes";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_prontuario = new SqlParameter("@ID_Prontuario", SqlDbType.Int);
                pid_prontuario.Value = prontuario.ID_Prontuario;
                cmd.Parameters.Add(pid_prontuario);
                SqlParameter pidosos = new SqlParameter("@Idosos", SqlDbType.NVarChar, 100);
                pidosos.Value = prontuario.Idosos;
                cmd.Parameters.Add(pidosos);
                SqlParameter penfermidades = new SqlParameter("@Enfermidades", SqlDbType.NVarChar, 100);
                penfermidades.Value = prontuario.Enfermidades;
                cmd.Parameters.Add(penfermidades);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = prontuario.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter premedios = new SqlParameter("@Remedios", SqlDbType.NVarChar, 100);
                premedios.Value = prontuario.Remedios;
                cmd.Parameters.Add(premedios);
                SqlParameter pdata_criacao = new SqlParameter("@Data_Criacao", SqlDbType.DateTime);
                pdata_criacao.Value = prontuario.Data_Criacao;
                cmd.Parameters.Add(pdata_criacao);
                SqlParameter pdata_uso = new SqlParameter("@Data_Uso", SqlDbType.DateTime);
                pdata_uso.Value = prontuario.Data_Uso;
                cmd.Parameters.Add(pdata_uso);
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Value = prontuario.ID_Idoso;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = prontuario.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);
                SqlParameter pid_remedio = new SqlParameter("@ID_Remedio", SqlDbType.Int);
                pid_remedio.Value = prontuario.ID_Remedio;
                cmd.Parameters.Add(pid_remedio);

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

        public void AlterarAlimento(ProntuarioInformation prontuario)
        {
            //conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "alterar_Prontuarios_Alimentos";
                // parametros da stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter pid_prontuario = new SqlParameter("@ID_Prontuario", SqlDbType.Int);
                pid_prontuario.Value = prontuario.ID_Prontuario;
                cmd.Parameters.Add(pid_prontuario);
                SqlParameter pidosos = new SqlParameter("@Idosos", SqlDbType.NVarChar, 100);
                pidosos.Value = prontuario.Idosos;
                cmd.Parameters.Add(pidosos);
                SqlParameter palimentos = new SqlParameter("@Alimentos", SqlDbType.NVarChar, 100);
                palimentos.Value = prontuario.Alimentos;
                cmd.Parameters.Add(palimentos);
                SqlParameter pdata_criacao = new SqlParameter("@Data_Criacao", SqlDbType.DateTime);
                pdata_criacao.Value = prontuario.Data_Criacao;
                cmd.Parameters.Add(pdata_criacao);
                SqlParameter pdata_uso = new SqlParameter("@Data_Uso", SqlDbType.DateTime);
                pdata_uso.Value = prontuario.Data_Uso;
                cmd.Parameters.Add(pdata_uso);
                SqlParameter pid_idoso = new SqlParameter("@ID_Idoso", SqlDbType.Int);
                pid_idoso.Value = prontuario.ID_Idoso;
                cmd.Parameters.Add(pid_idoso);
                SqlParameter pid_alimento = new SqlParameter("@ID_Alimento", SqlDbType.Int);
                pid_alimento.Value = prontuario.ID_Alimento;
                cmd.Parameters.Add(pid_alimento);

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

        public DataTable PesquisarProntuario(string pesquisar)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable prontuario = new DataTable();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "pesquisar_Prontuario_Idosos";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros de stored procedure
                SqlParameter ppesquisar;
                ppesquisar = da.SelectCommand.Parameters.Add("@pesquisar", SqlDbType.Text);
                ppesquisar.Value = pesquisar;

                da.Fill(prontuario);

                return prontuario;
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
