using App.Domain.Entidade;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class UsuariosService : IUsuariosService
    {
        private IRepositoryBase<Usuarios> _repository { get; set; }

        public UsuariosService(IRepositoryBase<Usuarios> repository)
        {
            _repository = repository;
        }
        public List<Usuarios> ListaUsuarios()
        {
            return _repository.Query(x => 1 == 1).ToList();
        }

        public void Salvar(Usuarios obj)
        {
            if (String.IsNullOrEmpty(obj.Nome))
            {
                throw new Exception("Informe o nome");
            }
            _repository.Save(obj);
            _repository.SaveChanges();
        }
    }
}
