

using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models;

public class User:BaseEntity
{
    [Required, MaxLength(25)]
    public  string FirstName { get; set; } = string.Empty;
    [Required, MaxLength(25)]
    public string LastName { get; set; } = string.Empty;
    [Required, MaxLength(100)]
    public string Lavozimi {  get; set; } = string.Empty;
    [Required, MaxLength(13)]
    public string PhoneNumber {  get; set; } = string.Empty;
    [Required, MaxLength(25)]
    public string Parol {  get; set; } = string.Empty;
    [Required, MaxLength(25)]
    public string TasqidParol {  get; set; } = string.Empty;
}
