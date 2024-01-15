

using BusinessLogicLayer.UserDtos;

namespace BusinessLogicLayer.Interfaces;

public interface IUserInterface
{
    Task Registration(RegisterDto registerDto);
    Task Login(LoginDto loginDto);
    Task ForgetPasswor(ForgetDto forgetDto);
}
