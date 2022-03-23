using BusinessLayer.Abstract;
using Core.Security.Hashing;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
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

        public void Register(Writer writer)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(writer.WriterPassword,out passwordHash,out passwordSalt);
            writer.PasswordHash = passwordHash;
            writer.PasswordHash=passwordSalt;
            writer.WriterStatus = true;
            _writerDal.Add(writer);
        }
    }
}
