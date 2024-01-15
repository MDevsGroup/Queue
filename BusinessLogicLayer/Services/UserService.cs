

using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services;

public class UserService(AppDbContext dbContext) : IUserInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public Task ForgetPasswor(ForgetDto forgetDto)
    {
        throw new NotImplementedException();
    }



    public async Task Login(LoginDto loginDto)
    {
        var user = _dbContext.Users.SingleOrDefault(s => s.PhoneNumber == loginDto.PhoneNumber);

        if (user == null)
        {
            throw new Exception("Foydalanuvchi topilmadi");
        }

        if (user.Parol != loginDto.Parol)
        {
            throw new Exception("Noto'g'ri parol");
        }

    }

    public async void Registration(RegisterDto registerDto)
    {
        if (registerDto is null)
        {
            throw new ArgumentNullException("Iltimos hamma malumotlarni to'ldiring");
        }

        var users = await _dbContext.Users.ToListAsync();

        if (!users.Any(i => i.PhoneNumber == registerDto.PhoneNumber))
        {
            await _dbContext.Users.AddAsync((User)registerDto);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<bool> RegistrationCheck(RegisterDto registerDto)
    {
        if (registerDto is null)
        {
            throw new ArgumentNullException("Iltimos hamma malumotlarni to'ldiring");
        }

        var users = await _dbContext.Users.ToListAsync();

        if (!users.Any(i => i.PhoneNumber == registerDto.PhoneNumber))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
