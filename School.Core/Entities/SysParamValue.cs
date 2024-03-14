using System.ComponentModel.DataAnnotations.Schema;

namespace School.Core.Entities
{

    [Table("SysParamValue")]
    public class SysParamValue : EntityBase
    {
        public string Code { get; set; }

        public string ShortText1 { get; set; }

        public string LongText1 { get; set; }

        public int? IntValue1 { get; set; }

        public decimal? DecimalValue1 { get; set; }

        public virtual int SysParamId { get; set; }

        public virtual SysParam? SysParam { get; set; }
    }
}
