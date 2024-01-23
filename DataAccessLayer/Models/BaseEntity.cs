
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class BaseEntity
    {
        [Key, Required]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
