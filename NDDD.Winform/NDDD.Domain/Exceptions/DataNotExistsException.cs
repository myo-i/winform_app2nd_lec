using System;

namespace NDDD.Domain.Exceptions
{
    public sealed class DataNotExistsException : Exception
    {

        public DataNotExistsException() 
            :base("データがありません")
        { 
        }
    }
}
