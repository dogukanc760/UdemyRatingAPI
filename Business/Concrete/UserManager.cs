using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(Users user)
        {
            _userDal.Add(user);
        }

        public Users GetByMail(string mail)
        {
            return _userDal.Get(u => u.UserName == mail);
        }

        public List<OperationClaims> GetClaim(Users user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
