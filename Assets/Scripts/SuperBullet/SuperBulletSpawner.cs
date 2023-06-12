using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawn<T>(T param)
    {
        _cache ??= Resources.Load<SuperBullet>(BulletPathManager.SUPER_BULLET_PATH);

        _cache.SetData(param.Name, param.Power, param.Speed);
        return _cache;
    }
}