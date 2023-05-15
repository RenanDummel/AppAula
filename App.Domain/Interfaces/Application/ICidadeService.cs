using App.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface ICidadeService
    {
        List<Cidade> ListaCidade();
        void Salvar(Cidade obj);
        Cidade BuscaPorId(Guid id);
        void Remover(Guid id);
    }
}
