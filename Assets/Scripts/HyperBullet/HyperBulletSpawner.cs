using UnityEngine;

/// <summary>
/// HyperBullet��Spawner
/// </summary>
public class HyperBulletSpawner : BulletSpawner
{
    public override BaseSpawnBullet Spawn<T>(T param)
    {
        _cache ??= Resources.Load<HyperBullet>(BulletPathManager.HYPER_BULLET_PATH);

        _cache.SetData(param.Name, param.Power, param.Speed);
        return _cache;
    }
}
