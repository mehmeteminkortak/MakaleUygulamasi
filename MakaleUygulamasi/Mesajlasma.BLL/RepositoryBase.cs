using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mesajlasma.DAL;

namespace Mesajlasma.BLL
{
    public abstract class RepositoryBase<T, ID> where T : class
    {
        protected internal static MesajContext dbContext;

        public List<T> GetALL()
        {
            dbContext = new MesajContext();
            return dbContext.Set<T>().ToList();
        }
        public T GetByID(ID id)
        {
            dbContext = new MesajContext();
            return dbContext.Set<T>().Find(id);
        }
        public virtual void Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MesajContext();
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                dbContext = new MesajContext();
                throw new Exception(ex.Message);
            }
        }
        public virtual void Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MesajContext();
                dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public virtual void Update()
        {
            try
            {
                dbContext.SaveChanges();
                dbContext = new MesajContext();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
