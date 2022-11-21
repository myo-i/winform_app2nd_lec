using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        // Exception
        public ExceptionBase(string message) : base(message)
        {
        }

        // InnerException
        public ExceptionBase(string message, Exception exception) 
            : base(message, exception)
        {
        }

        // このクラスを継承したクラスはKindを返却しないと
        // コンパイルが通らないので必ず区分を持つことになる
        public abstract ExceptionKind Kind {get;}
        public enum ExceptionKind
        {
            Info,
            Warning,
            Error,
        }
    }
}
