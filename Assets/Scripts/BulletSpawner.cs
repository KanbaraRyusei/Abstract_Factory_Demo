public abstract class BulletSpawner
{
    protected BaseSpawnBullet _cache = null;

    public abstract BaseSpawnBullet Spawn<T>(T param) where T : BaseSpawnParameter;
}
