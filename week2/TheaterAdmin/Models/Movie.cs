using System.ComponentModel.DataAnnotations;

namespace TheaterAdmin.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required]
    [StringLength(100)]
    public string? Director { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Contact Email")]
    public string? ContactEmail { get; set; }

    [Required]
    public Language Language { get; set; }

    // 关联 Category:一部电影属于一个分类,不能为空
    [Required]
    [Display(Name = "Category")]
    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}