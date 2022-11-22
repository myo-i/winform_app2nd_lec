using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDD.Domain.StaticValues
{
    public static class Measures
    {
        private static List<MeasureEntity> _entities
            = new List<MeasureEntity>();

        // 常に新しい直近値のみを_entitiesに格納するメソッド
        public static void Create(IMeasureRepository repository)
        {
            // 万が一でもClearとAddRangeの間でアクセスされると0件になってしまうので、
            // ロックをしている
            lock (((ICollection)_entities).SyncRoot)
            {
                _entities.Clear();
                _entities.AddRange(repository.GetLatests());
            }
        }

        // 取得した直近値のリストを扱うためのメソッド
        public static MeasureEntity GetLatest(AreaId　areaId)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                return _entities.Find(x=> x.AreaId == areaId);
            }
        }
    }
}
