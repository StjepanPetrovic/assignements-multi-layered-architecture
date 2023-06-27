using Business_logic_layer;
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
    public partial class AssignementsForm : Form
    {
        AssignementServices assignementServices = new AssignementServices();

        public AssignementsForm()
        {
            InitializeComponent();

            RefreshDataView();
            dgvAssignements.DataSource = assignementServices.getAssignments();
        }

        public void RefreshDataView()
        {
            dgvAssignements.DataSource = assignementServices.getAssignments();
            dgvAssignements.Columns[5].Visible = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewAssignementForm newAssignementForm = new NewAssignementForm(this);

            newAssignementForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Assignment assignment = new Assignment();

            assignment = dgvAssignements.CurrentRow.DataBoundItem as Assignment;

            assignementServices.removeAssignment(assignment);

            RefreshDataView();
        }
    }
}
