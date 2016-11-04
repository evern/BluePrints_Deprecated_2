namespace BluePrints.PrimeroData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PURCHORD_LINES
    {
        [Key]
        public int SEQNO { get; set; }

        public int? ACCNO { get; set; }

        public int? HDR_SEQNO { get; set; }

        [StringLength(23)]
        public string STOCKCODE { get; set; }

        [StringLength(40)]
        public string DESCRIPTION { get; set; }

        public double? ORD_QUANT { get; set; }

        public double? SUP_QUANT { get; set; }

        public double? INV_QUANT { get; set; }

        public double? UNITPRICE { get; set; }

        public double? DISCOUNT { get; set; }

        public int? ANALYSIS { get; set; }

        public int? LOCATION { get; set; }

        public double? SUPPLY_NOW { get; set; }

        public double? INVOICE_NOW { get; set; }

        [StringLength(15)]
        public string JOBCODE { get; set; }

        [StringLength(20)]
        public string BATCHCODE { get; set; }

        public int? SUBCODE { get; set; }

        public int? BRANCHNO { get; set; }

        public double? LAST_SUP { get; set; }

        public double? LAST_INV { get; set; }

        public double? TAXRATE { get; set; }

        public DateTime? DUEDATE { get; set; }

        public int? SALESORDNO { get; set; }

        public int? TAXRATE_NO { get; set; }

        [StringLength(1)]
        public string CODETYPE { get; set; }

        public double? LINETAX_OVERRIDE { get; set; }

        [StringLength(1)]
        public string LINETAX_OVERRIDDEN { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? LINETOTAL { get; set; }

        [StringLength(50)]
        public string SUPPLIERCODE { get; set; }

        public int? JOBNO { get; set; }

        [StringLength(1)]
        public string ISCONFIRMED { get; set; }

        public double PURCHPACKQUANT { get; set; }

        public double PURCHPACKPRICE { get; set; }

        public int? POLINEID { get; set; }

        [StringLength(20)]
        public string REFERENCE { get; set; }

        public int? LINETYPE { get; set; }

        public int? KITSEQNO { get; set; }

        [StringLength(23)]
        public string KITCODE { get; set; }

        [StringLength(23)]
        public string LINKED_STOCKCODE { get; set; }

        public double? LINKED_QTY { get; set; }

        public double SELL_PRICE { get; set; }

        public double COST_QUANT { get; set; }

        [StringLength(1)]
        public string BOMTYPE { get; set; }

        [StringLength(1)]
        public string SHOWLINE { get; set; }

        [StringLength(1)]
        public string LINKEDSTATUS { get; set; }

        [StringLength(1)]
        public string BOMPRICING { get; set; }

        public double? CORRECTION_QUANT { get; set; }

        public int? NARRATIVE_SEQNO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? BKORD_QUANT { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? CORRECTED_QUANT { get; set; }

        [Required]
        [StringLength(1)]
        public string PRICE_OVERRIDDEN { get; set; }

        public int? SOLINEID { get; set; }

        public double? SELLPRICE_DISC { get; set; }

        public int? LSTATUS { get; set; }

        public int COSTTYPE { get; set; }

        public int COSTGROUP { get; set; }
    }
}
