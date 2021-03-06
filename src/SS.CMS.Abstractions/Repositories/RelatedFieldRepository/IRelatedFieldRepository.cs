using System.Collections.Generic;
using System.Threading.Tasks;
using Datory;

namespace SS.CMS.Abstractions
{
    public interface IRelatedFieldRepository : IRepository
    {
        Task<int> InsertAsync(RelatedField relatedField);

        Task<bool> UpdateAsync(RelatedField relatedField);

        Task DeleteAsync(int id);

        Task<RelatedField> GetRelatedFieldAsync(int siteId, string title);

        Task<List<RelatedField>> GetRelatedFieldListAsync(int siteId);

        Task<string> GetImportTitleAsync(int siteId, string relatedFieldName);
    }
}