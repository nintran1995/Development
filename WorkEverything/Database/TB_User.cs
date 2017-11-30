namespace WorkEverything.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_User
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [StringLength(250)]
        public string Adress { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public bool? Gender { get; set; }

        [StringLength(50)]
        public string IdentityCard { get; set; }

        public int? IdTypeUser { get; set; }

        public int? IdStatus { get; set; }

        public bool? MarialStatus { get; set; }

        [StringLength(50)]
        public string TaxCode { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(50)]
        public string Nation { get; set; }

        [StringLength(50)]
        public string Health { get; set; }

        public string Describe { get; set; }

        [StringLength(250)]
        public string Hobby { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        [StringLength(50)]
        public string IdPosition { get; set; }
    }
}
