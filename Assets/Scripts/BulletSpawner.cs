/// <summary>
/// Bullet��Spawn������N���X
/// </summary>
public abstract class BulletSpawner
{
    // �L���b�V���ϐ�
    protected BaseSpawnBullet _cache = null;

    // abstract�Ȋ֐����`
    // Bullet��Spawn������̂ɕK�v
    public abstract BaseSpawnBullet Spawn<T>(T param) where T : BaseSpawnParameter;
}
