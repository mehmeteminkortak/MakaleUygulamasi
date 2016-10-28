using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mesajlasma.Models;

namespace Mesajlasma.BLL
{
    public interface IRepository<T,ID>
    {
        List<T> GetAll();
        T GetByID(ID id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
    public class KullaniciRepo : IRepository<Kisi, int>
    {
        public void Delete(Kisi entity)
        {
            throw new NotImplementedException();
        }

        public List<Kisi> GetAll()
        {
            throw new NotImplementedException();
        }

        public Kisi GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Kisi entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Kisi entity)
        {
            throw new NotImplementedException();
        }
    }
}
