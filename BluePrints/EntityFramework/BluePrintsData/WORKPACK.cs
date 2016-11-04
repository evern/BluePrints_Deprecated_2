namespace BluePrints.Data
{
    using BluePrints.Data.Attributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WORKPACK")]
    [ConstraintAttributes("GUID_PROJECT, INTERNAL_NAME1, INTERNAL_NAME2")]
    public partial class WORKPACK
    {
        public WORKPACK()
        {
            WORKPACK_ASSIGNMENTS = new HashSet<WORKPACK_ASSIGNMENT>();
            BASELINE_ITEMS = new HashSet<BASELINE_ITEM>();
            STARTDATE = DateTime.Now;
            ENDDATE = DateTime.Now;
            REVIEWSTARTDATE = DateTime.Now;
            REVIEWENDDATE = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid GUID { get; set; }

        [Required]
        [FilterValueAttribute]
        public Guid GUID_PROJECT { get; set; }

        public Guid? GUID_DPHASE { get; set; }

        [Required]
        public Guid GUID_DAREA { get; set; }

        [Required]
        public Guid GUID_DDOCTYPE { get; set; }

        [Required]
        public Guid GUID_DDEPARTMENT { get; set; }

        [Required]
        public Guid GUID_DDISCIPLINE { get; set; }

        [Required]
        [StringLength(200)]
        public string INTERNAL_NAME1 { get; set; }

        [StringLength(200)]
        public string INTERNAL_NAME2 { get; set; }

        public DateTime STARTDATE { get; set; }

        public DateTime ENDDATE { get; set; }

        public DateTime REVIEWSTARTDATE { get; set; }

        public DateTime REVIEWENDDATE { get; set; }

        public DateTime? FORECASTSTARTDATE { get; set; }

        public DateTime? FORECASTENDDATE { get; set; }

        public bool AUTOGENERATED { get; set; }

        public DateTime CREATED { get; set; }

        public Guid CREATEDBY { get; set; }

        public DateTime? UPDATED { get; set; }

        public Guid? UPDATEDBY { get; set; }

        public DateTime? DELETED { get; set; }

        public Guid? DELETEDBY { get; set; }

        public virtual PHASE PHASE { get; set; }

        public virtual AREA AREA { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }

        public virtual DISCIPLINE DISCIPLINE { get; set; }

        public virtual DOCTYPE DOCTYPE { get; set; }

        [FilterNameAttribute]
        public virtual PROJECT PROJECT { get; set; }

        public virtual ICollection<WORKPACK_ASSIGNMENT> WORKPACK_ASSIGNMENTS { get; set; }

        public virtual ICollection<BASELINE_ITEM> BASELINE_ITEMS { get; set; }
    }
}
