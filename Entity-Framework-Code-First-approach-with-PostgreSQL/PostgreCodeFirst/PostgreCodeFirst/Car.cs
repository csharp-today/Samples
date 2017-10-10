using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreCodeFirst
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        [Column("Licence_Number", Order = 1)]
        [MinLength(4), MaxLength(10)]
        public string LicenceNumber { get; set; }

        [Key]
        [Column(Order = 2)]
        [Index("MulticolumnIndexName", 1)]
        public Guid Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [Index("MulticolumnIndexName", 2)]
        public string Insurance { get; set; }

        public Person Owner { get; set; }

        [Index("MyIndexName")]
        public int? Year { get; set; }

        [NotMapped]
        public string Summary { get { return LicenceNumber + ", " + Insurance; } }

        public override string ToString()
        {
            return Summary;
        }
    }
}
