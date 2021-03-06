﻿using OnlinePremios.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using OnlinePremios.Mvc.Data;
using OnlinePremios.Mvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlinePremios.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly ApplicationDbContext _context;

        public LancheRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
    }
}
