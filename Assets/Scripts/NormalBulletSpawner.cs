using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawn<T>(T param)
    {
        _cache ??= Resources.Load<NormalBullet>(BulletPathManager.NOMAL_BULLET_PATH);

        var b = _cache;
        b.SetName(param.Name);
        b.SetPower(param.Power);
        b.SetSpeed(param.Speed);
        return b;
    }
}
