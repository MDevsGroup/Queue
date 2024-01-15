

using BusinessLogicLayer.UserDtos;

namespace BusinessLogicLayer.Interfaces;

public interface IUserInterface
{
    Task<bool> Registration(RegisterDto registerDto);
    Task Login(LoginDto loginDto);
    Task ForgetPasswor(ForgetDto forgetDto);
}
