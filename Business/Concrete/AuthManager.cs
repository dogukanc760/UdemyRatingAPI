using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {

        private IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        public IDataResult<AccessToken> CreateAccessToken(Users user)
        {
            var claims = _userService.GetClaim(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Access Token Created");
        }

        public IDataResult<Users> Login(UserForLoginDto userForLogin)
        {
            var userToCheck = _userService.GetByMail(userForLogin.UserName);
            if (userToCheck == null)
            {
                return new ErrorDataResult<Users>(message: "User not found! Please Check Your Email or Password.");
            }
            if (HashingHelper.VerifyPassword(userForLogin.Password, userToCheck.PasswordSalt, userToCheck.PasswordHash))
            {
                return new ErrorDataResult<Users>(message: "Your email or password false!");
            }
            return new SuccessDataResult<Users>(userToCheck, message: "Login is successfull");
        }

        public IDataResult<Users> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new Users
            {
                UserName = userForRegisterDto.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
            _userService.Add(user);
            return new SuccessDataResult<Users>(user, message: "User Added!");
        }

        public IResult UserExist(string email)
        {
            if (_userService.GetByMail(email)!=null)
            {
                return new ErrorResult(message: "User has already exists!");
            }
            return new SuccessResult(message: "Not Exists!");
        }
    }
}
