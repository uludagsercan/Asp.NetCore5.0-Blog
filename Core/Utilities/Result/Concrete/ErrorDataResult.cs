using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Concrete
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, string message):base(false,data,message)
        {

        }
        public ErrorDataResult(string message):base(false,default,message)
        {

        }
        public ErrorDataResult():base(false,default)
        {

        }
    }
}
