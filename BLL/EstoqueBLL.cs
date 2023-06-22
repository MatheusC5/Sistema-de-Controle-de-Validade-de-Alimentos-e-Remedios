using Casa.DAL;
using Casa.Modelos;
using System;
using System.Data;

namespace Casa.BLL
{
    public class EstoqueBLL
    {
        private EstoqueDAL objDAL;

        public EstoqueBLL()
        {
            objDAL = new EstoqueDAL();
        }

        public DataTable ListaDeAlimentos
        {
            get
            {
                return objDAL.ListaDeAlimentos;
            }
        }

        public DataTable ListaDeRemedios
        {
            get
            {
                return objDAL.ListaDeRemedios;
            }
        }

        public void Incluir(EstoqueInformation estoque)
        {
            AlimentoDAL alimento = new AlimentoDAL();
            RemedioDAL remedio = new RemedioDAL();
            decimal ResultadoAli = alimento.VerificaEstoqueAlimento(estoque);
            decimal CalculoAli = estoque.Quantidade_Alimentos - ResultadoAli;
            decimal ResultadoRem = remedio.VerificaEstoqueRemedio(estoque);
            decimal CalculoRem = estoque.Quantidade_Remedios - ResultadoRem;

            if (ResultadoAli < estoque.Quantidade_Alimentos && ResultadoRem > estoque.Quantidade_Remedios)
            {
                throw new Exception("Estoque insuficiente do Alimento!\nEstoque Atual: " + ResultadoAli +
                    "\nFalta " + CalculoAli + " para atualizar o Estoque!");
            }

            else if (ResultadoAli > estoque.Quantidade_Alimentos && ResultadoRem < estoque.Quantidade_Remedios)
            {
                throw new Exception("Estoque insuficiente do Remédio!\nEstoque Atual: " + ResultadoRem +
                    "\nFalta " + CalculoRem + " para atualizar o Estoque!");
            }

            else if (ResultadoAli < estoque.Quantidade_Alimentos && ResultadoRem < estoque.Quantidade_Remedios)
            {
                throw new Exception("Estoque insuficiente do Alimento!\nEstoque Atual: " + ResultadoAli +
                    "\nFalta " + CalculoAli + "\n" + "e Estoque insuficiente do Remédio!\nSaldo Atual: "
                    + ResultadoRem + "\nFalta " + CalculoRem + " para atualizar o Estoque!");
            }

            else
            {
                objDAL.Incluir(estoque);
            }
        }

        public void IncluirAlimento(EstoqueInformation estoquealimento)
        {
            AlimentoDAL alimento = new AlimentoDAL();
            decimal ResultadoAli = alimento.VerificaEstoqueAlimento(estoquealimento);
            decimal CalculoAli = estoquealimento.Quantidade_Alimentos - ResultadoAli;

            if (ResultadoAli < estoquealimento.Quantidade_Alimentos)
            {
                throw new Exception("Estoque insuficiente do Alimento!\nEstoque Atual: " + ResultadoAli +
                    "\nFalta " + CalculoAli + " para atualizar o Estoque!");
            }

            else
            {
                objDAL.IncluirAlimento(estoquealimento);
            }
        }

        public void IncluirRemedio(EstoqueInformation estoqueremedio)
        {
            RemedioDAL remedio = new RemedioDAL();
            decimal ResultadoRem = remedio.VerificaEstoqueRemedio(estoqueremedio);
            decimal CalculoRem = estoqueremedio.Quantidade_Remedios - ResultadoRem;

            if (ResultadoRem < estoqueremedio.Quantidade_Remedios)
            {
                throw new Exception("Estoque insuficiente do Remédio!\nEstoque Atual: " + ResultadoRem +
                    "\nFalta " + CalculoRem + " para atualizar o Estoque!");
            }

            else
            {
                objDAL.IncluirRemedio(estoqueremedio);
            }
        }
    }
}
