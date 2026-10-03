using ComlabManager.Core.Interfaces;
using ComLabManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    public partial class BorrowModalForm : Form
    {
        private readonly IEquipmentRepository _equipmentRepo;
  private readonly Dictionary<string, Func<IEnumerable<string>>> _scopeDataLoaders;

        public BorrowModalForm(IEquipmentRepository equipmentRepo)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo;

            _scopeDataLoaders = new Dictionary<string, Func<IEnumerable<string>>>
            {
                { "Borrow Entire Room", () => new[] { "CLV1", "CLV2", "CLV3", "Engineering", "ICT" } },
                { "Borrow ComLab PC", () => _equipmentRepo.GetEquipmentByCategory("System Unit").Select(e => e.AssetTag) },
                { "Borrow Lab Equipment", () => _equipmentRepo.GetEquipmentByCategory("Tool").Select(e => e.Name) }
            };

            InitializeDropdowns();
        }

          private void InitializeDropdowns()
        {
            cmbScope.Items.Clear();
            cmbScope.Items.AddRange(_scopeDataLoaders.Keys.ToArray());
        }

        private void cmbScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Items.Clear();

           if (cmbScope.SelectedItem is string selectedScope &&
                _scopeDataLoaders.TryGetValue(selectedScope, out var dataLoader))
            {
                var itemsToLoad = dataLoader.Invoke().ToArray();
                cmbItem.Items.AddRange(itemsToLoad);
            }
        }
    }
}