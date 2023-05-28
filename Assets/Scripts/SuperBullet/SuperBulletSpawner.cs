using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawn<T>(T param)
    {
        _cache ??= Resources.Load<SuperBullet>(BulletPathManager.SUPER_BULLET_PATH);

        var b = _cache;
        b.SetName(param.Name);
        b.SetPower(param.Power);
        b.SetSpeed(param.Speed);
        return b;
    }
}
