﻿using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Enum;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface ISorteioService : IDisposable
    {
        Task Adicionar(Sorteio sorteio);
        Task Atualizar(Sorteio sorteio);
        Task Remover(Guid id);
        void GerarCotas(int numero, int quantidade);
    }
}
