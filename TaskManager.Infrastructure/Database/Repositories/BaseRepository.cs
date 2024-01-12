using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;
using TaskManager.Infrastructure.Database.Repositories.Interface;
using Task = System.Threading.Tasks.Task;

namespace TaskManager.Infrastructure.Database.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly TaskManagerContext _context;
        private readonly DbSet<T> _table;
        
        public BaseRepository(TaskManagerContext context) 
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public virtual void Delete(Guid id)
        {
            T? entity = _table.Find(id);
            if (entity != null)
            {
                _table.Remove(entity);
                _context.SaveChanges();
            }
        }

        public virtual async Task Insert(T entity)
        {
            return _table.AddAsync(entity).Result;
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
