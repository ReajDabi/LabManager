
using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IEquipmentRepository
    {
       List<Equipment> GetAllEquipment();
        void AddEquipment(Equipment equipment);
        void UpdateEquipment(Equipment equipment);
        void DeleteEquipment(int id);
        List<Equipment> SearchEquipment(string keyword);

        IEnumerable<Equipment> GetEquipmentByCategory(string category);
    }
}
