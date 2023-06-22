using System;

namespace Casa.Modelos
{
    public class IdosoInformation
    {
        private int _ID_Idoso;

        private string _Nome;

        private DateTime _Data_Nascimento;

        private string _Endereco_Responsavel;

        private string _Telefone_Responsavel;

        private string _Celular_Responsavel;

        private string _Telefone_Emergencia;

        public int ID_Idoso
        {
            get
            {
                return _ID_Idoso;
            }
            set
            {
                _ID_Idoso = value;
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

        public DateTime Data_Nascimento
        {
            get
            {
                return _Data_Nascimento;
            }
            set
            {
                _Data_Nascimento = value;
            }
        }

        public string Endereco_Responsavel
        {
            get
            {
                return _Endereco_Responsavel;
            }
            set
            {
                _Endereco_Responsavel = value;
            }
        }

        public string Telefone_Responsavel
        {
            get
            {
                return _Telefone_Responsavel;
            }
            set
            {
                _Telefone_Responsavel = value;
            }
        }

        public string Celular_Responsavel
        {
            get
            {
                return _Celular_Responsavel;
            }
            set
            {
                _Celular_Responsavel = value;
            }
        }

        public string Telefone_Emergencia
        {
            get
            {
                return _Telefone_Emergencia;
            }
            set
            {
                _Telefone_Emergencia = value;
            }
        }
    }
}
