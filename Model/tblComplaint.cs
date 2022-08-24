namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComplaint")]
    public partial class tblComplaint
    {
        [Key]
        public int ComplaintID { get; set; }

        [Required]
        [StringLength(10)]
        public string CustId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserID { get; set; }

        public int ComplaintTypeID { get; set; }

        public string ComplaintDescription { get; set; }

        public int Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Stamp { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Stamp_Sent { get; set; }
    }
}
