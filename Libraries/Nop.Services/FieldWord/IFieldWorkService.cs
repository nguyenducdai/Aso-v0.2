using Nop.Core;
using Nop.Core.Domain.FieldWork;
using System.Collections.Generic;

namespace Nop.Services.FieldWord
{
    public interface IFieldWorkService
    {
        void DeleteFieldWork(FieldWorkItem fieldWorkItem);

        FieldWorkItem GetFieldWorkItemsById(int fieldWorkId);

        IList<FieldWorkItem> GetFieldWorkItemsByIds(int[] fieldWorkIds);

        IList<FieldWorkItem> GetAllFieldWork();

        void InsertWorkItems(FieldWorkItem fieldWorkItemws);

        void UpdateWorkItems(FieldWorkItem fieldWorkItemws);
    }
}