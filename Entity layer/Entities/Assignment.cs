using Data_access_layer;

namespace Entity_layer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Assignment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Student { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int Points { get; set; }

        public int IdAssignmentStatuses { get; set; }

        public virtual AssignmentStatus AssignmentStatus { get; set; }
    }
}
