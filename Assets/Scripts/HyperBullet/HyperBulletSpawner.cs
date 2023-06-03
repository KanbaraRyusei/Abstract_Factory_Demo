using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawn<T>(T param)
    {
        _cache ??= Resources.Load<HyperBullet>(BulletPathManager.HYPER_BULLET_PATH);

        _cache.SetName(param.Name);
        _cache.SetPower(param.Power);
        _cache.SetSpeed(param.Speed);
        return _cache;
    }
}
