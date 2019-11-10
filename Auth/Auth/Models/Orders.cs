namespace Auth.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_orders { get; set; }

        public int id_users { get; set; }

        public int id_device { get; set; }

        public int id_master { get; set; }

        [Required]
        [StringLength(50)]
        public string date_order { get; set; }

        public virtual Device Device { get; set; }

        public virtual Master Master { get; set; }

        public virtual Users Users { get; set; }
    }
}
