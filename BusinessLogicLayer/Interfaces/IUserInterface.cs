

using BusinessLogicLayer.UserDtos;
using DataAccessLayer.Models;

namespace BusinessLogicLayer.Interfaces;

public interface IUserInterface
{
    Task<bool> GetByPhoneNumber(string number);
    void Registration(RegisterDto registerDto);
    Task<bool> RegistrationCheck(RegisterDto registerDto);
    Task Login(LoginDto loginDto);
    Task UpdatePassword(string phoneNumber, string newPassword);
}
