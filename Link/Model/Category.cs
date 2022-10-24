using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Link.Model;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [DisplayName("category name")]
    public string Name { get; set; }
    
    [DisplayName("display order")]
    public int DisplayOrder { get; set; }
}