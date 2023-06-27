using Business_logic_layer;
using Data_access_layer;
using Entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignements_multi_layered_arhitecture
{
    public partial class NewAssignementForm : Form
    {
        AssignementStatusServices assignementStatusService = new AssignementStatusServices();
        AssignementServices assignementServices = new AssignementServices();

        AssignementsForm assignementsForm;

        public NewAssignementForm(AssignementsForm assignementsForm)
        {
            InitializeComponent();

            cbStatus.DataSource = assignementStatusService.getAssignmentsStatuses();
            this.assignementsForm = assignementsForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Assignment assignment = new Assignment();
            AssignmentStatus assignmentStatus = cbStatus.SelectedItem as AssignmentStatus;

            assignment.Student = txtStudent.Text;
            assignment.Description = txtDescription.Text;
            assignment.Points = int.Parse(txtPoints.Text);
            assignment.IdAssignmentStatuses = assignmentStatus.Id;

            assignementServices.addAssignemnt(assignment);

            assignementsForm.RefreshDataView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
