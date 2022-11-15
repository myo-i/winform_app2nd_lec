using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
    }
}
