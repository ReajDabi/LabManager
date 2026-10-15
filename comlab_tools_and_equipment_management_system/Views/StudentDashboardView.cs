using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComLabManager.UI.Views
{
    public partial class StudentDashboardView : UserControl
    {
        private readonly IEquipmentRepository _equipmentRepo;
        private readonly IBorrowRequestRepository _borrowRepo;
        private readonly int _studentId;

        public StudentDashboardView(IEquipmentRepository equipmentRepo, IBorrowRequestRepository borrowRepo, int studentId)
        {
            InitializeComponent();
            _equipmentRepo = equipmentRepo ?? throw new ArgumentNullException(nameof(equipmentRepo));
            _borrowRepo = borrowRepo ?? throw new ArgumentNullException(nameof(borrowRepo));
            _studentId = studentId;

            SetupGrid();
            RefreshGrid();
        }

        private void SetupGrid()
        {
            dgvMyRequests.AutoGenerateColumns = false;

           
            Target.DataPropertyName = "TargetLocation";
            Date.DataPropertyName = "RequestedDate";
            Status.DataPropertyName = "Status";
            
        }

        private void RefreshGrid()
        {
            if (_borrowRepo != null)
            {
                var myRequests = _borrowRepo.GetRequestsByStudent(_studentId);
                dgvMyRequests.DataSource = myRequests;
            }
        }

       
        private void dgvMyRequests_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMyRequests.Rows[e.RowIndex];
                var request = row.DataBoundItem as BorrowRequest;

                if (request != null)
                {
                   
                    if (e.ColumnIndex == 2)
                    {
                       
                        DateTime start = DateTime.Today.Add(request.StartTime);
                        DateTime end = DateTime.Today.Add(request.EndTime);
                        e.Value = $"{start:h:mm tt} - {end:h:mm tt}";
                        e.FormattingApplied = true;
                    }

                
                    if (dgvMyRequests.Columns[e.ColumnIndex].Name == "Status") 
                    {
                        if (request.Status == "Pending")
                            row.Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(255, 193, 7); 
                        else if (request.Status == "Approved")
                            row.Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(25, 135, 84); 
                        else if (request.Status == "Denied")
                            row.Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(220, 53, 69); 
                    }
                }
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            using (BorrowModalForm form = new BorrowModalForm(_equipmentRepo, _studentId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _borrowRepo.AddRequest(form.ProcessedRequest);
                    RefreshGrid();
                }
            }
        }

        private void btnToggleSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedules.BringToFront();
            btnToggleSchedule.BackColor = Color.FromArgb(0, 120, 215);
            btnToggleBorrow.BackColor = Color.FromArgb(30, 41, 59);
        }

        private void btnToggleBorrow_Click(object sender, EventArgs e)
        {
            pnlBorrow.BringToFront();
            btnToggleBorrow.BackColor = Color.FromArgb(0, 120, 215);
            btnToggleSchedule.BackColor = Color.FromArgb(30, 41, 59);
        }
    }
}