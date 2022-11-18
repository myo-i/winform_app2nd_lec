﻿using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;

namespace NDDD.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            return new MeasureEntity(
                10,
                Convert.ToDateTime("2024/12/12 12:34:56"),
                123.341f);
        }
    }
}
