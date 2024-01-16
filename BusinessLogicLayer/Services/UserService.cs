

using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services;

public class UserService(AppDbContext dbContext) : IUserInterface
{
    private readonly AppDbContext _dbContext = dbContext;

    public async Task UpdatePassword(string phoneNumber, string newPassword)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(i => i.PhoneNumber == phoneNumber);
        if (user != null)
        {
            user.Parol = newPassword;
            user.TasqidParol = newPassword;
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }
        else
        {
            throw new ArgumentNullException("User not found");
        }
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

    public async Task<bool> GetByPhoneNumber(string number)
    {
        var check = await _dbContext.Users.FirstOrDefaultAsync(i => i.PhoneNumber == number);
        if (check != null)
        {
            return true;
        }
        return false;
    }
}
