using Data_access_layer;
using Data_access_layer.Repositories;
using Entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_layer
{
    public class AssignementStatusServices
    {
        public List<AssignmentStatus> getAssignmentsStatuses()
        {
            using (var repo = new AssignmentStatusRepository())
            {
                List<AssignmentStatus> assignmentsStatus = repo.GetAll().ToList();

                return assignmentsStatus;
            }
        }
    }
}
