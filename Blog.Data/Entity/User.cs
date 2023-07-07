﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Data.Entity;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required, Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    [Required, Column(TypeName = "nvarchar(200)")]
    public string Email { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string? City { get; set; }

    [Required, Column(TypeName = "nvarchar(100)")]
    public string Password { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string? Phone { get; set; }

    public string? Role { get; set; }
}
