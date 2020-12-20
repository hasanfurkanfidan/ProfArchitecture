using Hff.Business.Abstract;
using Hff.Core.Entities.Concrete;
using Hff.Core.Utilities.Results;
using Hff.DataAccess.Abstract;
using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Business.Concrete
{
    public class UserManager:IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task<IResult> AddAsync(User user)
        {
            try
            {
                await _userDal.AddAsync(user);
                return new SuccessResult("User added successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message, "");
                
            }
        }

        public async Task<IDataResult<User>> GetByMailAsync(string mail)
        {
            try
            {
                return new SuccessDataResult<User>(await _userDal.GetAsync(p => p.Email == mail));
            }
            catch (Exception)
            {
                return new ErrorDataResult<User>(await _userDal.GetAsync(p => p.Email == mail), "");
            }
        }

        public async Task<IDataResult<List<OperationClaim>>> GetClaimsAsync(User user)
        {
            try
            {
                return new SuccessDataResult<List<OperationClaim>>(await _userDal.GetClaims(user));
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<OperationClaim>>(await _userDal.GetClaims(user), "");
            }
        }
    }
}
