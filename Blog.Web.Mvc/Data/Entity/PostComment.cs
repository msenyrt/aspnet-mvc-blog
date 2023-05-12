using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Mvc.Data.Entity;
public class PostComment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int PostId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required, Column(TypeName = "text")]
    public string Comment { get; set; }

    [Required]
    public bool IsActive { get; set; }
}