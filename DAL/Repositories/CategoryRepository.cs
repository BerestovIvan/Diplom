using AutoMapper;
using DAL.DbContext;
using DAL.Entity;
using DAL.Models;
using DAL.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly ApplicationDbContext context;
        readonly IMapper mapper;

        public CategoryRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        Task<IEnumerable<Category>> ICategoryRepository.Get()
        {
            throw new NotImplementedException();
        }

        Task<Category> ICategoryRepository.Get(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Category> ICategoryRepository.Get(string title)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Create(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Update(Category category)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Category category)
        {
            throw new NotImplementedException();
        }
    }
}