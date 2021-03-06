﻿using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IGenericRepository<Cliente, Guid>
    {
        Task<Cliente> ObterUmClienteComSuasCompras(Guid id);

    }

}
