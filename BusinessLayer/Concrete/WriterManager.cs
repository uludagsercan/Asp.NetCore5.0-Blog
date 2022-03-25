using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Security.Hashing;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer writer)
        {
            _writerDal.Add(writer);
        }

        [ValidationAspect(typeof(UserForDtoValidator),Priority =1)]
        public IResult Register(UserForDto userForDto)
        {
            IResult result = BusinessRules.Run(IsPasswordEqual(userForDto.UserPassowrd, userForDto.UserPasswordConfimation));
            if (result!=null)
            {
                return result;
            }
            byte[] passwordHashing, passwordSalt;
            HashingHelper.CreatePasswordHash(userForDto.UserPassowrd,out passwordHashing,out passwordSalt);
            var writer = new Writer
            {
                WriterName =userForDto.Username,
                PasswordHash = passwordHashing,
                PasswordSalt = passwordSalt,
                WriterMail=userForDto.UserMail,
                WriterImage=userForDto.UserImage
            };
            _writerDal.Add(writer);
            return new SuccessResult("Kullanıcı Kaydı Oluşturuldu");
        }

        private IResult IsPasswordEqual(string password, string passwordConfimation)
        {
           
            if(!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(passwordConfimation))
            {
                if (!password.Equals(passwordConfimation))
                {
                    return new ErrorResult();
                }

            }
            else
            {
                return new ErrorResult("Value must be entered");
            }
            return new SuccessResult();
        }
    }
   
}
