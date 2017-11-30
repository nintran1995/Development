namespace WorkEverything.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TypeUser
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NamType { get; set; }
    }
}
