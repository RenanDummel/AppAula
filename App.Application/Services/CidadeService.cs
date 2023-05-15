using App.Domain.Entidade;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;

namespace App.Application.Services
{
    public class CidadeService : ICidadeService
    {
        private IRepositoryBase<Cidade> _repository { get; set; }

        public CidadeService(IRepositoryBase<Cidade> repository)
        {
            _repository = repository;
        }

        public List<Cidade> ListaCidade()
        {
            return _repository.Query(x => 1 == 1).ToList();
        }

        public Cidade BuscaPorId(Guid id)
        {
            return _repository.Query(x => x.Id == id).FirstOrDefault();
        }

        public void Remover(Guid id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
        }

        public void Salvar(Cidade obj)
        {
            if (String.IsNullOrEmpty(obj.Municipio))
            {
                throw new Exception("Informe o município");
            }
            _repository.Save(obj);
            _repository.SaveChanges();
        }
    }
}
