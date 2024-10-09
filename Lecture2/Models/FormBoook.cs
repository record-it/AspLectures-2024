using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

public class FormBoook
{
    [HiddenInput]
    public int Id { get; set; }
    [MaxLength(length: 50)]
    [Required(ErrorMessage = "Musisz podać tytuł!")]
    public string Title { get; set; }
    [MaxLength(length: 20)]
    [Required]
    public string Author { get; set; }
}