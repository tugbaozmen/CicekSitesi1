using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public interface IBaseService<TEntity>
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
