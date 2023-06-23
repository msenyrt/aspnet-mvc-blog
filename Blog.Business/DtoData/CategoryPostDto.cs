using System.ComponentModel.DataAnnotations;

namespace Blog.Business.DtoData;

public class CategoryPostDto
{
    [Key]
    public int Id { get; set; }
    public int CategoryId { get; set;}
    public int PostId { get; set; }
}
