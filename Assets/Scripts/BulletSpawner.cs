/// <summary>
/// BulletをSpawnさせるクラス
/// </summary>
public abstract class BulletSpawner
{
    // キャッシュ変数
    protected BaseSpawnBullet _cache = null;

    // abstractな関数を定義
    // BulletをSpawnさせるのに必要
    public abstract BaseSpawnBullet Spawn<T>(T param) where T : BaseSpawnParameter;
}
