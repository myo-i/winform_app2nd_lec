using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.ValueObjects
{
    public sealed class AreaId : ValueObject<AreaId>
    {
        public AreaId(int value) 
        { 
            Value = value;
        }

        public int Value { get; }

        protected override bool EqualsCore(AreaId other)
        {
            return this.Value == other.Value;
        }
    }
}
