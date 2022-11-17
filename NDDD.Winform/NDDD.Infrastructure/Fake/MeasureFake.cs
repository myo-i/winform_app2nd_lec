using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;

namespace NDDD.Infrastructure.Fake
{
    public class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            throw new System.NotImplementedException();
        }
    }
}
