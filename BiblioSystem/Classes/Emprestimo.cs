using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSystem.Classes
{
    internal class Emprestimo
    {
        public string Livro;
        public string Leitor;
        public string DataEmprestimo;
        public string DataDevolucao;
        
        public string ConfigDataSolicitacao()
        {
            var dataSolicitacao = DateTime.Now;
            return dataSolicitacao.ToString("dd/MM/yyyy");
        }
        public string ConfigDataDevolucao()
        {
            var dataDevolucao = DateTime.Now.AddDays(7);
            return dataDevolucao.ToString("dd/MM/yyyy");
        }
        

        
    }

    
}
