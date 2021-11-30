using Examination.Domain.AggregateModels.CategoryAggregate;
using Examination.Infrastructure.SeedWork;
using MediatR;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examination.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(
            IMongoClient mongoClient,
            IClientSessionHandle clientSessionHandle,
            IOptions<ExamSettings> settings,
            IMediator mediator) : base(mongoClient, clientSessionHandle, settings, mediator, Constants.Collections.Category)
        {
        }

        public async Task<Category> GetCategoryByIdAsync(string id)
        {
            FilterDefinition<Category> filterDefinition = Builders<Category>.Filter.Eq(x => x.Id, id);
            var result = await Collection.Find(filterDefinition).FirstOrDefaultAsync();
            return result;
        }

        public async Task<Category> GetCategoryByNamesAsync(string name)
        {
            FilterDefinition<Category> filter = Builders<Category>.Filter.Eq(x => x.Name, name);
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<Tuple<IList<Category>, long>> GetCategorysPagingAsync(string search, int pageIndex, int pageSize)
        {
            FilterDefinition<Category> filter = Builders<Category>.Filter.Empty;
            if (!string.IsNullOrEmpty(search))
                filter = Builders<Category>.Filter.Eq(x => x.Name, search);
            var totalRow = await Collection.Find(filter).CountDocumentsAsync();
            var item = await Collection.Find(filter).Skip((pageIndex - 1) * pageSize).Limit(pageSize).ToListAsync();
            return new Tuple<IList<Category>, long>(item, totalRow);
        }
    }
}