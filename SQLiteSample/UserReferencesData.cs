using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SQLiteSample
{
    [Table("UserReferencesData")]
    [Index(nameof(RowId))]
    public class UserReferencesData
    {
        [Key]
        public int Id
        {
            get;
            set;
        }
        public int MetadataId
        {
            get;
            set;
        }
        public int RowId
        {
            get;
            set;
        }
        public Guid ColumnId
        {
            get;
            set;
        }
        public int ColumnType
        {
            get;
            set;
        }
        //type 0
        public DateTime? DateValue
        {
            get;
            set;
        }
        //type 1
        public string StringValue
        {
            get;
            set;
        }
        //type 2
        public int? IntValue
        {
            get;
            set;
        }
        //type 3
        public double? DoubleValue
        {
            get;
            set;
        }
        //type 4
        public bool? BoolValue
        {
            get;
            set;
        }
        //type 5
        public decimal? DecimalValue
        {
            get;
            set;
        }
    }
}
