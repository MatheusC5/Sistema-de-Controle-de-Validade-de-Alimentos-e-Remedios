using System;

namespace Casa.Modelos
{
    public class RemedioInformation
    {
        private int _ID_Remedio;
        private string _Nome;
        private string _Marca;
        private int _Unidade;
        private DateTime _Validade;
        private decimal _Estoque;
        private string _Peso;

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

        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
        }

        public string Marca
        {
            get
            {
                return _Marca;
            }
            set
            {
                _Marca = value;
            }
        }

        public int Unidade
        {
            get
            {
                return _Unidade;
            }
            set
            {
                _Unidade = value;
            }
        }

        public DateTime Validade
        {
            get
            {
                return _Validade;
            }
            set
            {
                _Validade = value;
            }
        }

        public decimal Estoque
        {
            get
            {
                return _Estoque;
            }
            set
            {
                _Estoque = value;
            }
        }

        public string Peso
        {
            get
            {
                return _Peso;
            }
            set
            {
                _Peso = value;
            }
        }
    }
}
