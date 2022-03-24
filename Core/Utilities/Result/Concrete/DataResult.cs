using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Concrete
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public T Data { get; set; }
        

        public DataResult(bool success,T data,string message):this(success,data)
        {
            Success = success;
            Message = message;
            Data = data;
          
        }
        public DataResult(bool success,T data)
        {
          
        }
    }
}
