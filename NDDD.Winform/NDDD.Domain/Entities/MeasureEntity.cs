﻿using NDDD.Domain.ValueObjects;
using System;

namespace NDDD.Domain.Entities
{
    public sealed class MeasureEntity
    {
        public MeasureEntity(
            int areaId, 
            DateTime measureDate, 
            float measureValue)
        {
            AreaId = new AreaId(areaId);
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }

        public AreaId AreaId { get; }
        public DateTime MeasureDate { get; }
        public float MeasureValue { get; }
    }
}
