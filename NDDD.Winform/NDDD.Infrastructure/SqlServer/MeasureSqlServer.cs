﻿using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Infrastructure.Fake.SqlServer
{
    internal sealed class MeasureSqlServer : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<MeasureEntity> GetLatests()
        {
            throw new NotImplementedException();
        }
    }
}
