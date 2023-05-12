using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Mvc.Data.Entity;
public class Page
{
    [Key]
    public int Id { get; set; }

    [Required, Column(TypeName = "nvarchar(200)")]
    public string Title { get; set; }

    [Required, Column(TypeName = "text")]
    public string Content { get; set; }

    [Required]
    public bool IsActive { get; set; }
}