using System;
using System.Collections.Generic;
using Nop.Core.Data;
using Nop.Core.Domain.FieldWork;
using System.Linq;
using Nop.Core;

namespace Nop.Services.FieldWord
{
    public partial class FieldWorkService : IFieldWorkService
    {
        private readonly IRepository<FieldWorkItem> _iRepositoryFieldWorkItem;

        public FieldWorkService(IRepository<FieldWorkItem> iRepositoryFieldWorkItem)
        {
            this._iRepositoryFieldWorkItem = iRepositoryFieldWorkItem;
        }

        public void DeleteFieldWork(FieldWorkItem fieldWorkItem)
        {
            if (fieldWorkItem == null)
                throw new ArgumentNullException("FieldWorkItem");
            _iRepositoryFieldWorkItem.Delete(fieldWorkItem);
        }

        public IList<FieldWorkItem> GetAllFieldWork()
        {
            var query = _iRepositoryFieldWorkItem.Table;
            var FieldWorkI = query.ToList();
            return FieldWorkI; 
        }

        public FieldWorkItem GetFieldWorkItemsById(int fieldWorkId)
        {
            if (fieldWorkId == 0)
                return null;
            return _iRepositoryFieldWorkItem.GetById(fieldWorkId);
        }

        public IList<FieldWorkItem> GetFieldWorkItemsByIds(int[] fieldWorkIds)
        {
            var query = _iRepositoryFieldWorkItem.Table;
            return query.Where(p => fieldWorkIds.Contains(p.Id)).ToList();
        }

        public void InsertWorkItems(FieldWorkItem fieldWorkItemws)
        {
            if (fieldWorkItemws == null)
                throw new ArgumentNullException("FieldWorkItem");

            _iRepositoryFieldWorkItem.Insert(fieldWorkItemws);
        }

        public void UpdateWorkItems(FieldWorkItem fieldWorkItemws)
        {
            if (fieldWorkItemws == null)
                throw new ArgumentNullException("FieldWorkItem");
            _iRepositoryFieldWorkItem.Update(fieldWorkItemws);
        }
    }
}