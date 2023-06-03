﻿using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Data.Entity;

public class CategoryPost
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int CategoryId { get; set;}

    [Required]
    public int PostId { get; set; }
}
