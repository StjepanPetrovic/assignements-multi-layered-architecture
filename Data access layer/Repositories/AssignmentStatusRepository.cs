using Entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.Repositories
{
    public class AssignmentStatusRepository : Repository<AssignmentStatus>
    {
        public AssignmentStatusRepository() : base(new AssignementsModel())
        {

        }
        public override int Update(AssignmentStatus entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
