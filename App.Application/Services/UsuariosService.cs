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
            return _repository.Query(x => 1 == 1).Select(x => new Usuarios
            {
                Id = x.Id,
                Nome = x.Nome,
                Email = x.Email,    
                Cidade = new Cidade
                {
                    Cep = x.Cidade.Cep,
                    Municipio = x.Cidade.Municipio
                }
            }).ToList();
        }

        public Usuarios BuscaPorId(Guid id)
        {
            return _repository.Query(x => x.Id == id).FirstOrDefault();
        }

        public void Remover(Guid id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
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
