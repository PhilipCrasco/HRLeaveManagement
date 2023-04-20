using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistance.Contracts
{
    public interface IGeneric_Repository<T> where T : class  // Generic Interface
    {

        Task<T> Get(int Id );

        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);

        Task<T> Delete(T entity);

    }

}
