using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Interfaces;
using System.Data;
using System.Linq.Expressions;

namespace School.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected SchoolContext _Context { get; set; }

        public GenericRepository(SchoolContext context)
        {
            _Context = context;
        }

        public IList<T> ExecuteStoredProcedure(string procedure, params object[] args)
        {
            var formatIndexes = Enumerable.Range(0, args.Length).Select(i => $"{{{i}}}");
            var command = $"{procedure} {string.Join(",", formatIndexes)}";
            return _Context.Set<T>().FromSqlRaw(command, args).ToList();
        }

        public void Delete(int entityId)
        {
            var objet = _Context.Set<T>().Find(entityId);
            if (objet is null)
                return;

            _Context.Remove(objet);
        }

        private static Expression<Func<T, bool>> BuildIdExpression(int id)
        {
            var parameter = Expression.Parameter(typeof(T), "entity");
            var property = Expression.Property(parameter, "Id");
            var equals = Expression.Equal(property, Expression.Constant(id));
            return Expression.Lambda<Func<T, bool>>(equals, parameter);
        }

        public IQueryable<T> Find(int? id = null)
        {
            if (id.HasValue)
                return _Context.Set<T>().Where(BuildIdExpression(id.Value));

            return _Context.Set<T>().AsQueryable();
        }

        public T Insert(T entity)
        {
            _Context.Set<T>().Add(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _Context.Set<T>().Update(entity);
        }

        public void Commit()
        {
            _Context.SaveChanges();
        }
    }
}
