using System;

namespace Casa.Modelos
{
    public class ProntuarioInformation
    {
        private int _ID_Prontuario;
        private string _Idosos;
        private string _Enfermidades;
        private string _Alimentos;
        private string _Remedios;
        private DateTime _Data_Criacao;
        private DateTime _Data_Uso;
        private string _Prescricao_Observacoes;
        private int _ID_Idoso;
        private int _ID_Alimento;
        private int _ID_Remedio;

        public int ID_Prontuario
        {
            get
            {
                return _ID_Prontuario;
            }
            set
            {
                _ID_Prontuario = value;
            }
        }
        public string Idosos
        {
            get
            {
                return _Idosos;
            }
            set
            {
                _Idosos = value;
            }
        }

        public string Enfermidades
        {
            get
            {
                return _Enfermidades;
            }
            set
            {
                _Enfermidades = value;
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

        public DateTime Data_Criacao
        {
            get
            {
                return _Data_Criacao;
            }
            set
            {
                _Data_Criacao = value;
            }
        }

        public DateTime Data_Uso
        {
            get
            {
                return _Data_Uso;
            }
            set
            {
                _Data_Uso = value;
            }
        }

        public string Prescricao_Observacoes
        {
            get
            {
                return _Prescricao_Observacoes;
            }
            set
            {
                _Prescricao_Observacoes = value;
            }
        }

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
