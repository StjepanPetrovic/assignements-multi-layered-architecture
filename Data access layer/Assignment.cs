namespace Data_access_layer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
