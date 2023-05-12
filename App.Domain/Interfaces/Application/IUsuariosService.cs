﻿using App.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface IUsuariosService
    {
        List<Usuarios> ListaUsuarios();
        void Salvar(Usuarios obj);
        void Remover(Guid id);
    }
}
