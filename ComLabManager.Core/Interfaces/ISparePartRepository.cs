using ComLabManager.Core.Models;
using System.Collections.Generic;

namespace ComLabManager.Core.Interfaces
{
    public interface ISparePartRepository
    {
        IEnumerable<SparePart> GetAllSpareParts();
        public void UpdateSparePartQuantity(int id, int newQuantity);
        void AddSparePart(SparePart part);
        void UpdateSparePart(SparePart part);
        void DeleteSparePart(int id);
    }
}