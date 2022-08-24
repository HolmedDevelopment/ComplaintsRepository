namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblComplaintType")]
    public partial class tblComplaintType
    {
        [Key]
        public int ComplaintTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string ComplaintDescription { get; set; }
    }
}
