using NDDD.Domain;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure.Fake;
using NDDD.Infrastructure.Fake.SqlServer;

namespace NDDD.Infrastructure
{
    public static class Factories
    {
        public static IMeasureRepository CreateMeasure()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new MeasureFake();
            }
#endif

            return new MeasureSqlServer();
        }
    }
}
