using Data_access_layer.Repositories;
using Entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_layer
{
    public class AssignementServices
    {
        public List<Assignment> getAssignments()
        {
            using (var repo = new AssignmentRepository())
            {
                List<Assignment> assignments = repo.GetAll().ToList();

                return assignments;
            }
        }

        public bool addAssignemnt(Assignment assignment)
        {
            bool isSuccessful = false;

            using (var repo = new AssignmentRepository())
            {
                int affectedRows = repo.Add(assignment);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool removeAssignment(Assignment assignment)
        {
            bool isSuccessful = false;

            using (var repo = new AssignmentRepository())
            {
                int affectedRows = repo.Remove(assignment);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }
    }
}
