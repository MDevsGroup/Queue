

using BusinessLogicLayer.UserDtos;

namespace BusinessLogicLayer.Interfaces;

public interface IUserInterface
{
    void Registration(RegisterDto registerDto);
    Task<bool> RegistrationCheck(RegisterDto registerDto);
    Task Login(LoginDto loginDto);
    Task UpdatePassword(string newPassword);
}
