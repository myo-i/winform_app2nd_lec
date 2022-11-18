using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.Fake.SqlServer
{
    public sealed class MeasureSqlServer : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            throw new NotImplementedException();
        }

    }
}
