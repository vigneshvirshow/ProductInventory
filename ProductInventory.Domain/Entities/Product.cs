using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductInventory.Domain.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid VariantId { get; set; }
        public virtual Variant? Variant { get; set; } 
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public byte[] ProductImage { get; set; } = Array.Empty<byte>();
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public Guid CreatedUser { get; set; }
        public virtual User User { get; set; }
        public bool IsFavourite { get; set; }
        public bool Active { get; set; }
        public string HSNCode { get; set; } = string.Empty; 
        public decimal TotalStock { get; set; }
    }
}
