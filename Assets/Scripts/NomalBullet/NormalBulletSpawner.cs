using UnityEngine;

/// <summary>
/// NormalBullet‚ÌSpawner
/// </summary>
public class NormalBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawn<T>(T param)
    {
        _cache ??= Resources.Load<NormalBullet>(BulletPathManager.NORMAL_BULLET_PATH);

        _cache.SetData(param.Name, param.Power, param.Speed);
        return _cache;
    }
}
