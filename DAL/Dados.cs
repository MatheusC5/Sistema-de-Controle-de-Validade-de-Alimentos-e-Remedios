namespace Casa.DAL
{
    public class Dados
    {
        public static string StringDeConexao
        {
            get
            {
               return $"Data Source=MATHEUS-C5\\SQLEXPRESS;" +
                        $"Initial Catalog=CasaDeApoioNossoLar;" +
                        $"Integrated Security=True";
            }
        }
    }
}
