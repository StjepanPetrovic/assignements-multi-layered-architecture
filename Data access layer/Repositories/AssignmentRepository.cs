using Entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access_layer.Repositories
{
    public class AssignmentRepository : Repository<Assignment>
    {
        public AssignmentRepository() : base(new AssignementsModel())
        {

        }

        public override int Update(Assignment entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
