using BusinessLogicLayer.Enums;
using DataAccessLayer.Models;
namespace BusinessLogicLayer.UserDtos;

public class RegisterDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Lavozimi { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Parol { get; set; } = string.Empty;
    public string TasqidParol { get; set; } = string.Empty;
    public State State { get; set; }

    public static implicit operator User(RegisterDto dto)
    {
        return new User()
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Lavozimi = dto.Lavozimi,
            PhoneNumber = dto.PhoneNumber,
            Parol = dto.Parol,
            TasqidParol = dto.TasqidParol
        };
    }
}

