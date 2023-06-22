namespace Casa.Modelos
{
    public class EstoqueInformation
    {
        private int _ID_Atualizar_Estoque;
        private string _Alimentos;
        private decimal _Quantidade_Alimentos;
        private string _Remedios;
        private decimal _Quantidade_Remedios;
        private int _ID_Alimento;
        private int _ID_Remedio;

        public int ID_Atualizar_Estoque
        {
            get
            {
                return _ID_Atualizar_Estoque;
            }

            set
            {
                _ID_Atualizar_Estoque = value;
            }
        }

        public string Alimentos
        {
            get
            {
                return _Alimentos;
            }

            set
            {
                _Alimentos = value;
            }
        }

        public decimal Quantidade_Alimentos
        {
            get
            {
                return _Quantidade_Alimentos;
            }

            set
            {
                _Quantidade_Alimentos = value;
            }
        }

        public string Remedios
        {
            get
            {
                return _Remedios;
            }

            set
            {
                _Remedios = value;
            }
        }

        public decimal Quantidade_Remedios
        {
            get
            {
                return _Quantidade_Remedios;
            }

            set
            {
                _Quantidade_Remedios = value;
            }
        }

        public int ID_Alimento
        {
            get
            {
                return _ID_Alimento;
            }

            set
            {
                _ID_Alimento = value;
            }
        }

        public int ID_Remedio
        {
            get
            {
                return _ID_Remedio;
            }

            set
            {
                _ID_Remedio = value;
            }
        }
    }
}
