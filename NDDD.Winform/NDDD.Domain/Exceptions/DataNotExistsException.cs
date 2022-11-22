using System;

namespace NDDD.Domain.Exceptions
{
    public sealed class DataNotExistsException : ExceptionBase
    {

        public DataNotExistsException() 
            :base("データがありません")
        { 
        }

        // データが取れないことはシステムとしておかしいわけではないのでInfo
        public override ExceptionKind Kind => ExceptionKind.Info;
    }
}
