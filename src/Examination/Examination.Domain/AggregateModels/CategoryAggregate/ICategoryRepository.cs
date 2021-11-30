using Examination.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Domain.AggregateModels.CategoryAggregate
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Task<Tuple<IList<Category>, long>> GetCategorysPagingAsync(string search, int pageIndex, int pageSize);

        Task<Category> GetCategoryByIdAsync(string id);

        Task<Category> GetCategoryByNamesAsync(string name);
    }
}
